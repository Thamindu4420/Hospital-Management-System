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
    public partial class Patient_Appointment : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public Patient_Appointment()
        {
            InitializeComponent();

            RefreshData();
            SearchButton.Click += SearchButton_Click;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private void AddPatientAppointmentButton_Click(object sender, EventArgs e)
        {
            Add_Appointment addAppointmentForm = new Add_Appointment();
            addAppointmentForm.WindowState = FormWindowState.Maximized;
            addAppointmentForm.ShowDialog();
        }

        private void RefreshData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM healthcare_plus.patient_appointment";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Style the header row
                        dataGridView1.EnableHeadersVisualStyles = false;
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

                        // Style alternating rows
                        dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                        dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void DoctorSchedulesButton_Click(object sender, EventArgs e)
        {
            Doctor_Schedules doctorSchedulesForm = new Doctor_Schedules();
            doctorSchedulesForm.WindowState = FormWindowState.Maximized;
            doctorSchedulesForm.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Appointment_Types appointmentTypesForm = new Appointment_Types();
            appointmentTypesForm.WindowState = FormWindowState.Maximized;
            appointmentTypesForm.Show();
            this.Hide();
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
                RefreshData();
            }
        }

        private DataTable FilterDataTable(string searchTerm)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM healthcare_plus.patient_appointment WHERE PatientName LIKE @searchTerm OR DoctorName LIKE @searchTerm OR AppointmentDate LIKE @searchTerm";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell editedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int appointmentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["AppointmentID"].Value);
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                string newValue = editedCell.Value.ToString();

                UpdateDatabase(appointmentID, columnName, newValue);
            }
        }

        private void UpdateDatabase(int appointmentID, string columnName, string newValue)
        {
            string query = $"UPDATE patient_appointment SET {columnName} = @NewValue WHERE AppointmentID = @AppointmentID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@AppointmentID", appointmentID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error updating appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeletePatientAppointmentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int appointmentID = Convert.ToInt32(selectedRow.Cells["AppointmentID"].Value);

                string query = $"DELETE FROM patient_appointment WHERE AppointmentID = {appointmentID}";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                        }
                        else
                        {
                            MessageBox.Show("Error deleting appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            
            Add_Patient addPatientForm = new Add_Patient();
            addPatientForm.WindowState = FormWindowState.Maximized;
            addPatientForm.ShowDialog();
        }
    }

}

