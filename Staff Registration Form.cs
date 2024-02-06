using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace HealthCare_Plus
{
    public partial class Staff_Registration_Form : Form
    {
        public Staff_Registration_Form()
        {
            InitializeComponent();
        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // Validate the form fields before inserting data
            if (!ValidateFormFields())
            {
                MessageBox.Show("Please fill all the details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            byte[] profilePhotoBytes = ConvertImageToBytes(pictureBox1.Image);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO staff_registration (FirstName, LastName, Address, DOB, NIC, MobileNumber, Gender, Email, Password, ConfirmPassword, ProfilePhoto) " +
                     "VALUES (@FirstName, @LastName, @Address, @DOB, @NIC, @MobileNumber, @Gender, @Email, @Password, @ConfirmPassword, @ProfilePhoto)";


                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                    cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@NIC", textBox5.Text);
                    cmd.Parameters.AddWithValue("@MobileNumber", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Gender", radioButton1.Checked ? "Male" : "Female");
                    cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox7.Text);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", textBox8.Text);
                    cmd.Parameters.AddWithValue("@ProfilePhoto", profilePhotoBytes);


                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFormFields();
            }
        }

        private byte[] ConvertImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private bool ValidateFormFields()
        {
            // Perform validation for each required field
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) ||
                (!radioButton1.Checked && !radioButton2.Checked))
            {
                return false; // Validation failed
            }

            return true; // All fields are filled
        }


        private void ClearFormFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBox5.Clear();
            textBox6.Clear();
            radioButton1.Checked = true;
            textBox4.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void DevelopedBy_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            // Close the current Staff_Registration_Form
            this.Close();

            // Show the Form1
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
    }

}


