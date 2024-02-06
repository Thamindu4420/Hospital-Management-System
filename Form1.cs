using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace HealthCare_Plus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Subscribe to the Click event of the Login button
            Login.Click += new System.EventHandler(this.Login_Click);
        }

        private void Register_Click(object sender, EventArgs e)
        {
            // Hide the current Form1
            this.Hide();

            // Create an instance of Staff_Registration_Form
            Staff_Registration_Form staffRegistrationForm = new Staff_Registration_Form();

            // Set the window state of Staff_Registration_Form to Maximized
            staffRegistrationForm.WindowState = FormWindowState.Maximized;

            // Show the Staff_Registration_Form
            staffRegistrationForm.ShowDialog();

            // Close the Staff_Registration_Form when it's done
            staffRegistrationForm.Close();

            // Show the current Form1 again
            this.Show();

        }

        private void Login_Click(object? sender, EventArgs e)
        {
            
            string email = textBox1.Text;
            string password = textBox2.Text;

            // Assuming you have a ComboBox named comboBox1
            string role = comboBox1.SelectedItem?.ToString() ?? string.Empty;

            try
            {
                string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    bool isValid = ValidateLoginCredentials(connection, email, password, role);

                    if (isValid)
                    {
                        // Redirect to the appropriate dashboard based on the user's role
                        if (role == "Admin")
                        {
                            Admin_Dashboard adminDashboard = new Admin_Dashboard();
                            adminDashboard.WindowState = FormWindowState.Maximized;
                            adminDashboard.Show();
                            this.Hide();
                        }
                        else if (role == "Staff")
                        {
                            Staff_Dashboard staffDashboard = new Staff_Dashboard();
                            staffDashboard.WindowState = FormWindowState.Maximized;
                            staffDashboard.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter correct login credentials.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool ValidateLoginCredentials(MySqlConnection connection, string email, string password, string role)
        {
            string tableName = (role == "Admin") ? "admin_registration" : "staff_registration";
            string query = $"SELECT COUNT(*) FROM {tableName} WHERE Email = @Email AND Password = @Password";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
                    }
                }
            }
        
    






