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
    public partial class Bills_and_Invoices_Selection : Form
    {
        public Bills_and_Invoices_Selection()
        {
            InitializeComponent();
            BackToDashboardButton.MouseDown += BackToDashboardButton_MouseDown;
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            Billing billingForm = new Billing();
            billingForm.WindowState = FormWindowState.Maximized;
            billingForm.Show();
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adminDashboardForm = new Admin_Dashboard();
            adminDashboardForm.WindowState = FormWindowState.Maximized;
            adminDashboardForm.Show();
            this.Close();
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

        private void InvoiceButton_Click(object sender, EventArgs e)
        {
            Invoice invoiceForm = new Invoice();
            invoiceForm.WindowState = FormWindowState.Maximized;
            invoiceForm.Show();
            this.Hide();
        }
    }
}
