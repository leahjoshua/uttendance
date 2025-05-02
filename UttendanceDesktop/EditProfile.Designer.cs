/******************************************************************************
* EditProfile Form Designer for the UttendanceDesktop application.
* This form allows users to edit their profile information (first name, last name,
* password) and delete their account. It interacts with the MySQL database to
* fetch, update, and delete instructor records. Deletion also removes associated
* course assignments from the teaches table to maintain referential integrity.
* Written by Parisa Nawar (pxn210032) for CS4485.0W1 at The University of Texas at Dallas
* starting April 10, 2025.
******************************************************************************/
namespace UttendanceDesktop
{
    partial class EditProfile
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
            homepageBanner = new Panel();
            ProfilePictureBox = new PictureBox();
            uttendanceLabel = new Label();
            DeleteButton = new Button();
            EditButton = new Button();
            SaveButton = new Button();
            ProfileLabel = new Label();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            PasswordLabel = new Label();
            FirstNameTextbox = new TextBox();
            LastNameTextbox = new TextBox();
            PasswordTextbox = new TextBox();
            homepageBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // homepageBanner
            // 
            homepageBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            homepageBanner.BackColor = Color.FromArgb(50, 56, 87);
            homepageBanner.Controls.Add(ProfilePictureBox);
            homepageBanner.Controls.Add(uttendanceLabel);
            homepageBanner.Location = new Point(1, 7);
            homepageBanner.Margin = new Padding(2);
            homepageBanner.Name = "homepageBanner";
            homepageBanner.Size = new Size(919, 75);
            homepageBanner.TabIndex = 3;
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.Image = Properties.Resources.homepageprofilepic;
            ProfilePictureBox.Location = new Point(853, 19);
            ProfilePictureBox.Margin = new Padding(2);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(49, 41);
            ProfilePictureBox.TabIndex = 1;
            ProfilePictureBox.TabStop = false;
            // 
            // uttendanceLabel
            // 
            uttendanceLabel.AutoSize = true;
            uttendanceLabel.BackColor = Color.FromArgb(50, 56, 87);
            uttendanceLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uttendanceLabel.ForeColor = Color.White;
            uttendanceLabel.Location = new Point(29, 19);
            uttendanceLabel.Margin = new Padding(2, 0, 2, 0);
            uttendanceLabel.Name = "uttendanceLabel";
            uttendanceLabel.Size = new Size(209, 47);
            uttendanceLabel.TabIndex = 0;
            uttendanceLabel.Text = "UTtenDance";
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(146, 67, 133);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(640, 113);
            DeleteButton.Margin = new Padding(2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(118, 38);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(234, 117, 7);
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(783, 113);
            EditButton.Margin = new Padding(2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(112, 38);
            EditButton.TabIndex = 5;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(24, 162, 104);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(733, 114);
            SaveButton.Margin = new Padding(2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(118, 38);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Visible = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileLabel.Location = new Point(30, 107);
            ProfileLabel.Margin = new Padding(2, 0, 2, 0);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(108, 40);
            ProfileLabel.TabIndex = 7;
            ProfileLabel.Text = "Profile";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameLabel.Location = new Point(30, 158);
            FirstNameLabel.Margin = new Padding(2, 0, 2, 0);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(86, 21);
            FirstNameLabel.TabIndex = 8;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameLabel.Location = new Point(401, 158);
            LastNameLabel.Margin = new Padding(2, 0, 2, 0);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(84, 21);
            LastNameLabel.TabIndex = 9;
            LastNameLabel.Text = "Last Name";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(30, 240);
            PasswordLabel.Margin = new Padding(2, 0, 2, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(76, 21);
            PasswordLabel.TabIndex = 11;
            PasswordLabel.Text = "Password";
            // 
            // FirstNameTextbox
            // 
            FirstNameTextbox.BackColor = Color.FromArgb(208, 213, 238);
            FirstNameTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameTextbox.Location = new Point(30, 181);
            FirstNameTextbox.Margin = new Padding(2);
            FirstNameTextbox.Name = "FirstNameTextbox";
            FirstNameTextbox.ReadOnly = true;
            FirstNameTextbox.Size = new Size(322, 27);
            FirstNameTextbox.TabIndex = 12;
            // 
            // LastNameTextbox
            // 
            LastNameTextbox.BackColor = Color.FromArgb(208, 213, 238);
            LastNameTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameTextbox.Location = new Point(401, 181);
            LastNameTextbox.Margin = new Padding(2);
            LastNameTextbox.Name = "LastNameTextbox";
            LastNameTextbox.ReadOnly = true;
            LastNameTextbox.Size = new Size(347, 27);
            LastNameTextbox.TabIndex = 13;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.BackColor = Color.FromArgb(208, 213, 238);
            PasswordTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextbox.Location = new Point(30, 263);
            PasswordTextbox.Margin = new Padding(2);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.ReadOnly = true;
            PasswordTextbox.Size = new Size(322, 27);
            PasswordTextbox.TabIndex = 14;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(919, 349);
            Controls.Add(PasswordTextbox);
            Controls.Add(LastNameTextbox);
            Controls.Add(FirstNameTextbox);
            Controls.Add(PasswordLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(ProfileLabel);
            Controls.Add(SaveButton);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(homepageBanner);
            Margin = new Padding(2);
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            homepageBanner.ResumeLayout(false);
            homepageBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel homepageBanner;
        private PictureBox ProfilePictureBox;
        private Label uttendanceLabel;
        private Button DeleteButton;
        private Button EditButton;
        private Button SaveButton;
        private Label ProfileLabel;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label PasswordLabel;
        private TextBox FirstNameTextbox;
        private TextBox LastNameTextbox;
        private TextBox PasswordTextbox;
    }
}