namespace UttendanceDesktop
{
    partial class Homepage
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
            YourCoursesLabel = new Label();
            homepageBanner = new Panel();
            ProfilePictureBox = new PictureBox();
            uttendanceLabel = new Label();
            LogoutButton = new Button();
            EditProfileButton = new Button();
            editButton = new Button();
            addCourseManualButton = new Button();
            importCourseButton = new Button();
            AddCoursePictureBox = new PictureBox();
            homepageBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddCoursePictureBox).BeginInit();
            SuspendLayout();
            // 
            // YourCoursesLabel
            // 
            YourCoursesLabel.AutoSize = true;
            YourCoursesLabel.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YourCoursesLabel.Location = new Point(7, 103);
            YourCoursesLabel.Margin = new Padding(0);
            YourCoursesLabel.Name = "YourCoursesLabel";
            YourCoursesLabel.Size = new Size(1375, 54);
            YourCoursesLabel.TabIndex = 1;
            YourCoursesLabel.Text = "Your Courses                                                                                 ";
            // 
            // homepageBanner
            // 
            homepageBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            homepageBanner.BackColor = Color.FromArgb(50, 56, 87);
            homepageBanner.Controls.Add(ProfilePictureBox);
            homepageBanner.Controls.Add(uttendanceLabel);
            homepageBanner.Location = new Point(2, 2);
            homepageBanner.Margin = new Padding(2);
            homepageBanner.Name = "homepageBanner";
            homepageBanner.Size = new Size(1059, 100);
            homepageBanner.TabIndex = 2;
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProfilePictureBox.Image = Properties.Resources.homepageprofilepic;
            ProfilePictureBox.Location = new Point(964, 15);
            ProfilePictureBox.Margin = new Padding(2);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(71, 71);
            ProfilePictureBox.TabIndex = 1;
            ProfilePictureBox.TabStop = false;
            ProfilePictureBox.Click += ProfilePictureBox_Click;
            // 
            // uttendanceLabel
            // 
            uttendanceLabel.AutoSize = true;
            uttendanceLabel.BackColor = Color.FromArgb(50, 56, 87);
            uttendanceLabel.Font = new Font("Microsoft Sans Serif", 25.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uttendanceLabel.ForeColor = Color.FromArgb(166, 176, 230);
            uttendanceLabel.Location = new Point(33, 26);
            uttendanceLabel.Margin = new Padding(2, 0, 2, 0);
            uttendanceLabel.Name = "uttendanceLabel";
            uttendanceLabel.Size = new Size(267, 52);
            uttendanceLabel.TabIndex = 0;
            uttendanceLabel.Text = "UTtenDance";
            // 
            // LogoutButton
            // 
            LogoutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogoutButton.BackColor = Color.FromArgb(217, 217, 217);
            LogoutButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            LogoutButton.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutButton.Location = new Point(945, 121);
            LogoutButton.Margin = new Padding(2);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(90, 33);
            LogoutButton.TabIndex = 8;
            LogoutButton.Text = "Log Out";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Visible = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // EditProfileButton
            // 
            EditProfileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditProfileButton.BackColor = Color.FromArgb(217, 217, 217);
            EditProfileButton.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditProfileButton.ForeColor = SystemColors.ControlText;
            EditProfileButton.Location = new Point(945, 90);
            EditProfileButton.Margin = new Padding(2);
            EditProfileButton.Name = "EditProfileButton";
            EditProfileButton.Size = new Size(90, 32);
            EditProfileButton.TabIndex = 7;
            EditProfileButton.Text = "Edit Profile";
            EditProfileButton.UseVisualStyleBackColor = false;
            EditProfileButton.Visible = false;
            EditProfileButton.Click += EditProfileButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(234, 117, 7);
            editButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(334, 110);
            editButton.Margin = new Padding(2);
            editButton.Name = "editButton";
            editButton.Size = new Size(90, 42);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // addCourseManualButton
            // 
            addCourseManualButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addCourseManualButton.BackColor = Color.FromArgb(217, 217, 217);
            addCourseManualButton.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCourseManualButton.ForeColor = SystemColors.ControlText;
            addCourseManualButton.Location = new Point(979, 388);
            addCourseManualButton.Margin = new Padding(2);
            addCourseManualButton.Name = "addCourseManualButton";
            addCourseManualButton.Size = new Size(79, 31);
            addCourseManualButton.TabIndex = 4;
            addCourseManualButton.Text = "Create Course";
            addCourseManualButton.UseVisualStyleBackColor = false;
            addCourseManualButton.Visible = false;
            addCourseManualButton.Click += addCourseManualButton_Click;
            // 
            // importCourseButton
            // 
            importCourseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            importCourseButton.BackColor = Color.FromArgb(217, 217, 217);
            importCourseButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            importCourseButton.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importCourseButton.Location = new Point(979, 417);
            importCourseButton.Margin = new Padding(2);
            importCourseButton.Name = "importCourseButton";
            importCourseButton.Size = new Size(79, 29);
            importCourseButton.TabIndex = 5;
            importCourseButton.Text = "Import Course";
            importCourseButton.UseVisualStyleBackColor = false;
            importCourseButton.Visible = false;
            importCourseButton.Click += importCourseButton_Click;
            // 
            // AddCoursePictureBox
            // 
            AddCoursePictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddCoursePictureBox.Image = Properties.Resources.add_icon;
            AddCoursePictureBox.Location = new Point(991, 444);
            AddCoursePictureBox.Margin = new Padding(2);
            AddCoursePictureBox.Name = "AddCoursePictureBox";
            AddCoursePictureBox.Size = new Size(46, 52);
            AddCoursePictureBox.TabIndex = 6;
            AddCoursePictureBox.TabStop = false;
            AddCoursePictureBox.Click += AddCoursePictureBox_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(1064, 517);
            Controls.Add(EditProfileButton);
            Controls.Add(LogoutButton);
            Controls.Add(editButton);
            Controls.Add(importCourseButton);
            Controls.Add(addCourseManualButton);
            Controls.Add(YourCoursesLabel);
            Controls.Add(AddCoursePictureBox);
            Controls.Add(homepageBanner);
            Margin = new Padding(2);
            Name = "Homepage";
            Text = "Uttendance";
            homepageBanner.ResumeLayout(false);
            homepageBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddCoursePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label uttendanceLabel;
        private Label YourCoursesLabel;
        private Panel homepageBanner;
        private Button editButton;
        private Button addCourseManualButton;
        private Button importCourseButton;
        private PictureBox ProfilePictureBox;
        private PictureBox AddCoursePictureBox;
        private Button LogoutButton;
        private Button EditProfileButton;
    }
}