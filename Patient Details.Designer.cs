namespace HealthCare_Plus
{
    partial class Patient_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Details));
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            PatientDetailsHeading = new Label();
            AddPatientButton = new Button();
            DeletePatientButton = new Button();
            AddPatientAppointmentButton = new Button();
            BackToDashboardButton = new Button();
            ViewPatientButton = new Button();
            BrowseImageButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1702, 207);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 25;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1250, 207);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(354, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1457, 529);
            dataGridView1.TabIndex = 23;
            // 
            // PatientDetailsHeading
            // 
            PatientDetailsHeading.AutoSize = true;
            PatientDetailsHeading.BackColor = Color.Transparent;
            PatientDetailsHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            PatientDetailsHeading.ForeColor = Color.Lime;
            PatientDetailsHeading.Location = new Point(674, 87);
            PatientDetailsHeading.Name = "PatientDetailsHeading";
            PatientDetailsHeading.Size = new Size(453, 70);
            PatientDetailsHeading.TabIndex = 22;
            PatientDetailsHeading.Text = "Patient Details";
            // 
            // AddPatientButton
            // 
            AddPatientButton.BackColor = Color.FromArgb(255, 128, 0);
            AddPatientButton.FlatStyle = FlatStyle.Popup;
            AddPatientButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddPatientButton.ForeColor = Color.White;
            AddPatientButton.Location = new Point(75, 310);
            AddPatientButton.Name = "AddPatientButton";
            AddPatientButton.Size = new Size(193, 43);
            AddPatientButton.TabIndex = 36;
            AddPatientButton.Text = "Add Patient";
            AddPatientButton.UseVisualStyleBackColor = false;
            AddPatientButton.Click += AddPatientButton_Click;
            // 
            // DeletePatientButton
            // 
            DeletePatientButton.BackColor = Color.FromArgb(255, 128, 0);
            DeletePatientButton.FlatStyle = FlatStyle.Popup;
            DeletePatientButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeletePatientButton.ForeColor = Color.White;
            DeletePatientButton.Location = new Point(75, 480);
            DeletePatientButton.Name = "DeletePatientButton";
            DeletePatientButton.Size = new Size(193, 43);
            DeletePatientButton.TabIndex = 34;
            DeletePatientButton.Text = "Delete Patient";
            DeletePatientButton.UseVisualStyleBackColor = false;
            DeletePatientButton.Click += DeletePatientButton_Click;
            // 
            // AddPatientAppointmentButton
            // 
            AddPatientAppointmentButton.BackColor = Color.FromArgb(255, 128, 0);
            AddPatientAppointmentButton.FlatStyle = FlatStyle.Popup;
            AddPatientAppointmentButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddPatientAppointmentButton.ForeColor = Color.White;
            AddPatientAppointmentButton.Location = new Point(75, 654);
            AddPatientAppointmentButton.Name = "AddPatientAppointmentButton";
            AddPatientAppointmentButton.Size = new Size(193, 43);
            AddPatientAppointmentButton.TabIndex = 33;
            AddPatientAppointmentButton.Text = "Add Appointment";
            AddPatientAppointmentButton.UseVisualStyleBackColor = false;
            AddPatientAppointmentButton.Click += AddPatientAppointmentButton_Click;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Red;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(75, 733);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(193, 43);
            BackToDashboardButton.TabIndex = 32;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // ViewPatientButton
            // 
            ViewPatientButton.BackColor = Color.FromArgb(255, 128, 0);
            ViewPatientButton.FlatStyle = FlatStyle.Popup;
            ViewPatientButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ViewPatientButton.ForeColor = Color.White;
            ViewPatientButton.Location = new Point(75, 393);
            ViewPatientButton.Name = "ViewPatientButton";
            ViewPatientButton.Size = new Size(193, 43);
            ViewPatientButton.TabIndex = 37;
            ViewPatientButton.Text = "View Patient";
            ViewPatientButton.UseVisualStyleBackColor = false;
            ViewPatientButton.Click += ViewPatientButton_Click;
            // 
            // BrowseImageButton
            // 
            BrowseImageButton.BackColor = Color.FromArgb(255, 128, 0);
            BrowseImageButton.FlatStyle = FlatStyle.Popup;
            BrowseImageButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BrowseImageButton.ForeColor = Color.White;
            BrowseImageButton.Location = new Point(75, 566);
            BrowseImageButton.Name = "BrowseImageButton";
            BrowseImageButton.Size = new Size(193, 43);
            BrowseImageButton.TabIndex = 38;
            BrowseImageButton.Text = "Browse Image";
            BrowseImageButton.UseVisualStyleBackColor = false;
            BrowseImageButton.Click += BrowseImageButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(586, 838);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(784, 695);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // Patient_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pictureBox1);
            Controls.Add(BrowseImageButton);
            Controls.Add(ViewPatientButton);
            Controls.Add(AddPatientButton);
            Controls.Add(DeletePatientButton);
            Controls.Add(AddPatientAppointmentButton);
            Controls.Add(BackToDashboardButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(PatientDetailsHeading);
            DoubleBuffered = true;
            Name = "Patient_Details";
            Text = "Patient Details";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox SearchTextbox;
        private DataGridView dataGridView1;
        private Label PatientDetailsHeading;
        private Button AddPatientButton;
        private Button DeletePatientButton;
        private Button AddPatientAppointmentButton;
        private Button BackToDashboardButton;
        private Button ViewPatientButton;
        private Button BrowseImageButton;
        private PictureBox pictureBox1;
    }
}