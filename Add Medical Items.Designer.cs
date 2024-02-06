namespace HealthCare_Plus
{
    partial class Add_Medical_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Medical_Items));
            AddMedicalItemsHeading = new Label();
            textBox1 = new TextBox();
            ItemName = new Label();
            textBox2 = new TextBox();
            Quantity = new Label();
            PurchaseDate = new Label();
            AddItemButton = new Button();
            CancelButton = new Button();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddMedicalItemsHeading
            // 
            AddMedicalItemsHeading.AutoSize = true;
            AddMedicalItemsHeading.BackColor = Color.Transparent;
            AddMedicalItemsHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            AddMedicalItemsHeading.ForeColor = Color.Lime;
            AddMedicalItemsHeading.Location = new Point(659, 35);
            AddMedicalItemsHeading.Name = "AddMedicalItemsHeading";
            AddMedicalItemsHeading.Size = new Size(569, 70);
            AddMedicalItemsHeading.TabIndex = 14;
            AddMedicalItemsHeading.Text = "Add Medical Items";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(602, 27);
            textBox1.TabIndex = 30;
            // 
            // ItemName
            // 
            ItemName.AutoSize = true;
            ItemName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ItemName.Location = new Point(60, 49);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(91, 24);
            ItemName.TabIndex = 29;
            ItemName.Text = "Item Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(602, 27);
            textBox2.TabIndex = 32;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Quantity.Location = new Point(60, 122);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(75, 24);
            Quantity.TabIndex = 31;
            Quantity.Text = "Quantity";
            // 
            // PurchaseDate
            // 
            PurchaseDate.AutoSize = true;
            PurchaseDate.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PurchaseDate.Location = new Point(60, 196);
            PurchaseDate.Name = "PurchaseDate";
            PurchaseDate.Size = new Size(123, 24);
            PurchaseDate.TabIndex = 33;
            PurchaseDate.Text = "Purchase Date";
            // 
            // AddItemButton
            // 
            AddItemButton.BackColor = Color.Green;
            AddItemButton.FlatStyle = FlatStyle.Popup;
            AddItemButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddItemButton.ForeColor = Color.White;
            AddItemButton.Location = new Point(254, 314);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(193, 43);
            AddItemButton.TabIndex = 35;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = false;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Red;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(547, 314);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(193, 43);
            CancelButton.TabIndex = 36;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(AddItemButton);
            panel1.Controls.Add(PurchaseDate);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(Quantity);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(ItemName);
            panel1.Location = new Point(472, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 419);
            panel1.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(254, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(602, 27);
            dateTimePicker1.TabIndex = 37;
            // 
            // Add_Medical_Items
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 846);
            Controls.Add(panel1);
            Controls.Add(AddMedicalItemsHeading);
            DoubleBuffered = true;
            Name = "Add_Medical_Items";
            Text = "Add Medical Items";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddMedicalItemsHeading;
        private TextBox textBox1;
        private Label ItemName;
        private TextBox textBox2;
        private Label Quantity;
        private Label PurchaseDate;
        private Button AddItemButton;
        private Button CancelButton;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
    }
}