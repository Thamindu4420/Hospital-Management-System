namespace HealthCare_Plus
{
    partial class Add_Medication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Medication));
            panel1 = new Panel();
            BackButton = new Button();
            SaveButton = new Button();
            richTextBox4 = new RichTextBox();
            Comments = new Label();
            richTextBox3 = new RichTextBox();
            DosageStrength = new Label();
            richTextBox2 = new RichTextBox();
            Medication = new Label();
            dateTimePicker2 = new DateTimePicker();
            MedicationDate = new Label();
            AddMedicationHeading = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(richTextBox4);
            panel1.Controls.Add(Comments);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(DosageStrength);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(Medication);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(MedicationDate);
            panel1.Location = new Point(398, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 664);
            panel1.TabIndex = 39;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(563, 582);
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
            SaveButton.Location = new Point(352, 582);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(133, 45);
            SaveButton.TabIndex = 75;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(271, 405);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(602, 118);
            richTextBox4.TabIndex = 74;
            richTextBox4.Text = "";
            // 
            // Comments
            // 
            Comments.AutoSize = true;
            Comments.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Comments.Location = new Point(78, 405);
            Comments.Name = "Comments";
            Comments.Size = new Size(93, 24);
            Comments.TabIndex = 73;
            Comments.Text = "Comments";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(271, 266);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(602, 89);
            richTextBox3.TabIndex = 72;
            richTextBox3.Text = "";
            // 
            // DosageStrength
            // 
            DosageStrength.AutoSize = true;
            DosageStrength.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DosageStrength.Location = new Point(78, 266);
            DosageStrength.Name = "DosageStrength";
            DosageStrength.Size = new Size(140, 24);
            DosageStrength.TabIndex = 71;
            DosageStrength.Text = "Dosage Strength";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(271, 134);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(602, 92);
            richTextBox2.TabIndex = 70;
            richTextBox2.Text = "";
            // 
            // Medication
            // 
            Medication.AutoSize = true;
            Medication.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Medication.Location = new Point(78, 137);
            Medication.Name = "Medication";
            Medication.Size = new Size(94, 24);
            Medication.TabIndex = 69;
            Medication.Text = "Medication";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(271, 47);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(602, 27);
            dateTimePicker2.TabIndex = 68;
            // 
            // MedicationDate
            // 
            MedicationDate.AutoSize = true;
            MedicationDate.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MedicationDate.Location = new Point(78, 50);
            MedicationDate.Name = "MedicationDate";
            MedicationDate.Size = new Size(134, 24);
            MedicationDate.TabIndex = 67;
            MedicationDate.Text = "Medication Date";
            // 
            // AddMedicationHeading
            // 
            AddMedicationHeading.AutoSize = true;
            AddMedicationHeading.BackColor = Color.Transparent;
            AddMedicationHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            AddMedicationHeading.ForeColor = Color.Lime;
            AddMedicationHeading.Location = new Point(655, 50);
            AddMedicationHeading.Name = "AddMedicationHeading";
            AddMedicationHeading.Size = new Size(485, 70);
            AddMedicationHeading.TabIndex = 38;
            AddMedicationHeading.Text = "Add Medication";
            // 
            // Add_Medication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(AddMedicationHeading);
            DoubleBuffered = true;
            Name = "Add_Medication";
            Text = "Add Medication";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label AddMedicationHeading;
        private RichTextBox richTextBox4;
        private Label Comments;
        private RichTextBox richTextBox3;
        private Label DosageStrength;
        private RichTextBox richTextBox2;
        private Label Medication;
        private DateTimePicker dateTimePicker2;
        private Label MedicationDate;
        private Button BackButton;
        private Button SaveButton;
    }
}