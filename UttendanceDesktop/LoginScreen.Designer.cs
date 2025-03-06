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
            panel1 = new Panel();
            label2 = new Label();
            pwdTxtBox = new TextBox();
            label1 = new Label();
            netIDLabel = new Label();
            panel2 = new Panel();
            welcomeLabel2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // netIDTxtBox
            // 
            netIDTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            netIDTxtBox.Font = new Font("Segoe UI", 25F);
            netIDTxtBox.ForeColor = SystemColors.InactiveCaption;
            netIDTxtBox.Location = new Point(156, 663);
            netIDTxtBox.Name = "netIDTxtBox";
            netIDTxtBox.Size = new Size(737, 74);
            netIDTxtBox.TabIndex = 0;
            netIDTxtBox.Text = "Enter your NetID";
            netIDTxtBox.Enter += netIDTxtBox_Enter;
            netIDTxtBox.Leave += netIDTxtBox_Leave;
            // 
            // welcomeLabel1
            // 
            welcomeLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            welcomeLabel1.AutoSize = true;
            welcomeLabel1.BackColor = Color.Transparent;
            welcomeLabel1.Font = new Font("Segoe UI", 40F);
            welcomeLabel1.ForeColor = Color.FromArgb(50, 56, 87);
            welcomeLabel1.Location = new Point(279, 298);
            welcomeLabel1.Name = "welcomeLabel1";
            welcomeLabel1.Size = new Size(469, 106);
            welcomeLabel1.TabIndex = 1;
            welcomeLabel1.Text = "Welcome to";
            welcomeLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignInBtn
            // 
            SignInBtn.BackColor = Color.FromArgb(233, 117, 2);
            SignInBtn.Font = new Font("Segoe UI", 20F);
            SignInBtn.ForeColor = Color.White;
            SignInBtn.Location = new Point(156, 1081);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(737, 86);
            SignInBtn.TabIndex = 2;
            SignInBtn.Text = "Sign In";
            SignInBtn.UseVisualStyleBackColor = false;
            SignInBtn.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(235, 166, 176, 230);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SignInBtn);
            panel1.Controls.Add(pwdTxtBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(netIDLabel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(welcomeLabel2);
            panel1.Controls.Add(netIDTxtBox);
            panel1.Controls.Add(welcomeLabel1);
            panel1.Location = new Point(63, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 1413);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.FromArgb(88, 108, 168);
            label2.Location = new Point(156, 781);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // pwdTxtBox
            // 
            pwdTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pwdTxtBox.Font = new Font("Segoe UI", 25F);
            pwdTxtBox.ForeColor = SystemColors.InactiveCaption;
            pwdTxtBox.Location = new Point(156, 835);
            pwdTxtBox.Name = "pwdTxtBox";
            pwdTxtBox.Size = new Size(737, 74);
            pwdTxtBox.TabIndex = 6;
            pwdTxtBox.Text = "Enter your Password";
            pwdTxtBox.Enter += pwdTxtBox_Enter;
            pwdTxtBox.Leave += pwdTxtBox_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(88, 108, 168);
            label1.Location = new Point(279, 536);
            label1.Name = "label1";
            label1.Size = new Size(489, 41);
            label1.TabIndex = 5;
            label1.Text = "You're free from eLearning Quizzes!";
            // 
            // netIDLabel
            // 
            netIDLabel.AutoSize = true;
            netIDLabel.BackColor = Color.Transparent;
            netIDLabel.Font = new Font("Segoe UI", 15F);
            netIDLabel.ForeColor = Color.FromArgb(88, 108, 168);
            netIDLabel.Location = new Point(156, 609);
            netIDLabel.Name = "netIDLabel";
            netIDLabel.Size = new Size(95, 41);
            netIDLabel.TabIndex = 4;
            netIDLabel.Text = "NetID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Github;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(430, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(146, 136);
            panel2.TabIndex = 3;
            // 
            // welcomeLabel2
            // 
            welcomeLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            welcomeLabel2.AutoSize = true;
            welcomeLabel2.BackColor = Color.Transparent;
            welcomeLabel2.Font = new Font("Segoe UI", 40F);
            welcomeLabel2.ForeColor = Color.FromArgb(50, 56, 87);
            welcomeLabel2.Location = new Point(295, 404);
            welcomeLabel2.Name = "welcomeLabel2";
            welcomeLabel2.Size = new Size(453, 106);
            welcomeLabel2.TabIndex = 2;
            welcomeLabel2.Text = "Uttendance";
            welcomeLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            BackgroundImage = Properties.Resources.LoginBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2538, 1544);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "LoginScreen";
            Text = "Uttendance";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox netIDTxtBox;
        private Label welcomeLabel1;
        private Button SignInBtn;
        private Panel panel1;
        private Label welcomeLabel2;
        private Panel panel2;
        private Label netIDLabel;
        private Label label2;
        private TextBox pwdTxtBox;
        private Label label1;
    }
}
