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
    public partial class Appointment_Types : Form
    {
        public Appointment_Types()
        {
            InitializeComponent();
            BackToDashboardButton.MouseDown += BackToDashboardButton_MouseDown;
        }

        private void DoctorSchedulesButton_Click(object sender, EventArgs e)
        {

        }

        private void DoctorSchedulesButton_Click_1(object sender, EventArgs e)
        {
            Doctor_Schedules doctorSchedulesForm = new Doctor_Schedules();
            doctorSchedulesForm.WindowState = FormWindowState.Maximized;
            doctorSchedulesForm.ShowDialog();
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboardForm = new Admin_Dashboard();
            adminDashboardForm.WindowState = FormWindowState.Maximized;
            adminDashboardForm.Show();
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

        private void PatientAppointmentButton_Click(object sender, EventArgs e)
        {
            Patient_Appointment patientAppointmentForm = new Patient_Appointment();
            patientAppointmentForm.WindowState = FormWindowState.Maximized;
            patientAppointmentForm.ShowDialog();
        }
    }
}
