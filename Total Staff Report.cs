using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HealthCare_Plus
{
    public partial class Total_Staff_Report : Form
    {
        string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
        private PrintDocument printDocument = new PrintDocument();
        private PrintDialog printDialog = new PrintDialog();
        public Total_Staff_Report()
        {
            InitializeComponent();
            DisplayData();


            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printDialog.Document = printDocument;

            PrintButton.Click += PrintButton_Click;
        }

        private void DisplayData()
        {
            try
            {
                string connectionString = "Server=localhost;Database=healthcare_plus;User Id=root;Password=Thamindu4420#;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT StaffID, FirstName, LastName, MobileNumber FROM staff_registration";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
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

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Print the panel1 content for A4 paper size
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            e.Graphics.DrawImage(bmp, e.PageBounds);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            printDialog.UseEXDialog = true;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {

                printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);

                printDocument.Print();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Report_Types reportTypesForm = new Report_Types();
            reportTypesForm.WindowState = FormWindowState.Maximized;
            reportTypesForm.Show();
            this.Hide();
        }
    }
}
