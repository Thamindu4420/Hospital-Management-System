namespace HealthCare_Plus
{
    partial class Admin_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Profile));
            AdminProfile = new Label();
            pictureBox1 = new PictureBox();
            Username = new Label();
            Email = new Label();
            Password = new Label();
            RetreiveUsername = new Label();
            RetreiveEmail = new Label();
            RetreivePassword = new Label();
            BrowseButton = new Button();
            BackToDashboardButton = new Button();
            panel1 = new Panel();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AdminProfile
            // 
            AdminProfile.AutoSize = true;
            AdminProfile.BackColor = Color.Transparent;
            AdminProfile.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Underline, GraphicsUnit.Point);
            AdminProfile.ForeColor = Color.Red;
            AdminProfile.Location = new Point(816, 65);
            AdminProfile.Margin = new Padding(7, 0, 7, 0);
            AdminProfile.Name = "AdminProfile";
            AdminProfile.Size = new Size(331, 54);
            AdminProfile.TabIndex = 0;
            AdminProfile.Text = "Admin Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(315, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 171);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Username.Location = new Point(200, 355);
            Username.Name = "Username";
            Username.Size = new Size(132, 26);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Email.Location = new Point(200, 424);
            Email.Name = "Email";
            Email.Size = new Size(79, 26);
            Email.TabIndex = 3;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Password.Location = new Point(200, 498);
            Password.Name = "Password";
            Password.Size = new Size(129, 26);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // RetreiveUsername
            // 
            RetreiveUsername.AutoSize = true;
            RetreiveUsername.BorderStyle = BorderStyle.FixedSingle;
            RetreiveUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RetreiveUsername.Location = new Point(539, 357);
            RetreiveUsername.Name = "RetreiveUsername";
            RetreiveUsername.Size = new Size(64, 25);
            RetreiveUsername.TabIndex = 5;
            RetreiveUsername.Text = "label1";
            // 
            // RetreiveEmail
            // 
            RetreiveEmail.AutoSize = true;
            RetreiveEmail.BorderStyle = BorderStyle.FixedSingle;
            RetreiveEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RetreiveEmail.Location = new Point(539, 424);
            RetreiveEmail.Name = "RetreiveEmail";
            RetreiveEmail.Size = new Size(64, 25);
            RetreiveEmail.TabIndex = 6;
            RetreiveEmail.Text = "label1";
            // 
            // RetreivePassword
            // 
            RetreivePassword.AutoSize = true;
            RetreivePassword.BorderStyle = BorderStyle.FixedSingle;
            RetreivePassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RetreivePassword.Location = new Point(539, 498);
            RetreivePassword.Name = "RetreivePassword";
            RetreivePassword.Size = new Size(64, 25);
            RetreivePassword.TabIndex = 7;
            RetreivePassword.Text = "label1";
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = Color.FromArgb(128, 255, 255);
            BrowseButton.FlatStyle = FlatStyle.Popup;
            BrowseButton.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BrowseButton.Location = new Point(589, 216);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(86, 32);
            BrowseButton.TabIndex = 8;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Orange;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.Black;
            BackToDashboardButton.Location = new Point(481, 618);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(166, 47);
            BackToDashboardButton.TabIndex = 9;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(BrowseButton);
            panel1.Controls.Add(BackToDashboardButton);
            panel1.Controls.Add(RetreivePassword);
            panel1.Controls.Add(RetreiveEmail);
            panel1.Controls.Add(RetreiveUsername);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(544, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 740);
            panel1.TabIndex = 10;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Lime;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Location = new Point(232, 618);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(121, 47);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // Admin_Profile
            // 
            AutoScaleDimensions = new SizeF(19F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(AdminProfile);
            DoubleBuffered = true;
            Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 5, 7, 5);
            Name = "Admin_Profile";
            Text = "Admin Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AdminProfile;
        private PictureBox pictureBox1;
        private Label Username;
        private Label Email;
        private Label Password;
        private Label RetreiveUsername;
        private Label RetreiveEmail;
        private Label RetreivePassword;
        private Button BrowseButton;
        private Button BackToDashboardButton;
        private Panel panel1;
        private Button SaveButton;
    }
}