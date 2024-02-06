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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HealthCare_Plus
{
    public partial class Add_Patient_Room : Form
    {
        
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public Add_Patient_Room()
        {
            InitializeComponent();
            SaveButton.Click += SaveButton_Click;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Patient_Rooms patientRoomsForm = new Patient_Rooms();
            patientRoomsForm.WindowState = FormWindowState.Maximized;
            patientRoomsForm.Show();
            this.Hide();
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            {
                string roomNumber = textBox1.Text ?? "";
                string availability = comboBox1.SelectedItem?.ToString() ?? "";

                // Validate input
                if (string.IsNullOrEmpty(roomNumber) || string.IsNullOrEmpty(availability))
                {
                    MessageBox.Show("Patient Room Saved in the Database Sucessfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO patient_rooms (PatientroomNumber, PatientroomAvailability) VALUES (@roomNumber, @availability)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@roomNumber", roomNumber);
                        command.Parameters.AddWithValue("@availability", availability);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient Room Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            textBox1.Clear();
                            comboBox1.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add patient room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }
    }
}
