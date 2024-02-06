namespace HealthCare_Plus
{
    partial class Room_Availability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_Availability));
            RoomAvailabilityHeading = new Label();
            dataGridView1 = new DataGridView();
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            AddRoomButton = new Button();
            dataGridView2 = new DataGridView();
            UpdateRoomButton = new Button();
            PatientRoomsButton = new Button();
            BackToDashboardButton = new Button();
            DeleteRoomButton = new Button();
            SearchButton2 = new Button();
            SearchTextBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // RoomAvailabilityHeading
            // 
            RoomAvailabilityHeading.AutoSize = true;
            RoomAvailabilityHeading.BackColor = Color.Transparent;
            RoomAvailabilityHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            RoomAvailabilityHeading.ForeColor = Color.Lime;
            RoomAvailabilityHeading.Location = new Point(681, 67);
            RoomAvailabilityHeading.Name = "RoomAvailabilityHeading";
            RoomAvailabilityHeading.Size = new Size(533, 70);
            RoomAvailabilityHeading.TabIndex = 23;
            RoomAvailabilityHeading.Text = "Room Availability";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(318, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1470, 275);
            dataGridView1.TabIndex = 24;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1674, 253);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 27;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1222, 253);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 26;
            // 
            // AddRoomButton
            // 
            AddRoomButton.BackColor = Color.FromArgb(255, 128, 0);
            AddRoomButton.FlatStyle = FlatStyle.Popup;
            AddRoomButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddRoomButton.ForeColor = Color.White;
            AddRoomButton.Location = new Point(44, 474);
            AddRoomButton.Name = "AddRoomButton";
            AddRoomButton.Size = new Size(193, 43);
            AddRoomButton.TabIndex = 37;
            AddRoomButton.Text = "Add Room";
            AddRoomButton.UseVisualStyleBackColor = false;
            AddRoomButton.Click += AddRoomButton_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(318, 728);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1470, 311);
            dataGridView2.TabIndex = 38;
            // 
            // UpdateRoomButton
            // 
            UpdateRoomButton.BackColor = Color.FromArgb(255, 128, 0);
            UpdateRoomButton.FlatStyle = FlatStyle.Popup;
            UpdateRoomButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateRoomButton.ForeColor = Color.White;
            UpdateRoomButton.Location = new Point(44, 556);
            UpdateRoomButton.Name = "UpdateRoomButton";
            UpdateRoomButton.Size = new Size(193, 43);
            UpdateRoomButton.TabIndex = 41;
            UpdateRoomButton.Text = "Update Room";
            UpdateRoomButton.UseVisualStyleBackColor = false;
            UpdateRoomButton.Click += UpdateRoomButton_Click;
            // 
            // PatientRoomsButton
            // 
            PatientRoomsButton.BackColor = Color.FromArgb(255, 128, 0);
            PatientRoomsButton.FlatStyle = FlatStyle.Popup;
            PatientRoomsButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PatientRoomsButton.ForeColor = Color.White;
            PatientRoomsButton.Location = new Point(44, 728);
            PatientRoomsButton.Name = "PatientRoomsButton";
            PatientRoomsButton.Size = new Size(193, 43);
            PatientRoomsButton.TabIndex = 42;
            PatientRoomsButton.Text = "Patient Rooms";
            PatientRoomsButton.UseVisualStyleBackColor = false;
            PatientRoomsButton.Click += PatientRoomsButton_Click;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.Red;
            BackToDashboardButton.FlatStyle = FlatStyle.Popup;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(44, 824);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(193, 43);
            BackToDashboardButton.TabIndex = 43;
            BackToDashboardButton.Text = "Back To Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // DeleteRoomButton
            // 
            DeleteRoomButton.BackColor = Color.FromArgb(255, 128, 0);
            DeleteRoomButton.FlatStyle = FlatStyle.Popup;
            DeleteRoomButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteRoomButton.ForeColor = Color.White;
            DeleteRoomButton.Location = new Point(44, 648);
            DeleteRoomButton.Name = "DeleteRoomButton";
            DeleteRoomButton.Size = new Size(193, 43);
            DeleteRoomButton.TabIndex = 44;
            DeleteRoomButton.Text = "Delete Room";
            DeleteRoomButton.UseVisualStyleBackColor = false;
            DeleteRoomButton.Click += DeleteRoomButton_Click;
            // 
            // SearchButton2
            // 
            SearchButton2.BackColor = Color.LightGray;
            SearchButton2.FlatStyle = FlatStyle.Popup;
            SearchButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton2.Location = new Point(1674, 676);
            SearchButton2.Name = "SearchButton2";
            SearchButton2.Size = new Size(109, 27);
            SearchButton2.TabIndex = 46;
            SearchButton2.Text = "Search";
            SearchButton2.UseVisualStyleBackColor = false;
            SearchButton2.Click += SearchButton2_Click;
            // 
            // SearchTextBox2
            // 
            SearchTextBox2.Location = new Point(1222, 676);
            SearchTextBox2.Name = "SearchTextBox2";
            SearchTextBox2.Size = new Size(414, 27);
            SearchTextBox2.TabIndex = 45;
            // 
            // Room_Availability
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(SearchButton2);
            Controls.Add(SearchTextBox2);
            Controls.Add(DeleteRoomButton);
            Controls.Add(BackToDashboardButton);
            Controls.Add(PatientRoomsButton);
            Controls.Add(UpdateRoomButton);
            Controls.Add(dataGridView2);
            Controls.Add(AddRoomButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(RoomAvailabilityHeading);
            DoubleBuffered = true;
            Name = "Room_Availability";
            Text = "Room Availability";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RoomAvailabilityHeading;
        private DataGridView dataGridView1;
        private Button SearchButton;
        private TextBox SearchTextbox;
        private Button AddRoomButton;
        private DataGridView dataGridView2;
        private Button UpdateRoomButton;
        private Button PatientRoomsButton;
        private Button BackToDashboardButton;
        private Button DeleteRoomButton;
        private Button SearchButton2;
        private TextBox SearchTextBox2;
    }
}