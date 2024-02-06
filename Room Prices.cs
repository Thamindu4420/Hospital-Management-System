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
    public partial class Room_Prices : Form
    {
        public Room_Prices()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Patient_Rooms patientRoomsForm = new Patient_Rooms();
            patientRoomsForm.WindowState = FormWindowState.Maximized;
            patientRoomsForm.Show();
            this.Close();
        }
    }
}
