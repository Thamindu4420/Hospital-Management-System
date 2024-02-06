namespace HealthCare_Plus
{
    partial class View_Medication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Medication));
            panel1 = new Panel();
            richTextBox4 = new RichTextBox();
            Comments = new Label();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            dateTimePicker2 = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            BackButton = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Gender = new Label();
            Diagnosis = new Label();
            DosageStrength = new Label();
            Medication = new Label();
            MedicationDate = new Label();
            DOB = new Label();
            textBox2 = new TextBox();
            LastName = new Label();
            textBox1 = new TextBox();
            FirstName = new Label();
            ViewMedicationHeading = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox4);
            panel1.Controls.Add(Comments);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(Gender);
            panel1.Controls.Add(Diagnosis);
            panel1.Controls.Add(DosageStrength);
            panel1.Controls.Add(Medication);
            panel1.Controls.Add(MedicationDate);
            panel1.Controls.Add(DOB);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(LastName);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(FirstName);
            panel1.Location = new Point(57, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(1811, 684);
            panel1.TabIndex = 51;
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(1093, 405);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(602, 102);
            richTextBox4.TabIndex = 63;
            richTextBox4.Text = "";
            // 
            // Comments
            // 
            Comments.AutoSize = true;
            Comments.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Comments.Location = new Point(873, 445);
            Comments.Name = "Comments";
            Comments.Size = new Size(93, 24);
            Comments.TabIndex = 62;
            Comments.Text = "Comments";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(1093, 254);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(602, 102);
            richTextBox3.TabIndex = 61;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(1093, 101);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(602, 102);
            richTextBox2.TabIndex = 60;
            richTextBox2.Text = "";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1093, 36);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(602, 27);
            dateTimePicker2.TabIndex = 59;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(191, 282);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(602, 162);
            richTextBox1.TabIndex = 58;
            richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(191, 147);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(602, 27);
            dateTimePicker1.TabIndex = 57;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(832, 586);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(134, 45);
            BackButton.TabIndex = 51;
            BackButton.Text = "Back ";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(312, 208);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 49;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(191, 207);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 48;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Gender.Location = new Point(36, 207);
            Gender.Name = "Gender";
            Gender.Size = new Size(67, 24);
            Gender.TabIndex = 47;
            Gender.Text = "Gender";
            // 
            // Diagnosis
            // 
            Diagnosis.AutoSize = true;
            Diagnosis.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Diagnosis.Location = new Point(36, 339);
            Diagnosis.Name = "Diagnosis";
            Diagnosis.Size = new Size(87, 24);
            Diagnosis.TabIndex = 43;
            Diagnosis.Text = "Diagnosis";
            // 
            // DosageStrength
            // 
            DosageStrength.AutoSize = true;
            DosageStrength.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DosageStrength.Location = new Point(873, 294);
            DosageStrength.Name = "DosageStrength";
            DosageStrength.Size = new Size(140, 24);
            DosageStrength.TabIndex = 41;
            DosageStrength.Text = "Dosage Strength";
            // 
            // Medication
            // 
            Medication.AutoSize = true;
            Medication.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Medication.Location = new Point(879, 136);
            Medication.Name = "Medication";
            Medication.Size = new Size(94, 24);
            Medication.TabIndex = 39;
            Medication.Text = "Medication";
            // 
            // MedicationDate
            // 
            MedicationDate.AutoSize = true;
            MedicationDate.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MedicationDate.Location = new Point(879, 41);
            MedicationDate.Name = "MedicationDate";
            MedicationDate.Size = new Size(134, 24);
            MedicationDate.TabIndex = 37;
            MedicationDate.Text = "Medication Date";
            // 
            // DOB
            // 
            DOB.AutoSize = true;
            DOB.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DOB.Location = new Point(36, 148);
            DOB.Name = "DOB";
            DOB.Size = new Size(47, 24);
            DOB.TabIndex = 31;
            DOB.Text = "DOB";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(602, 27);
            textBox2.TabIndex = 30;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LastName.Location = new Point(36, 91);
            LastName.Name = "LastName";
            LastName.Size = new Size(92, 24);
            LastName.TabIndex = 29;
            LastName.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(602, 27);
            textBox1.TabIndex = 28;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FirstName.Location = new Point(36, 41);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(93, 24);
            FirstName.TabIndex = 27;
            FirstName.Text = "First Name";
            // 
            // ViewMedicationHeading
            // 
            ViewMedicationHeading.AutoSize = true;
            ViewMedicationHeading.BackColor = Color.Transparent;
            ViewMedicationHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            ViewMedicationHeading.ForeColor = Color.Lime;
            ViewMedicationHeading.Location = new Point(614, 58);
            ViewMedicationHeading.Name = "ViewMedicationHeading";
            ViewMedicationHeading.Size = new Size(508, 70);
            ViewMedicationHeading.TabIndex = 50;
            ViewMedicationHeading.Text = "View Medication";
            // 
            // View_Medication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 999);
            Controls.Add(panel1);
            Controls.Add(ViewMedicationHeading);
            DoubleBuffered = true;
            Name = "View_Medication";
            Text = "View Medication";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Button BackButton;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label Gender;
        private Label Diagnosis;
        private Label DosageStrength;
        private Label Medication;
        private Label MedicationDate;
        private Label DOB;
        private TextBox textBox2;
        private Label LastName;
        private TextBox textBox1;
        private Label FirstName;
        private Label ViewMedicationHeading;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private DateTimePicker dateTimePicker2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private Label Comments;
    }
}