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
            databaseInfoButton = new Button();
            ProfilePictureBox = new PictureBox();
            uttendanceLabel = new Label();
            LogoutButton = new Button();
            EditProfileButton = new Button();
            editButton = new Button();
            addCourseManualButton = new Button();
            importCourseButton = new Button();
            AddCoursePictureBox = new PictureBox();
            panel2 = new Panel();
            formsBtn = new Button();
            homepageBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddCoursePictureBox).BeginInit();
            SuspendLayout();
            // 
            // YourCoursesLabel
            // 
            YourCoursesLabel.AutoSize = true;
            YourCoursesLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YourCoursesLabel.Location = new Point(13, 178);
            YourCoursesLabel.Margin = new Padding(0);
            YourCoursesLabel.Name = "YourCoursesLabel";
            YourCoursesLabel.Padding = new Padding(29, 0, 0, 0);
            YourCoursesLabel.Size = new Size(1294, 60);
            YourCoursesLabel.TabIndex = 1;
            YourCoursesLabel.Text = "Your Courses                                                                                 ";
            // 
            // homepageBanner
            // 
            homepageBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            homepageBanner.BackColor = Color.FromArgb(50, 56, 87);
            homepageBanner.Controls.Add(databaseInfoButton);
            homepageBanner.Controls.Add(ProfilePictureBox);
            homepageBanner.Controls.Add(uttendanceLabel);
            homepageBanner.Location = new Point(3, 3);
            homepageBanner.Name = "homepageBanner";
            homepageBanner.Size = new Size(1324, 125);
            homepageBanner.TabIndex = 2;
            // 
            // databaseInfoButton
            // 
            databaseInfoButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            databaseInfoButton.BackColor = Color.FromArgb(234, 117, 7);
            databaseInfoButton.FlatAppearance.BorderSize = 0;
            databaseInfoButton.FlatStyle = FlatStyle.Flat;
            databaseInfoButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            databaseInfoButton.ForeColor = Color.White;
            databaseInfoButton.Location = new Point(987, 28);
            databaseInfoButton.Margin = new Padding(4, 5, 4, 5);
            databaseInfoButton.Name = "databaseInfoButton";
            databaseInfoButton.Size = new Size(153, 72);
            databaseInfoButton.TabIndex = 9;
            databaseInfoButton.Text = "Database Information";
            databaseInfoButton.UseVisualStyleBackColor = false;
            databaseInfoButton.Click += databaseInfoButton_Click;
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProfilePictureBox.Image = Properties.Resources.homepageprofilepic;
            ProfilePictureBox.Location = new Point(1206, 18);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(89, 88);
            ProfilePictureBox.TabIndex = 1;
            ProfilePictureBox.TabStop = false;
            ProfilePictureBox.Click += ProfilePictureBox_Click;
            // 
            // uttendanceLabel
            // 
            uttendanceLabel.AutoSize = true;
            uttendanceLabel.BackColor = Color.FromArgb(50, 56, 87);
            uttendanceLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uttendanceLabel.ForeColor = Color.White;
            uttendanceLabel.Location = new Point(29, 28);
            uttendanceLabel.Name = "uttendanceLabel";
            uttendanceLabel.Size = new Size(316, 71);
            uttendanceLabel.TabIndex = 0;
            uttendanceLabel.Text = "UTtenDance";
            // 
            // LogoutButton
            // 
            LogoutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogoutButton.BackColor = Color.FromArgb(217, 217, 217);
            LogoutButton.FlatAppearance.BorderColor = Color.Black;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutButton.ForeColor = Color.Black;
            LogoutButton.Location = new Point(1169, 162);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(126, 47);
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
            EditProfileButton.FlatStyle = FlatStyle.Flat;
            EditProfileButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditProfileButton.ForeColor = Color.Black;
            EditProfileButton.Location = new Point(1169, 113);
            EditProfileButton.Name = "EditProfileButton";
            EditProfileButton.Size = new Size(126, 50);
            EditProfileButton.TabIndex = 7;
            EditProfileButton.Text = "Edit Profile";
            EditProfileButton.UseVisualStyleBackColor = false;
            EditProfileButton.Visible = false;
            EditProfileButton.Click += EditProfileButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(234, 117, 7);
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(353, 178);
            editButton.Name = "editButton";
            editButton.Size = new Size(113, 53);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // addCourseManualButton
            // 
            addCourseManualButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addCourseManualButton.BackColor = Color.FromArgb(217, 217, 217);
            addCourseManualButton.FlatStyle = FlatStyle.Flat;
            addCourseManualButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCourseManualButton.ForeColor = SystemColors.ControlText;
            addCourseManualButton.Location = new Point(1169, 462);
            addCourseManualButton.Name = "addCourseManualButton";
            addCourseManualButton.Size = new Size(154, 50);
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
            importCourseButton.FlatAppearance.BorderColor = Color.Black;
            importCourseButton.FlatStyle = FlatStyle.Flat;
            importCourseButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importCourseButton.Location = new Point(1169, 510);
            importCourseButton.Name = "importCourseButton";
            importCourseButton.Size = new Size(154, 48);
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
            AddCoursePictureBox.Size = new Size(57, 65);
            AddCoursePictureBox.TabIndex = 6;
            AddCoursePictureBox.TabStop = false;
            AddCoursePictureBox.Click += AddCoursePictureBox_Click;
            // 
            // formsBtn
            // 
            formsBtn.BackColor = Color.FromArgb(50, 56, 87);
            formsBtn.FlatAppearance.BorderSize = 0;
            formsBtn.FlatStyle = FlatStyle.Flat;
            formsBtn.ForeColor = Color.White;
            formsBtn.Location = new Point(486, 178);
            formsBtn.Margin = new Padding(4, 5, 4, 5);
            formsBtn.Name = "formsBtn";
            formsBtn.Size = new Size(117, 53);
            formsBtn.TabIndex = 9;
            formsBtn.Text = "All Forms";
            formsBtn.UseVisualStyleBackColor = false;
            formsBtn.Click += formsBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 56, 87);
            panel2.BackgroundImage = Properties.Resources.real_xof_icon;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(29, 2);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 100);
            panel2.TabIndex = 4;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(1330, 647);
            Controls.Add(formsBtn);
            Controls.Add(EditProfileButton);
            Controls.Add(LogoutButton);
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
        private Button formsBtn;
        private Button databaseInfoButton;
        private Panel panel2;
    }
}