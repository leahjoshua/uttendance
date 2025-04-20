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
            homepageBanner.Location = new Point(2, 12);
            homepageBanner.Name = "homepageBanner";
            homepageBanner.Size = new Size(1313, 125);
            homepageBanner.TabIndex = 3;
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.Image = Properties.Resources.homepageprofilepic;
            ProfilePictureBox.Location = new Point(1218, 32);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(70, 69);
            ProfilePictureBox.TabIndex = 1;
            ProfilePictureBox.TabStop = false;
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
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(146, 67, 133);
            DeleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(914, 145);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(169, 63);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(234, 117, 7);
            EditButton.Font = new Font("Afacad", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(1130, 145);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(160, 63);
            EditButton.TabIndex = 5;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(24, 162, 104);
            SaveButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(1047, 163);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(169, 63);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Visible = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.Font = new Font("Afacad Medium", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileLabel.Location = new Point(30, 140);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(173, 75);
            ProfileLabel.TabIndex = 7;
            ProfileLabel.Text = "Profile";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Afacad", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameLabel.Location = new Point(43, 240);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(116, 32);
            FirstNameLabel.TabIndex = 8;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Afacad", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameLabel.Location = new Point(573, 240);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(117, 32);
            LastNameLabel.TabIndex = 9;
            LastNameLabel.Text = "Last Name";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Afacad", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(43, 377);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(103, 32);
            PasswordLabel.TabIndex = 11;
            PasswordLabel.Text = "Password";
            // 
            // FirstNameTextbox
            // 
            FirstNameTextbox.BackColor = Color.FromArgb(208, 213, 238);
            FirstNameTextbox.Location = new Point(43, 275);
            FirstNameTextbox.Name = "FirstNameTextbox";
            FirstNameTextbox.ReadOnly = true;
            FirstNameTextbox.Size = new Size(458, 31);
            FirstNameTextbox.TabIndex = 12;
            // 
            // LastNameTextbox
            // 
            LastNameTextbox.BackColor = Color.FromArgb(208, 213, 238);
            LastNameTextbox.Location = new Point(573, 275);
            LastNameTextbox.Name = "LastNameTextbox";
            LastNameTextbox.ReadOnly = true;
            LastNameTextbox.Size = new Size(494, 31);
            LastNameTextbox.TabIndex = 13;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.BackColor = Color.FromArgb(208, 213, 238);
            PasswordTextbox.Location = new Point(43, 412);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.ReadOnly = true;
            PasswordTextbox.Size = new Size(458, 31);
            PasswordTextbox.TabIndex = 14;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(1313, 690);
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
            Name = "EditProfile";
            Text = "EditProfile";
            homepageBanner.ResumeLayout(false);
            homepageBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel homepageBanner;
        //private Button EditProfileButton;
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