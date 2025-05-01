namespace UttendanceDesktop.CoursepageContent.QuestionItem
{
    partial class QuestionAnswerItem
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
            questionChoiceLabel = new Label();
            questionAnswerLabel = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // questionChoiceLabel
            // 
            questionChoiceLabel.Dock = DockStyle.Left;
            questionChoiceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            questionChoiceLabel.ForeColor = Color.FromArgb(50, 56, 87);
            questionChoiceLabel.Location = new Point(5, 5);
            questionChoiceLabel.Margin = new Padding(5);
            questionChoiceLabel.Name = "questionChoiceLabel";
            questionChoiceLabel.Size = new Size(40, 43);
            questionChoiceLabel.TabIndex = 8;
            questionChoiceLabel.Text = "X";
            questionChoiceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // questionAnswerLabel
            // 
            questionAnswerLabel.AutoSize = true;
            questionAnswerLabel.Dock = DockStyle.Left;
            questionAnswerLabel.Font = new Font("Segoe UI", 10F);
            questionAnswerLabel.ForeColor = Color.FromArgb(50, 56, 87);
            questionAnswerLabel.Location = new Point(55, 5);
            questionAnswerLabel.Margin = new Padding(5);
            questionAnswerLabel.MaximumSize = new Size(640, 0);
            questionAnswerLabel.MinimumSize = new Size(640, 40);
            questionAnswerLabel.Name = "questionAnswerLabel";
            questionAnswerLabel.Padding = new Padding(10);
            questionAnswerLabel.Size = new Size(640, 43);
            questionAnswerLabel.TabIndex = 9;
            questionAnswerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel.Controls.Add(questionChoiceLabel);
            flowLayoutPanel.Controls.Add(questionAnswerLabel);
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(700, 53);
            flowLayoutPanel.TabIndex = 10;
            // 
            // QuestionAnswerItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(222, 225, 241);
            Controls.Add(flowLayoutPanel);
            Name = "QuestionAnswerItem";
            Size = new Size(703, 56);
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label questionChoiceLabel;
        private Label questionAnswerLabel;
        private FlowLayoutPanel flowLayoutPanel;
    }
}
