namespace HealthCare_Plus
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            InvoiceHeading = new Label();
            Heading = new Label();
            PrintButton = new Button();
            BackButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(InvoiceHeading);
            panel1.Controls.Add(Heading);
            panel1.Location = new Point(503, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 957);
            panel1.TabIndex = 53;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(42, 246);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(798, 663);
            richTextBox1.TabIndex = 77;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
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
            // InvoiceHeading
            // 
            InvoiceHeading.AutoSize = true;
            InvoiceHeading.BackColor = Color.Transparent;
            InvoiceHeading.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            InvoiceHeading.ForeColor = Color.RoyalBlue;
            InvoiceHeading.Location = new Point(394, 138);
            InvoiceHeading.Name = "InvoiceHeading";
            InvoiceHeading.Size = new Size(153, 47);
            InvoiceHeading.TabIndex = 75;
            InvoiceHeading.Text = "Invoice";
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
            // PrintButton
            // 
            PrintButton.BackColor = Color.Lime;
            PrintButton.BackgroundImage = (Image)resources.GetObject("PrintButton.BackgroundImage");
            PrintButton.BackgroundImageLayout = ImageLayout.Stretch;
            PrintButton.FlatStyle = FlatStyle.Popup;
            PrintButton.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PrintButton.ForeColor = SystemColors.ActiveCaptionText;
            PrintButton.Location = new Point(136, 383);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(103, 70);
            PrintButton.TabIndex = 78;
            PrintButton.UseVisualStyleBackColor = false;
            PrintButton.Click += PrintButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(136, 521);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(103, 45);
            BackButton.TabIndex = 79;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // Invoice
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
            Name = "Invoice";
            Text = "Invoice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label InvoiceHeading;
        private Label Heading;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Button PrintButton;
        private Button BackButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}