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
    public partial class Doctor_Registration : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";

        public Doctor_Registration()
        {
            InitializeComponent();
            BackToDashboardButton.MouseDown += BackToDashboardButton_MouseDown;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO doctor_registration (FirstName, LastName, Address, NIC, MobileNumber, Gender, SpecialistIn, Location, Availability, Qualifications, ExpertistIn, RoomNumber) " +
                                         "VALUES (@FirstName, @LastName, @Address, @NIC, @MobileNumber, @Gender, @SpecialistIn, @Location, @Availability, @Qualifications, @ExpertistIn, @RoomNumber)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", textBox1.Text);
                        command.Parameters.AddWithValue("@LastName", textBox2.Text);
                        command.Parameters.AddWithValue("@Address", textBox3.Text);
                        command.Parameters.AddWithValue("@NIC", textBox5.Text);
                        command.Parameters.AddWithValue("@MobileNumber", int.Parse(textBox6.Text));
                        command.Parameters.AddWithValue("@Gender", radioButton1.Checked ? "Male" : "Female");
                        command.Parameters.AddWithValue("@SpecialistIn", comboBox1.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Location", richTextBox1.Text);
                        command.Parameters.AddWithValue("@Availability", richTextBox2.Text);
                        command.Parameters.AddWithValue("@Qualifications", richTextBox3.Text);
                        command.Parameters.AddWithValue("@ExpertistIn", richTextBox4.Text);
                        command.Parameters.AddWithValue("@RoomNumber", textBox4.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Doctor Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Error occurred while registering doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the Admin Dashboard form
            Admin_Dashboard adminDashboard = new Admin_Dashboard();

            // Set the Admin Dashboard form's WindowState to Maximized
            adminDashboard.WindowState = FormWindowState.Maximized;

            // Show the Admin Dashboard form
            adminDashboard.Show();
        }
        private void ClearInputFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            textBox4.Clear();
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




