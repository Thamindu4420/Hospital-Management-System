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
    public partial class Add_Room : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        private bool isSaving = false;
        public Add_Room()
        {
            InitializeComponent();
            SaveButton.Click += SaveButton_Click;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isSaving) return;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string room = textBox1.Text;
                    string availability = comboBox1.SelectedItem?.ToString();
                    string schedule = richTextBox1.Text;

                    if (string.IsNullOrEmpty(room) || string.IsNullOrEmpty(availability) || string.IsNullOrEmpty(schedule))
                    {
                        MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "INSERT INTO room_availability (Room, Availability, Schedule) VALUES (@Room, @Availability, @Schedule)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Room", room);
                        command.Parameters.AddWithValue("@Availability", availability);
                        command.Parameters.AddWithValue("@Schedule", schedule);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isSaving = true;
                            ClearFormFields();
                        }
                        else
                        {
                            MessageBox.Show("Error adding room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear form fields after successful save
        private void ClearFormFields()
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            richTextBox1.Text = "";

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Room_Availability roomAvailabilityForm = new Room_Availability();
            roomAvailabilityForm.WindowState = FormWindowState.Maximized;
            roomAvailabilityForm.Show();
            this.Hide();
        }
    }
}
