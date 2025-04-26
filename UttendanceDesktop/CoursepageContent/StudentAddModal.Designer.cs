using static UttendanceDesktop.GlobalStyle;
using static UttendanceDesktop.GlobalResource;

namespace UttendanceDesktop.CoursepageContent
{
    partial class StudentAddModal
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
            LNameLabel = new Label();
            FNameLabel = new Label();
            netIDLabel = new Label();
            utdIDLabel = new Label();
            createLName = new TextBox();
            createFName = new TextBox();
            createNetID = new TextBox();
            createUTDID = new TextBox();
            addBtn = new Button();
            cancelBtn = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            asterisk1 = new Label();
            asterisk2 = new Label();
            asterisk3 = new Label();
            asterisk4 = new Label();
            SuspendLayout();
            // 
            // LNameLabel
            // 
            LNameLabel.AutoSize = true;
            LNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNameLabel.ForeColor = Color.FromArgb(37, 42, 69);
            LNameLabel.Location = new Point(21, 25);
            LNameLabel.Name = "LNameLabel";
            LNameLabel.Size = new Size(84, 20);
            LNameLabel.TabIndex = 0;
            LNameLabel.Text = "Last Name";
            // 
            // FNameLabel
            // 
            FNameLabel.AutoSize = true;
            FNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FNameLabel.ForeColor = Color.FromArgb(37, 42, 69);
            FNameLabel.Location = new Point(188, 25);
            FNameLabel.Name = "FNameLabel";
            FNameLabel.Size = new Size(86, 20);
            FNameLabel.TabIndex = 1;
            FNameLabel.Text = "First Name";
            // 
            // netIDLabel
            // 
            netIDLabel.AutoSize = true;
            netIDLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            netIDLabel.ForeColor = Color.FromArgb(37, 42, 69);
            netIDLabel.Location = new Point(352, 25);
            netIDLabel.Name = "netIDLabel";
            netIDLabel.Size = new Size(56, 20);
            netIDLabel.TabIndex = 2;
            netIDLabel.Text = "Net-ID";
            // 
            // utdIDLabel
            // 
            utdIDLabel.AutoSize = true;
            utdIDLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            utdIDLabel.ForeColor = Color.FromArgb(37, 42, 69);
            utdIDLabel.Location = new Point(484, 25);
            utdIDLabel.Name = "utdIDLabel";
            utdIDLabel.Size = new Size(62, 20);
            utdIDLabel.TabIndex = 3;
            utdIDLabel.Text = "UTD-ID";
            // 
            // createLName
            // 
            createLName.Font = new Font("Segoe UI", 10F);
            createLName.Location = new Point(21, 47);
            createLName.Name = "createLName";
            createLName.Size = new Size(148, 25);
            createLName.TabIndex = 4;
            // 
            // createFName
            // 
            createFName.Font = new Font("Segoe UI", 10F);
            createFName.Location = new Point(188, 47);
            createFName.Name = "createFName";
            createFName.Size = new Size(144, 25);
            createFName.TabIndex = 5;
            // 
            // createNetID
            // 
            createNetID.Font = new Font("Segoe UI", 10F);
            createNetID.Location = new Point(352, 47);
            createNetID.Name = "createNetID";
            createNetID.Size = new Size(112, 25);
            createNetID.TabIndex = 6;
            // 
            // createUTDID
            // 
            createUTDID.Font = new Font("Segoe UI", 10F);
            createUTDID.Location = new Point(484, 47);
            createUTDID.Name = "createUTDID";
            createUTDID.Size = new Size(112, 25);
            createUTDID.TabIndex = 7;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(223, 117, 2);
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI", 10F);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(507, 103);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(82, 32);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(88, 101, 168);
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 10F);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(414, 103);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(82, 32);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // asterisk1
            // 
            asterisk1.AutoSize = true;
            asterisk1.BackColor = Color.Transparent;
            asterisk1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asterisk1.ForeColor = Color.Red;
            asterisk1.Location = new Point(103, 19);
            asterisk1.Name = "asterisk1";
            asterisk1.Size = new Size(20, 25);
            asterisk1.TabIndex = 11;
            asterisk1.Text = "*";
            // 
            // asterisk2
            // 
            asterisk2.AutoSize = true;
            asterisk2.BackColor = Color.Transparent;
            asterisk2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asterisk2.ForeColor = Color.Red;
            asterisk2.Location = new Point(273, 19);
            asterisk2.Name = "asterisk2";
            asterisk2.Size = new Size(20, 25);
            asterisk2.TabIndex = 12;
            asterisk2.Text = "*";
            // 
            // asterisk3
            // 
            asterisk3.AutoSize = true;
            asterisk3.BackColor = Color.Transparent;
            asterisk3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asterisk3.ForeColor = Color.Red;
            asterisk3.Location = new Point(406, 19);
            asterisk3.Name = "asterisk3";
            asterisk3.Size = new Size(20, 25);
            asterisk3.TabIndex = 13;
            asterisk3.Text = "*";
            // 
            // asterisk4
            // 
            asterisk4.AutoSize = true;
            asterisk4.BackColor = Color.Transparent;
            asterisk4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asterisk4.ForeColor = Color.Red;
            asterisk4.Location = new Point(546, 19);
            asterisk4.Name = "asterisk4";
            asterisk4.Size = new Size(20, 25);
            asterisk4.TabIndex = 14;
            asterisk4.Text = "*";
            // 
            // StudentAddModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(617, 146);
            Controls.Add(asterisk4);
            Controls.Add(asterisk3);
            Controls.Add(asterisk2);
            Controls.Add(asterisk1);
            Controls.Add(cancelBtn);
            Controls.Add(addBtn);
            Controls.Add(createUTDID);
            Controls.Add(createNetID);
            Controls.Add(createFName);
            Controls.Add(createLName);
            Controls.Add(utdIDLabel);
            Controls.Add(netIDLabel);
            Controls.Add(FNameLabel);
            Controls.Add(LNameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StudentAddModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNameLabel;
        private Label FNameLabel;
        private Label netIDLabel;
        private Label utdIDLabel;
        private TextBox createLName;
        private TextBox createFName;
        private TextBox createNetID;
        private TextBox createUTDID;
        private Button addBtn;
        private Button cancelBtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label asterisk1;
        private Label asterisk2;
        private Label asterisk3;
        private Label asterisk4;
    }
}