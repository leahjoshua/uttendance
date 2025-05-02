namespace UttendanceDesktop.CoursepageContent
{
    partial class AttendanceForms_Details
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
            flowLayoutPanel = new FlowLayoutPanel();
            questionItem1 = new UttendanceDesktop.CoursepageContent.QuestionItem.QuestionItem();
            questionsLabel = new Label();
            SaveEditIcon = new Button();
            detailsLabel = new Label();
            submissionPanel = new Panel();
            formTitleLabel = new Label();
            addQuestionBtn = new Button();
            importQuestionBtn = new Button();
            openOptionsBtn = new Button();
            pwdTxtBox = new TextBox();
            label3 = new Label();
            closeTimePicker = new DateTimePicker();
            label4 = new Label();
            releaseTimePicker = new DateTimePicker();
            label1 = new Label();
            saveEditBtn = new Button();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(questionItem1);
            flowLayoutPanel.Location = new Point(57, 444);
            flowLayoutPanel.MaximumSize = new Size(900, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(900, 84);
            flowLayoutPanel.TabIndex = 19;
            // 
            // questionItem1
            // 
            questionItem1.AnswerList = null;
            questionItem1.AutoSize = true;
            questionItem1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            questionItem1.BackColor = Color.FromArgb(50, 56, 87);
            questionItem1.IsBankQuestion = false;
            questionItem1.IsChecked = false;
            questionItem1.IsEditable = true;
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
            // questionsLabel
            // 
            questionsLabel.AutoSize = true;
            questionsLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            questionsLabel.Location = new Point(57, 411);
            questionsLabel.Name = "questionsLabel";
            questionsLabel.Size = new Size(166, 30);
            questionsLabel.TabIndex = 18;
            questionsLabel.Text = "Form Questions";
            // 
            // SaveEditIcon
            // 
            SaveEditIcon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveEditIcon.BackColor = Color.FromArgb(0, 192, 0);
            SaveEditIcon.FlatAppearance.BorderColor = Color.White;
            SaveEditIcon.FlatAppearance.BorderSize = 2;
            SaveEditIcon.FlatStyle = FlatStyle.Flat;
            SaveEditIcon.Location = new Point(1117, 1788);
            SaveEditIcon.Name = "SaveEditIcon";
            SaveEditIcon.Size = new Size(40, 40);
            SaveEditIcon.TabIndex = 20;
            SaveEditIcon.UseVisualStyleBackColor = false;
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            detailsLabel.Location = new Point(57, 101);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(77, 30);
            detailsLabel.TabIndex = 21;
            detailsLabel.Text = "Details";
            // 
            // submissionPanel
            // 
            submissionPanel.BackColor = SystemColors.Control;
            submissionPanel.Location = new Point(57, 134);
            submissionPanel.Name = "submissionPanel";
            submissionPanel.Size = new Size(285, 257);
            submissionPanel.TabIndex = 22;
            // 
            // formTitleLabel
            // 
            formTitleLabel.AutoSize = true;
            formTitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formTitleLabel.ForeColor = Color.FromArgb(37, 42, 69);
            formTitleLabel.Location = new Point(57, 39);
            formTitleLabel.Name = "formTitleLabel";
            formTitleLabel.Size = new Size(387, 41);
            formTitleLabel.TabIndex = 24;
            formTitleLabel.Text = "XX/XX/XX Attendance Form";
            // 
            // addQuestionBtn
            // 
            addQuestionBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addQuestionBtn.BackColor = Color.FromArgb(224, 224, 224);
            addQuestionBtn.FlatStyle = FlatStyle.Flat;
            addQuestionBtn.ForeColor = Color.FromArgb(37, 42, 69);
            addQuestionBtn.Location = new Point(1100, 394);
            addQuestionBtn.Margin = new Padding(3, 4, 3, 4);
            addQuestionBtn.Name = "addQuestionBtn";
            addQuestionBtn.Size = new Size(138, 48);
            addQuestionBtn.TabIndex = 26;
            addQuestionBtn.Text = "Add Question";
            addQuestionBtn.UseVisualStyleBackColor = false;
            addQuestionBtn.Visible = false;
            // 
            // importQuestionBtn
            // 
            importQuestionBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            importQuestionBtn.BackColor = Color.FromArgb(224, 224, 224);
            importQuestionBtn.FlatStyle = FlatStyle.Flat;
            importQuestionBtn.ForeColor = Color.FromArgb(37, 42, 69);
            importQuestionBtn.Location = new Point(1100, 441);
            importQuestionBtn.Margin = new Padding(3, 4, 3, 4);
            importQuestionBtn.Name = "importQuestionBtn";
            importQuestionBtn.Size = new Size(138, 48);
            importQuestionBtn.TabIndex = 27;
            importQuestionBtn.Text = "Import Questions";
            importQuestionBtn.UseVisualStyleBackColor = false;
            importQuestionBtn.Visible = false;
            // 
            // openOptionsBtn
            // 
            openOptionsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            openOptionsBtn.BackColor = Color.FromArgb(166, 176, 230);
            openOptionsBtn.Cursor = Cursors.Hand;
            openOptionsBtn.FlatAppearance.BorderSize = 0;
            openOptionsBtn.FlatStyle = FlatStyle.Flat;
            openOptionsBtn.Image = Properties.Resources.add_icon;
            openOptionsBtn.Location = new Point(1195, 497);
            openOptionsBtn.Margin = new Padding(3, 4, 3, 4);
            openOptionsBtn.Name = "openOptionsBtn";
            openOptionsBtn.Size = new Size(43, 43);
            openOptionsBtn.TabIndex = 25;
            openOptionsBtn.UseVisualStyleBackColor = false;
            // 
            // pwdTxtBox
            // 
            pwdTxtBox.Font = new Font("Segoe UI", 10F);
            pwdTxtBox.Location = new Point(373, 299);
            pwdTxtBox.Name = "pwdTxtBox";
            pwdTxtBox.Size = new Size(572, 30);
            pwdTxtBox.TabIndex = 33;
            pwdTxtBox.TextChanged += pwdTxtBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(37, 42, 69);
            label3.Location = new Point(373, 271);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 32;
            label3.Text = "Password";
            // 
            // closeTimePicker
            // 
            closeTimePicker.CustomFormat = "MMMMdd, yyyy  |  hh:mm tt";
            closeTimePicker.Enabled = false;
            closeTimePicker.Format = DateTimePickerFormat.Custom;
            closeTimePicker.Location = new Point(672, 235);
            closeTimePicker.Margin = new Padding(2);
            closeTimePicker.Name = "closeTimePicker";
            closeTimePicker.Size = new Size(273, 27);
            closeTimePicker.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(37, 42, 69);
            label4.Location = new Point(672, 208);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 30;
            label4.Text = "Close Date";
            // 
            // releaseTimePicker
            // 
            releaseTimePicker.CustomFormat = "MMMMdd, yyyy  |  hh:mm tt";
            releaseTimePicker.Enabled = false;
            releaseTimePicker.Format = DateTimePickerFormat.Custom;
            releaseTimePicker.Location = new Point(373, 235);
            releaseTimePicker.Margin = new Padding(2);
            releaseTimePicker.Name = "releaseTimePicker";
            releaseTimePicker.Size = new Size(273, 27);
            releaseTimePicker.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.FromArgb(37, 42, 69);
            label1.Location = new Point(373, 208);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 28;
            label1.Text = "Release Date";
            // 
            // saveEditBtn
            // 
            saveEditBtn.BackColor = Color.FromArgb(255, 128, 0);
            saveEditBtn.FlatStyle = FlatStyle.Flat;
            saveEditBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveEditBtn.ForeColor = SystemColors.Control;
            saveEditBtn.Location = new Point(373, 354);
            saveEditBtn.Name = "saveEditBtn";
            saveEditBtn.Size = new Size(94, 37);
            saveEditBtn.TabIndex = 34;
            saveEditBtn.Text = "Edit";
            saveEditBtn.UseVisualStyleBackColor = false;
            saveEditBtn.Click += saveEditBtn_Click;
            // 
            // AttendanceForms_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(1250, 553);
            Controls.Add(saveEditBtn);
            Controls.Add(pwdTxtBox);
            Controls.Add(label3);
            Controls.Add(closeTimePicker);
            Controls.Add(label4);
            Controls.Add(releaseTimePicker);
            Controls.Add(label1);
            Controls.Add(addQuestionBtn);
            Controls.Add(importQuestionBtn);
            Controls.Add(openOptionsBtn);
            Controls.Add(formTitleLabel);
            Controls.Add(submissionPanel);
            Controls.Add(detailsLabel);
            Controls.Add(flowLayoutPanel);
            Controls.Add(questionsLabel);
            Controls.Add(SaveEditIcon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttendanceForms_Details";
            Text = "Attendance Form Details";
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private QuestionItem.QuestionItem questionItem1;
        private Label questionsLabel;
        private Label formTitle;
        private Button SaveEditIcon;
        private Label detailsLabel;
        private Panel submissionPanel;
        private Label formTitleLabel;
        private Button addQuestionBtn;
        private Button importQuestionBtn;
        private Button openOptionsBtn;
        private TextBox pwdTxtBox;
        private Label label3;
        private DateTimePicker closeTimePicker;
        private Label label4;
        private DateTimePicker releaseTimePicker;
        private Label label1;
        private Button saveEditBtn;
    }
}