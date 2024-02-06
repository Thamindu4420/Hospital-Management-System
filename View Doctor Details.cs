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
    public partial class View_Doctor_Details : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        private DataTable doctorData = new DataTable();
        private DataTable? originalDoctorData;

        public View_Doctor_Details()
        {
            InitializeComponent();
            LoadDoctorData();
            originalDoctorData = (DataTable)dataGridView1.DataSource;
        }

        private void View_Doctor_Details_Load(object sender, EventArgs e)
        {

        }


        private void LoadDoctorData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM doctor_registration";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable doctorData = new DataTable();
                        adapter.Fill(doctorData);

                        dataGridView1.DataSource = doctorData;

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
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (originalDoctorData != null)
            {
                string searchTerm = SearchTextbox.Text;
                DataTable filteredTable = originalDoctorData.Clone();

                foreach (DataRow row in originalDoctorData.Rows)
                {
                    // Check if any cell in the row contains the search term
                    if (row.ItemArray != null && row.ItemArray.Any(field => field.ToString().Contains(searchTerm)))
                    {
                        filteredTable.ImportRow(row);
                    }
                }

                dataGridView1.DataSource = filteredTable;
            }
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Dashboard staffDashboard = new Staff_Dashboard();
            staffDashboard.WindowState = FormWindowState.Maximized;
            staffDashboard.Show();
        }
    }

}
