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
    public partial class Staff_Dashboard : Form
    {
        public Staff_Dashboard()
        {
            InitializeComponent();
        }

        private void adminProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int loggedInStaffID = GetLoggedInStaffID();
            Staff_Profile staffProfileForm = new Staff_Profile(loggedInStaffID);
            staffProfileForm.WindowState = FormWindowState.Maximized;
            staffProfileForm.Show();
        }

        private int GetLoggedInStaffID()
        {
            // Replace this with your actual way of getting the logged-in staff's ID
            int loggedInStaffID = 1;
            return loggedInStaffID;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.WindowState = FormWindowState.Maximized;
            form1.Show();
            this.Close();
        }

        private void DoctorButton_Click(object sender, EventArgs e)
        {

            View_Doctor_Details viewdoctorDetails = new View_Doctor_Details();
            viewdoctorDetails.WindowState = FormWindowState.Maximized;
            viewdoctorDetails.ShowDialog();
        }

        private void PatientButton_Click(object sender, EventArgs e)
        {
            View_Patient_Details viewpatientDetailsForm = new View_Patient_Details();
            viewpatientDetailsForm.WindowState = FormWindowState.Maximized;
            viewpatientDetailsForm.ShowDialog();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            Appointment_Types appointmentTypesForm = new Appointment_Types();
            appointmentTypesForm.WindowState = FormWindowState.Maximized;
            appointmentTypesForm.Show();
        }

        private void MedicalItemsButton_Click(object sender, EventArgs e)
        {
            View_Medical_Items viewmedicalItemsForm = new View_Medical_Items();
            viewmedicalItemsForm.WindowState = FormWindowState.Maximized;
            viewmedicalItemsForm.ShowDialog();
        }

        private void MedicationTrackingButton_Click(object sender, EventArgs e)
        {
            Medications medicationsForm = new Medications();
            medicationsForm.WindowState = FormWindowState.Maximized;
            medicationsForm.ShowDialog();
        }

        private void RoomAvailabilityButton_Click(object sender, EventArgs e)
        {
            View_Room_Availability viewroomAvailabilityForm = new View_Room_Availability();
            viewroomAvailabilityForm.WindowState = FormWindowState.Maximized;
            viewroomAvailabilityForm.ShowDialog();
        }

        private void DoctorRegistrationButton_Click(object sender, EventArgs e)
        {
            Doctor_Registration doctorRegistrationForm = new Doctor_Registration();
            doctorRegistrationForm.WindowState = FormWindowState.Maximized;
            doctorRegistrationForm.Show();
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            Bills_and_Invoices_Selection billsAndInvoicesForm = new Bills_and_Invoices_Selection();
            billsAndInvoicesForm.WindowState = FormWindowState.Maximized;
            billsAndInvoicesForm.ShowDialog();
        }
    }
}
