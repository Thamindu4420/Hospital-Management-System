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
using static HealthCare_Plus.Room_Availability;

namespace HealthCare_Plus
{
    public partial class View_Room_Availability : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public View_Room_Availability()
        {
            InitializeComponent();
            RefreshRoomDataGridViews();
        }

        private void View_Room_Availability_Load(object sender, EventArgs e)
        {

        }


        private void RefreshRoomDataGridViews()
        {
            try
            {
                List<Room> availableRooms = new List<Room>();
                List<Room> notAvailableRooms = new List<Room>();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT RoomID, Room, Availability, Schedule FROM room_availability";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int roomID = reader.GetInt32("RoomID");
                        string room = reader.GetString("Room");
                        string availability = reader.GetString("Availability");
                        string schedule = reader.GetString("Schedule");

                        Room currentRoom = new Room(roomID, room, availability, schedule);

                        if (availability == "Available")
                        {
                            availableRooms.Add(currentRoom);
                        }
                        else if (availability == "Not Available")
                        {
                            notAvailableRooms.Add(currentRoom);
                        }
                    }

                    reader.Close();
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Style the header row
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

                // Style alternating rows
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;



                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Style the header row
                dataGridView2.EnableHeadersVisualStyles = false;
                dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);
                dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

                // Style alternating rows
                dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                dataGridView1.DataSource = availableRooms;
                dataGridView2.DataSource = notAvailableRooms;
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


                dataGridView1.DataSource = filteredDataTable;
            }
            else
            {

                RefreshRoomDataGridViews();
            }

            DataTable FilterDataTable(string searchTerm)
            {
                DataTable dataTable = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT RoomID, Room, Availability, Schedule FROM room_availability WHERE Room LIKE @searchTerm";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                return dataTable;
            }
        }

        private void SearchButton2_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox2.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                DataTable filteredDataTable = FilterDataTable(searchTerm);


                dataGridView2.DataSource = filteredDataTable;
            }
            else
            {

                RefreshRoomDataGridViews();
            }
        }

        DataTable FilterDataTable(string searchTerm)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT RoomID, Room, Availability, Schedule FROM room_availability WHERE Room LIKE @searchTerm";
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

        private void PatientRoomsButton_Click(object sender, EventArgs e)
        {
            View_Patient_Rooms viewpatientRoomsForm = new View_Patient_Rooms();
            viewpatientRoomsForm.WindowState = FormWindowState.Maximized;
            viewpatientRoomsForm.ShowDialog();
        }
    }
}
