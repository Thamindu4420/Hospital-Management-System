namespace HealthCare_Plus
{
    partial class Medical_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medical_Items));
            MedicalItemsHeading = new Label();
            BackToDashboardButton = new Button();
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            AddMedicalItemButton = new Button();
            DeleteMedicalItemButton = new Button();
            PrintButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MedicalItemsHeading
            // 
            MedicalItemsHeading.AutoSize = true;
            MedicalItemsHeading.BackColor = Color.Transparent;
            MedicalItemsHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            MedicalItemsHeading.ForeColor = Color.Lime;
            MedicalItemsHeading.Location = new Point(815, 40);
            MedicalItemsHeading.Name = "MedicalItemsHeading";
            MedicalItemsHeading.Size = new Size(435, 70);
            MedicalItemsHeading.TabIndex = 13;
            MedicalItemsHeading.Text = "Medical Items";
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Red;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(68, 662);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(193, 43);
            BackToDashboardButton.TabIndex = 20;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1733, 223);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 19;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1281, 223);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1219, 529);
            dataGridView1.TabIndex = 17;
            // 
            // AddMedicalItemButton
            // 
            AddMedicalItemButton.BackColor = Color.FromArgb(255, 128, 0);
            AddMedicalItemButton.FlatStyle = FlatStyle.Popup;
            AddMedicalItemButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddMedicalItemButton.ForeColor = Color.White;
            AddMedicalItemButton.Location = new Point(68, 479);
            AddMedicalItemButton.Name = "AddMedicalItemButton";
            AddMedicalItemButton.Size = new Size(193, 43);
            AddMedicalItemButton.TabIndex = 21;
            AddMedicalItemButton.Text = "Add";
            AddMedicalItemButton.UseVisualStyleBackColor = false;
            AddMedicalItemButton.Click += AddMedicalItemButton_Click;
            // 
            // DeleteMedicalItemButton
            // 
            DeleteMedicalItemButton.BackColor = Color.FromArgb(255, 128, 0);
            DeleteMedicalItemButton.FlatStyle = FlatStyle.Popup;
            DeleteMedicalItemButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteMedicalItemButton.ForeColor = Color.White;
            DeleteMedicalItemButton.Location = new Point(68, 568);
            DeleteMedicalItemButton.Name = "DeleteMedicalItemButton";
            DeleteMedicalItemButton.Size = new Size(193, 43);
            DeleteMedicalItemButton.TabIndex = 23;
            DeleteMedicalItemButton.Text = "Delete";
            DeleteMedicalItemButton.UseVisualStyleBackColor = false;
            DeleteMedicalItemButton.Click += DeleteMedicalItemButton_Click;
            // 
            // PrintButton
            // 
            PrintButton.BackColor = Color.FromArgb(255, 128, 0);
            PrintButton.BackgroundImage = (Image)resources.GetObject("PrintButton.BackgroundImage");
            PrintButton.BackgroundImageLayout = ImageLayout.Zoom;
            PrintButton.FlatStyle = FlatStyle.Popup;
            PrintButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PrintButton.ForeColor = Color.White;
            PrintButton.Location = new Point(68, 387);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(193, 43);
            PrintButton.TabIndex = 24;
            PrintButton.UseVisualStyleBackColor = false;
            PrintButton.Click += PrintButton_Click;
            // 
            // Medical_Items
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1032);
            Controls.Add(PrintButton);
            Controls.Add(DeleteMedicalItemButton);
            Controls.Add(AddMedicalItemButton);
            Controls.Add(BackToDashboardButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(MedicalItemsHeading);
            DoubleBuffered = true;
            Name = "Medical_Items";
            Text = "Medical Items";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MedicalItemsHeading;
        private Button BackToDashboardButton;
        private Button SearchButton;
        private TextBox SearchTextbox;
        private DataGridView dataGridView1;
        private Button AddMedicalItemButton;
        private Button DeleteMedicalItemButton;
        private Button PrintButton;
    }
}