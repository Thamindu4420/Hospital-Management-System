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
    public partial class View_Room_Prices : Form
    {
        public View_Room_Prices()
        {
            InitializeComponent();
        }

        private void View_Room_Prices_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            View_Patient_Rooms viewpatientRoomsForm = new View_Patient_Rooms();
            viewpatientRoomsForm.WindowState = FormWindowState.Maximized;
            viewpatientRoomsForm.Show();
            this.Close();
        }
    }
}
