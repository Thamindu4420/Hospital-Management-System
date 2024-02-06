namespace HealthCare_Plus
{
    partial class Update_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Room));
            panel1 = new Panel();
            Schedule = new Label();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            BackButton = new Button();
            SaveButton = new Button();
            Availability = new Label();
            Room = new Label();
            UpdateRoomHeading = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Schedule);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(Availability);
            panel1.Controls.Add(Room);
            panel1.Location = new Point(333, 264);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 556);
            panel1.TabIndex = 42;
            // 
            // Schedule
            // 
            Schedule.AutoSize = true;
            Schedule.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Schedule.Location = new Point(78, 284);
            Schedule.Name = "Schedule";
            Schedule.Size = new Size(82, 24);
            Schedule.TabIndex = 80;
            Schedule.Text = "Schedule";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(295, 266);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(575, 81);
            richTextBox1.TabIndex = 79;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Not Available" });
            comboBox1.Location = new Point(295, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(575, 28);
            comboBox1.TabIndex = 78;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 50);
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
            BackButton.Location = new Point(578, 443);
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
            SaveButton.Location = new Point(367, 443);
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
            Availability.Location = new Point(78, 161);
            Availability.Name = "Availability";
            Availability.Size = new Size(92, 24);
            Availability.TabIndex = 69;
            Availability.Text = "Availability";
            // 
            // Room
            // 
            Room.AutoSize = true;
            Room.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Room.Location = new Point(78, 50);
            Room.Name = "Room";
            Room.Size = new Size(56, 24);
            Room.TabIndex = 67;
            Room.Text = "Room";
            // 
            // UpdateRoomHeading
            // 
            UpdateRoomHeading.AutoSize = true;
            UpdateRoomHeading.BackColor = Color.Transparent;
            UpdateRoomHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            UpdateRoomHeading.ForeColor = Color.Lime;
            UpdateRoomHeading.Location = new Point(678, 64);
            UpdateRoomHeading.Name = "UpdateRoomHeading";
            UpdateRoomHeading.Size = new Size(443, 70);
            UpdateRoomHeading.TabIndex = 41;
            UpdateRoomHeading.Text = "Update Room ";
            // 
            // Update_Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(UpdateRoomHeading);
            DoubleBuffered = true;
            Name = "Update_Room";
            Text = "Update Room";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Schedule;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button BackButton;
        private Button SaveButton;
        private Label Availability;
        private Label Room;
        private Label UpdateRoomHeading;
    }
}