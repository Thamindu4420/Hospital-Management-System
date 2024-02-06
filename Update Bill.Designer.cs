namespace HealthCare_Plus
{
    partial class Update_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Bill));
            PatientBillHeading = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            PaymentStatus = new Label();
            AddTotalBillButton = new Button();
            textBox10 = new TextBox();
            TotalBill = new Label();
            textBox9 = new TextBox();
            Tax = new Label();
            textBox8 = new TextBox();
            MedicationCharges = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            RoomCharges = new Label();
            AppointmentCharges = new Label();
            textBox7 = new TextBox();
            DoctorCharges = new Label();
            BackButton = new Button();
            textBox2 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            CheckedOut = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            PayButton = new Button();
            CheckedIn = new Label();
            textBox3 = new TextBox();
            MobileNumber = new Label();
            NIC = new Label();
            LastName = new Label();
            textBox1 = new TextBox();
            FirstName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PatientBillHeading
            // 
            PatientBillHeading.AutoSize = true;
            PatientBillHeading.BackColor = Color.Transparent;
            PatientBillHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            PatientBillHeading.ForeColor = Color.Lime;
            PatientBillHeading.Location = new Point(851, 52);
            PatientBillHeading.Name = "PatientBillHeading";
            PatientBillHeading.Size = new Size(342, 70);
            PatientBillHeading.TabIndex = 25;
            PatientBillHeading.Text = "Patient Bill";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(PaymentStatus);
            panel1.Controls.Add(AddTotalBillButton);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(TotalBill);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(Tax);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(MedicationCharges);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(RoomCharges);
            panel1.Controls.Add(AppointmentCharges);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(DoctorCharges);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(CheckedOut);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(PayButton);
            panel1.Controls.Add(CheckedIn);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(MobileNumber);
            panel1.Controls.Add(NIC);
            panel1.Controls.Add(LastName);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(FirstName);
            panel1.Location = new Point(201, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(1668, 819);
            panel1.TabIndex = 50;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Paid", "Not Paid" });
            comboBox1.Location = new Point(540, 642);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(602, 28);
            comboBox1.TabIndex = 73;
            // 
            // PaymentStatus
            // 
            PaymentStatus.AutoSize = true;
            PaymentStatus.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentStatus.Location = new Point(340, 646);
            PaymentStatus.Name = "PaymentStatus";
            PaymentStatus.Size = new Size(131, 24);
            PaymentStatus.TabIndex = 72;
            PaymentStatus.Text = "Payment Status";
            // 
            // AddTotalBillButton
            // 
            AddTotalBillButton.BackColor = Color.FromArgb(255, 128, 0);
            AddTotalBillButton.FlatStyle = FlatStyle.Popup;
            AddTotalBillButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddTotalBillButton.ForeColor = SystemColors.ActiveCaptionText;
            AddTotalBillButton.Location = new Point(1185, 583);
            AddTotalBillButton.Name = "AddTotalBillButton";
            AddTotalBillButton.Size = new Size(37, 30);
            AddTotalBillButton.TabIndex = 71;
            AddTotalBillButton.Text = "+";
            AddTotalBillButton.UseVisualStyleBackColor = false;
            AddTotalBillButton.Click += AddTotalBillButton_Click;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(540, 586);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(602, 27);
            textBox10.TabIndex = 70;
            // 
            // TotalBill
            // 
            TotalBill.AutoSize = true;
            TotalBill.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TotalBill.Location = new Point(340, 589);
            TotalBill.Name = "TotalBill";
            TotalBill.Size = new Size(77, 24);
            TotalBill.TabIndex = 69;
            TotalBill.Text = "Total Bill";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(540, 533);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(602, 27);
            textBox9.TabIndex = 68;
            // 
            // Tax
            // 
            Tax.AutoSize = true;
            Tax.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Tax.Location = new Point(340, 536);
            Tax.Name = "Tax";
            Tax.Size = new Size(43, 24);
            Tax.TabIndex = 67;
            Tax.Text = "Tax ";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(540, 474);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(602, 27);
            textBox8.TabIndex = 66;
            // 
            // MedicationCharges
            // 
            MedicationCharges.AutoSize = true;
            MedicationCharges.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MedicationCharges.Location = new Point(340, 477);
            MedicationCharges.Name = "MedicationCharges";
            MedicationCharges.Size = new Size(164, 24);
            MedicationCharges.TabIndex = 65;
            MedicationCharges.Text = "Medication Charges";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(540, 318);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(602, 27);
            textBox5.TabIndex = 64;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(540, 368);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(602, 27);
            textBox6.TabIndex = 63;
            // 
            // RoomCharges
            // 
            RoomCharges.AutoSize = true;
            RoomCharges.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RoomCharges.Location = new Point(340, 428);
            RoomCharges.Name = "RoomCharges";
            RoomCharges.Size = new Size(126, 24);
            RoomCharges.TabIndex = 62;
            RoomCharges.Text = "Room Charges";
            // 
            // AppointmentCharges
            // 
            AppointmentCharges.AutoSize = true;
            AppointmentCharges.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AppointmentCharges.Location = new Point(340, 371);
            AppointmentCharges.Name = "AppointmentCharges";
            AppointmentCharges.Size = new Size(178, 24);
            AppointmentCharges.TabIndex = 61;
            AppointmentCharges.Text = "Appointment Charges";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(540, 425);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(602, 27);
            textBox7.TabIndex = 60;
            // 
            // DoctorCharges
            // 
            DoctorCharges.AutoSize = true;
            DoctorCharges.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DoctorCharges.Location = new Point(340, 321);
            DoctorCharges.Name = "DoctorCharges";
            DoctorCharges.Size = new Size(132, 24);
            DoctorCharges.TabIndex = 59;
            DoctorCharges.Text = "Doctor Charges";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(875, 743);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(117, 45);
            BackButton.TabIndex = 58;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1071, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(489, 27);
            textBox2.TabIndex = 57;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1070, 197);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(490, 27);
            dateTimePicker2.TabIndex = 56;
            // 
            // CheckedOut
            // 
            CheckedOut.AutoSize = true;
            CheckedOut.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CheckedOut.Location = new Point(871, 200);
            CheckedOut.Name = "CheckedOut";
            CheckedOut.Size = new Size(111, 24);
            CheckedOut.TabIndex = 55;
            CheckedOut.Text = "Checked Out";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(258, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(489, 27);
            dateTimePicker1.TabIndex = 54;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1071, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(489, 27);
            textBox4.TabIndex = 53;
            // 
            // PayButton
            // 
            PayButton.BackColor = Color.Lime;
            PayButton.FlatStyle = FlatStyle.Popup;
            PayButton.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PayButton.ForeColor = SystemColors.ActiveCaptionText;
            PayButton.Location = new Point(638, 743);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(133, 45);
            PayButton.TabIndex = 50;
            PayButton.Text = "Pay";
            PayButton.UseVisualStyleBackColor = false;
            PayButton.Click += PayButton_Click;
            // 
            // CheckedIn
            // 
            CheckedIn.AutoSize = true;
            CheckedIn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CheckedIn.Location = new Point(58, 203);
            CheckedIn.Name = "CheckedIn";
            CheckedIn.Size = new Size(97, 24);
            CheckedIn.TabIndex = 43;
            CheckedIn.Text = "Checked In";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(489, 27);
            textBox3.TabIndex = 36;
            // 
            // MobileNumber
            // 
            MobileNumber.AutoSize = true;
            MobileNumber.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MobileNumber.Location = new Point(871, 118);
            MobileNumber.Name = "MobileNumber";
            MobileNumber.Size = new Size(127, 24);
            MobileNumber.TabIndex = 34;
            MobileNumber.Text = "Mobile Number";
            // 
            // NIC
            // 
            NIC.AutoSize = true;
            NIC.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NIC.Location = new Point(58, 124);
            NIC.Name = "NIC";
            NIC.Size = new Size(38, 24);
            NIC.TabIndex = 31;
            NIC.Text = "NIC";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LastName.Location = new Point(871, 44);
            LastName.Name = "LastName";
            LastName.Size = new Size(92, 24);
            LastName.TabIndex = 29;
            LastName.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(489, 27);
            textBox1.TabIndex = 28;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FirstName.Location = new Point(58, 47);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(93, 24);
            FirstName.TabIndex = 27;
            FirstName.Text = "First Name";
            // 
            // Update_Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(PatientBillHeading);
            DoubleBuffered = true;
            Name = "Update_Bill";
            Text = "Update Bill";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PatientBillHeading;
        private Panel panel1;
        private Button BackButton;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker2;
        private Label CheckedOut;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private Label AppointmentTime;
        private Button PayButton;
        private Label CheckedIn;
        private TextBox textBox3;
        private Label MobileNumber;
        private Label NIC;
        private Label LastName;
        private TextBox textBox1;
        private Label FirstName;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label RoomCharges;
        private Label AppointmentCharges;
        private TextBox textBox7;
        private Label DoctorCharges;
        private TextBox textBox8;
        private Label MedicationCharges;
        private TextBox textBox9;
        private Label Tax;
        private TextBox textBox10;
        private Label TotalBill;
        private Button AddTotalBillButton;
        private ComboBox comboBox1;
        private Label PaymentStatus;
    }
}