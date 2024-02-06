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
    public partial class Invoice : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private PrintDialog printDialog = new PrintDialog();
        public Invoice()
        {
            InitializeComponent();

            printDocument.PrintPage += PrintDocument_PrintPage;
            printDialog.Document = printDocument;

            PrintButton.Click += PrintButton_Click;
            BackButton.Click += BackButton_Click;

            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            Graphics g = e.Graphics;

            
            Bitmap panelBitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(panelBitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));

            
            g.DrawImage(panelBitmap, e.PageBounds.Location);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Bills_and_Invoices_Selection selectionForm = new Bills_and_Invoices_Selection();
            selectionForm.WindowState = FormWindowState.Maximized;
            selectionForm.Show();
            this.Hide();
        }
    }
}
