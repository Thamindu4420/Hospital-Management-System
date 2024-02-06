namespace HealthCare_Plus
{
    partial class Patient_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Appointment));
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            PatientAppointmentHeading = new Label();
            DeletePatientAppointmentButton = new Button();
            AddPatientAppointmentButton = new Button();
            BackButton = new Button();
            DoctorSchedulesButton = new Button();
            AddPatientButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1738, 225);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 21;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1286, 225);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 302);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1457, 529);
            dataGridView1.TabIndex = 19;
            // 
            // PatientAppointmentHeading
            // 
            PatientAppointmentHeading.AutoSize = true;
            PatientAppointmentHeading.BackColor = Color.Transparent;
            PatientAppointmentHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            PatientAppointmentHeading.ForeColor = Color.Lime;
            PatientAppointmentHeading.Location = new Point(633, 54);
            PatientAppointmentHeading.Name = "PatientAppointmentHeading";
            PatientAppointmentHeading.Size = new Size(625, 70);
            PatientAppointmentHeading.TabIndex = 18;
            PatientAppointmentHeading.Text = "Patient Appointment";
            // 
            // DeletePatientAppointmentButton
            // 
            DeletePatientAppointmentButton.BackColor = Color.FromArgb(255, 128, 0);
            DeletePatientAppointmentButton.FlatStyle = FlatStyle.Popup;
            DeletePatientAppointmentButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeletePatientAppointmentButton.ForeColor = Color.White;
            DeletePatientAppointmentButton.Location = new Point(91, 468);
            DeletePatientAppointmentButton.Name = "DeletePatientAppointmentButton";
            DeletePatientAppointmentButton.Size = new Size(193, 43);
            DeletePatientAppointmentButton.TabIndex = 29;
            DeletePatientAppointmentButton.Text = "Delete Appointment";
            DeletePatientAppointmentButton.UseVisualStyleBackColor = false;
            DeletePatientAppointmentButton.Click += DeletePatientAppointmentButton_Click;
            // 
            // AddPatientAppointmentButton
            // 
            AddPatientAppointmentButton.BackColor = Color.FromArgb(255, 128, 0);
            AddPatientAppointmentButton.FlatStyle = FlatStyle.Popup;
            AddPatientAppointmentButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddPatientAppointmentButton.ForeColor = Color.White;
            AddPatientAppointmentButton.Location = new Point(91, 379);
            AddPatientAppointmentButton.Name = "AddPatientAppointmentButton";
            AddPatientAppointmentButton.Size = new Size(193, 43);
            AddPatientAppointmentButton.TabIndex = 28;
            AddPatientAppointmentButton.Text = "Add Appointment";
            AddPatientAppointmentButton.UseVisualStyleBackColor = false;
            AddPatientAppointmentButton.Click += AddPatientAppointmentButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(91, 709);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(193, 43);
            BackButton.TabIndex = 27;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // DoctorSchedulesButton
            // 
            DoctorSchedulesButton.BackColor = Color.Red;
            DoctorSchedulesButton.FlatStyle = FlatStyle.Popup;
            DoctorSchedulesButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DoctorSchedulesButton.ForeColor = Color.White;
            DoctorSchedulesButton.Location = new Point(91, 627);
            DoctorSchedulesButton.Name = "DoctorSchedulesButton";
            DoctorSchedulesButton.Size = new Size(193, 43);
            DoctorSchedulesButton.TabIndex = 30;
            DoctorSchedulesButton.Text = "Doctor Schedules";
            DoctorSchedulesButton.UseVisualStyleBackColor = false;
            DoctorSchedulesButton.Click += DoctorSchedulesButton_Click;
            // 
            // AddPatientButton
            // 
            AddPatientButton.BackColor = Color.FromArgb(255, 128, 0);
            AddPatientButton.FlatStyle = FlatStyle.Popup;
            AddPatientButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddPatientButton.ForeColor = Color.White;
            AddPatientButton.Location = new Point(91, 549);
            AddPatientButton.Name = "AddPatientButton";
            AddPatientButton.Size = new Size(193, 43);
            AddPatientButton.TabIndex = 31;
            AddPatientButton.Text = "Add Patient";
            AddPatientButton.UseVisualStyleBackColor = false;
            AddPatientButton.Click += AddPatientButton_Click;
            // 
            // Patient_Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 883);
            Controls.Add(AddPatientButton);
            Controls.Add(DoctorSchedulesButton);
            Controls.Add(DeletePatientAppointmentButton);
            Controls.Add(AddPatientAppointmentButton);
            Controls.Add(BackButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(PatientAppointmentHeading);
            DoubleBuffered = true;
            Name = "Patient_Appointment";
            Text = "Patient_Appointment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox SearchTextbox;
        private DataGridView dataGridView1;
        private Label PatientAppointmentHeading;
        private Button DeletePatientAppointmentButton;
        private Button AddPatientAppointmentButton;
        private Button BackButton;
        private Button DoctorSchedulesButton;
        private Button AddPatientButton;
    }
}