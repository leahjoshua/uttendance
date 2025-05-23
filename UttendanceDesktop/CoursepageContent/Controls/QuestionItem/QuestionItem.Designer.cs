﻿namespace UttendanceDesktop.CoursepageContent.QuestionItem
{
    partial class QuestionItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topFlowLayout = new FlowLayoutPanel();
            checkbox = new CheckBox();
            questionChoiceLabel = new Label();
            splitter1 = new Splitter();
            QuestionLabel = new Label();
            correctLabel = new Button();
            submittedLabel = new Button();
            TopPanel = new Panel();
            editButton = new Button();
            answerChoiceTable = new TableLayoutPanel();
            questionAnswerItem1 = new QuestionAnswerItem();
            questionAnswerItem2 = new QuestionAnswerItem();
            topFlowLayout.SuspendLayout();
            TopPanel.SuspendLayout();
            answerChoiceTable.SuspendLayout();
            SuspendLayout();
            // 
            // topFlowLayout
            // 
            topFlowLayout.AutoSize = true;
            topFlowLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            topFlowLayout.BackColor = Color.FromArgb(50, 56, 87);
            topFlowLayout.Controls.Add(checkbox);
            topFlowLayout.Controls.Add(questionChoiceLabel);
            topFlowLayout.Controls.Add(splitter1);
            topFlowLayout.Controls.Add(QuestionLabel);
            topFlowLayout.Dock = DockStyle.Top;
            topFlowLayout.Location = new Point(0, 0);
            topFlowLayout.MaximumSize = new Size(700, 0);
            topFlowLayout.Name = "topFlowLayout";
            topFlowLayout.Size = new Size(550, 135);
            topFlowLayout.TabIndex = 12;
            topFlowLayout.Click += topFlowLayout_Click;
            // 
            // checkbox
            // 
            checkbox.Appearance = Appearance.Button;
            checkbox.Dock = DockStyle.Left;
            checkbox.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            checkbox.FlatAppearance.BorderSize = 2;
            checkbox.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            checkbox.FlatStyle = FlatStyle.Flat;
            checkbox.Font = new Font("Segoe UI", 20F);
            checkbox.ForeColor = Color.FromArgb(255, 128, 0);
            checkbox.Location = new Point(14, 20);
            checkbox.Margin = new Padding(14, 20, 14, 20);
            checkbox.MaximumSize = new Size(40, 40);
            checkbox.MinimumSize = new Size(40, 40);
            checkbox.Name = "checkbox";
            checkbox.Padding = new Padding(10);
            checkbox.Size = new Size(40, 40);
            checkbox.TabIndex = 13;
            checkbox.TextAlign = ContentAlignment.MiddleCenter;
            checkbox.UseVisualStyleBackColor = true;
            checkbox.CheckedChanged += checkbox_CheckedChanged;
            // 
            // questionChoiceLabel
            // 
            questionChoiceLabel.Dock = DockStyle.Left;
            questionChoiceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            questionChoiceLabel.ForeColor = Color.FromArgb(222, 225, 241);
            questionChoiceLabel.Location = new Point(73, 5);
            questionChoiceLabel.Margin = new Padding(5);
            questionChoiceLabel.MinimumSize = new Size(0, 64);
            questionChoiceLabel.Name = "questionChoiceLabel";
            questionChoiceLabel.Size = new Size(60, 125);
            questionChoiceLabel.TabIndex = 9;
            questionChoiceLabel.Text = "0";
            questionChoiceLabel.TextAlign = ContentAlignment.MiddleCenter;
            questionChoiceLabel.Click += questionChoiceLabel_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(141, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 129);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Dock = DockStyle.Left;
            QuestionLabel.Font = new Font("Segoe UI", 10F);
            QuestionLabel.ForeColor = Color.FromArgb(222, 225, 241);
            QuestionLabel.Location = new Point(148, 0);
            QuestionLabel.Margin = new Padding(0);
            QuestionLabel.MaximumSize = new Size(400, 0);
            QuestionLabel.MinimumSize = new Size(375, 0);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Padding = new Padding(10);
            QuestionLabel.Size = new Size(394, 135);
            QuestionLabel.TabIndex = 11;
            QuestionLabel.Text = "Question answer\r\n edfkn df df ldfjld f df ld f dlfjdl fl d fld fld l dl dlf dlf df  df ld kehfke rker fe rkef rek fe rfke rfker f ekr fke rker fe fker fke fr ferk f\r\n fl df dl dlf dl fd fdl f";
            QuestionLabel.TextAlign = ContentAlignment.MiddleLeft;
            QuestionLabel.Click += QuestionLabel_Click;
            // 
            // correctLabel
            // 
            correctLabel.BackColor = Color.FromArgb(24, 162, 105);
            correctLabel.Dock = DockStyle.Right;
            correctLabel.FlatAppearance.BorderColor = Color.FromArgb(50, 56, 87);
            correctLabel.FlatAppearance.BorderSize = 10;
            correctLabel.FlatStyle = FlatStyle.Flat;
            correctLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            correctLabel.ForeColor = SystemColors.ButtonFace;
            correctLabel.Location = new Point(550, 0);
            correctLabel.Margin = new Padding(10);
            correctLabel.MaximumSize = new Size(80, 80);
            correctLabel.MinimumSize = new Size(80, 80);
            correctLabel.Name = "correctLabel";
            correctLabel.Size = new Size(80, 80);
            correctLabel.TabIndex = 14;
            correctLabel.Text = "0";
            correctLabel.UseVisualStyleBackColor = false;
            // 
            // submittedLabel
            // 
            submittedLabel.BackColor = Color.FromArgb(88, 101, 168);
            submittedLabel.Dock = DockStyle.Right;
            submittedLabel.FlatAppearance.BorderColor = Color.FromArgb(50, 56, 87);
            submittedLabel.FlatAppearance.BorderSize = 10;
            submittedLabel.FlatStyle = FlatStyle.Flat;
            submittedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            submittedLabel.ForeColor = SystemColors.ButtonFace;
            submittedLabel.Location = new Point(630, 0);
            submittedLabel.Margin = new Padding(10);
            submittedLabel.MaximumSize = new Size(80, 80);
            submittedLabel.MinimumSize = new Size(80, 80);
            submittedLabel.Name = "submittedLabel";
            submittedLabel.Size = new Size(80, 80);
            submittedLabel.TabIndex = 15;
            submittedLabel.Text = "0";
            submittedLabel.UseVisualStyleBackColor = false;
            // 
            // TopPanel
            // 
            TopPanel.AutoSize = true;
            TopPanel.BackColor = Color.Transparent;
            TopPanel.Controls.Add(topFlowLayout);
            TopPanel.Controls.Add(correctLabel);
            TopPanel.Controls.Add(submittedLabel);
            TopPanel.Controls.Add(editButton);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(5, 5);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(790, 135);
            TopPanel.TabIndex = 12;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Transparent;
            editButton.BackgroundImage = Properties.Resources.icons8_pencil_96;
            editButton.BackgroundImageLayout = ImageLayout.Zoom;
            editButton.Dock = DockStyle.Right;
            editButton.FlatAppearance.BorderColor = Color.FromArgb(50, 56, 87);
            editButton.FlatAppearance.BorderSize = 20;
            editButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 52, 80);
            editButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 52, 80);
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.ForeColor = Color.Transparent;
            editButton.Location = new Point(710, 0);
            editButton.Margin = new Padding(14);
            editButton.MaximumSize = new Size(80, 80);
            editButton.MinimumSize = new Size(80, 80);
            editButton.Name = "editButton";
            editButton.Size = new Size(80, 80);
            editButton.TabIndex = 14;
            editButton.UseVisualStyleBackColor = false;
            editButton.UseWaitCursor = true;
            editButton.Click += editButton_Click;
            // 
            // answerChoiceTable
            // 
            answerChoiceTable.AutoSize = true;
            answerChoiceTable.BackColor = Color.FromArgb(222, 225, 241);
            answerChoiceTable.ColumnCount = 1;
            answerChoiceTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            answerChoiceTable.Controls.Add(questionAnswerItem1, 0, 0);
            answerChoiceTable.Controls.Add(questionAnswerItem2, 0, 1);
            answerChoiceTable.Dock = DockStyle.Top;
            answerChoiceTable.Location = new Point(5, 140);
            answerChoiceTable.Name = "answerChoiceTable";
            answerChoiceTable.Padding = new Padding(16, 0, 16, 0);
            answerChoiceTable.RowCount = 2;
            answerChoiceTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            answerChoiceTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            answerChoiceTable.Size = new Size(790, 124);
            answerChoiceTable.TabIndex = 13;
            // 
            // questionAnswerItem1
            // 
            questionAnswerItem1.AnswerID = 0;
            questionAnswerItem1.AnswerValue = "Hellow";
            questionAnswerItem1.AutoSize = true;
            questionAnswerItem1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            questionAnswerItem1.BackColor = Color.FromArgb(222, 225, 241);
            questionAnswerItem1.ChoiceLetter = 'A';
            questionAnswerItem1.IsCorrect = false;
            questionAnswerItem1.Location = new Point(19, 3);
            questionAnswerItem1.Name = "questionAnswerItem1";
            questionAnswerItem1.Size = new Size(703, 56);
            questionAnswerItem1.TabIndex = 0;
            // 
            // questionAnswerItem2
            // 
            questionAnswerItem2.AnswerID = 0;
            questionAnswerItem2.AnswerValue = "Test Answer";
            questionAnswerItem2.AutoSize = true;
            questionAnswerItem2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            questionAnswerItem2.BackColor = Color.FromArgb(222, 225, 241);
            questionAnswerItem2.ChoiceLetter = 'B';
            questionAnswerItem2.IsCorrect = true;
            questionAnswerItem2.Location = new Point(19, 65);
            questionAnswerItem2.Name = "questionAnswerItem2";
            questionAnswerItem2.Size = new Size(703, 56);
            questionAnswerItem2.TabIndex = 1;
            // 
            // QuestionItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(50, 56, 87);
            Controls.Add(answerChoiceTable);
            Controls.Add(TopPanel);
            Margin = new Padding(0, 5, 0, 5);
            MinimumSize = new Size(800, 0);
            Name = "QuestionItem";
            Padding = new Padding(5);
            Size = new Size(800, 269);
            topFlowLayout.ResumeLayout(false);
            topFlowLayout.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            answerChoiceTable.ResumeLayout(false);
            answerChoiceTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel topFlowLayout;
        private Label questionChoiceLabel;
        private Splitter splitter1;
        private Label QuestionLabel;
        private Panel TopPanel;
        private TableLayoutPanel answerChoiceTable;
        private QuestionAnswerItem questionAnswerItem1;
        private QuestionAnswerItem questionAnswerItem2;
        private CheckBox checkbox;
        private Button editButton;
        private Button correctLabel;
        private Button submittedLabel;
    }
}
