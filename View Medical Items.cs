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

namespace HealthCare_Plus
{
    public partial class View_Medical_Items : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public View_Medical_Items()
        {
            InitializeComponent();

            PopulateDataGridView();

            SearchButton.Click += SearchButton_Click;
        }

        private void View_Medical_Items_Load(object sender, EventArgs e)
        {

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

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            Staff_Dashboard staffDashboardForm = new Staff_Dashboard();
            staffDashboardForm.WindowState = FormWindowState.Maximized;
            staffDashboardForm.ShowDialog();
        }
    }
}
