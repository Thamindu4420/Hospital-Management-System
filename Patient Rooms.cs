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

    public partial class Patient_Rooms : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public Patient_Rooms()
        {
            InitializeComponent();
            Load += Patient_Rooms_Load;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;


        }


        private void AddRoomButton_Click(object sender, EventArgs e)
        {

            Add_Patient_Room addPatientRoomForm = new Add_Patient_Room();
            addPatientRoomForm.WindowState = FormWindowState.Maximized;
            addPatientRoomForm.Show();
        }

        private void PopulateDataGridView2()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PatientroomID, PatientroomNumber, PatientroomAvailability FROM patient_rooms";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Style the header row
                    dataGridView2.EnableHeadersVisualStyles = false;
                    dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);
                    dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

                    // Style alternating rows
                    dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
                    dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Patient_Rooms_Load(object sender, EventArgs e)
        {

            PopulateDataGridView2();
            PopulateDataGridView1();

        }



        private void PopulateDataGridView1()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PatientID, FirstName, LastName, Gender, PatientRoomNumber FROM patient_registration";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
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

                // Bind the filtered DataTable to the DataGridView
                dataGridView1.DataSource = filteredDataTable;
            }
            else
            {
                PopulateDataGridView1();
            }
        }

        private DataTable FilterDataTable(string searchTerm)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT PatientID, FirstName, LastName, Gender, PatientRoomNumber " +
                               "FROM patient_registration " +
                               "WHERE PatientRoomNumber LIKE @searchTerm OR FirstName LIKE @searchTerm OR LastName LIKE @searchTerm";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
 
            return dataTable;
        }

        private void SearchButton2_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox2.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                DataTable filteredDataTable = FilterDataTable2(searchTerm);


                dataGridView2.DataSource = filteredDataTable;
            }
            else
            {
                PopulateDataGridView2();
            }
        }

        private DataTable FilterDataTable2(string searchTerm)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT PatientroomNumber, PatientroomAvailability " +
                               "FROM patient_rooms " +
                               "WHERE PatientroomNumber LIKE @searchTerm OR PatientroomAvailability LIKE @searchTerm";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private void UpdateRoomButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string selectedPatientRoomNumber = dataGridView2.SelectedRows[0].Cells["PatientroomNumber"].Value.ToString();
                string selectedPatientRoomAvailability = dataGridView2.SelectedRows[0].Cells["PatientroomAvailability"].Value.ToString();

                Update_Patient_Room updatePatientRoomForm = new Update_Patient_Room(selectedPatientRoomNumber, selectedPatientRoomAvailability);
                if (updatePatientRoomForm.ShowDialog() == DialogResult.OK)
                {

                    RefreshDataGridView2();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            void RefreshDataGridView2()
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT PatientroomNumber, PatientroomAvailability FROM patient_rooms";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView2.DataSource = dataTable;
                        }
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
            Room_Availability roomAvailabilityForm = new Room_Availability();
            roomAvailabilityForm.WindowState = FormWindowState.Maximized;
            roomAvailabilityForm.Show();
            this.Close();
        }

        private void RoomPricesButton_Click(object sender, EventArgs e)
        {
            Room_Prices roomPricesForm = new Room_Prices();
            roomPricesForm.WindowState = FormWindowState.Maximized;
            roomPricesForm.Show();
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
                        MessageBox.Show("Patient Room Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error updating data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int patientId = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);
                string roomNumber = selectedRow.Cells["PatientRoomNumber"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this patient room?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeletePatientRoom(patientId, roomNumber);
                    dataGridView1.Rows.Remove(selectedRow);
                    MessageBox.Show("Patient Room Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                string roomNumber = selectedRow.Cells["PatientroomNumber"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteRoom(roomNumber);
                    dataGridView2.Rows.Remove(selectedRow);
                    MessageBox.Show("Room Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeletePatientRoom(int patientId, string roomNumber)
        {
            string deleteQuery = "DELETE FROM patient_registration WHERE PatientID = @PatientID";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@PatientID", patientId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void DeleteRoom(string roomNumber)
        {
            string deleteQuery = "DELETE FROM patient_rooms WHERE PatientroomNumber = @RoomNumber";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}











