namespace UttendanceDesktop.CoursepageContent
{
    partial class CreateAttendanceFormPage
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
            createFormPanel = new Panel();
            pwdTxtBox = new TextBox();
            label3 = new Label();
            saveBtn = new Button();
            questionsListingPanel = new Panel();
            defaultQuestionsTxt = new Label();
            label2 = new Label();
            closeTimePicker = new DateTimePicker();
            label4 = new Label();
            releaseTimePicker = new DateTimePicker();
            label1 = new Label();
            questionBankLabel = new Label();
            attendanceFormsLabel = new Label();
            addQuestionBtn = new Button();
            button1 = new Button();
            createFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // createFormPanel
            // 
            createFormPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createFormPanel.AutoScroll = true;
            createFormPanel.BackColor = Color.FromArgb(166, 176, 230);
            createFormPanel.Controls.Add(button1);
            createFormPanel.Controls.Add(pwdTxtBox);
            createFormPanel.Controls.Add(label3);
            createFormPanel.Controls.Add(saveBtn);
            createFormPanel.Controls.Add(questionsListingPanel);
            createFormPanel.Controls.Add(defaultQuestionsTxt);
            createFormPanel.Controls.Add(label2);
            createFormPanel.Controls.Add(closeTimePicker);
            createFormPanel.Controls.Add(label4);
            createFormPanel.Controls.Add(releaseTimePicker);
            createFormPanel.Controls.Add(label1);
            createFormPanel.Controls.Add(questionBankLabel);
            createFormPanel.Controls.Add(attendanceFormsLabel);
            createFormPanel.Location = new Point(0, 0);
            createFormPanel.Margin = new Padding(2);
            createFormPanel.Name = "createFormPanel";
            createFormPanel.Size = new Size(914, 600);
            createFormPanel.TabIndex = 0;
            // 
            // pwdTxtBox
            // 
            pwdTxtBox.Font = new Font("Segoe UI", 10F);
            pwdTxtBox.Location = new Point(89, 224);
            pwdTxtBox.Name = "pwdTxtBox";
            pwdTxtBox.Size = new Size(575, 30);
            pwdTxtBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(37, 42, 69);
            label3.Location = new Point(89, 192);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(24, 162, 104);
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.Control;
            saveBtn.Location = new Point(742, 54);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 37);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // questionsListingPanel
            // 
            questionsListingPanel.AutoScroll = true;
            questionsListingPanel.Location = new Point(40, 310);
            questionsListingPanel.Margin = new Padding(2);
            questionsListingPanel.Name = "questionsListingPanel";
            questionsListingPanel.Size = new Size(784, 340);
            questionsListingPanel.TabIndex = 3;
            questionsListingPanel.Visible = false;
            // 
            // defaultQuestionsTxt
            // 
            defaultQuestionsTxt.AutoSize = true;
            defaultQuestionsTxt.Font = new Font("Segoe UI", 12F);
            defaultQuestionsTxt.ForeColor = Color.FromArgb(58, 64, 99);
            defaultQuestionsTxt.Location = new Point(89, 310);
            defaultQuestionsTxt.Name = "defaultQuestionsTxt";
            defaultQuestionsTxt.Size = new Size(663, 56);
            defaultQuestionsTxt.TabIndex = 10;
            defaultQuestionsTxt.Text = "Looks like you currently don’t have any questions!\nLeave this section blank if you wish to create a default Attendance Check-in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(37, 42, 69);
            label2.Location = new Point(66, 267);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 9;
            label2.Text = "Quiz Questions";
            // 
            // closeTimePicker
            // 
            closeTimePicker.CustomFormat = "MMMMdd, yyyy  |  hh:mm tt";
            closeTimePicker.Format = DateTimePickerFormat.Custom;
            closeTimePicker.Location = new Point(391, 157);
            closeTimePicker.Margin = new Padding(2);
            closeTimePicker.Name = "closeTimePicker";
            closeTimePicker.Size = new Size(273, 27);
            closeTimePicker.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(37, 42, 69);
            label4.Location = new Point(391, 123);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 7;
            label4.Text = "Close Date";
            // 
            // releaseTimePicker
            // 
            releaseTimePicker.CustomFormat = "MMMMdd, yyyy  |  hh:mm tt";
            releaseTimePicker.Format = DateTimePickerFormat.Custom;
            releaseTimePicker.Location = new Point(89, 157);
            releaseTimePicker.Margin = new Padding(2);
            releaseTimePicker.Name = "releaseTimePicker";
            releaseTimePicker.Size = new Size(273, 27);
            releaseTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(37, 42, 69);
            label1.Location = new Point(89, 123);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 3;
            label1.Text = "Release Date";
            // 
            // questionBankLabel
            // 
            questionBankLabel.AutoSize = true;
            questionBankLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionBankLabel.ForeColor = Color.FromArgb(37, 42, 69);
            questionBankLabel.Location = new Point(66, 91);
            questionBankLabel.Name = "questionBankLabel";
            questionBankLabel.Size = new Size(86, 32);
            questionBankLabel.TabIndex = 2;
            questionBankLabel.Text = "Details";
            // 
            // attendanceFormsLabel
            // 
            attendanceFormsLabel.AutoSize = true;
            attendanceFormsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceFormsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            attendanceFormsLabel.Location = new Point(49, 46);
            attendanceFormsLabel.Name = "attendanceFormsLabel";
            attendanceFormsLabel.Size = new Size(315, 41);
            attendanceFormsLabel.TabIndex = 1;
            attendanceFormsLabel.Text = "New Attendance Form";
            // 
            // addQuestionBtn
            // 
            addQuestionBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addQuestionBtn.BackColor = Color.FromArgb(166, 176, 230);
            addQuestionBtn.Cursor = Cursors.Hand;
            addQuestionBtn.FlatAppearance.BorderSize = 0;
            addQuestionBtn.FlatStyle = FlatStyle.Flat;
            addQuestionBtn.Image = Properties.Resources.add_icon;
            addQuestionBtn.Location = new Point(821, 529);
            addQuestionBtn.Margin = new Padding(3, 4, 3, 4);
            addQuestionBtn.Name = "addQuestionBtn";
            addQuestionBtn.Size = new Size(43, 43);
            addQuestionBtn.TabIndex = 2;
            addQuestionBtn.UseVisualStyleBackColor = false;
            addQuestionBtn.Click += addQuestionBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(88, 101, 160);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(742, 104);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 14;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CreateAttendanceFormPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(addQuestionBtn);
            Controls.Add(createFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateAttendanceFormPage";
            Text = "CreateAttendanceForm";
            createFormPanel.ResumeLayout(false);
            createFormPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel createFormPanel;
        private Label attendanceFormsLabel;
        private Label questionBankLabel;
        private Label label1;
        private DateTimePicker releaseTimePicker;
        private DateTimePicker closeTimePicker;
        private Label label4;
        private Label label2;
        private Button addQuestionBtn;
        private Label defaultQuestionsTxt;
        private Panel questionsListingPanel;
        private Button saveBtn;
        private TextBox pwdTxtBox;
        private Label label3;
        private Button button1;
    }
}