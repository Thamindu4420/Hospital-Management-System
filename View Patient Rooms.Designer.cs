namespace HealthCare_Plus
{
    partial class View_Patient_Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Patient_Rooms));
            SearchButton2 = new Button();
            SearchTextBox2 = new TextBox();
            dataGridView2 = new DataGridView();
            SearchButton = new Button();
            SearchTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            PatientRoomsHeading = new Label();
            RoomPricesButton = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton2
            // 
            SearchButton2.BackColor = Color.LightGray;
            SearchButton2.FlatStyle = FlatStyle.Popup;
            SearchButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton2.Location = new Point(1711, 651);
            SearchButton2.Name = "SearchButton2";
            SearchButton2.Size = new Size(109, 27);
            SearchButton2.TabIndex = 59;
            SearchButton2.Text = "Search";
            SearchButton2.UseVisualStyleBackColor = false;
            SearchButton2.Click += SearchButton2_Click;
            // 
            // SearchTextBox2
            // 
            SearchTextBox2.Location = new Point(1259, 651);
            SearchTextBox2.Name = "SearchTextBox2";
            SearchTextBox2.Size = new Size(414, 27);
            SearchTextBox2.TabIndex = 58;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(355, 703);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1470, 279);
            dataGridView2.TabIndex = 57;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(1711, 228);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(109, 27);
            SearchButton.TabIndex = 56;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Location = new Point(1259, 228);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(414, 27);
            SearchTextbox.TabIndex = 55;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(355, 299);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1470, 275);
            dataGridView1.TabIndex = 54;
            // 
            // PatientRoomsHeading
            // 
            PatientRoomsHeading.AutoSize = true;
            PatientRoomsHeading.BackColor = Color.Transparent;
            PatientRoomsHeading.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Underline, GraphicsUnit.Point);
            PatientRoomsHeading.ForeColor = Color.Lime;
            PatientRoomsHeading.Location = new Point(676, 66);
            PatientRoomsHeading.Name = "PatientRoomsHeading";
            PatientRoomsHeading.Size = new Size(452, 70);
            PatientRoomsHeading.TabIndex = 53;
            PatientRoomsHeading.Text = "Patient Rooms";
            // 
            // RoomPricesButton
            // 
            RoomPricesButton.BackColor = Color.FromArgb(255, 128, 0);
            RoomPricesButton.FlatStyle = FlatStyle.Popup;
            RoomPricesButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RoomPricesButton.ForeColor = Color.White;
            RoomPricesButton.Location = new Point(36, 553);
            RoomPricesButton.Name = "RoomPricesButton";
            RoomPricesButton.Size = new Size(193, 43);
            RoomPricesButton.TabIndex = 61;
            RoomPricesButton.Text = "Room Prices";
            RoomPricesButton.UseVisualStyleBackColor = false;
            RoomPricesButton.Click += RoomPricesButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(36, 633);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(193, 43);
            BackButton.TabIndex = 60;
            BackButton.Text = "Back ";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // View_Patient_Rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1055);
            Controls.Add(RoomPricesButton);
            Controls.Add(BackButton);
            Controls.Add(SearchButton2);
            Controls.Add(SearchTextBox2);
            Controls.Add(dataGridView2);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextbox);
            Controls.Add(dataGridView1);
            Controls.Add(PatientRoomsHeading);
            DoubleBuffered = true;
            Name = "View_Patient_Rooms";
            Text = "View Patient Rooms";
            Load += View_Patient_Rooms_Load;
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
        private Label PatientRoomsHeading;
        private Button RoomPricesButton;
        private Button BackButton;
    }
}