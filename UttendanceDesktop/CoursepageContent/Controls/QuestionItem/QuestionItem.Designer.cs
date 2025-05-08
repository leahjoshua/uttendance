namespace UttendanceDesktop.CoursepageContent.QuestionItem
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
            editButton = new Button();
            TopPanel = new Panel();
            answerChoiceTable = new TableLayoutPanel();
            questionAnswerItem1 = new QuestionAnswerItem();
            questionAnswerItem2 = new QuestionAnswerItem();
            editButton = new Button();
            topFlowLayout.SuspendLayout();
            TopPanel.SuspendLayout();
            answerChoiceTable.SuspendLayout();
            SuspendLayout();
            // 
            // topFlowLayout
            // 
            topFlowLayout.AutoSize = true;
            topFlowLayout.BackColor = Color.FromArgb(50, 56, 87);
            topFlowLayout.Controls.Add(checkbox);
            topFlowLayout.Controls.Add(questionChoiceLabel);
            topFlowLayout.Controls.Add(splitter1);
            topFlowLayout.Controls.Add(QuestionLabel);
            topFlowLayout.Dock = DockStyle.Top;
            topFlowLayout.Location = new Point(0, 0);
            topFlowLayout.MaximumSize = new Size(660, 0);
            topFlowLayout.Name = "topFlowLayout";
            topFlowLayout.Size = new Size(660, 78);
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
            checkbox.Location = new Point(14, 14);
            checkbox.Margin = new Padding(14);
            checkbox.MaximumSize = new Size(50, 50);
            checkbox.MinimumSize = new Size(50, 50);
            checkbox.Name = "checkbox";
            checkbox.Padding = new Padding(10);
            checkbox.Size = new Size(50, 50);
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
            questionChoiceLabel.Location = new Point(83, 5);
            questionChoiceLabel.Margin = new Padding(5);
            questionChoiceLabel.MinimumSize = new Size(0, 64);
            questionChoiceLabel.Name = "questionChoiceLabel";
            questionChoiceLabel.Size = new Size(60, 68);
            questionChoiceLabel.TabIndex = 9;
            questionChoiceLabel.Text = "0";
            questionChoiceLabel.TextAlign = ContentAlignment.MiddleCenter;
            questionChoiceLabel.Click += questionChoiceLabel_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(151, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 72);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // QuestionLabel
            // 
            QuestionLabel.Dock = DockStyle.Left;
            QuestionLabel.Font = new Font("Segoe UI", 10F);
            QuestionLabel.ForeColor = Color.FromArgb(222, 225, 241);
            QuestionLabel.Location = new Point(158, 0);
            QuestionLabel.Margin = new Padding(0);
            QuestionLabel.MaximumSize = new Size(500, 0);
            QuestionLabel.MinimumSize = new Size(404, 0);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Padding = new Padding(10);
            QuestionLabel.Size = new Size(500, 78);
            QuestionLabel.TabIndex = 11;
            QuestionLabel.Text = "Question answer\r\n";
            QuestionLabel.TextAlign = ContentAlignment.MiddleLeft;
            QuestionLabel.Click += QuestionLabel_Click;
            // 
            // editButton
            // 
            editButton.Dock = DockStyle.Right;
            editButton.Location = new Point(660, 0);
            editButton.Margin = new Padding(14);
            editButton.Name = "editButton";
            editButton.Size = new Size(80, 78);
            editButton.TabIndex = 14;
            editButton.Text = "edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // TopPanel
            // 
            TopPanel.AutoSize = true;
            TopPanel.BackColor = Color.Transparent;
            TopPanel.Controls.Add(topFlowLayout);
            TopPanel.Controls.Add(editButton);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(5, 5);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(740, 78);
            TopPanel.TabIndex = 12;
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
            answerChoiceTable.Location = new Point(5, 83);
            answerChoiceTable.Name = "answerChoiceTable";
            answerChoiceTable.Padding = new Padding(16, 0, 16, 0);
            answerChoiceTable.RowCount = 2;
            answerChoiceTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            answerChoiceTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            answerChoiceTable.Size = new Size(740, 124);
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
            questionAnswerItem1.Size = new Size(702, 56);
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
            questionAnswerItem2.Size = new Size(702, 56);
            questionAnswerItem2.TabIndex = 1;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Chocolate;
            editButton.Dock = DockStyle.Right;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.Location = new Point(660, 0);
            editButton.Margin = new Padding(14);
            editButton.Name = "editButton";
            editButton.Size = new Size(80, 78);
            editButton.TabIndex = 14;
            editButton.Text = "edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
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
            MaximumSize = new Size(750, 0);
            MinimumSize = new Size(750, 0);
            Name = "QuestionItem";
            Padding = new Padding(5);
            Size = new Size(750, 212);
            topFlowLayout.ResumeLayout(false);
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
    }
}
