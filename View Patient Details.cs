using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace HealthCare_Plus
{
    public partial class View_Patient_Details : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public View_Patient_Details()
        {
            InitializeComponent();
            LoadPatientData();
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void View_Patient_Details_Load(object sender, EventArgs e)
        {

        }


        private void LoadPatientData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT PatientID, FirstName, LastName, DOB, NIC, Gender, MobileNumber, Diagnosis, Prescription, LabResult, MedicalHistory FROM patient_registration";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Style the header row
                    dataGridView1.EnableHeadersVisualStyles = false;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

                    // Style alternating rows
                    dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextbox1.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                DataTable filteredDataTable = FilterDataTable(searchTerm);
                dataGridView1.DataSource = filteredDataTable;
            }
            else
            {
                LoadPatientData();
            }
        }


        private DataTable FilterDataTable(string searchTerm)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM patient_registration WHERE FirstName LIKE @searchTerm OR LastName LIKE @searchTerm";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Prescription" || columnName == "LabResult")
                {
                    byte[] imageBytes = (byte[])selectedRow.Cells[columnName].Value;
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image image = Image.FromStream(ms);
                            pictureBox1.Image = image;
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }

            }

        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            Staff_Dashboard staffDashboardForm = new Staff_Dashboard();
            staffDashboardForm.WindowState = FormWindowState.Maximized;
            staffDashboardForm.ShowDialog();
        }
    }
}
