namespace HealthCare_Plus
{
    partial class Medical_Items_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medical_Items_Report));
            PrintButton = new Button();
            BackButton = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            MedicalItemsHeading = new Label();
            Heading = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PrintButton
            // 
            PrintButton.BackColor = Color.Lime;
            PrintButton.BackgroundImage = (Image)resources.GetObject("PrintButton.BackgroundImage");
            PrintButton.BackgroundImageLayout = ImageLayout.Stretch;
            PrintButton.FlatStyle = FlatStyle.Popup;
            PrintButton.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PrintButton.ForeColor = SystemColors.ActiveCaptionText;
            PrintButton.Location = new Point(209, 424);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(103, 70);
            PrintButton.TabIndex = 83;
            PrintButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(209, 562);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(103, 45);
            BackButton.TabIndex = 84;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(MedicalItemsHeading);
            panel1.Controls.Add(Heading);
            panel1.Location = new Point(538, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 957);
            panel1.TabIndex = 82;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 294);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(812, 504);
            dataGridView1.TabIndex = 77;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(42, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 75);
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // MedicalItemsHeading
            // 
            MedicalItemsHeading.AutoSize = true;
            MedicalItemsHeading.BackColor = Color.Transparent;
            MedicalItemsHeading.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MedicalItemsHeading.ForeColor = Color.Red;
            MedicalItemsHeading.Location = new Point(336, 152);
            MedicalItemsHeading.Name = "MedicalItemsHeading";
            MedicalItemsHeading.Size = new Size(285, 47);
            MedicalItemsHeading.TabIndex = 75;
            MedicalItemsHeading.Text = "Medical Items ";
            MedicalItemsHeading.Click += MedicalItemsReportHeading_Click;
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.BackColor = Color.Transparent;
            Heading.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Heading.ForeColor = Color.Black;
            Heading.Location = new Point(226, 47);
            Heading.Name = "Heading";
            Heading.Size = new Size(526, 52);
            Heading.TabIndex = 59;
            Heading.Text = "HealthCare Plus Hospital";
            // 
            // Medical_Items_Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(PrintButton);
            Controls.Add(BackButton);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Medical_Items_Report";
            Text = "Medical Items Report";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button PrintButton;
        private Button BackButton;
        private Panel panel1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label MedicalItemsHeading;
        private Label Heading;
    }
}