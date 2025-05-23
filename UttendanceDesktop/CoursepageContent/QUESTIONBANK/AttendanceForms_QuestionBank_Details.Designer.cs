﻿namespace UttendanceDesktop.CoursepageContent
{
    partial class AttendanceForms_QuestionBank_Details
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
            questionsLabel = new Label();
            bankTitleLabel = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            questionItem1 = new UttendanceDesktop.CoursepageContent.QuestionItem.QuestionItem();
            SaveEditIcon = new Button();
            newEditIcon = new Button();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // questionsLabel
            // 
            questionsLabel.AutoSize = true;
            questionsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            questionsLabel.Location = new Point(53, 98);
            questionsLabel.Name = "questionsLabel";
            questionsLabel.Size = new Size(121, 32);
            questionsLabel.TabIndex = 3;
            questionsLabel.Text = "Questions";
            // 
            // bankTitleLabel
            // 
            bankTitleLabel.AutoSize = true;
            bankTitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bankTitleLabel.ForeColor = Color.FromArgb(37, 42, 69);
            bankTitleLabel.Location = new Point(53, 57);
            bankTitleLabel.Name = "bankTitleLabel";
            bankTitleLabel.Size = new Size(75, 41);
            bankTitleLabel.TabIndex = 2;
            bankTitleLabel.Text = "Title";
            bankTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            bankTitleLabel.Click += bankTitleLabel_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.Controls.Add(questionItem1);
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(53, 148);
            flowLayoutPanel.MaximumSize = new Size(900, 0);
            flowLayoutPanel.MinimumSize = new Size(900, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(900, 122);
            flowLayoutPanel.TabIndex = 15;
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
            questionItem1.NumCorrect = 0;
            questionItem1.NumSubmissions = 0;
            questionItem1.Padding = new Padding(5);
            questionItem1.QuestionID = 0;
            questionItem1.QuestionNumber = 0;
            questionItem1.QuestionValue = null;
            questionItem1.Selected = false;
            questionItem1.ShowSubmissionData = false;
            questionItem1.Size = new Size(750, 122);
            questionItem1.TabIndex = 0;
            // 
            // SaveEditIcon
            // 
            SaveEditIcon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveEditIcon.BackColor = Color.FromArgb(0, 192, 0);
            SaveEditIcon.FlatAppearance.BorderColor = Color.White;
            SaveEditIcon.FlatAppearance.BorderSize = 2;
            SaveEditIcon.FlatStyle = FlatStyle.Flat;
            SaveEditIcon.Location = new Point(779, 681);
            SaveEditIcon.Name = "SaveEditIcon";
            SaveEditIcon.Size = new Size(40, 40);
            SaveEditIcon.TabIndex = 16;
            SaveEditIcon.UseVisualStyleBackColor = false;
            // 
            // newEditIcon
            // 
            newEditIcon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newEditIcon.BackColor = Color.Transparent;
            newEditIcon.BackgroundImage = Properties.Resources.add_icon;
            newEditIcon.BackgroundImageLayout = ImageLayout.Zoom;
            newEditIcon.FlatAppearance.BorderColor = Color.White;
            newEditIcon.FlatAppearance.BorderSize = 0;
            newEditIcon.FlatStyle = FlatStyle.Flat;
            newEditIcon.Location = new Point(963, 540);
            newEditIcon.Name = "newEditIcon";
            newEditIcon.Size = new Size(48, 48);
            newEditIcon.TabIndex = 17;
            newEditIcon.UseVisualStyleBackColor = false;
            newEditIcon.Click += newEditIcon_Click;
            // 
            // AttendanceForms_QuestionBank_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(1023, 600);
            Controls.Add(newEditIcon);
            Controls.Add(SaveEditIcon);
            Controls.Add(flowLayoutPanel);
            Controls.Add(questionsLabel);
            Controls.Add(bankTitleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttendanceForms_QuestionBank_Details";
            Text = "QuestionBank_Details";
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionsLabel;
        private Label bankTitleLabel;
        private FlowLayoutPanel flowLayoutPanel;
        private Button SaveEditIcon;
        private QuestionItem.QuestionItem questionItem1;
        private Button newEditIcon;
    }
}