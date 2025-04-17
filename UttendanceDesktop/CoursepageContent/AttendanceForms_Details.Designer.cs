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
            releaseLabel = new Label();
            formTitleLabel = new Label();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(questionItem1);
            flowLayoutPanel.Location = new Point(46, 444);
            flowLayoutPanel.MaximumSize = new Size(779, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(779, 84);
            flowLayoutPanel.TabIndex = 19;
            // 
            // questionItem1
            // 
            questionItem1.AnswerList = null;
            questionItem1.AutoSize = true;
            questionItem1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            questionItem1.BackColor = Color.FromArgb(50, 56, 87);
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
            SaveEditIcon.Location = new Point(742, 1843);
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
            // releaseLabel
            // 
            releaseLabel.AutoSize = true;
            releaseLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            releaseLabel.ForeColor = Color.FromArgb(37, 42, 69);
            releaseLabel.Location = new Point(382, 156);
            releaseLabel.Name = "releaseLabel";
            releaseLabel.Size = new Size(121, 25);
            releaseLabel.TabIndex = 23;
            releaseLabel.Text = "Release Time";
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
            // AttendanceForms_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(896, 553);
            Controls.Add(formTitleLabel);
            Controls.Add(releaseLabel);
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
        private Label releaseLabel;
        private Label formTitleLabel;
    }
}