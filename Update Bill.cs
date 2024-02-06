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
    public partial class Update_Bill : Form
    {
        private int patientID;
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";


        public Update_Bill(int patientID, string firstName, string lastName, string nic, string mobileNumber,
    DateTime? checkedIn, DateTime? checkedOut,
    string doctorCharges, string appointmentCharges,
    string roomCharges, string medicationCharges,
    string tax, string totalBill, string paymentStatus)
        {
            InitializeComponent();

            this.patientID = patientID;

            textBox1.Text = firstName;
            textBox2.Text = lastName;
            textBox3.Text = nic;
            textBox4.Text = mobileNumber;

            if (checkedIn != null)
            {
                dateTimePicker1.Value = (DateTime)checkedIn;
            }

            if (checkedOut != null)
            {
                dateTimePicker2.Value = (DateTime)checkedOut;
            }

            textBox5.Text = doctorCharges;
            textBox6.Text = appointmentCharges;
            textBox7.Text = roomCharges;
            textBox8.Text = medicationCharges;
            textBox9.Text = tax;
            textBox10.Text = totalBill;
            comboBox1.SelectedItem = paymentStatus;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE patient_registration SET " +
                       "FirstName = @FirstName, LastName = @LastName, NIC = @NIC, MobileNumber = @MobileNumber, " +
                       "CheckedIn = @CheckedIn, CheckedOut = @CheckedOut, DoctorCharges = @DoctorCharges, " +
                       "AppointmentCharges = @AppointmentCharges, RoomCharges = @RoomCharges, " +
                       "MedicationCharges = @MedicationCharges, Tax = @Tax, TotalBill = @TotalBill, " +
                       "PaymentStatus = @PaymentStatus WHERE PatientID = @PatientID";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientID", patientID);
                command.Parameters.AddWithValue("@FirstName", textBox1.Text);
                command.Parameters.AddWithValue("@LastName", textBox2.Text);
                command.Parameters.AddWithValue("@NIC", textBox3.Text);
                command.Parameters.AddWithValue("@MobileNumber", textBox4.Text);
                command.Parameters.AddWithValue("@CheckedIn", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@CheckedOut", dateTimePicker2.Value);
                command.Parameters.AddWithValue("@DoctorCharges", textBox5.Text);
                command.Parameters.AddWithValue("@AppointmentCharges", textBox6.Text);
                command.Parameters.AddWithValue("@RoomCharges", textBox7.Text);
                command.Parameters.AddWithValue("@MedicationCharges", textBox8.Text);
                command.Parameters.AddWithValue("@Tax", textBox9.Text);
                command.Parameters.AddWithValue("@TotalBill", textBox10.Text);
                command.Parameters.AddWithValue("@PaymentStatus", comboBox1.SelectedItem);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {

                    Billing billingForm = Application.OpenForms["Billing"] as Billing;
                    if (billingForm != null)
                    {
                        billingForm.UpdateDataGridView();
                    }

                    
                    MessageBox.Show("Payment Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Payment Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            comboBox1.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            Billing billingForm = new Billing();
            billingForm.WindowState = FormWindowState.Maximized;
            billingForm.Show();
            this.Hide();
        }

        private void AddTotalBillButton_Click(object sender, EventArgs e)
        {
            double totalAmount = 0;
            if (double.TryParse(textBox5.Text, out double doctorCharges))
                totalAmount += doctorCharges;
            if (double.TryParse(textBox6.Text, out double appointmentCharges))
                totalAmount += appointmentCharges;
            if (double.TryParse(textBox7.Text, out double roomCharges))
                totalAmount += roomCharges;
            if (double.TryParse(textBox8.Text, out double medicationCharges))
                totalAmount += medicationCharges;
            if (double.TryParse(textBox9.Text, out double tax))
                totalAmount += tax;

            textBox10.Text = totalAmount.ToString();
        }
    }

}
