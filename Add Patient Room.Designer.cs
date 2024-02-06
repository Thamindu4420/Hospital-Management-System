namespace HealthCare_Plus
{
    partial class Add_Patient_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Patient_Room));
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            BackButton = new Button();
            SaveButton = new Button();
            Availability = new Label();
            RoomNumber = new Label();
            AddPatientRoomHeading = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(Availability);
            panel1.Controls.Add(RoomNumber);
            panel1.Location = new Point(368, 313);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 452);
            panel1.TabIndex = 42;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Not Available" });
            comboBox1.Location = new Point(297, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(575, 28);
            comboBox1.TabIndex = 78;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(297, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(575, 27);
            textBox1.TabIndex = 77;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(562, 338);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(134, 45);
            BackButton.TabIndex = 76;
            BackButton.Text = "Back ";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Lime;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.ForeColor = SystemColors.ActiveCaptionText;
            SaveButton.Location = new Point(328, 338);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(133, 45);
            SaveButton.TabIndex = 75;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // Availability
            // 
            Availability.AutoSize = true;
            Availability.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Availability.Location = new Point(80, 180);
            Availability.Name = "Availability";
            Availability.Size = new Size(92, 24);
            Availability.TabIndex = 69;
            Availability.Text = "Availability";
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSize = true;
            RoomNumber.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RoomNumber.Location = new Point(80, 69);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(122, 24);
            RoomNumber.TabIndex = 67;
            RoomNumber.Text = "Room Number";
            // 
            // AddPatientRoomHeading
            // 
            AddPatientRoomHeading.AutoSize = true;
            AddPatientRoomHeading.BackColor = Color.Transparent;
            AddPatientRoomHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            AddPatientRoomHeading.ForeColor = Color.Lime;
            AddPatientRoomHeading.Location = new Point(595, 52);
            AddPatientRoomHeading.Name = "AddPatientRoomHeading";
            AddPatientRoomHeading.Size = new Size(568, 70);
            AddPatientRoomHeading.TabIndex = 41;
            AddPatientRoomHeading.Text = "Add Patient Room ";
            // 
            // Add_Patient_Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(AddPatientRoomHeading);
            DoubleBuffered = true;
            Name = "Add_Patient_Room";
            Text = "Add Patient Room";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button BackButton;
        private Button SaveButton;
        private Label Availability;
        private Label RoomNumber;
        private Label AddPatientRoomHeading;
    }
}