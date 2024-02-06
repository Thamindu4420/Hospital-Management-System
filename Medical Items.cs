using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare_Plus;
using MySql.Data.MySqlClient;

namespace HealthCare_Plus
{
    public partial class Medical_Items : Form
    {

        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public Medical_Items()
        {
            InitializeComponent();

            PopulateDataGridView();

            SearchButton.Click += SearchButton_Click;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            BackToDashboardButton.MouseDown += BackToDashboardButton_MouseDown;


        }

        private void AddMedicalItemButton_Click(object sender, EventArgs e)
        {
            
            Add_Medical_Items addMedicalItemsForm = new Add_Medical_Items();

            
            addMedicalItemsForm.WindowState = FormWindowState.Maximized;

            
            addMedicalItemsForm.ShowDialog();
        }

        private void PopulateDataGridView()
        {
            
            DataTable dataTable = new DataTable();

            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM medical_item";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Style the header row
                    dataGridView1.EnableHeadersVisualStyles = false;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

                    // Style alternating rows
                    dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextbox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                DataTable filteredDataTable = FilterDataTable(searchTerm);

                // Bind the filtered DataTable to the DataGridView
                dataGridView1.DataSource = filteredDataTable;
            }
            else
            {
                PopulateDataGridView();
            }
        }

        private DataTable FilterDataTable(string searchTerm)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM medical_item WHERE MedicalItem LIKE @searchTerm";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private void UpdateMedicalItemButton_Click(object sender, EventArgs e)
        {
            {


            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell editedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int itemId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ItemID"].Value);
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                string newValue = editedCell.Value.ToString();

                UpdateDatabase(itemId, columnName, newValue);
            }
        }

        private void UpdateDatabase(int itemId, string columnName, string newValue)
        {
            string query = $"UPDATE medical_item SET {columnName} = @NewValue WHERE ItemID = @ItemID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@ItemID", itemId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error updating data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteMedicalItemButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int itemId = Convert.ToInt32(selectedRow.Cells["ItemID"].Value);

                string query = $"DELETE FROM medical_item WHERE ItemID = {itemId}";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PopulateDataGridView(); // Refresh the DataGridView to reflect the updated data
                        }
                        else
                        {
                            MessageBox.Show("Error deleting item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }


            void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
            {
                // Print the MedicalItemsHeading
                string headingText = "Medical Items";
                Font headingFont = new Font("Arial", 18, FontStyle.Bold);
                SizeF headingSize = e.Graphics.MeasureString(headingText, headingFont);
                float headingX = (e.PageBounds.Width - headingSize.Width) / 2;
                float headingY = 50;
                e.Graphics.DrawString(headingText, headingFont, Brushes.Black, headingX, headingY);

                // Print the DataGridView content
                float dataGridViewX = 100;
                float dataGridViewY = headingY + headingSize.Height + 20;
                DrawDataGridView(dataGridView1, e.Graphics, new PointF(dataGridViewX, dataGridViewY));
            }

            void DrawDataGridView(DataGridView dataGridView, Graphics graphics, PointF location)
            {
                float x = location.X;
                float y = location.Y;

                float rowHeight = dataGridView.RowTemplate.Height;
                int rowCount = dataGridView.RowCount;
                int columnCount = dataGridView.ColumnCount;

                for (int i = 0; i < rowCount; i++)
                {
                    DataGridViewRow row = dataGridView.Rows[i];
                    for (int j = 0; j < columnCount; j++)
                    {
                        DataGridViewCell cell = row.Cells[j];
                        float cellWidth = dataGridView.Columns[j].Width;
                        graphics.DrawRectangle(Pens.Black, x, y, cellWidth, rowHeight);
                        graphics.DrawString(cell.Value?.ToString(), dataGridView.Font, Brushes.Black, x, y);
                        x += cellWidth;
                    }
                    x = location.X;
                    y += rowHeight;
                }
            }
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboardForm = new Admin_Dashboard();
            adminDashboardForm.WindowState = FormWindowState.Maximized;
            adminDashboardForm.ShowDialog();
        }

        private void BackToDashboardButton_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                this.Hide();
                Staff_Dashboard staffDashboard = new Staff_Dashboard();
                staffDashboard.WindowState = FormWindowState.Maximized;
                staffDashboard.Show();
            }
            else if (e.Button == MouseButtons.Left)
            {

                this.Hide();
                Admin_Dashboard adminDashboard = new Admin_Dashboard();
                adminDashboard.WindowState = FormWindowState.Maximized;
                adminDashboard.Show();
            }
        }
    }
}







