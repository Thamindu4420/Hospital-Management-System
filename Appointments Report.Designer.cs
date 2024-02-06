namespace HealthCare_Plus
{
    partial class Appointments_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments_Report));
            PrintButton = new Button();
            BackButton = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            AppointmentsReportHeading = new Label();
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
            PrintButton.Location = new Point(217, 460);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(103, 70);
            PrintButton.TabIndex = 86;
            PrintButton.UseVisualStyleBackColor = false;
            PrintButton.Click += PrintButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(217, 598);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(103, 45);
            BackButton.TabIndex = 87;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(AppointmentsReportHeading);
            panel1.Controls.Add(Heading);
            panel1.Location = new Point(546, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 957);
            panel1.TabIndex = 85;
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
            // AppointmentsReportHeading
            // 
            AppointmentsReportHeading.AutoSize = true;
            AppointmentsReportHeading.BackColor = Color.Transparent;
            AppointmentsReportHeading.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            AppointmentsReportHeading.ForeColor = Color.Red;
            AppointmentsReportHeading.Location = new Point(264, 148);
            AppointmentsReportHeading.Name = "AppointmentsReportHeading";
            AppointmentsReportHeading.Size = new Size(418, 47);
            AppointmentsReportHeading.TabIndex = 75;
            AppointmentsReportHeading.Text = "Appointments Report";
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
            // Appointments_Report
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
            Name = "Appointments_Report";
            Text = "Appointments Report";
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
        private Label AppointmentsReportHeading;
        private Label Heading;
    }
}