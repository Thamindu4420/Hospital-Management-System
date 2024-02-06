namespace HealthCare_Plus
{
    partial class Bills_and_Invoices_Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills_and_Invoices_Selection));
            BackToDashboardButton = new Button();
            InvoiceButton = new Button();
            BillingButton = new Button();
            SuspendLayout();
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Red;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(793, 750);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(297, 80);
            BackToDashboardButton.TabIndex = 20;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // InvoiceButton
            // 
            InvoiceButton.BackColor = Color.White;
            InvoiceButton.BackgroundImage = (Image)resources.GetObject("InvoiceButton.BackgroundImage");
            InvoiceButton.BackgroundImageLayout = ImageLayout.Stretch;
            InvoiceButton.FlatStyle = FlatStyle.Popup;
            InvoiceButton.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            InvoiceButton.ForeColor = Color.Red;
            InvoiceButton.Location = new Point(1054, 224);
            InvoiceButton.Name = "InvoiceButton";
            InvoiceButton.Size = new Size(352, 321);
            InvoiceButton.TabIndex = 19;
            InvoiceButton.UseVisualStyleBackColor = false;
            InvoiceButton.Click += InvoiceButton_Click;
            // 
            // BillingButton
            // 
            BillingButton.BackColor = Color.White;
            BillingButton.BackgroundImage = (Image)resources.GetObject("BillingButton.BackgroundImage");
            BillingButton.BackgroundImageLayout = ImageLayout.Stretch;
            BillingButton.FlatStyle = FlatStyle.Popup;
            BillingButton.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            BillingButton.ForeColor = Color.Red;
            BillingButton.Location = new Point(519, 224);
            BillingButton.Name = "BillingButton";
            BillingButton.Size = new Size(352, 321);
            BillingButton.TabIndex = 18;
            BillingButton.UseVisualStyleBackColor = false;
            BillingButton.Click += BillingButton_Click;
            // 
            // Bills_and_Invoices_Selection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(BackToDashboardButton);
            Controls.Add(InvoiceButton);
            Controls.Add(BillingButton);
            DoubleBuffered = true;
            Name = "Bills_and_Invoices_Selection";
            Text = "Bills and Invoices Selection";
            ResumeLayout(false);
        }

        #endregion

        private Button BackToDashboardButton;
        private Button InvoiceButton;
        private Button BillingButton;
    }
}