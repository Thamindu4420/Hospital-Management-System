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
    public partial class Add_Patient : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public Add_Patient()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            {

                string firstName = textBox1.Text;
                string lastName = textBox2.Text;
                DateTime dob = dateTimePicker1.Value;
                string nic = textBox5.Text;
                string gender = radioButton1.Checked ? "Male" : "Female";
                string mobileNumber = textBox6.Text;
                string diagnosis = richTextBox5.Text;
                byte[] prescription = GetFileBytes(pictureBox1.ImageLocation);
                byte[] labResult = GetFileBytes(pictureBox2.ImageLocation);
                string medicalHistory = richTextBox3.Text;

                // Establish MySQL database connection
                string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Create SQL query
                    string query = "INSERT INTO patient_registration (FirstName, LastName, DOB, NIC, Gender, MobileNumber, Diagnosis, Prescription, LabResult, MedicalHistory) " +
                                   "VALUES (@FirstName, @LastName, @DOB, @NIC, @Gender, @MobileNumber, @Diagnosis, @Prescription, @LabResult, @MedicalHistory)";

                    // Create MySqlCommand and add parameters
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@NIC", nic);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);
                        cmd.Parameters.AddWithValue("@Diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@Prescription", prescription);
                        cmd.Parameters.AddWithValue("@LabResult", labResult);
                        cmd.Parameters.AddWithValue("@MedicalHistory", medicalHistory);


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Patient Added Successfully");
                    }
                }


                ClearForm();
            }

            void ClearForm()
            {
                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.Value = DateTime.Now;
                textBox5.Clear();
                textBox6.Clear();
                richTextBox5.Clear();
                richTextBox3.Clear();
                pictureBox1.ImageLocation = null;
                pictureBox2.ImageLocation = null;
            }

            byte[] GetFileBytes(string filePath)
            {
                if (File.Exists(filePath))
                {
                    return File.ReadAllBytes(filePath);
                }
                return null;
            }

        }

        private void PrescriptionBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog.FileName;
            }
        }

        private void LabResultBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            Patient_Details patientDetailsForm = new Patient_Details();
            patientDetailsForm.WindowState = FormWindowState.Maximized;
            patientDetailsForm.ShowDialog();
        }

        public void PopulatePatientData(string firstName, string lastName, DateTime dob, string nic, string gender, string mobileNumber, string diagnosis, Image prescriptionImage, Image labResultImage, string medicalHistory)
        {
            textBox1.Text = firstName;
            textBox2.Text = lastName;
            dateTimePicker1.Value = dob;
            textBox5.Text = nic;

            if (gender == "Male")
            {
                radioButton1.Checked = true;
            }
            else if (gender == "Female")
            {
                radioButton2.Checked = true;
            }

            textBox6.Text = mobileNumber;
            richTextBox5.Text = diagnosis;
            pictureBox1.Image = prescriptionImage;
            pictureBox2.Image = labResultImage;
            richTextBox3.Text = medicalHistory;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

        }
    }
}




