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
    public partial class Medications : Form
    {

        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        private int selectedPatientID;


        public Medications()
        {
            InitializeComponent();
            LoadPatientData();
            SearchButton.Click += SearchButton_Click;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            BackToDashboardButton.MouseDown += BackToDashboardButton_MouseDown;


        }


        private void LoadPatientData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT PatientID, FirstName, LastName, DOB, Gender, Diagnosis, MedicationDate, Medication, DosageStrength, Comments FROM patient_registration";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void AddMedicationButton_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    selectedPatientID = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);

                    Add_Medication addMedicationForm = new Add_Medication(selectedPatientID);
                    addMedicationForm.WindowState = FormWindowState.Maximized;

                    DialogResult result = addMedicationForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        LoadPatientData();
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextbox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                DataTable filteredDataTable = FilterDataTable(searchTerm);

                // Bind the filtered DataTable to the DataGridView
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

                string query = "SELECT PatientID, FirstName, LastName, DOB, Gender, Diagnosis, MedicationDate, Medication, DosageStrength, Comments FROM patient_registration WHERE FirstName LIKE @searchTerm OR LastName LIKE @searchTerm";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private void ViewMedicationButton_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                    string lastName = selectedRow.Cells["LastName"].Value.ToString();
                    DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
                    string gender = selectedRow.Cells["Gender"].Value.ToString();
                    string diagnosis = selectedRow.Cells["Diagnosis"].Value.ToString();
                    DateTime medicationDate = Convert.ToDateTime(selectedRow.Cells["MedicationDate"].Value);
                    string medication = selectedRow.Cells["Medication"].Value.ToString();
                    string dosageStrength = selectedRow.Cells["DosageStrength"].Value.ToString();
                    string comments = selectedRow.Cells["Comments"].Value.ToString();

                    View_Medication viewMedicationForm = new View_Medication(
                        firstName, lastName, dob, gender, diagnosis, medicationDate, medication, dosageStrength, comments);

                    viewMedicationForm.WindowState = FormWindowState.Maximized;
                    viewMedicationForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a medication to view.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {

            Add_Patient addPatientForm = new Add_Patient();
            addPatientForm.WindowState = FormWindowState.Maximized;
            addPatientForm.Show();
            this.Hide();
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {

            Admin_Dashboard adminDashboardForm = new Admin_Dashboard();
            adminDashboardForm.WindowState = FormWindowState.Maximized;
            adminDashboardForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell editedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int patientID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                string newValue = editedCell.Value.ToString();

                UpdateDatabase(patientID, columnName, newValue);
            }
        }

        private void UpdateDatabase(int patientID, string columnName, string newValue)
        {
            string query = $"UPDATE patient_registration SET {columnName} = @NewValue WHERE PatientID = @PatientID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@PatientID", patientID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Medication data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error updating medication data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteMedicationButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int patientID = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this medication?", "Confirm Delete",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteFromDatabase(patientID);
                    dataGridView1.Rows.Remove(selectedRow);
                    MessageBox.Show("Medication Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a medication to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteFromDatabase(int patientID)
        {
            string query = "DELETE FROM patient_registration WHERE PatientID = @PatientID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", patientID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Error deleting medication data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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



















