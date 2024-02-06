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
using HealthCare_Plus;

namespace HealthCare_Plus
{
    public partial class Add_Medical_Items : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public Add_Medical_Items()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string itemName = textBox1.Text;
                    int quantity = Convert.ToInt32(textBox2.Text);
                    string purchaseDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // Convert DateTime to string in MySQL format

                    string insertQuery = "INSERT INTO medical_item (MedicalItem, Quantity, PurchaseDate) VALUES (@MedicalItem, @Quantity, @PurchaseDate)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MedicalItem", itemName);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@PurchaseDate", purchaseDate);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the input fields
                            textBox1.Clear();
                            textBox2.Clear();
                            dateTimePicker1.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close the current form (Add_Medical_Items)
            this.Close();

            // Open the Medical_Items form in maximized mode
            Medical_Items medicalItemsForm = new Medical_Items();
            medicalItemsForm.WindowState = FormWindowState.Maximized;
            medicalItemsForm.ShowDialog();
        }
    }
}
