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
    public partial class View_Patient_Rooms : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public View_Patient_Rooms()
        {
            InitializeComponent();
            Load += Patient_Rooms_Load;
        }

        private void View_Patient_Rooms_Load(object sender, EventArgs e)
        {

        }


        private void PopulateDataGridView2()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PatientroomID, PatientroomNumber, PatientroomAvailability FROM patient_rooms";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Style the header row
                    dataGridView2.EnableHeadersVisualStyles = false;
                    dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);
                    dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

                    // Style alternating rows
                    dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
                    dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Patient_Rooms_Load(object sender, EventArgs e)
        {

            PopulateDataGridView2();
            PopulateDataGridView1();

        }



        private void PopulateDataGridView1()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PatientID, FirstName, LastName, Gender, PatientRoomNumber FROM patient_registration";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                PopulateDataGridView1();
            }
        }

        private DataTable FilterDataTable(string searchTerm)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT PatientID, FirstName, LastName, Gender, PatientRoomNumber " +
                               "FROM patient_registration " +
                               "WHERE PatientRoomNumber LIKE @searchTerm OR FirstName LIKE @searchTerm OR LastName LIKE @searchTerm";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }


        private void SearchButton2_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox2.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                DataTable filteredDataTable = FilterDataTable2(searchTerm);


                dataGridView2.DataSource = filteredDataTable;
            }
            else
            {
                PopulateDataGridView2();
            }
        }

        private DataTable FilterDataTable2(string searchTerm)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT PatientroomNumber, PatientroomAvailability " +
                               "FROM patient_rooms " +
                               "WHERE PatientroomNumber LIKE @searchTerm OR PatientroomAvailability LIKE @searchTerm";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            View_Room_Availability viewroomAvailabilityForm = new View_Room_Availability();
            viewroomAvailabilityForm.WindowState = FormWindowState.Maximized;
            viewroomAvailabilityForm.Show();
            this.Close();
        }

        private void RoomPricesButton_Click(object sender, EventArgs e)
        {
            View_Room_Prices viewroomPricesForm = new View_Room_Prices();
            viewroomPricesForm.WindowState = FormWindowState.Maximized;
            viewroomPricesForm.ShowDialog();
            
        }
    }

}


