namespace HealthCare_Plus
{
    partial class View_Room_Availability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Room_Availability));
            SearchButton2 = new Button();
            SearchTextBox2 = new TextBox();
            dataGridView2 = new DataGridView();
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            RoomAvailabilityHeading = new Label();
            BackToDashboardButton = new Button();
            PatientRoomsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton2
            // 
            SearchButton2.BackColor = Color.LightGray;
            SearchButton2.FlatStyle = FlatStyle.Popup;
            SearchButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton2.Location = new Point(1708, 648);
            SearchButton2.Name = "SearchButton2";
            SearchButton2.Size = new Size(109, 27);
            SearchButton2.TabIndex = 53;
            SearchButton2.Text = "Search";
            SearchButton2.UseVisualStyleBackColor = false;
            SearchButton2.Click += SearchButton2_Click;
            // 
            // SearchTextBox2
            // 
            SearchTextBox2.Location = new Point(1256, 648);
            SearchTextBox2.Name = "SearchTextBox2";
            SearchTextBox2.Size = new Size(414, 27);
            SearchTextBox2.TabIndex = 52;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(352, 700);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1470, 311);
            dataGridView2.TabIndex = 51;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1708, 225);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 50;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1256, 225);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 49;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(352, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1470, 275);
            dataGridView1.TabIndex = 48;
            // 
            // RoomAvailabilityHeading
            // 
            RoomAvailabilityHeading.AutoSize = true;
            RoomAvailabilityHeading.BackColor = Color.Transparent;
            RoomAvailabilityHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            RoomAvailabilityHeading.ForeColor = Color.Lime;
            RoomAvailabilityHeading.Location = new Point(715, 39);
            RoomAvailabilityHeading.Name = "RoomAvailabilityHeading";
            RoomAvailabilityHeading.Size = new Size(533, 70);
            RoomAvailabilityHeading.TabIndex = 47;
            RoomAvailabilityHeading.Text = "Room Availability";
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Red;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(12, 643);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(191, 43);
            BackToDashboardButton.TabIndex = 55;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // PatientRoomsButton
            // 
            PatientRoomsButton.BackColor = Color.FromArgb(255, 128, 0);
            PatientRoomsButton.FlatStyle = FlatStyle.Popup;
            PatientRoomsButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PatientRoomsButton.ForeColor = Color.White;
            PatientRoomsButton.Location = new Point(12, 547);
            PatientRoomsButton.Name = "PatientRoomsButton";
            PatientRoomsButton.Size = new Size(191, 43);
            PatientRoomsButton.TabIndex = 54;
            PatientRoomsButton.Text = "Patient Rooms";
            PatientRoomsButton.UseVisualStyleBackColor = false;
            PatientRoomsButton.Click += PatientRoomsButton_Click;
            // 
            // View_Room_Availability
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(BackToDashboardButton);
            Controls.Add(PatientRoomsButton);
            Controls.Add(SearchButton2);
            Controls.Add(SearchTextBox2);
            Controls.Add(dataGridView2);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(RoomAvailabilityHeading);
            DoubleBuffered = true;
            Name = "View_Room_Availability";
            Text = "View_Room_Availability";
            Load += View_Room_Availability_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton2;
        private TextBox SearchTextBox2;
        private DataGridView dataGridView2;
        private Button SearchButton;
        private TextBox SearchTextbox;
        private DataGridView dataGridView1;
        private Label RoomAvailabilityHeading;
        private Button BackToDashboardButton;
        private Button PatientRoomsButton;
    }
}