namespace HealthCare_Plus
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            BillingHeading = new Label();
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            BackButton = new Button();
            UpdateBillButton = new Button();
            ViewBillButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BillingHeading
            // 
            BillingHeading.AutoSize = true;
            BillingHeading.BackColor = Color.Transparent;
            BillingHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            BillingHeading.ForeColor = Color.Lime;
            BillingHeading.Location = new Point(746, 45);
            BillingHeading.Name = "BillingHeading";
            BillingHeading.Size = new Size(211, 70);
            BillingHeading.TabIndex = 49;
            BillingHeading.Text = "Billing";
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1693, 286);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 52;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1241, 286);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 51;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(221, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1669, 567);
            dataGridView1.TabIndex = 50;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(25, 609);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(129, 43);
            BackButton.TabIndex = 56;
            BackButton.Text = "Back ";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // UpdateBillButton
            // 
            UpdateBillButton.BackColor = Color.FromArgb(255, 128, 0);
            UpdateBillButton.FlatStyle = FlatStyle.Popup;
            UpdateBillButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBillButton.ForeColor = Color.White;
            UpdateBillButton.Location = new Point(25, 526);
            UpdateBillButton.Name = "UpdateBillButton";
            UpdateBillButton.Size = new Size(129, 43);
            UpdateBillButton.TabIndex = 54;
            UpdateBillButton.Text = "Update Bill";
            UpdateBillButton.UseVisualStyleBackColor = false;
            UpdateBillButton.Click += UpdateBillButton_Click;
            // 
            // ViewBillButton
            // 
            ViewBillButton.BackColor = Color.FromArgb(255, 128, 0);
            ViewBillButton.FlatStyle = FlatStyle.Popup;
            ViewBillButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ViewBillButton.ForeColor = Color.White;
            ViewBillButton.Location = new Point(25, 443);
            ViewBillButton.Name = "ViewBillButton";
            ViewBillButton.Size = new Size(129, 43);
            ViewBillButton.TabIndex = 58;
            ViewBillButton.Text = "View Bill";
            ViewBillButton.UseVisualStyleBackColor = false;
            ViewBillButton.Click += ViewBillButton_Click;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(ViewBillButton);
            Controls.Add(BackButton);
            Controls.Add(UpdateBillButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(BillingHeading);
            DoubleBuffered = true;
            Name = "Billing";
            Text = "Billing";
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BillingHeading;
        private Button SearchButton;
        private TextBox SearchTextbox;
        private DataGridView dataGridView1;
        private Button DeleteRoomButton;
        private Button BackButton;
        private Button PatientRoomsButton;
        private Button UpdateBillButton;
        private Button ViewBillButton;
        private Button AddRoomButton;
    }
}