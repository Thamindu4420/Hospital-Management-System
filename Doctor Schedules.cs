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
    public partial class Doctor_Schedules : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public Doctor_Schedules()
        {
            InitializeComponent();
            LoadDoctorSchedules();
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(DataGridView1_CellEndEdit);
        }

        private void LoadDoctorSchedules()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT FirstName, LastName, Gender, SpecialistIn, Availability, RoomNumber FROM doctor_registration";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable doctorDataTable = new DataTable();
                            adapter.Fill(doctorDataTable);

                            // Assign the data source to the DataGridView
                            dataGridView1.DataSource = doctorDataTable;

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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextbox.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable doctorDataTable = (DataTable)dataGridView1.DataSource;
                DataView dataView = doctorDataTable.DefaultView;
                dataView.RowFilter = $"FirstName LIKE '%{searchTerm}%' OR LastName LIKE '%{searchTerm}%' OR SpecialistIn LIKE '%{searchTerm}%'";

                dataView.RowStateFilter = DataViewRowState.CurrentRows;
            }
            else
            {
                DataTable doctorDataTable = (DataTable)dataGridView1.DataSource;
                doctorDataTable.DefaultView.RowFilter = "";
            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow editedRow = dataGridView1.Rows[e.RowIndex];
                string firstName = editedRow.Cells["FirstName"].Value.ToString();
                string lastName = editedRow.Cells["LastName"].Value.ToString();
                string specialistIn = editedRow.Cells["SpecialistIn"].Value.ToString();
                string availability = editedRow.Cells["Availability"].Value.ToString();
                string roomNumber = editedRow.Cells["RoomNumber"].Value.ToString();

                UpdateDoctorSchedule(firstName, lastName, specialistIn, availability, roomNumber);

                
                MessageBox.Show("Doctor Schedule Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateDoctorSchedule(string firstName, string lastName, string specialistIn, string availability, string roomNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE doctor_registration SET SpecialistIn = @SpecialistIn, Availability = @Availability, RoomNumber = @RoomNumber " +
                                     "WHERE FirstName = @FirstName AND LastName = @LastName";

                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@SpecialistIn", specialistIn);
                    command.Parameters.AddWithValue("@Availability", availability);
                    command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Data updated successfully
                    }
                    else
                    {
                        // No rows were affected, update failed
                    }
                }
            }
        }

        private void DeleteDoctorScheduleButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();

                
                DeleteDoctorSchedule(firstName, lastName);

                
                dataGridView1.Rows.Remove(selectedRow);

                
                MessageBox.Show("Schedule Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteDoctorSchedule(string firstName, string lastName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM doctor_registration WHERE FirstName = @FirstName AND LastName = @LastName";

                using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Data deleted successfully from the database
                    }
                    else
                    {
                        // No rows were affected, delete failed
                    }
                }
            }
        }

        private void AddDoctorScheduleButton_Click(object sender, EventArgs e)
        {
            Doctor_Registration doctorRegistrationForm = new Doctor_Registration();
            doctorRegistrationForm.WindowState = FormWindowState.Maximized;
            doctorRegistrationForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Appointment_Types appointmentTypesForm = new Appointment_Types();
            appointmentTypesForm.WindowState = FormWindowState.Maximized;
            appointmentTypesForm.Show();

        }

        private void Doctor_Schedules_Load(object sender, EventArgs e)
        {

        }

        private void PatientAppointmentsButton_Click(object sender, EventArgs e)
        {
            Patient_Appointment patientAppointmentForm = new Patient_Appointment();
            patientAppointmentForm.WindowState = FormWindowState.Maximized;
            patientAppointmentForm.Show();
            this.Hide();
        }
    }

}
