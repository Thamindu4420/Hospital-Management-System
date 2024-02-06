namespace HealthCare_Plus
{
    partial class Doctor_Schedules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Schedules));
            DoctorScheduleHeading = new Label();
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            DeleteDoctorScheduleButton = new Button();
            AddDoctorScheduleButton = new Button();
            BackButton = new Button();
            PatientAppointmentsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DoctorScheduleHeading
            // 
            DoctorScheduleHeading.AutoSize = true;
            DoctorScheduleHeading.BackColor = Color.Transparent;
            DoctorScheduleHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            DoctorScheduleHeading.ForeColor = Color.Lime;
            DoctorScheduleHeading.Location = new Point(636, 44);
            DoctorScheduleHeading.Name = "DoctorScheduleHeading";
            DoctorScheduleHeading.Size = new Size(518, 70);
            DoctorScheduleHeading.TabIndex = 13;
            DoctorScheduleHeading.Text = "Doctor Schedule";
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1741, 215);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 17;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1289, 215);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(393, 292);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1457, 529);
            dataGridView1.TabIndex = 15;
            // 
            // DeleteDoctorScheduleButton
            // 
            DeleteDoctorScheduleButton.BackColor = Color.FromArgb(255, 128, 0);
            DeleteDoctorScheduleButton.FlatStyle = FlatStyle.Popup;
            DeleteDoctorScheduleButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteDoctorScheduleButton.ForeColor = Color.White;
            DeleteDoctorScheduleButton.Location = new Point(94, 482);
            DeleteDoctorScheduleButton.Name = "DeleteDoctorScheduleButton";
            DeleteDoctorScheduleButton.Size = new Size(193, 43);
            DeleteDoctorScheduleButton.TabIndex = 26;
            DeleteDoctorScheduleButton.Text = "Delete Schedule";
            DeleteDoctorScheduleButton.UseVisualStyleBackColor = false;
            DeleteDoctorScheduleButton.Click += DeleteDoctorScheduleButton_Click;
            // 
            // AddDoctorScheduleButton
            // 
            AddDoctorScheduleButton.BackColor = Color.FromArgb(255, 128, 0);
            AddDoctorScheduleButton.FlatStyle = FlatStyle.Popup;
            AddDoctorScheduleButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddDoctorScheduleButton.ForeColor = Color.White;
            AddDoctorScheduleButton.Location = new Point(94, 393);
            AddDoctorScheduleButton.Name = "AddDoctorScheduleButton";
            AddDoctorScheduleButton.Size = new Size(193, 43);
            AddDoctorScheduleButton.TabIndex = 25;
            AddDoctorScheduleButton.Text = "Add Schedule";
            AddDoctorScheduleButton.UseVisualStyleBackColor = false;
            AddDoctorScheduleButton.Click += AddDoctorScheduleButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(94, 649);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(193, 43);
            BackButton.TabIndex = 24;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // PatientAppointmentsButton
            // 
            PatientAppointmentsButton.BackColor = Color.Red;
            PatientAppointmentsButton.FlatStyle = FlatStyle.Popup;
            PatientAppointmentsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PatientAppointmentsButton.ForeColor = Color.White;
            PatientAppointmentsButton.Location = new Point(94, 568);
            PatientAppointmentsButton.Name = "PatientAppointmentsButton";
            PatientAppointmentsButton.Size = new Size(193, 43);
            PatientAppointmentsButton.TabIndex = 27;
            PatientAppointmentsButton.Text = "Patient Appointments";
            PatientAppointmentsButton.UseVisualStyleBackColor = false;
            PatientAppointmentsButton.Click += PatientAppointmentsButton_Click;
            // 
            // Doctor_Schedules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 887);
            Controls.Add(PatientAppointmentsButton);
            Controls.Add(DeleteDoctorScheduleButton);
            Controls.Add(AddDoctorScheduleButton);
            Controls.Add(BackButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(DoctorScheduleHeading);
            DoubleBuffered = true;
            Name = "Doctor_Schedules";
            Text = "Doctor Schedules";
            Load += Doctor_Schedules_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DoctorScheduleHeading;
        private Button SearchButton;
        private TextBox SearchTextbox;
        private DataGridView dataGridView1;
        private Button DeleteDoctorScheduleButton;
        private Button AddDoctorScheduleButton;
        private Button BackButton;
        private Button PatientAppointmentsButton;
    }
}