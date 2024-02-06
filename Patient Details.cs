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
using System.IO;

namespace HealthCare_Plus
{
    public partial class Patient_Details : Form
    {

        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public Patient_Details()
        {
            InitializeComponent();

            LoadPatientData();
            SearchButton.Click += SearchButton_Click;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            BackToDashboardButton.MouseDown += BackToDashboardButton_MouseDown;

        }

        private void LoadPatientData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT PatientID, FirstName, LastName, DOB, NIC, Gender, MobileNumber, Diagnosis, Prescription, LabResult, MedicalHistory FROM patient_registration";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Style the header row
                    dataGridView1.EnableHeadersVisualStyles = false;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

                    // Style alternating rows
                    dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextbox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                DataTable filteredDataTable = FilterDataTable(searchTerm);
                dataGridView1.DataSource = filteredDataTable;
            }
            else
            {
                LoadPatientData();
            }
        }

        private DataTable FilterDataTable(string searchTerm)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM patient_registration WHERE FirstName LIKE @searchTerm OR LastName LIKE @searchTerm";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {

            Add_Patient addPatientForm = new Add_Patient();
            addPatientForm.WindowState = FormWindowState.Maximized;
            addPatientForm.ShowDialog();
        }

        private void AddPatientAppointmentButton_Click(object sender, EventArgs e)
        {

            Add_Appointment addAppointmentForm = new Add_Appointment();
            addAppointmentForm.WindowState = FormWindowState.Maximized;
            addAppointmentForm.ShowDialog();
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {

            Admin_Dashboard adminDashboardForm = new Admin_Dashboard();
            adminDashboardForm.WindowState = FormWindowState.Maximized;
            adminDashboardForm.ShowDialog();
        }

        private void BackToDashboardButton_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                this.Hide();
                Staff_Dashboard staffDashboard = new Staff_Dashboard();
                staffDashboard.WindowState = FormWindowState.Maximized;
                staffDashboard.ShowDialog();
            }
            else if (e.Button == MouseButtons.Left)
            {

                this.Hide();
                Admin_Dashboard adminDashboard = new Admin_Dashboard();
                adminDashboard.WindowState = FormWindowState.Maximized;
                adminDashboard.ShowDialog();
            }
        }

        private void DeletePatientButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int patientId = Convert.ToInt32(selectedRow.Cells["PatientID"].Value); // Replace "PatientID" with the actual column name

                string query = $"DELETE FROM patient_registration WHERE PatientID = {patientId}";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPatientData();
                        }
                        else
                        {
                            MessageBox.Show("Error deleting patient data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell editedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int patientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                string newValue = editedCell.Value.ToString();

                UpdateDatabase(patientId, columnName, newValue);
            }

        }

        private void UpdateDatabase(int patientId, string columnName, string newValue)
        {
            string query = $"UPDATE patient_registration SET {columnName} = @NewValue WHERE PatientID = @PatientID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@PatientID", patientId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error updating patient data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ViewPatientButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
                string nic = selectedRow.Cells["NIC"].Value.ToString();
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string mobileNumber = selectedRow.Cells["MobileNumber"].Value.ToString();
                string diagnosis = selectedRow.Cells["Diagnosis"].Value.ToString();
                Image prescriptionImage = GetImageFromBytes((byte[])selectedRow.Cells["Prescription"].Value);
                Image labResultImage = GetImageFromBytes((byte[])selectedRow.Cells["LabResult"].Value);
                string medicalHistory = selectedRow.Cells["MedicalHistory"].Value.ToString();

                Add_Patient addPatientForm = new Add_Patient();
                addPatientForm.WindowState = FormWindowState.Maximized;
                addPatientForm.PopulatePatientData(firstName, lastName, dob, nic, gender, mobileNumber, diagnosis, prescriptionImage, labResultImage, medicalHistory);
                addPatientForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a patient to view.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Image? GetImageFromBytes(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        private void BrowseImageButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                int patientId = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);

                if (dataGridView1.SelectedCells[0].OwningColumn.Name == "Prescription" || dataGridView1.SelectedCells[0].OwningColumn.Name == "LabResult")
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string imagePath = openFileDialog.FileName;
                            byte[] imageBytes = File.ReadAllBytes(imagePath);

                            UpdateImageInDatabase(patientId, dataGridView1.SelectedCells[0].OwningColumn.Name, imageBytes);

                            // Refresh the DataGridView to show updated image
                            LoadPatientData();

                            MessageBox.Show("Image Uploaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a cell under the Prescription or LabResult columns.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a cell under the Prescription or LabResult columns.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void UpdateImageInDatabase(int patientId, string columnName, byte[] newImageBytes)
        {
            string query = $"UPDATE patient_registration SET {columnName} = @NewImage WHERE PatientID = @PatientID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewImage", newImageBytes);
                    command.Parameters.AddWithValue("@PatientID", patientId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Image updated successfully in the database
                    }
                    else
                    {
                        MessageBox.Show("Error updating image in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Prescription" || columnName == "LabResult")
                {
                    byte[] imageBytes = (byte[])selectedRow.Cells[columnName].Value;
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image image = Image.FromStream(ms);
                            pictureBox1.Image = image;
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }

            }
        }
    }
}







