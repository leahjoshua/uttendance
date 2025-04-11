using static UttendanceDesktop.GlobalStyle;
using static UttendanceDesktop.GlobalResource;

namespace UttendanceDesktop.CoursepageContent
{
    partial class StudentModule
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
            SuspendLayout();
            // 
            // LNameLabel
            // 
            LNameLabel.AutoSize = true;
            LNameLabel.Font = new Font("Segoe UI", 10F);
            LNameLabel.ForeColor = Color.FromArgb(37, 42, 69);
            LNameLabel.Location = new Point(21, 25);
            LNameLabel.Name = "LNameLabel";
            LNameLabel.Size = new Size(74, 19);
            LNameLabel.TabIndex = 0;
            LNameLabel.Text = "Last Name";
            // 
            // FNameLabel
            // 
            FNameLabel.AutoSize = true;
            FNameLabel.Font = new Font("Segoe UI", 10F);
            FNameLabel.ForeColor = Color.FromArgb(37, 42, 69);
            FNameLabel.Location = new Point(188, 25);
            FNameLabel.Name = "FNameLabel";
            FNameLabel.Size = new Size(75, 19);
            FNameLabel.TabIndex = 1;
            FNameLabel.Text = "First Name";
            // 
            // netIDLabel
            // 
            netIDLabel.AutoSize = true;
            netIDLabel.Font = new Font("Segoe UI", 10F);
            netIDLabel.ForeColor = Color.FromArgb(37, 42, 69);
            netIDLabel.Location = new Point(352, 25);
            netIDLabel.Name = "netIDLabel";
            netIDLabel.Size = new Size(51, 19);
            netIDLabel.TabIndex = 2;
            netIDLabel.Text = "Net-ID";
            // 
            // utdIDLabel
            // 
            utdIDLabel.AutoSize = true;
            utdIDLabel.Font = new Font("Segoe UI", 10F);
            utdIDLabel.ForeColor = Color.FromArgb(37, 42, 69);
            utdIDLabel.Location = new Point(484, 25);
            utdIDLabel.Name = "utdIDLabel";
            utdIDLabel.Size = new Size(56, 19);
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
            addBtn.Location = new Point(507, 114);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(89, 30);
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
            cancelBtn.Location = new Point(394, 114);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(89, 30);
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
            // StudentModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(617, 159);
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
            Name = "StudentModule";
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
    }
}