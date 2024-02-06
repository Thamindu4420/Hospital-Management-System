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
    public partial class Add_Medication : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        private int patientID;
        public Add_Medication(int selectedPatientID)
        {
            InitializeComponent();
            patientID = selectedPatientID;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE patient_registration SET MedicationDate = @MedicationDate, Medication = @Medication, DosageStrength = @DosageStrength, Comments = @Comments WHERE PatientID = @PatientID";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@MedicationDate", dateTimePicker2.Value);
                        cmd.Parameters.AddWithValue("@Medication", richTextBox2.Text);
                        cmd.Parameters.AddWithValue("@DosageStrength", richTextBox3.Text);
                        cmd.Parameters.AddWithValue("@Comments", richTextBox4.Text);
                        cmd.Parameters.AddWithValue("@PatientID", patientID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Medication Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        connection.Close();
                        DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
            Medications medicationsForm = new Medications();
            medicationsForm.WindowState = FormWindowState.Maximized;
            medicationsForm.Show();
            this.Hide();

        }
    }
}


