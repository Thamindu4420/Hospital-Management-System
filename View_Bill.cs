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

namespace HealthCare_Plus
{
    public partial class View_Bill : Form
    {
        public View_Bill(string firstName, string lastName, string mobileNumber,
    string checkedIn, string checkedOut,
    string doctorCharges, string appointmentCharges,
    string roomCharges, string medicationCharges,
    string tax, string totalBill, string paymentStatus)

        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            textBox1.Text = firstName;
            textBox2.Text = lastName;
            textBox4.Text = mobileNumber;
            textBox11.Text = checkedIn;
            textBox12.Text = checkedOut;
            textBox5.Text = doctorCharges;
            textBox6.Text = appointmentCharges;
            textBox7.Text = roomCharges;
            textBox8.Text = medicationCharges;
            textBox9.Text = tax;
            textBox10.Text = totalBill;
            textBox3.Text = paymentStatus;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Billing billingForm = new Billing();
            billingForm.WindowState = FormWindowState.Maximized;
            billingForm.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create a Graphics object from the PrintPageEventArgs to draw on the page
            Graphics g = e.Graphics;

            // Set the font and brush for drawing text
            Font font = new Font("Cambria", 16);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Define the area to print
            Rectangle printArea = e.MarginBounds;

            // Draw the heading
            string heading = "";
            SizeF headingSize = g.MeasureString(heading, font);
            float x = (printArea.Width - headingSize.Width) / 2;
            g.DrawString(heading, font, brush, x, printArea.Top);

            // Draw the contents of panel1
            Bitmap panelBitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(panelBitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));
            g.DrawImage(panelBitmap, printArea.Left, printArea.Top + headingSize.Height);

            // Draw the "Thank You" message at the bottom
            string thankYouMessage = "";
            SizeF messageSize = g.MeasureString(thankYouMessage, font);
            float y = printArea.Bottom - messageSize.Height;
            x = (printArea.Width - messageSize.Width) / 2;
            g.DrawString(thankYouMessage, font, brush, x, y);

            e.HasMorePages = false;
        }


        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {

        }
    }
}
