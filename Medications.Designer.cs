namespace HealthCare_Plus
{
    partial class Medications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medications));
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            MedicationsHeading = new Label();
            ViewMedicationButton = new Button();
            AddMedicationButton = new Button();
            DeleteMedicationButton = new Button();
            AddPatientButton = new Button();
            BackToDashboardButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1682, 278);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 29;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1230, 278);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(334, 355);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1457, 588);
            dataGridView1.TabIndex = 27;
            // 
            // MedicationsHeading
            // 
            MedicationsHeading.AutoSize = true;
            MedicationsHeading.BackColor = Color.Transparent;
            MedicationsHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            MedicationsHeading.ForeColor = Color.Lime;
            MedicationsHeading.Location = new Point(706, 46);
            MedicationsHeading.Name = "MedicationsHeading";
            MedicationsHeading.Size = new Size(384, 70);
            MedicationsHeading.TabIndex = 26;
            MedicationsHeading.Text = "Medications";
            // 
            // ViewMedicationButton
            // 
            ViewMedicationButton.BackColor = Color.FromArgb(255, 128, 0);
            ViewMedicationButton.FlatStyle = FlatStyle.Popup;
            ViewMedicationButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ViewMedicationButton.ForeColor = Color.White;
            ViewMedicationButton.Location = new Point(64, 495);
            ViewMedicationButton.Name = "ViewMedicationButton";
            ViewMedicationButton.Size = new Size(193, 43);
            ViewMedicationButton.TabIndex = 43;
            ViewMedicationButton.Text = "View Medication";
            ViewMedicationButton.UseVisualStyleBackColor = false;
            ViewMedicationButton.Click += ViewMedicationButton_Click;
            // 
            // AddMedicationButton
            // 
            AddMedicationButton.BackColor = Color.FromArgb(255, 128, 0);
            AddMedicationButton.FlatStyle = FlatStyle.Popup;
            AddMedicationButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddMedicationButton.ForeColor = Color.White;
            AddMedicationButton.Location = new Point(64, 412);
            AddMedicationButton.Name = "AddMedicationButton";
            AddMedicationButton.Size = new Size(193, 43);
            AddMedicationButton.TabIndex = 42;
            AddMedicationButton.Text = "Add Medication";
            AddMedicationButton.UseVisualStyleBackColor = false;
            AddMedicationButton.Click += AddMedicationButton_Click;
            // 
            // DeleteMedicationButton
            // 
            DeleteMedicationButton.BackColor = Color.FromArgb(255, 128, 0);
            DeleteMedicationButton.FlatStyle = FlatStyle.Popup;
            DeleteMedicationButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteMedicationButton.ForeColor = Color.White;
            DeleteMedicationButton.Location = new Point(64, 582);
            DeleteMedicationButton.Name = "DeleteMedicationButton";
            DeleteMedicationButton.Size = new Size(193, 43);
            DeleteMedicationButton.TabIndex = 41;
            DeleteMedicationButton.Text = "Delete Medication";
            DeleteMedicationButton.UseVisualStyleBackColor = false;
            DeleteMedicationButton.Click += DeleteMedicationButton_Click;
            // 
            // AddPatientButton
            // 
            AddPatientButton.BackColor = Color.FromArgb(255, 128, 0);
            AddPatientButton.FlatStyle = FlatStyle.Popup;
            AddPatientButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddPatientButton.ForeColor = Color.White;
            AddPatientButton.Location = new Point(64, 660);
            AddPatientButton.Name = "AddPatientButton";
            AddPatientButton.Size = new Size(193, 43);
            AddPatientButton.TabIndex = 40;
            AddPatientButton.Text = "Add Patient";
            AddPatientButton.UseVisualStyleBackColor = false;
            AddPatientButton.Click += AddPatientButton_Click;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Red;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(64, 744);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(193, 43);
            BackToDashboardButton.TabIndex = 39;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // Medications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(ViewMedicationButton);
            Controls.Add(AddMedicationButton);
            Controls.Add(DeleteMedicationButton);
            Controls.Add(AddPatientButton);
            Controls.Add(BackToDashboardButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(MedicationsHeading);
            DoubleBuffered = true;
            Name = "Medications";
            Text = "Medications";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox SearchTextbox;
        private DataGridView dataGridView1;
        private Label MedicationsHeading;
        private Button ViewMedicationButton;
        private Button AddMedicationButton;
        private Button DeleteMedicationButton;
        private Button AddPatientButton;
        private Button BackToDashboardButton;
    }
}