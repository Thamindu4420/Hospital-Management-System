using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace HealthCare_Plus
{
    public partial class Update_Room : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";

        private string selectedRoomName;
        private string selectedAvailability;
        private string selectedSchedule;

        public Update_Room(string roomName, string availability, string schedule)
        {
            InitializeComponent();
            selectedRoomName = roomName;
            selectedAvailability = availability;
            selectedSchedule = schedule;

            textBox1.Text = roomName;
            comboBox1.SelectedItem = availability;
            richTextBox1.Text = schedule;

        }



        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = (Application.OpenForms["Room_Availability"] as Room_Availability)?.GetSelectedRow();

            if (selectedRow != null)
            {
                string selectedRoomName = selectedRow.Cells["RoomName"].Value.ToString();
                string newRoomName = textBox1.Text;
                string newAvailability = comboBox1.SelectedItem.ToString();
                string newSchedule = richTextBox1.Text;

                // Update the selected row in the DataGridView
                selectedRow.Cells["RoomName"].Value = newRoomName;
                selectedRow.Cells["Availability"].Value = newAvailability;
                selectedRow.Cells["Schedule"].Value = newSchedule;

                // Update the room availability data in the database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE room_availability SET Room = @newRoomName, Availability = @newAvailability, Schedule = @newSchedule WHERE Room = @selectedRoomName";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@newRoomName", newRoomName);
                    command.Parameters.AddWithValue("@newAvailability", newAvailability);
                    command.Parameters.AddWithValue("@newSchedule", newSchedule);
                    command.Parameters.AddWithValue("@selectedRoomName", selectedRoomName);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Room Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Room_Availability roomAvailabilityForm = new Room_Availability();
            roomAvailabilityForm.WindowState = FormWindowState.Maximized;
            roomAvailabilityForm.Show();
            this.Close();
        }
    }
}
















