using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Staff_Profile : Form
    {
        private int loggedInStaffID;
        public Staff_Profile(int staffID)
        {
            InitializeComponent();

            loggedInStaffID = 1;

            LoadStaffDetails();
            LoadProfilePhoto();

            BrowseButton.Click += BrowseButton_Click;
            SaveButton.Click += SaveButton_Click;
            BackToDashboardButton.Click += BackToDashboardButton_Click;

            this.Load += Staff_Profile_Load;
        }

        private void Staff_Profile_Load(object? sender, EventArgs e)
        {
            // Load and display the profile photo if available
            LoadProfilePhoto();
        }

        private void LoadProfilePhoto()
        {
            string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ProfilePhoto FROM staff_registration WHERE StaffID = @StaffID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffID", loggedInStaffID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhoto")))
                            {
                                try
                                {
                                    byte[] imageBytes = (byte[])reader["ProfilePhoto"];
                                    using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                                    {
                                        pictureBox1.Image = Image.FromStream(memoryStream);
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error loading image: {ex.Message}");
                                    MessageBox.Show("Error loading profile photo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Profile photo is NULL.");
                            }
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the pictureBox1 control
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            int loggedInStaffID = GetLoggedInStaffID();

            if (loggedInStaffID > 0)
            {
                // Ensure pictureBox1.Image is not null
                if (pictureBox1.Image != null)
                {
                    // Convert the image to byte array using Bitmap
                    Bitmap imageBitmap = new Bitmap(pictureBox1.Image);
                    byte[] imageBytes = ImageToByteArray(imageBitmap);

                    // Update the staff details including the profile photo
                    UpdateStaffDetails(loggedInStaffID, imageBytes);

                    // Show success message
                    MessageBox.Show("Changes saved successfully.");

                    // Reload the profile photo after update
                    LoadProfilePhoto();
                }
            }

            void UpdateStaffDetails(int staffID, byte[] profilePhoto)
            {
                string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE staff_registration SET ProfilePhoto = @ProfilePhoto WHERE StaffID = @StaffID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProfilePhoto", profilePhoto);
                        command.Parameters.AddWithValue("@StaffID", staffID);

                        command.ExecuteNonQuery();
                    }
                }
            }

            int GetLoggedInStaffID()
            {
                // Assuming you have a way to store the logged-in staff's ID
                int loggedInStaffID = 1;
                return loggedInStaffID;
            }

            byte[] ImageToByteArray(Image image)
            {
                if (image == null)
                    return Array.Empty<byte>(); // Return an empty byte array if image is null

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return memoryStream.ToArray();
                }
            }
        }

        private void BackToDashboardButton_Click(object? sender, EventArgs e)
        {
            // Create an instance of the Staff_Dashboard form
            Staff_Dashboard staffDashboard = new Staff_Dashboard();

            // Set the window state of Staff_Dashboard to Maximized
            staffDashboard.WindowState = FormWindowState.Maximized;

            // Show the Staff_Dashboard form
            staffDashboard.Show();

            // Hide the current Staff_Profile form
            this.Hide();
        }

        private void LoadStaffDetails()
        {
            string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT FirstName, LastName, Address, DOB, NIC, MobileNumber, Gender, Email, Password FROM staff_registration WHERE StaffID = @StaffID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffID", loggedInStaffID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            RetreiveFirstname.Text = reader["FirstName"].ToString();
                            RetreiveLastname.Text = reader["LastName"].ToString();
                            RetreiveAddress.Text = reader["Address"].ToString();
                            RetreiveDOB.Text = reader["DOB"].ToString();
                            RetreiveNIC.Text = reader["NIC"].ToString();
                            RetreiveMobileNumber.Text = reader["MobileNumber"].ToString();
                            RetreiveGender.Text = reader["Gender"].ToString();
                            RetreiveEmail.Text = reader["Email"].ToString();
                            RetreivePassword.Text = reader["Password"].ToString();
                        }
                    }
                }
            }
        }
    }
}
        
    



