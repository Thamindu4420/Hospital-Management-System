namespace HealthCare_Plus
{
    partial class Staff_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Dashboard));
            menuStrip1 = new MenuStrip();
            StaffDropdown = new ToolStripMenuItem();
            StaffProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            RoomAvailabilityButton = new Button();
            MedicationTrackingButton = new Button();
            MedicalItemsButton = new Button();
            AppointmentsButton = new Button();
            PatientButton = new Button();
            DoctorButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 224, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { StaffDropdown });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1924, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // StaffDropdown
            // 
            StaffDropdown.BackColor = Color.Transparent;
            StaffDropdown.DropDownItems.AddRange(new ToolStripItem[] { StaffProfileToolStripMenuItem, logoutToolStripMenuItem });
            StaffDropdown.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StaffDropdown.ForeColor = SystemColors.ActiveCaptionText;
            StaffDropdown.Margin = new Padding(1700, 0, 0, 0);
            StaffDropdown.Name = "StaffDropdown";
            StaffDropdown.RightToLeft = RightToLeft.No;
            StaffDropdown.Size = new Size(64, 28);
            StaffDropdown.Text = "Staff";
            // 
            // StaffProfileToolStripMenuItem
            // 
            StaffProfileToolStripMenuItem.Name = "StaffProfileToolStripMenuItem";
            StaffProfileToolStripMenuItem.Size = new Size(199, 28);
            StaffProfileToolStripMenuItem.Text = "Staff Profile ";
            StaffProfileToolStripMenuItem.Click += adminProfileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(199, 28);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // RoomAvailabilityButton
            // 
            RoomAvailabilityButton.BackColor = Color.White;
            RoomAvailabilityButton.BackgroundImage = (Image)resources.GetObject("RoomAvailabilityButton.BackgroundImage");
            RoomAvailabilityButton.BackgroundImageLayout = ImageLayout.Stretch;
            RoomAvailabilityButton.FlatStyle = FlatStyle.Popup;
            RoomAvailabilityButton.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            RoomAvailabilityButton.ForeColor = Color.Red;
            RoomAvailabilityButton.Location = new Point(1084, 470);
            RoomAvailabilityButton.Name = "RoomAvailabilityButton";
            RoomAvailabilityButton.Size = new Size(197, 165);
            RoomAvailabilityButton.TabIndex = 16;
            RoomAvailabilityButton.Text = "ROOM AVAILABILITY";
            RoomAvailabilityButton.UseVisualStyleBackColor = false;
            RoomAvailabilityButton.Click += RoomAvailabilityButton_Click;
            // 
            // MedicationTrackingButton
            // 
            MedicationTrackingButton.BackColor = Color.White;
            MedicationTrackingButton.BackgroundImage = (Image)resources.GetObject("MedicationTrackingButton.BackgroundImage");
            MedicationTrackingButton.BackgroundImageLayout = ImageLayout.Stretch;
            MedicationTrackingButton.FlatStyle = FlatStyle.Popup;
            MedicationTrackingButton.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MedicationTrackingButton.ForeColor = Color.Red;
            MedicationTrackingButton.Location = new Point(789, 468);
            MedicationTrackingButton.Name = "MedicationTrackingButton";
            MedicationTrackingButton.Size = new Size(197, 165);
            MedicationTrackingButton.TabIndex = 15;
            MedicationTrackingButton.Text = "MEDICAL TRACKING";
            MedicationTrackingButton.UseVisualStyleBackColor = false;
            MedicationTrackingButton.Click += MedicationTrackingButton_Click;
            // 
            // MedicalItemsButton
            // 
            MedicalItemsButton.BackColor = Color.White;
            MedicalItemsButton.BackgroundImage = (Image)resources.GetObject("MedicalItemsButton.BackgroundImage");
            MedicalItemsButton.BackgroundImageLayout = ImageLayout.Stretch;
            MedicalItemsButton.FlatStyle = FlatStyle.Popup;
            MedicalItemsButton.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            MedicalItemsButton.ForeColor = Color.Red;
            MedicalItemsButton.Location = new Point(500, 467);
            MedicalItemsButton.Name = "MedicalItemsButton";
            MedicalItemsButton.Size = new Size(197, 165);
            MedicalItemsButton.TabIndex = 14;
            MedicalItemsButton.Text = "MEDICAL \r\nITEMS";
            MedicalItemsButton.UseVisualStyleBackColor = false;
            MedicalItemsButton.Click += MedicalItemsButton_Click;
            // 
            // AppointmentsButton
            // 
            AppointmentsButton.BackColor = Color.White;
            AppointmentsButton.BackgroundImage = (Image)resources.GetObject("AppointmentsButton.BackgroundImage");
            AppointmentsButton.BackgroundImageLayout = ImageLayout.Stretch;
            AppointmentsButton.FlatStyle = FlatStyle.Popup;
            AppointmentsButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AppointmentsButton.ForeColor = Color.Red;
            AppointmentsButton.Location = new Point(1083, 240);
            AppointmentsButton.Name = "AppointmentsButton";
            AppointmentsButton.Size = new Size(198, 165);
            AppointmentsButton.TabIndex = 13;
            AppointmentsButton.Text = "APPOINTMENTS";
            AppointmentsButton.UseVisualStyleBackColor = false;
            AppointmentsButton.Click += AppointmentsButton_Click;
            // 
            // PatientButton
            // 
            PatientButton.BackColor = Color.White;
            PatientButton.BackgroundImage = (Image)resources.GetObject("PatientButton.BackgroundImage");
            PatientButton.BackgroundImageLayout = ImageLayout.Stretch;
            PatientButton.FlatStyle = FlatStyle.Popup;
            PatientButton.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            PatientButton.ForeColor = Color.Red;
            PatientButton.Location = new Point(789, 240);
            PatientButton.Name = "PatientButton";
            PatientButton.Size = new Size(197, 165);
            PatientButton.TabIndex = 12;
            PatientButton.Text = "PATIENT";
            PatientButton.UseVisualStyleBackColor = false;
            PatientButton.Click += PatientButton_Click;
            // 
            // DoctorButton
            // 
            DoctorButton.BackColor = Color.White;
            DoctorButton.BackgroundImage = (Image)resources.GetObject("DoctorButton.BackgroundImage");
            DoctorButton.BackgroundImageLayout = ImageLayout.Stretch;
            DoctorButton.FlatStyle = FlatStyle.Popup;
            DoctorButton.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorButton.ForeColor = Color.Red;
            DoctorButton.Location = new Point(500, 240);
            DoctorButton.Name = "DoctorButton";
            DoctorButton.Size = new Size(197, 165);
            DoctorButton.TabIndex = 11;
            DoctorButton.Text = "DOCTOR";
            DoctorButton.UseVisualStyleBackColor = false;
            DoctorButton.Click += DoctorButton_Click;
            // 
            // Staff_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 840);
            Controls.Add(RoomAvailabilityButton);
            Controls.Add(MedicationTrackingButton);
            Controls.Add(MedicalItemsButton);
            Controls.Add(AppointmentsButton);
            Controls.Add(PatientButton);
            Controls.Add(DoctorButton);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Name = "Staff_Dashboard";
            Text = "Staff Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem StaffDropdown;
        private ToolStripMenuItem StaffProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Button RoomAvailabilityButton;
        private Button MedicationTrackingButton;
        private Button MedicalItemsButton;
        private Button AppointmentsButton;
        private Button PatientButton;
        private Button DoctorButton;
    }
}