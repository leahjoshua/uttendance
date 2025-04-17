using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    partial class AttendanceForms_Listings
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
            attendanceFormPagePanel = new Panel();
            SaveEditIcon = new Button();
            filterButton = new Button();
            attendanceflowLayoutPanel = new FlowLayoutPanel();
            dateTimePicker = new DateTimePicker();
            dateLabel = new Label();
            filterLabel = new Label();
            filterDropdown = new ComboBox();
            statusDropDown = new ComboBox();
            statusLabel = new Label();
            listingsLabel = new Label();
            attendanceFormsLabel = new Label();
            attendanceFormPagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // attendanceFormPagePanel
            // 
            attendanceFormPagePanel.Controls.Add(SaveEditIcon);
            attendanceFormPagePanel.Controls.Add(filterButton);
            attendanceFormPagePanel.Controls.Add(attendanceflowLayoutPanel);
            attendanceFormPagePanel.Controls.Add(dateTimePicker);
            attendanceFormPagePanel.Controls.Add(dateLabel);
            attendanceFormPagePanel.Controls.Add(filterLabel);
            attendanceFormPagePanel.Controls.Add(filterDropdown);
            attendanceFormPagePanel.Controls.Add(statusDropDown);
            attendanceFormPagePanel.Controls.Add(statusLabel);
            attendanceFormPagePanel.Controls.Add(listingsLabel);
            attendanceFormPagePanel.Controls.Add(attendanceFormsLabel);
            attendanceFormPagePanel.Dock = DockStyle.Fill;
            attendanceFormPagePanel.Location = new Point(0, 0);
            attendanceFormPagePanel.Margin = new Padding(3, 4, 3, 4);
            attendanceFormPagePanel.Name = "attendanceFormPagePanel";
            attendanceFormPagePanel.Size = new Size(914, 600);
            attendanceFormPagePanel.TabIndex = 0;
            // 
            // SaveEditIcon
            // 
            SaveEditIcon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveEditIcon.BackColor = Color.Transparent;
            SaveEditIcon.BackgroundImage = Properties.Resources.add_icon;
            SaveEditIcon.FlatAppearance.BorderColor = Color.White;
            SaveEditIcon.FlatAppearance.BorderSize = 0;
            SaveEditIcon.FlatStyle = FlatStyle.Flat;
            SaveEditIcon.Location = new Point(852, 532);
            SaveEditIcon.Name = "SaveEditIcon";
            SaveEditIcon.Size = new Size(45, 49);
            SaveEditIcon.TabIndex = 13;
            SaveEditIcon.UseVisualStyleBackColor = false;
            SaveEditIcon.Click += SaveEditIcon_Click;
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.FromArgb(255, 128, 0);
            filterButton.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            filterButton.FlatAppearance.BorderSize = 2;
            filterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Location = new Point(799, 170);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(27, 27);
            filterButton.TabIndex = 12;
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // attendanceflowLayoutPanel
            // 
            attendanceflowLayoutPanel.Anchor = AnchorStyles.Top;
            attendanceflowLayoutPanel.AutoScroll = true;
            attendanceflowLayoutPanel.Location = new Point(72, 216);
            attendanceflowLayoutPanel.Name = "attendanceflowLayoutPanel";
            attendanceflowLayoutPanel.Size = new Size(779, 466);
            attendanceflowLayoutPanel.TabIndex = 11;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarForeColor = Color.FromArgb(37, 42, 69);
            dateTimePicker.CalendarTitleForeColor = Color.FromArgb(37, 42, 69);
            dateTimePicker.Location = new Point(543, 170);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 10;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 10.25F);
            dateLabel.ForeColor = Color.FromArgb(37, 42, 69);
            dateLabel.Location = new Point(543, 141);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(53, 25);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date:";
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Segoe UI", 10.25F);
            filterLabel.ForeColor = Color.FromArgb(37, 42, 69);
            filterLabel.Location = new Point(386, 141);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(54, 25);
            filterLabel.TabIndex = 7;
            filterLabel.Text = "Filter:";
            // 
            // filterDropdown
            // 
            filterDropdown.ForeColor = Color.FromArgb(37, 42, 69);
            filterDropdown.FormattingEnabled = true;
            filterDropdown.Items.AddRange(new object[] { "Before", "After", "On", "All" });
            filterDropdown.Location = new Point(386, 169);
            filterDropdown.Name = "filterDropdown";
            filterDropdown.Size = new Size(151, 28);
            filterDropdown.TabIndex = 5;
            // 
            // statusDropDown
            // 
            statusDropDown.ForeColor = Color.FromArgb(37, 42, 69);
            statusDropDown.FormattingEnabled = true;
            statusDropDown.Items.AddRange(new object[] { "Upcoming", "Open", "Closed", "All" });
            statusDropDown.Location = new Point(72, 169);
            statusDropDown.Name = "statusDropDown";
            statusDropDown.Size = new Size(151, 28);
            statusDropDown.TabIndex = 4;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 10.25F);
            statusLabel.ForeColor = Color.FromArgb(37, 42, 69);
            statusLabel.Location = new Point(72, 141);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(64, 25);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Status:";
            // 
            // listingsLabel
            // 
            listingsLabel.AutoSize = true;
            listingsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listingsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            listingsLabel.Location = new Point(72, 100);
            listingsLabel.Name = "listingsLabel";
            listingsLabel.Size = new Size(93, 32);
            listingsLabel.TabIndex = 1;
            listingsLabel.Text = "Listings";
            // 
            // attendanceFormsLabel
            // 
            attendanceFormsLabel.AutoSize = true;
            attendanceFormsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceFormsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            attendanceFormsLabel.Location = new Point(49, 49);
            attendanceFormsLabel.Name = "attendanceFormsLabel";
            attendanceFormsLabel.Size = new Size(260, 41);
            attendanceFormsLabel.TabIndex = 0;
            attendanceFormsLabel.Text = "Attendance Forms";
            // 
            // AttendanceForms_Listings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(914, 600);
            Controls.Add(attendanceFormPagePanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AttendanceForms_Listings";
            Text = "Uttendance";
            attendanceFormPagePanel.ResumeLayout(false);
            attendanceFormPagePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel attendanceFormPagePanel;
        private Label attendanceFormsLabel;
        private Label listingsLabel;
        private Label statusLabel;
        private Button editButton;
        private Label dateLabel;
        private Label filterLabel;
        private ComboBox filterDropdown;
        private ComboBox statusDropDown;
        private DateTimePicker dateTimePicker;
        private CoursepageContent.attendanceFormItem attendanceFormItem1;
        private FlowLayoutPanel attendanceflowLayoutPanel;
        private Button filterButton;
        private Button SaveEditIcon;
        private Panel addPanel;
        private Button importStudentsBtn;
    }
}