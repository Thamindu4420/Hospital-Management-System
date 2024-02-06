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
    public partial class Add_Appointment : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public Add_Appointment()
        {
            InitializeComponent();

            SubmitButton.Click += SubmitButton_Click;
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

                    string insertQuery = "INSERT INTO patient_appointment (PatientName, DOB, NIC, Age, MobileNumber, DoctorName, AppointmentDate, AppointmentTime) " +
                                         "VALUES (@PatientName, @DOB, @NIC, @Age, @MobileNumber, @DoctorName, @AppointmentDate, @AppointmentTime)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PatientName", textBox1.Text);
                        command.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@NIC", textBox3.Text);
                        command.Parameters.AddWithValue("@Age", textBox5.Text);
                        command.Parameters.AddWithValue("@MobileNumber", int.Parse(textBox6.Text));
                        command.Parameters.AddWithValue("@DoctorName", textBox2.Text);
                        command.Parameters.AddWithValue("@AppointmentDate", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@AppointmentTime", textBox4.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearInputFields();

                        }
                        else
                        {
                            MessageBox.Show("Error occurred while adding appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {


        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            Patient_Appointment patientAppointmentForm = new Patient_Appointment();
            patientAppointmentForm.WindowState = FormWindowState.Maximized;
            patientAppointmentForm.Show();
            this.Close();

        }
    }
}



