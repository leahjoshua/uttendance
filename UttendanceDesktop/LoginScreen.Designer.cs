namespace UttendanceDesktop
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            netIDTxtBox = new TextBox();
            welcomeLabel1 = new Label();
            SignInBtn = new Button();
            logInPanel = new Panel();
            rmbrMeCheck = new CheckBox();
            createAccount = new LinkLabel();
            label2 = new Label();
            pwdTxtBox = new TextBox();
            label1 = new Label();
            netIDLabel = new Label();
            panel2 = new Panel();
            welcomeLabel2 = new Label();
            createAccountPanel = new Panel();
            backToLoginLink = new LinkLabel();
            createAccountBtn = new Button();
            createPwd = new TextBox();
            label8 = new Label();
            createNetID = new TextBox();
            label7 = new Label();
            createLName = new TextBox();
            label6 = new Label();
            createFName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            logInPanel.SuspendLayout();
            createAccountPanel.SuspendLayout();
            SuspendLayout();
            // 
            // netIDTxtBox
            // 
            netIDTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            netIDTxtBox.Font = new Font("Segoe UI", 15F);
            netIDTxtBox.ForeColor = SystemColors.InactiveCaption;
            netIDTxtBox.Location = new Point(67, 259);
            netIDTxtBox.Margin = new Padding(1);
            netIDTxtBox.Name = "netIDTxtBox";
            netIDTxtBox.Size = new Size(259, 34);
            netIDTxtBox.TabIndex = 0;
            netIDTxtBox.Text = "Enter your NetID";
            netIDTxtBox.Enter += netIDTxtBox_Enter;
            netIDTxtBox.Leave += netIDTxtBox_Leave;
            // 
            // welcomeLabel1
            // 
            welcomeLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            welcomeLabel1.AutoSize = true;
            welcomeLabel1.BackColor = Color.Transparent;
            welcomeLabel1.Font = new Font("Segoe UI", 30F);
            welcomeLabel1.ForeColor = Color.FromArgb(50, 56, 87);
            welcomeLabel1.Location = new Point(74, 112);
            welcomeLabel1.Margin = new Padding(1, 0, 1, 0);
            welcomeLabel1.Name = "welcomeLabel1";
            welcomeLabel1.Size = new Size(233, 54);
            welcomeLabel1.TabIndex = 1;
            welcomeLabel1.Text = "Welcome to";
            welcomeLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignInBtn
            // 
            SignInBtn.Anchor = AnchorStyles.Bottom;
            SignInBtn.BackColor = Color.FromArgb(233, 117, 2);
            SignInBtn.FlatAppearance.BorderSize = 0;
            SignInBtn.FlatStyle = FlatStyle.Flat;
            SignInBtn.Font = new Font("Segoe UI", 15F);
            SignInBtn.ForeColor = Color.White;
            SignInBtn.Location = new Point(67, 425);
            SignInBtn.Margin = new Padding(1);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(258, 36);
            SignInBtn.TabIndex = 2;
            SignInBtn.Text = "Sign In";
            SignInBtn.UseVisualStyleBackColor = false;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // logInPanel
            // 
            logInPanel.BackColor = Color.FromArgb(235, 166, 176, 230);
            logInPanel.Controls.Add(rmbrMeCheck);
            logInPanel.Controls.Add(createAccount);
            logInPanel.Controls.Add(label2);
            logInPanel.Controls.Add(SignInBtn);
            logInPanel.Controls.Add(pwdTxtBox);
            logInPanel.Controls.Add(label1);
            logInPanel.Controls.Add(netIDLabel);
            logInPanel.Controls.Add(panel2);
            logInPanel.Controls.Add(welcomeLabel2);
            logInPanel.Controls.Add(netIDTxtBox);
            logInPanel.Controls.Add(welcomeLabel1);
            logInPanel.Location = new Point(22, 19);
            logInPanel.Margin = new Padding(1);
            logInPanel.Name = "logInPanel";
            logInPanel.Size = new Size(386, 539);
            logInPanel.TabIndex = 3;
            // 
            // rmbrMeCheck
            // 
            rmbrMeCheck.AutoSize = true;
            rmbrMeCheck.BackColor = Color.Transparent;
            rmbrMeCheck.Location = new Point(67, 385);
            rmbrMeCheck.Margin = new Padding(1);
            rmbrMeCheck.Name = "rmbrMeCheck";
            rmbrMeCheck.Size = new Size(104, 19);
            rmbrMeCheck.TabIndex = 9;
            rmbrMeCheck.Text = "Remember Me";
            rmbrMeCheck.UseVisualStyleBackColor = false;
            // 
            // createAccount
            // 
            createAccount.AutoSize = true;
            createAccount.BackColor = Color.Transparent;
            createAccount.LinkColor = Color.FromArgb(146, 67, 133);
            createAccount.Location = new Point(216, 385);
            createAccount.Margin = new Padding(1, 0, 1, 0);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(105, 15);
            createAccount.TabIndex = 8;
            createAccount.TabStop = true;
            createAccount.Text = "Create an Account";
            createAccount.LinkClicked += createAccount_LinkClicked;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(88, 108, 168);
            label2.Location = new Point(67, 306);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // pwdTxtBox
            // 
            pwdTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pwdTxtBox.Font = new Font("Segoe UI", 15F);
            pwdTxtBox.ForeColor = SystemColors.InactiveCaption;
            pwdTxtBox.Location = new Point(67, 331);
            pwdTxtBox.Margin = new Padding(1);
            pwdTxtBox.Name = "pwdTxtBox";
            pwdTxtBox.Size = new Size(259, 34);
            pwdTxtBox.TabIndex = 6;
            pwdTxtBox.Text = "Enter your Password";
            pwdTxtBox.Enter += pwdTxtBox_Enter;
            pwdTxtBox.Leave += pwdTxtBox_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(88, 108, 168);
            label1.Location = new Point(83, 202);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 17);
            label1.TabIndex = 5;
            label1.Text = "You're free from eLearning Quizzes!";
            // 
            // netIDLabel
            // 
            netIDLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            netIDLabel.AutoSize = true;
            netIDLabel.BackColor = Color.Transparent;
            netIDLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            netIDLabel.ForeColor = Color.FromArgb(88, 108, 168);
            netIDLabel.Location = new Point(67, 241);
            netIDLabel.Margin = new Padding(1, 0, 1, 0);
            netIDLabel.Name = "netIDLabel";
            netIDLabel.Size = new Size(47, 17);
            netIDLabel.TabIndex = 4;
            netIDLabel.Text = "Net-ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Github;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(143, 36);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 73);
            panel2.TabIndex = 3;
            // 
            // welcomeLabel2
            // 
            welcomeLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            welcomeLabel2.AutoSize = true;
            welcomeLabel2.BackColor = Color.Transparent;
            welcomeLabel2.Font = new Font("Segoe UI", 30F);
            welcomeLabel2.ForeColor = Color.FromArgb(50, 56, 87);
            welcomeLabel2.Location = new Point(78, 153);
            welcomeLabel2.Margin = new Padding(1, 0, 1, 0);
            welcomeLabel2.Name = "welcomeLabel2";
            welcomeLabel2.Size = new Size(228, 54);
            welcomeLabel2.TabIndex = 2;
            welcomeLabel2.Text = "Uttendance";
            welcomeLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createAccountPanel
            // 
            createAccountPanel.BackColor = Color.FromArgb(235, 166, 176, 230);
            createAccountPanel.Controls.Add(backToLoginLink);
            createAccountPanel.Controls.Add(createAccountBtn);
            createAccountPanel.Controls.Add(createPwd);
            createAccountPanel.Controls.Add(label8);
            createAccountPanel.Controls.Add(createNetID);
            createAccountPanel.Controls.Add(label7);
            createAccountPanel.Controls.Add(createLName);
            createAccountPanel.Controls.Add(label6);
            createAccountPanel.Controls.Add(createFName);
            createAccountPanel.Controls.Add(label5);
            createAccountPanel.Controls.Add(label4);
            createAccountPanel.Controls.Add(label3);
            createAccountPanel.Location = new Point(22, 19);
            createAccountPanel.Margin = new Padding(1);
            createAccountPanel.Name = "createAccountPanel";
            createAccountPanel.Size = new Size(386, 539);
            createAccountPanel.TabIndex = 4;
            // 
            // backToLoginLink
            // 
            backToLoginLink.AutoSize = true;
            backToLoginLink.BackColor = Color.Transparent;
            backToLoginLink.LinkColor = Color.FromArgb(146, 67, 133);
            backToLoginLink.Location = new Point(165, 467);
            backToLoginLink.Margin = new Padding(1, 0, 1, 0);
            backToLoginLink.Name = "backToLoginLink";
            backToLoginLink.Size = new Size(50, 15);
            backToLoginLink.TabIndex = 15;
            backToLoginLink.TabStop = true;
            backToLoginLink.Text = "Go Back";
            backToLoginLink.LinkClicked += backToLoginLink_LinkClicked;
            // 
            // createAccountBtn
            // 
            createAccountBtn.Anchor = AnchorStyles.Bottom;
            createAccountBtn.BackColor = Color.FromArgb(233, 117, 2);
            createAccountBtn.Font = new Font("Segoe UI", 15F);
            createAccountBtn.ForeColor = Color.White;
            createAccountBtn.Location = new Point(67, 414);
            createAccountBtn.Margin = new Padding(1);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(258, 36);
            createAccountBtn.TabIndex = 14;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.UseVisualStyleBackColor = false;
            createAccountBtn.Click += createAccountBtn_Click;
            // 
            // createPwd
            // 
            createPwd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createPwd.Font = new Font("Segoe UI", 15F);
            createPwd.ForeColor = SystemColors.InactiveCaption;
            createPwd.Location = new Point(67, 355);
            createPwd.Margin = new Padding(1);
            createPwd.Name = "createPwd";
            createPwd.Size = new Size(259, 34);
            createPwd.TabIndex = 13;
            createPwd.Text = "Enter your Password";
            createPwd.Enter += createPwd_Enter;
            createPwd.Leave += createPwd_Leave;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(88, 108, 168);
            label8.Location = new Point(67, 335);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 19);
            label8.TabIndex = 12;
            label8.Text = "Password";
            // 
            // createNetID
            // 
            createNetID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createNetID.Font = new Font("Segoe UI", 15F);
            createNetID.ForeColor = SystemColors.InactiveCaption;
            createNetID.Location = new Point(67, 299);
            createNetID.Margin = new Padding(1);
            createNetID.Name = "createNetID";
            createNetID.Size = new Size(259, 34);
            createNetID.TabIndex = 11;
            createNetID.Text = "Enter your NetID";
            createNetID.Enter += createNetID_Enter;
            createNetID.Leave += createNetID_Leave;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(88, 108, 168);
            label7.Location = new Point(67, 277);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 19);
            label7.TabIndex = 10;
            label7.Text = "Net ID";
            // 
            // createLName
            // 
            createLName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createLName.Font = new Font("Segoe UI", 15F);
            createLName.ForeColor = SystemColors.InactiveCaption;
            createLName.Location = new Point(67, 241);
            createLName.Margin = new Padding(1);
            createLName.Name = "createLName";
            createLName.Size = new Size(259, 34);
            createLName.TabIndex = 9;
            createLName.Text = "Enter your Last Name";
            createLName.Enter += createLName_Enter;
            createLName.Leave += createLName_Leave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(88, 108, 168);
            label6.Location = new Point(67, 220);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 8;
            label6.Text = "Last Name";
            // 
            // createFName
            // 
            createFName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createFName.Font = new Font("Segoe UI", 15F);
            createFName.ForeColor = SystemColors.InactiveCaption;
            createFName.Location = new Point(67, 182);
            createFName.Margin = new Padding(1);
            createFName.Name = "createFName";
            createFName.Size = new Size(259, 34);
            createFName.TabIndex = 7;
            createFName.Text = "Enter your First Name";
            createFName.Enter += createFName_Enter;
            createFName.Leave += createFName_Leave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(88, 108, 168);
            label5.Location = new Point(67, 161);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 6;
            label5.Text = "First Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 30F);
            label4.ForeColor = Color.FromArgb(50, 56, 87);
            label4.Location = new Point(104, 86);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 54);
            label4.TabIndex = 3;
            label4.Tag = "";
            label4.Text = "Account";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 30F);
            label3.ForeColor = Color.FromArgb(50, 56, 87);
            label3.Location = new Point(90, 43);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 54);
            label3.TabIndex = 2;
            label3.Tag = "";
            label3.Text = "Create an";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginScreen
            // 
            AcceptButton = SignInBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 56, 87);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 560);
            Controls.Add(logInPanel);
            Controls.Add(createAccountPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(1);
            MaximizeBox = false;
            Name = "LoginScreen";
            StartPosition = FormStartPosition.Manual;
            Text = "Uttendance";
            Load += LoginScreen_Load;
            logInPanel.ResumeLayout(false);
            logInPanel.PerformLayout();
            createAccountPanel.ResumeLayout(false);
            createAccountPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox netIDTxtBox;
        private Label welcomeLabel1;
        private Button SignInBtn;
        private Panel logInPanel;
        private Label welcomeLabel2;
        private Panel panel2;
        private Label netIDLabel;
        private Label label2;
        private TextBox pwdTxtBox;
        private Label label1;
        private LinkLabel createAccount;
        private CheckBox rmbrMeCheck;
        private Panel createAccountPanel;
        private TextBox createFName;
        private Label label5;
        private Label label4;
        private Label label3;
        private LinkLabel backToLoginLink;
        private Button createAccountBtn;
        private TextBox createPwd;
        private Label label8;
        private TextBox createNetID;
        private Label label7;
        private TextBox createLName;
        private Label label6;
    }
}
