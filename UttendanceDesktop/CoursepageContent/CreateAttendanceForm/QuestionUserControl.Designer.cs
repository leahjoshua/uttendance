namespace UttendanceDesktop.CoursepageContent.CreateAttendanceForm
{
    partial class QuestionUserControl
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
            answersPanel = new Panel();
            choiceDLabel = new Label();
            choiceCLabel = new Label();
            choiceBLabel = new Label();
            choiceALabel = new Label();
            questionNumLabel = new Label();
            borderPanel = new Panel();
            problemStmtLabel = new Label();
            answersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // answersPanel
            // 
            answersPanel.BackColor = Color.FromArgb(222, 225, 241);
            answersPanel.Controls.Add(choiceDLabel);
            answersPanel.Controls.Add(choiceCLabel);
            answersPanel.Controls.Add(choiceBLabel);
            answersPanel.Controls.Add(choiceALabel);
            answersPanel.Location = new Point(19, 184);
            answersPanel.Name = "answersPanel";
            answersPanel.Size = new Size(868, 189);
            answersPanel.TabIndex = 0;
            // 
            // choiceDLabel
            // 
            choiceDLabel.AutoSize = true;
            choiceDLabel.Font = new Font("Segoe UI", 13F);
            choiceDLabel.ForeColor = Color.FromArgb(50, 56, 87);
            choiceDLabel.Location = new Point(10, 127);
            choiceDLabel.Name = "choiceDLabel";
            choiceDLabel.Size = new Size(0, 36);
            choiceDLabel.TabIndex = 7;
            // 
            // choiceCLabel
            // 
            choiceCLabel.AutoSize = true;
            choiceCLabel.Font = new Font("Segoe UI", 13F);
            choiceCLabel.ForeColor = Color.FromArgb(50, 56, 87);
            choiceCLabel.Location = new Point(10, 91);
            choiceCLabel.Name = "choiceCLabel";
            choiceCLabel.Size = new Size(0, 36);
            choiceCLabel.TabIndex = 6;
            // 
            // choiceBLabel
            // 
            choiceBLabel.AutoSize = true;
            choiceBLabel.Font = new Font("Segoe UI", 13F);
            choiceBLabel.ForeColor = Color.FromArgb(50, 56, 87);
            choiceBLabel.Location = new Point(10, 55);
            choiceBLabel.Name = "choiceBLabel";
            choiceBLabel.Size = new Size(0, 36);
            choiceBLabel.TabIndex = 5;
            // 
            // choiceALabel
            // 
            choiceALabel.AutoSize = true;
            choiceALabel.Font = new Font("Segoe UI", 13F);
            choiceALabel.ForeColor = Color.FromArgb(50, 56, 87);
            choiceALabel.Location = new Point(10, 19);
            choiceALabel.Name = "choiceALabel";
            choiceALabel.Size = new Size(0, 36);
            choiceALabel.TabIndex = 4;
            // 
            // questionNumLabel
            // 
            questionNumLabel.AutoSize = true;
            questionNumLabel.Font = new Font("Segoe UI", 13F);
            questionNumLabel.ForeColor = Color.White;
            questionNumLabel.Location = new Point(24, 78);
            questionNumLabel.Name = "questionNumLabel";
            questionNumLabel.Size = new Size(108, 36);
            questionNumLabel.TabIndex = 1;
            questionNumLabel.Text = "20 of 20";
            // 
            // borderPanel
            // 
            borderPanel.BackColor = Color.FromArgb(222, 225, 241);
            borderPanel.Location = new Point(143, 15);
            borderPanel.Name = "borderPanel";
            borderPanel.Size = new Size(4, 150);
            borderPanel.TabIndex = 2;
            // 
            // problemStmtLabel
            // 
            problemStmtLabel.AutoSize = true;
            problemStmtLabel.Font = new Font("Segoe UI", 13F);
            problemStmtLabel.ForeColor = Color.White;
            problemStmtLabel.Location = new Point(168, 15);
            problemStmtLabel.Name = "problemStmtLabel";
            problemStmtLabel.Size = new Size(0, 36);
            problemStmtLabel.TabIndex = 3;
            // 
            // QuestionUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(50, 56, 87);
            Controls.Add(problemStmtLabel);
            Controls.Add(borderPanel);
            Controls.Add(questionNumLabel);
            Controls.Add(answersPanel);
            Name = "QuestionUserControl";
            Size = new Size(908, 392);
            Load += QuestionUserControl_Load;
            answersPanel.ResumeLayout(false);
            answersPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel answersPanel;
        private Label questionNumLabel;
        private Panel borderPanel;
        private Label problemStmtLabel;
        private Label choiceALabel;
        private Label choiceDLabel;
        private Label choiceCLabel;
        private Label choiceBLabel;
    }
}
