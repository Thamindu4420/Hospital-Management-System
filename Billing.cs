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
    public partial class Billing : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        public Billing()
        {
            InitializeComponent();
            SearchButton.Click += new EventHandler(SearchButton_Click);
            DateTime? checkedIn = null;
            DateTime? checkedOut = null;

        }

        public void UpdateDataGridView()
        {


        }

        private void Billing_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            LoadPatientRegistrationData();
            ViewBillButton.Click += new EventHandler(ViewBillButton_Click);

        }

        private void PopulateDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PatientID, FirstName, LastName, NIC, MobileNumber, CheckedIn, CheckedOut, DoctorCharges, " +
                                   "AppointmentCharges, RoomCharges, MedicationCharges, Tax, TotalBill, PaymentStatus " +
                                   "FROM patient_registration";

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
                    PopulateDataGridView();
                    LoadPatientRegistrationData();
                }
            }


            DataTable FilterDataTable(string searchTerm)
            {
                DataTable dataTable = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PatientID, FirstName, LastName, CheckedIn, CheckedOut, DoctorCharges, RoomCharges, AppointmentCharges, MedicationCharges, Tax, TotalBill, PaymentStatus " +
                                   "FROM patient_registration " +
                                   "WHERE FirstName LIKE @searchTerm OR LastName LIKE @searchTerm OR " +
                                   "CheckedIn LIKE @searchTerm OR CheckedOut LIKE @searchTerm OR PaymentStatus LIKE @searchTerm";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                return dataTable;
            }
        }

        private void UpdateBillButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                DateTime? checkedIn = null;
                DateTime? checkedOut = null;

                if (selectedRow.Cells["CheckedIn"].Value != DBNull.Value)
                {
                    checkedIn = Convert.ToDateTime(selectedRow.Cells["CheckedIn"].Value);
                }

                if (selectedRow.Cells["CheckedOut"].Value != DBNull.Value)
                {
                    checkedOut = Convert.ToDateTime(selectedRow.Cells["CheckedOut"].Value);
                }

                int patientID = Convert.ToInt32(selectedRow.Cells["PatientID"].Value);


                Update_Bill updateBillForm = new Update_Bill(
                patientID, // Add patientID here
                selectedRow.Cells["FirstName"].Value.ToString(),
                selectedRow.Cells["LastName"].Value.ToString(),
                selectedRow.Cells["NIC"].Value.ToString(),
                selectedRow.Cells["MobileNumber"].Value.ToString(),
                checkedIn,
                checkedOut,
                selectedRow.Cells["DoctorCharges"].Value.ToString(),
                selectedRow.Cells["AppointmentCharges"].Value.ToString(),
                selectedRow.Cells["RoomCharges"].Value.ToString(),
                selectedRow.Cells["MedicationCharges"].Value.ToString(),
                selectedRow.Cells["Tax"].Value.ToString(),
                selectedRow.Cells["TotalBill"].Value.ToString(),
                selectedRow.Cells["PaymentStatus"].Value.ToString()
                 );


                updateBillForm.WindowState = FormWindowState.Maximized;
                updateBillForm.ShowDialog();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Bills_and_Invoices_Selection billsForm = new Bills_and_Invoices_Selection();
            billsForm.WindowState = FormWindowState.Maximized;
            billsForm.Show();
            this.Hide();
        }

        private void LoadPatientRegistrationData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT PatientID, FirstName, LastName, NIC, MobileNumber, CheckedIn, CheckedOut, DoctorCharges, AppointmentCharges, RoomCharges, MedicationCharges, Tax, TotalBill, PaymentStatus FROM patient_registration";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewBillButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                string mobileNumber = selectedRow.Cells["MobileNumber"].Value.ToString();
                string checkedIn = selectedRow.Cells["CheckedIn"].Value.ToString();
                string checkedOut = selectedRow.Cells["CheckedOut"].Value.ToString();
                string doctorCharges = selectedRow.Cells["DoctorCharges"].Value.ToString();
                string appointmentCharges = selectedRow.Cells["AppointmentCharges"].Value.ToString();
                string roomCharges = selectedRow.Cells["RoomCharges"].Value.ToString();
                string medicationCharges = selectedRow.Cells["MedicationCharges"].Value.ToString();
                string tax = selectedRow.Cells["Tax"].Value.ToString();
                string totalBill = selectedRow.Cells["TotalBill"].Value.ToString();
                string paymentStatus = selectedRow.Cells["PaymentStatus"].Value.ToString();

                // Create an instance of View_Bill form and pass the data
                View_Bill viewBillForm = new View_Bill(
                    firstName, lastName, mobileNumber,
                    checkedIn, checkedOut, doctorCharges,
                    appointmentCharges, roomCharges, medicationCharges,
                    tax, totalBill, paymentStatus);

                // Show the View_Bill form
                viewBillForm.WindowState = FormWindowState.Maximized;
                viewBillForm.ShowDialog();
            }
        }
    }
}


