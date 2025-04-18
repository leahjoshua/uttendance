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
            flowLayoutPanel = new FlowLayoutPanel();
            questionItem1 = new UttendanceDesktop.CoursepageContent.QuestionItem.QuestionItem();
            button1 = new Button();
            pwdTxtBox = new TextBox();
            label3 = new Label();
            saveBtn = new Button();
            defaultQuestionsTxt = new Label();
            label2 = new Label();
            closeTimePicker = new DateTimePicker();
            label4 = new Label();
            releaseTimePicker = new DateTimePicker();
            label1 = new Label();
            questionBankLabel = new Label();
            attendanceFormsLabel = new Label();
            openOptionsBtn = new Button();
            addQuestionBtn = new Button();
            importQuestionBtn = new Button();
            createFormPanel.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // createFormPanel
            // 
            createFormPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createFormPanel.AutoScroll = true;
            createFormPanel.BackColor = Color.FromArgb(166, 176, 230);
            createFormPanel.Controls.Add(flowLayoutPanel);
            createFormPanel.Controls.Add(button1);
            createFormPanel.Controls.Add(pwdTxtBox);
            createFormPanel.Controls.Add(label3);
            createFormPanel.Controls.Add(saveBtn);
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
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(questionItem1);
            flowLayoutPanel.Location = new Point(66, 310);
            flowLayoutPanel.MaximumSize = new Size(779, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(779, 84);
            flowLayoutPanel.TabIndex = 20;
            // 
            // questionItem1
            // 
            questionItem1.AnswerList = null;
            questionItem1.AutoSize = true;
            questionItem1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            questionItem1.BackColor = Color.FromArgb(50, 56, 87);
            questionItem1.IsBankQuestion = false;
            questionItem1.IsChecked = false;
            questionItem1.IsSelectable = false;
            questionItem1.Location = new Point(0, 0);
            questionItem1.Margin = new Padding(0);
            questionItem1.MaximumSize = new Size(750, 0);
            questionItem1.MinimumSize = new Size(750, 0);
            questionItem1.Name = "questionItem1";
            questionItem1.Padding = new Padding(5);
            questionItem1.QuestionID = 0;
            questionItem1.QuestionNumber = 0;
            questionItem1.QuestionValue = null;
            questionItem1.Selected = false;
            questionItem1.Size = new Size(750, 84);
            questionItem1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // pwdTxtBox
            // 
            pwdTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            saveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // openOptionsBtn
            // 
            openOptionsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            openOptionsBtn.BackColor = Color.FromArgb(166, 176, 230);
            openOptionsBtn.Cursor = Cursors.Hand;
            openOptionsBtn.FlatAppearance.BorderSize = 0;
            openOptionsBtn.FlatStyle = FlatStyle.Flat;
            openOptionsBtn.Image = Properties.Resources.add_icon;
            openOptionsBtn.Location = new Point(821, 529);
            openOptionsBtn.Margin = new Padding(3, 4, 3, 4);
            openOptionsBtn.Name = "openOptionsBtn";
            openOptionsBtn.Size = new Size(43, 43);
            openOptionsBtn.TabIndex = 2;
            openOptionsBtn.UseVisualStyleBackColor = false;
            openOptionsBtn.Click += addQuestionBtn_Click;
            // 
            // addQuestionBtn
            // 
            addQuestionBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addQuestionBtn.BackColor = Color.FromArgb(224, 224, 224);
            addQuestionBtn.FlatStyle = FlatStyle.Flat;
            addQuestionBtn.ForeColor = Color.FromArgb(37, 42, 69);
            addQuestionBtn.Location = new Point(726, 426);
            addQuestionBtn.Margin = new Padding(3, 4, 3, 4);
            addQuestionBtn.Name = "addQuestionBtn";
            addQuestionBtn.Size = new Size(138, 48);
            addQuestionBtn.TabIndex = 15;
            addQuestionBtn.Text = "Add Question";
            addQuestionBtn.UseVisualStyleBackColor = false;
            addQuestionBtn.Visible = false;
            addQuestionBtn.Click += addQuestionBtn_Click_1;
            // 
            // importQuestionBtn
            // 
            importQuestionBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            importQuestionBtn.BackColor = Color.FromArgb(224, 224, 224);
            importQuestionBtn.FlatStyle = FlatStyle.Flat;
            importQuestionBtn.ForeColor = Color.FromArgb(37, 42, 69);
            importQuestionBtn.Location = new Point(726, 473);
            importQuestionBtn.Margin = new Padding(3, 4, 3, 4);
            importQuestionBtn.Name = "importQuestionBtn";
            importQuestionBtn.Size = new Size(138, 48);
            importQuestionBtn.TabIndex = 16;
            importQuestionBtn.Text = "Import Questions";
            importQuestionBtn.UseVisualStyleBackColor = false;
            importQuestionBtn.Visible = false;
            importQuestionBtn.Click += importQuestionBtn_Click;
            // 
            // CreateAttendanceFormPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(addQuestionBtn);
            Controls.Add(importQuestionBtn);
            Controls.Add(openOptionsBtn);
            Controls.Add(createFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateAttendanceFormPage";
            Text = "CreateAttendanceForm";
            createFormPanel.ResumeLayout(false);
            createFormPanel.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
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
        private Button openOptionsBtn;
        private Label defaultQuestionsTxt;
        private Button saveBtn;
        private TextBox pwdTxtBox;
        private Label label3;
        private Button button1;
        private Button importQuestionBtn;
        private Button addQuestionBtn;
        private FlowLayoutPanel flowLayoutPanel;
        private QuestionItem.QuestionItem questionItem1;
    }
}