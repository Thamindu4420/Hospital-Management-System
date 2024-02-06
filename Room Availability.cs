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
    public partial class Room_Availability : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";



        public Room_Availability()
        {
            InitializeComponent();

            AddRoomButton.Click += AddRoomButton_Click;
            RefreshRoomDataGridViews();
            BackToDashboardButton.MouseDown += BackToDashboardButton_MouseDown;


        }
        public class Room
        {
            public int RoomID { get; set; }
            public string RoomName { get; set; }
            public string Availability { get; set; }
            public string Schedule { get; set; }

            public Room(int roomID, string roomName, string availability, string schedule)
            {
                RoomID = roomID;
                RoomName = roomName;
                Availability = availability;
                Schedule = schedule;

            }
        }

        public DataGridViewRow GetSelectedRow()
        {
            DataGridViewRow selectedRow = null;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView1.SelectedRows[0];
            }
            else if (dataGridView2.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView2.SelectedRows[0];
            }

            return selectedRow;
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

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            Add_Room addRoomForm = new Add_Room();
            addRoomForm.WindowState = FormWindowState.Maximized;
            addRoomForm.Show();
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboardForm = new Admin_Dashboard();
            adminDashboardForm.WindowState = FormWindowState.Maximized;
            adminDashboardForm.Show();
            this.Hide();
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

        private void UpdateRoomButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string roomName = selectedRow.Cells["RoomName"].Value.ToString();
                string availability = selectedRow.Cells["Availability"].Value.ToString();
                string schedule = selectedRow.Cells["Schedule"].Value.ToString();

                Update_Room updateRoomForm = new Update_Room(roomName, availability, schedule);
                updateRoomForm.WindowState = FormWindowState.Maximized;
                updateRoomForm.Show();
            }
            // If no row is selected in dataGridView1, check dataGridView2
            else if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                string roomName = selectedRow.Cells["RoomName"].Value.ToString();
                string availability = selectedRow.Cells["Availability"].Value.ToString();
                string schedule = selectedRow.Cells["Schedule"].Value.ToString();

                Update_Room updateRoomForm = new Update_Room(roomName, availability, schedule);
                updateRoomForm.WindowState = FormWindowState.Maximized;
                updateRoomForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            {
                DataGridViewRow selectedRow = GetSelectedRow();

                if (selectedRow != null)
                {
                    int roomID = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteFromDatabase(roomID);
                        RefreshRoomDataGridViews();
                        MessageBox.Show("Room Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a room to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            void DeleteFromDatabase(int roomID)
            {
                string query = "DELETE FROM room_availability WHERE RoomID = @RoomID";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomID", roomID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected <= 0)
                        {
                            MessageBox.Show("Error deleting room data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void PatientRoomsButton_Click(object sender, EventArgs e)
        {
            Patient_Rooms patientRoomsForm = new Patient_Rooms();
            patientRoomsForm.WindowState = FormWindowState.Maximized;
            patientRoomsForm.Show();
            this.Close();
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



