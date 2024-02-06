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
    public partial class View_Medication : Form
    {

        public View_Medication(

             string firstName, string lastName, DateTime dob, string gender,
            string diagnosis, DateTime medicationDate, string medication,
            string dosageStrength, string comments)
        {
            InitializeComponent();

            textBox1.Text = firstName;
            textBox2.Text = lastName;
            dateTimePicker1.Value = dob;
            if (gender == "Male")
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;

            richTextBox1.Text = diagnosis;
            dateTimePicker2.Value = medicationDate;
            richTextBox2.Text = medication;
            richTextBox3.Text = dosageStrength;
            richTextBox4.Text = comments;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Medications medicationsForm = new Medications();
            medicationsForm.WindowState = FormWindowState.Maximized;
            medicationsForm.Show();
            this.Hide();
        }
    }
}









