using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using HealthCare_Plus;

namespace HealthCare_Plus
{
    public partial class Doctor_Details : Form
    {
        private string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        private DataTable doctorData = new DataTable();
        private DataTable? originalDoctorData;


        public Doctor_Details()
        {
            InitializeComponent();

            LoadDoctorData();
            originalDoctorData = (DataTable)dataGridView1.DataSource;
            BackToDashboardButton.MouseDown += BackToDashboardButton_MouseDown;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDoctorData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM doctor_registration";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable doctorData = new DataTable();
                        adapter.Fill(doctorData);

                        dataGridView1.DataSource = doctorData;

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


        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            if (originalDoctorData != null)
            {
                string searchTerm = SearchTextbox.Text;
                DataTable filteredTable = originalDoctorData.Clone();

                foreach (DataRow row in originalDoctorData.Rows)
                {
                    // Check if any cell in the row contains the search term
                    if (row.ItemArray != null && row.ItemArray.Any(field => field.ToString().Contains(searchTerm)))
                    {
                        filteredTable.ImportRow(row);
                    }
                }

                dataGridView1.DataSource = filteredTable;
            }
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.WindowState = FormWindowState.Maximized;
            adminDashboard.Show();
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

        private void Doctor_Details_Load(object sender, EventArgs e)
        {

        }
    }
}

