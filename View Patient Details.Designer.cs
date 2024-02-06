namespace HealthCare_Plus
{
    partial class View_Patient_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Patient_Details));
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            PatientDetailsHeading = new Label();
            SearchButton1 = new Button();
            SearchTextbox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            BackToDashboardButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1582, -76);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 43;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1130, -76);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 42;
            // 
            // PatientDetailsHeading
            // 
            PatientDetailsHeading.AutoSize = true;
            PatientDetailsHeading.BackColor = Color.Transparent;
            PatientDetailsHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            PatientDetailsHeading.ForeColor = Color.Lime;
            PatientDetailsHeading.Location = new Point(554, -196);
            PatientDetailsHeading.Name = "PatientDetailsHeading";
            PatientDetailsHeading.Size = new Size(453, 70);
            PatientDetailsHeading.TabIndex = 40;
            PatientDetailsHeading.Text = "Patient Details";
            // 
            // SearchButton1
            // 
            SearchButton1.BackColor = Color.LightGray;
            SearchButton1.FlatStyle = FlatStyle.Popup;
            SearchButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton1.Location = new Point(1753, 204);
            SearchButton1.Name = "SearchButton1";
            SearchButton1.Size = new Size(109, 27);
            SearchButton1.TabIndex = 47;
            SearchButton1.Text = "Search";
            SearchButton1.UseVisualStyleBackColor = false;
            SearchButton1.Click += button1_Click;
            // 
            // SearchTextbox1
            // 
            SearchTextbox1.Location = new Point(1301, 204);
            SearchTextbox1.Name = "SearchTextbox1";
            SearchTextbox1.Size = new Size(414, 27);
            SearchTextbox1.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(707, 27);
            label1.Name = "label1";
            label1.Size = new Size(453, 70);
            label1.TabIndex = 45;
            label1.Text = "Patient Details";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(458, 835);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(784, 695);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(264, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1419, 529);
            dataGridView1.TabIndex = 48;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Red;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(26, 542);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(193, 43);
            BackToDashboardButton.TabIndex = 50;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // View_Patient_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(BackToDashboardButton);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(SearchButton1);
            Controls.Add(SearchTextbox1);
            Controls.Add(label1);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(PatientDetailsHeading);
            DoubleBuffered = true;
            Name = "View_Patient_Details";
            Text = "View Patient Details";
            Load += View_Patient_Details_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SearchButton;
        private TextBox SearchTextbox;
        private Label PatientDetailsHeading;
        private Button SearchButton1;
        private TextBox SearchTextbox1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button BackToDashboardButton;
    }
}