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
            questionChoiceLabel = new Label();
            splitter1 = new Splitter();
            QuestionLabel = new Label();
            TopPanel = new Panel();
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
            topFlowLayout.BackColor = Color.FromArgb(50, 56, 87);
            topFlowLayout.Controls.Add(questionChoiceLabel);
            topFlowLayout.Controls.Add(splitter1);
            topFlowLayout.Controls.Add(QuestionLabel);
            topFlowLayout.Dock = DockStyle.Top;
            topFlowLayout.Location = new Point(0, 0);
            topFlowLayout.Name = "topFlowLayout";
            topFlowLayout.Size = new Size(740, 74);
            topFlowLayout.TabIndex = 12;
            topFlowLayout.Click += topFlowLayout_Click;
            // 
            // questionChoiceLabel
            // 
            questionChoiceLabel.Dock = DockStyle.Left;
            questionChoiceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            questionChoiceLabel.ForeColor = Color.FromArgb(222, 225, 241);
            questionChoiceLabel.Location = new Point(5, 5);
            questionChoiceLabel.Margin = new Padding(5);
            questionChoiceLabel.MinimumSize = new Size(0, 64);
            questionChoiceLabel.Name = "questionChoiceLabel";
            questionChoiceLabel.Size = new Size(59, 64);
            questionChoiceLabel.TabIndex = 9;
            questionChoiceLabel.Text = "0";
            questionChoiceLabel.TextAlign = ContentAlignment.MiddleCenter;
            questionChoiceLabel.Click += questionChoiceLabel_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(72, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 68);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Dock = DockStyle.Left;
            QuestionLabel.Font = new Font("Segoe UI", 10F);
            QuestionLabel.ForeColor = Color.FromArgb(222, 225, 241);
            QuestionLabel.Location = new Point(79, 0);
            QuestionLabel.Margin = new Padding(0);
            QuestionLabel.MaximumSize = new Size(660, 0);
            QuestionLabel.MinimumSize = new Size(660, 0);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Padding = new Padding(10);
            QuestionLabel.Size = new Size(660, 74);
            QuestionLabel.TabIndex = 11;
            QuestionLabel.Text = "Question answer\r\n";
            QuestionLabel.TextAlign = ContentAlignment.MiddleLeft;
            QuestionLabel.Click += QuestionLabel_Click;
            // 
            // TopPanel
            // 
            TopPanel.AutoSize = true;
            TopPanel.BackColor = Color.FromArgb(222, 225, 241);
            TopPanel.Controls.Add(topFlowLayout);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(5, 5);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(740, 74);
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
            answerChoiceTable.Location = new Point(5, 79);
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
            Size = new Size(750, 208);
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
    }
}
