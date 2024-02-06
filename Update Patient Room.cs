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
    public partial class Update_Patient_Room : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        private string selectedPatientRoomNumber;
        private string selectedPatientRoomAvailability;
        public Update_Patient_Room(string patientRoomNumber, string patientRoomAvailability)
        {
            InitializeComponent();

            selectedPatientRoomNumber = patientRoomNumber;
            selectedPatientRoomAvailability = patientRoomAvailability;

            textBox1.Text = selectedPatientRoomNumber;
            comboBox1.SelectedItem = selectedPatientRoomAvailability;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string updatedAvailability = comboBox1.SelectedItem?.ToString() ?? "";

            if (!string.IsNullOrEmpty(updatedAvailability))
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE patient_rooms SET PatientroomAvailability = @updatedAvailability WHERE PatientroomNumber = @roomNumber";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@updatedAvailability", updatedAvailability);
                        command.Parameters.AddWithValue("@roomNumber", selectedPatientRoomNumber);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Patient_Rooms patientRoomsForm = new Patient_Rooms();
            patientRoomsForm.WindowState = FormWindowState.Maximized;
            patientRoomsForm.Show();
            this.Close();
        }
    }
}
