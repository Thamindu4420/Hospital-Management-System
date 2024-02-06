namespace HealthCare_Plus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Heading = new Label();
            Email = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Password = new Label();
            User = new Label();
            comboBox1 = new ComboBox();
            Register = new Button();
            Login = new Button();
            panel1 = new Panel();
            DevelopedBy = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.BackColor = Color.Transparent;
            Heading.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            Heading.ForeColor = Color.Lime;
            Heading.Location = new Point(463, 38);
            Heading.Name = "Heading";
            Heading.Size = new Size(1013, 93);
            Heading.TabIndex = 0;
            Heading.Text = "HealthCare Plus Hospital";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Email.Location = new Point(36, 49);
            Email.Name = "Email";
            Email.Size = new Size(52, 24);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(602, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(602, 27);
            textBox2.TabIndex = 4;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Password.Location = new Point(36, 116);
            Password.Name = "Password";
            Password.Size = new Size(87, 24);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            User.Location = new Point(36, 189);
            User.Name = "User";
            User.Size = new Size(46, 24);
            User.TabIndex = 5;
            User.Text = "User";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Staff" });
            comboBox1.Location = new Point(177, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(602, 28);
            comboBox1.TabIndex = 6;
            // 
            // Register
            // 
            Register.BackColor = Color.Red;
            Register.FlatStyle = FlatStyle.Popup;
            Register.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Register.ForeColor = SystemColors.ButtonHighlight;
            Register.Location = new Point(258, 284);
            Register.Name = "Register";
            Register.Size = new Size(133, 45);
            Register.TabIndex = 7;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.Lime;
            Login.FlatStyle = FlatStyle.Popup;
            Login.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = SystemColors.ActiveCaptionText;
            Login.Location = new Point(506, 284);
            Login.Name = "Login";
            Login.Size = new Size(133, 45);
            Login.TabIndex = 8;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Login);
            panel1.Controls.Add(Register);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(User);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Email);
            panel1.Location = new Point(588, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 397);
            panel1.TabIndex = 9;
            // 
            // DevelopedBy
            // 
            DevelopedBy.AutoSize = true;
            DevelopedBy.BackColor = Color.Transparent;
            DevelopedBy.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DevelopedBy.ForeColor = SystemColors.ButtonHighlight;
            DevelopedBy.Location = new Point(888, 777);
            DevelopedBy.Name = "DevelopedBy";
            DevelopedBy.Size = new Size(288, 34);
            DevelopedBy.TabIndex = 10;
            DevelopedBy.Text = "Developed By Thamindu Perera";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1591, 840);
            Controls.Add(DevelopedBy);
            Controls.Add(panel1);
            Controls.Add(Heading);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Login Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Heading;
        private Label Email;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Password;
        private Label User;
        private ComboBox comboBox1;
        private Button Register;
        private Button Login;
        private Panel panel1;
        private Label DevelopedBy;
    }
}