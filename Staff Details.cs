using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Staff_Details : Form
    {
        public Staff_Details()
        {
            InitializeComponent();

            dataGridView1.DataSource = GetStaffData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Set the row header color and alternating row colors
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;

            // Apply bold style to specific header cells
            dataGridView1.Columns["StaffID"].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.Columns["FirstName"].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.Columns["LastName"].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.Columns["Address"].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.Columns["DOB"].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.Columns["NIC"].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.Columns["MobileNumber"].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.Columns["Gender"].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.Columns["Email"].HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
        }


        private DataTable GetStaffData()
        {
            string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
            string query = "SELECT StaffID, FirstName, LastName, Address, DOB, NIC, MobileNumber, Gender, Email FROM staff_registration";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the Admin_Dashboard form
            Admin_Dashboard adminDashboard = new Admin_Dashboard();

            // Set the window state of Admin_Dashboard to Maximized
            adminDashboard.WindowState = FormWindowState.Maximized;

            // Show the Admin_Dashboard form
            adminDashboard.Show();

            // Close the current Staff_Details form
            this.Close();
        }
    }
}

