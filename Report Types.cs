using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Report_Types : Form
    {
        public Report_Types()
        {
            InitializeComponent();
        }

        private void ReportsHeading_Click(object sender, EventArgs e)
        {

        }

        private void TotalIncomeReportButton_Click(object sender, EventArgs e)
        {
            Total_Income_Report incomeReportForm = new Total_Income_Report();
            incomeReportForm.WindowState = FormWindowState.Maximized;
            incomeReportForm.Show();
            this.Hide();
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashboardForm = new Admin_Dashboard();
            dashboardForm.WindowState = FormWindowState.Maximized;
            dashboardForm.Show();
            this.Hide();
        }

        private void MedicalItemsReportButton_Click(object sender, EventArgs e)
        {
            Medical_Items_Report medicalItemsReportForm = new Medical_Items_Report();
            medicalItemsReportForm.WindowState = FormWindowState.Maximized;
            medicalItemsReportForm.Show();
            this.Hide();
        }

        private void AppointmentsReportButton_Click(object sender, EventArgs e)
        {
            Appointments_Report appointmentsReportForm = new Appointments_Report();
            appointmentsReportForm.WindowState = FormWindowState.Maximized;
            appointmentsReportForm.Show();
            this.Hide();
        }

        private void TotalDoctorsReportButton_Click(object sender, EventArgs e)
        {

            Total_Doctors_Report totalDoctorsReportForm = new Total_Doctors_Report();
            totalDoctorsReportForm.WindowState = FormWindowState.Maximized;
            totalDoctorsReportForm.Show();
            this.Hide();
        }

        private void TotalStaffReportButton_Click(object sender, EventArgs e)
        {
            Total_Staff_Report totalStaffReportForm = new Total_Staff_Report();
            totalStaffReportForm.WindowState = FormWindowState.Maximized;
            totalStaffReportForm.Show();
            this.Hide();

        }

        private void TotalPatientsReportButton_Click(object sender, EventArgs e)
        {
            Total_Patients_Report totalPatientsReportForm = new Total_Patients_Report();
            totalPatientsReportForm.WindowState = FormWindowState.Maximized;
            totalPatientsReportForm.Show();
            this.Hide();
        }
    }
}
