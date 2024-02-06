namespace HealthCare_Plus
{
    partial class View_Doctor_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Doctor_Details));
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            DoctorsHeading = new Label();
            dataGridView1 = new DataGridView();
            BackToDashboardButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1688, 246);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 18;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1236, 246);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 17;
            // 
            // DoctorsHeading
            // 
            DoctorsHeading.AutoSize = true;
            DoctorsHeading.BackColor = Color.Transparent;
            DoctorsHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            DoctorsHeading.ForeColor = Color.Lime;
            DoctorsHeading.Location = new Point(737, 51);
            DoctorsHeading.Name = "DoctorsHeading";
            DoctorsHeading.Size = new Size(276, 70);
            DoctorsHeading.TabIndex = 16;
            DoctorsHeading.Text = "Doctor's";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1844, 529);
            dataGridView1.TabIndex = 15;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Red;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(834, 892);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(193, 43);
            BackToDashboardButton.TabIndex = 19;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // View_Doctor_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(BackToDashboardButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(DoctorsHeading);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "View_Doctor_Details";
            Text = "View Doctor Details";
            Load += View_Doctor_Details_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private TextBox SearchTextbox;
        private Label DoctorsHeading;
        private DataGridView dataGridView1;
        private Button BackToDashboardButton;
    }
}