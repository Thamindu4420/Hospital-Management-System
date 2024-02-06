namespace HealthCare_Plus
{
    partial class Appointment_Types
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment_Types));
            DoctorSchedulesButton = new Button();
            PatientAppointmentButton = new Button();
            BackToDashboardButton = new Button();
            SuspendLayout();
            // 
            // DoctorSchedulesButton
            // 
            DoctorSchedulesButton.BackColor = Color.White;
            DoctorSchedulesButton.BackgroundImage = (Image)resources.GetObject("DoctorSchedulesButton.BackgroundImage");
            DoctorSchedulesButton.BackgroundImageLayout = ImageLayout.Stretch;
            DoctorSchedulesButton.FlatStyle = FlatStyle.Popup;
            DoctorSchedulesButton.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorSchedulesButton.ForeColor = Color.Red;
            DoctorSchedulesButton.Location = new Point(498, 224);
            DoctorSchedulesButton.Name = "DoctorSchedulesButton";
            DoctorSchedulesButton.Size = new Size(352, 321);
            DoctorSchedulesButton.TabIndex = 5;
            DoctorSchedulesButton.Text = "Doctor\r\nSchedules";
            DoctorSchedulesButton.UseVisualStyleBackColor = false;
            DoctorSchedulesButton.Click += DoctorSchedulesButton_Click_1;
            // 
            // PatientAppointmentButton
            // 
            PatientAppointmentButton.BackColor = Color.White;
            PatientAppointmentButton.BackgroundImage = (Image)resources.GetObject("PatientAppointmentButton.BackgroundImage");
            PatientAppointmentButton.BackgroundImageLayout = ImageLayout.Stretch;
            PatientAppointmentButton.FlatStyle = FlatStyle.Popup;
            PatientAppointmentButton.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            PatientAppointmentButton.ForeColor = Color.Red;
            PatientAppointmentButton.Location = new Point(1033, 224);
            PatientAppointmentButton.Name = "PatientAppointmentButton";
            PatientAppointmentButton.Size = new Size(352, 321);
            PatientAppointmentButton.TabIndex = 6;
            PatientAppointmentButton.Text = "Patient \r\nAppointment";
            PatientAppointmentButton.UseVisualStyleBackColor = false;
            PatientAppointmentButton.Click += PatientAppointmentButton_Click;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Red;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(772, 750);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(297, 80);
            BackToDashboardButton.TabIndex = 17;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // Appointment_Types
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 881);
            Controls.Add(BackToDashboardButton);
            Controls.Add(PatientAppointmentButton);
            Controls.Add(DoctorSchedulesButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Appointment_Types";
            Text = "Appointment Types";
            ResumeLayout(false);
        }

        #endregion

        private Button DoctorSchedulesButton;
        private Button PatientAppointmentButton;
        private Button BackToDashboardButton;
    }
}