/******************************************************************************
 * Homepage Form Designer for the UttendanceDesktop application.
 * This form serves as the main dashboard after login. It displays the user's
 * courses as interactive tiles and provides options to add, import, and
 * delete courses, as well as edit profile and logout features.
 * Written by Parisa Nawar (pxn210032) for CS4485.0W1 at The University of Texas at Dallas
 * starting March 13, 2025.
 ******************************************************************************/
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
            LogoutButton = new Button();
            EditProfileButton = new Button();
            ProfilePictureBox = new PictureBox();
            uttendanceLabel = new Label();
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
            YourCoursesLabel.Font = new Font("Afacad Medium", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YourCoursesLabel.Location = new Point(9, 129);
            YourCoursesLabel.Margin = new Padding(0);
            YourCoursesLabel.Name = "YourCoursesLabel";
            YourCoursesLabel.Size = new Size(1287, 75);
            YourCoursesLabel.TabIndex = 1;
            YourCoursesLabel.Text = "Your Courses                                                                                 ";
            // 
            // homepageBanner
            // 
            homepageBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            homepageBanner.BackColor = Color.FromArgb(50, 56, 87);
            homepageBanner.Controls.Add(LogoutButton);
            homepageBanner.Controls.Add(EditProfileButton);
            homepageBanner.Controls.Add(ProfilePictureBox);
            homepageBanner.Controls.Add(uttendanceLabel);
            homepageBanner.Location = new Point(3, 3);
            homepageBanner.Name = "homepageBanner";
            homepageBanner.Size = new Size(1324, 125);
            homepageBanner.TabIndex = 2;
            // 
            // LogoutButton
            // 
            LogoutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogoutButton.BackColor = Color.FromArgb(217, 217, 217);
            LogoutButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            LogoutButton.Font = new Font("Afacad", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutButton.Location = new Point(1169, 98);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(112, 26);
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
            EditProfileButton.Font = new Font("Afacad", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditProfileButton.ForeColor = SystemColors.ControlText;
            EditProfileButton.Location = new Point(1169, 77);
            EditProfileButton.Name = "EditProfileButton";
            EditProfileButton.Size = new Size(112, 24);
            EditProfileButton.TabIndex = 7;
            EditProfileButton.Text = "Edit Profile";
            EditProfileButton.UseVisualStyleBackColor = false;
            EditProfileButton.Visible = false;
            EditProfileButton.Click += EditProfileButton_Click;
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProfilePictureBox.Image = Properties.Resources.homepageprofilepic;
            ProfilePictureBox.Location = new Point(1194, 9);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(70, 69);
            ProfilePictureBox.TabIndex = 1;
            ProfilePictureBox.TabStop = false;
            ProfilePictureBox.Click += ProfilePictureBox_Click;
            // 
            // uttendanceLabel
            // 
            uttendanceLabel.AutoSize = true;
            uttendanceLabel.BackColor = Color.FromArgb(50, 56, 87);
            uttendanceLabel.Font = new Font("Afacad", 25.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uttendanceLabel.ForeColor = Color.FromArgb(166, 176, 230);
            uttendanceLabel.Location = new Point(41, 32);
            uttendanceLabel.Name = "uttendanceLabel";
            uttendanceLabel.Size = new Size(286, 69);
            uttendanceLabel.TabIndex = 0;
            uttendanceLabel.Text = "UTtenDance";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editButton.BackColor = Color.FromArgb(234, 117, 7);
            editButton.Font = new Font("Afacad", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(1175, 149);
            editButton.Name = "editButton";
            editButton.Size = new Size(112, 61);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // addCourseManualButton
            // 
            addCourseManualButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addCourseManualButton.BackColor = Color.FromArgb(217, 217, 217);
            addCourseManualButton.Font = new Font("Afacad", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCourseManualButton.ForeColor = SystemColors.ControlText;
            addCourseManualButton.Location = new Point(1224, 595);
            addCourseManualButton.Name = "addCourseManualButton";
            addCourseManualButton.Size = new Size(99, 24);
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
            importCourseButton.Font = new Font("Afacad", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importCourseButton.Location = new Point(1224, 616);
            importCourseButton.Name = "importCourseButton";
            importCourseButton.Size = new Size(99, 26);
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
            AddCoursePictureBox.Location = new Point(1239, 555);
            AddCoursePictureBox.Name = "AddCoursePictureBox";
            AddCoursePictureBox.Size = new Size(57, 55);
            AddCoursePictureBox.TabIndex = 6;
            AddCoursePictureBox.TabStop = false;
            AddCoursePictureBox.Click += AddCoursePictureBox_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(1330, 646);
            Controls.Add(editButton);
            Controls.Add(importCourseButton);
            Controls.Add(addCourseManualButton);
            Controls.Add(YourCoursesLabel);
            Controls.Add(AddCoursePictureBox);
            Controls.Add(homepageBanner);
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