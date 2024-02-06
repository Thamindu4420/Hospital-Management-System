namespace HealthCare_Plus
{
    partial class Report_Types
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Types));
            ReportsHeading = new Label();
            TotalIncomeReportButton = new Button();
            TotalIncome = new Label();
            MedicalItems = new Label();
            MedicalItemsReportButton = new Button();
            Appointments = new Label();
            AppointmentsReportButton = new Button();
            TotalDoctors = new Label();
            TotalDoctorsReportButton = new Button();
            TotalStaff = new Label();
            TotalStaffReportButton = new Button();
            TotalPatients = new Label();
            TotalPatientsReportButton = new Button();
            BackToDashboardButton = new Button();
            SuspendLayout();
            // 
            // ReportsHeading
            // 
            ReportsHeading.AutoSize = true;
            ReportsHeading.BackColor = Color.Transparent;
            ReportsHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            ReportsHeading.ForeColor = Color.Lime;
            ReportsHeading.Location = new Point(779, 46);
            ReportsHeading.Name = "ReportsHeading";
            ReportsHeading.Size = new Size(263, 70);
            ReportsHeading.TabIndex = 50;
            ReportsHeading.Text = "Reports";
            ReportsHeading.Click += ReportsHeading_Click;
            // 
            // TotalIncomeReportButton
            // 
            TotalIncomeReportButton.BackColor = Color.PeachPuff;
            TotalIncomeReportButton.BackgroundImage = (Image)resources.GetObject("TotalIncomeReportButton.BackgroundImage");
            TotalIncomeReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            TotalIncomeReportButton.FlatStyle = FlatStyle.Popup;
            TotalIncomeReportButton.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TotalIncomeReportButton.ForeColor = Color.Red;
            TotalIncomeReportButton.Location = new Point(397, 228);
            TotalIncomeReportButton.Name = "TotalIncomeReportButton";
            TotalIncomeReportButton.Size = new Size(225, 225);
            TotalIncomeReportButton.TabIndex = 51;
            TotalIncomeReportButton.UseVisualStyleBackColor = false;
            TotalIncomeReportButton.Click += TotalIncomeReportButton_Click;
            // 
            // TotalIncome
            // 
            TotalIncome.AutoSize = true;
            TotalIncome.BackColor = Color.Black;
            TotalIncome.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TotalIncome.ForeColor = Color.Red;
            TotalIncome.Location = new Point(430, 472);
            TotalIncome.Name = "TotalIncome";
            TotalIncome.Size = new Size(148, 27);
            TotalIncome.TabIndex = 52;
            TotalIncome.Text = "Total Income";
            // 
            // MedicalItems
            // 
            MedicalItems.AutoSize = true;
            MedicalItems.BackColor = Color.Black;
            MedicalItems.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MedicalItems.ForeColor = Color.Red;
            MedicalItems.Location = new Point(826, 472);
            MedicalItems.Name = "MedicalItems";
            MedicalItems.Size = new Size(158, 27);
            MedicalItems.TabIndex = 54;
            MedicalItems.Text = "Medical Items";
            // 
            // MedicalItemsReportButton
            // 
            MedicalItemsReportButton.BackColor = Color.PeachPuff;
            MedicalItemsReportButton.BackgroundImage = (Image)resources.GetObject("MedicalItemsReportButton.BackgroundImage");
            MedicalItemsReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            MedicalItemsReportButton.FlatStyle = FlatStyle.Popup;
            MedicalItemsReportButton.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            MedicalItemsReportButton.ForeColor = Color.Red;
            MedicalItemsReportButton.Location = new Point(793, 228);
            MedicalItemsReportButton.Name = "MedicalItemsReportButton";
            MedicalItemsReportButton.Size = new Size(225, 225);
            MedicalItemsReportButton.TabIndex = 53;
            MedicalItemsReportButton.UseVisualStyleBackColor = false;
            MedicalItemsReportButton.Click += MedicalItemsReportButton_Click;
            // 
            // Appointments
            // 
            Appointments.AutoSize = true;
            Appointments.BackColor = Color.Black;
            Appointments.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Appointments.ForeColor = Color.Red;
            Appointments.Location = new Point(1218, 472);
            Appointments.Name = "Appointments";
            Appointments.Size = new Size(162, 27);
            Appointments.TabIndex = 56;
            Appointments.Text = "Appointments";
            // 
            // AppointmentsReportButton
            // 
            AppointmentsReportButton.BackColor = Color.PeachPuff;
            AppointmentsReportButton.BackgroundImage = (Image)resources.GetObject("AppointmentsReportButton.BackgroundImage");
            AppointmentsReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            AppointmentsReportButton.FlatStyle = FlatStyle.Popup;
            AppointmentsReportButton.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            AppointmentsReportButton.ForeColor = Color.Red;
            AppointmentsReportButton.Location = new Point(1185, 228);
            AppointmentsReportButton.Name = "AppointmentsReportButton";
            AppointmentsReportButton.Size = new Size(225, 225);
            AppointmentsReportButton.TabIndex = 55;
            AppointmentsReportButton.UseVisualStyleBackColor = false;
            AppointmentsReportButton.Click += AppointmentsReportButton_Click;
            // 
            // TotalDoctors
            // 
            TotalDoctors.AutoSize = true;
            TotalDoctors.BackColor = Color.Black;
            TotalDoctors.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TotalDoctors.ForeColor = Color.Red;
            TotalDoctors.Location = new Point(430, 826);
            TotalDoctors.Name = "TotalDoctors";
            TotalDoctors.Size = new Size(153, 27);
            TotalDoctors.TabIndex = 58;
            TotalDoctors.Text = "Total Doctors";
            // 
            // TotalDoctorsReportButton
            // 
            TotalDoctorsReportButton.BackColor = Color.PeachPuff;
            TotalDoctorsReportButton.BackgroundImage = (Image)resources.GetObject("TotalDoctorsReportButton.BackgroundImage");
            TotalDoctorsReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            TotalDoctorsReportButton.FlatStyle = FlatStyle.Popup;
            TotalDoctorsReportButton.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TotalDoctorsReportButton.ForeColor = Color.Red;
            TotalDoctorsReportButton.Location = new Point(397, 582);
            TotalDoctorsReportButton.Name = "TotalDoctorsReportButton";
            TotalDoctorsReportButton.Size = new Size(225, 225);
            TotalDoctorsReportButton.TabIndex = 57;
            TotalDoctorsReportButton.UseVisualStyleBackColor = false;
            TotalDoctorsReportButton.Click += TotalDoctorsReportButton_Click;
            // 
            // TotalStaff
            // 
            TotalStaff.AutoSize = true;
            TotalStaff.BackColor = Color.Black;
            TotalStaff.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TotalStaff.ForeColor = Color.Red;
            TotalStaff.Location = new Point(826, 826);
            TotalStaff.Name = "TotalStaff";
            TotalStaff.Size = new Size(118, 27);
            TotalStaff.TabIndex = 60;
            TotalStaff.Text = "Total Staff";
            // 
            // TotalStaffReportButton
            // 
            TotalStaffReportButton.BackColor = Color.PeachPuff;
            TotalStaffReportButton.BackgroundImage = (Image)resources.GetObject("TotalStaffReportButton.BackgroundImage");
            TotalStaffReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            TotalStaffReportButton.FlatStyle = FlatStyle.Popup;
            TotalStaffReportButton.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TotalStaffReportButton.ForeColor = Color.Red;
            TotalStaffReportButton.Location = new Point(793, 582);
            TotalStaffReportButton.Name = "TotalStaffReportButton";
            TotalStaffReportButton.Size = new Size(225, 225);
            TotalStaffReportButton.TabIndex = 59;
            TotalStaffReportButton.UseVisualStyleBackColor = false;
            TotalStaffReportButton.Click += TotalStaffReportButton_Click;
            // 
            // TotalPatients
            // 
            TotalPatients.AutoSize = true;
            TotalPatients.BackColor = Color.Black;
            TotalPatients.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TotalPatients.ForeColor = Color.Red;
            TotalPatients.Location = new Point(1218, 826);
            TotalPatients.Name = "TotalPatients";
            TotalPatients.Size = new Size(155, 27);
            TotalPatients.TabIndex = 62;
            TotalPatients.Text = "Total Patients";
            // 
            // TotalPatientsReportButton
            // 
            TotalPatientsReportButton.BackColor = Color.PeachPuff;
            TotalPatientsReportButton.BackgroundImage = (Image)resources.GetObject("TotalPatientsReportButton.BackgroundImage");
            TotalPatientsReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            TotalPatientsReportButton.FlatStyle = FlatStyle.Popup;
            TotalPatientsReportButton.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPatientsReportButton.ForeColor = Color.Red;
            TotalPatientsReportButton.Location = new Point(1185, 582);
            TotalPatientsReportButton.Name = "TotalPatientsReportButton";
            TotalPatientsReportButton.Size = new Size(225, 225);
            TotalPatientsReportButton.TabIndex = 61;
            TotalPatientsReportButton.UseVisualStyleBackColor = false;
            TotalPatientsReportButton.Click += TotalPatientsReportButton_Click;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Red;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(793, 934);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(211, 60);
            BackToDashboardButton.TabIndex = 63;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // Report_Types
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(BackToDashboardButton);
            Controls.Add(TotalPatients);
            Controls.Add(TotalPatientsReportButton);
            Controls.Add(TotalStaff);
            Controls.Add(TotalStaffReportButton);
            Controls.Add(TotalDoctors);
            Controls.Add(TotalDoctorsReportButton);
            Controls.Add(Appointments);
            Controls.Add(AppointmentsReportButton);
            Controls.Add(MedicalItems);
            Controls.Add(MedicalItemsReportButton);
            Controls.Add(TotalIncome);
            Controls.Add(TotalIncomeReportButton);
            Controls.Add(ReportsHeading);
            DoubleBuffered = true;
            Name = "Report_Types";
            Text = "Report Types";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReportsHeading;
        private Button TotalIncomeReportButton;
        private Label TotalIncome;
        private Label MedicalItems;
        private Button MedicalItemsReportButton;
        private Label Appointments;
        private Button AppointmentsReportButton;
        private Label TotalDoctors;
        private Button TotalDoctorsReportButton;
        private Label TotalStaff;
        private Button TotalStaffReportButton;
        private Label TotalPatients;
        private Button TotalPatientsReportButton;
        private Button BackToDashboardButton;
    }
}