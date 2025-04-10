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
            panel1 = new Panel();
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
            answersPanel.Location = new Point(15, 147);
            answersPanel.Margin = new Padding(2, 2, 2, 2);
            answersPanel.Name = "answersPanel";
            answersPanel.Size = new Size(694, 151);
            answersPanel.TabIndex = 0;
            // 
            // choiceDLabel
            // 
            choiceDLabel.AutoSize = true;
            choiceDLabel.Font = new Font("Segoe UI", 13F);
            choiceDLabel.ForeColor = Color.FromArgb(50, 56, 87);
            choiceDLabel.Location = new Point(8, 102);
            choiceDLabel.Margin = new Padding(2, 0, 2, 0);
            choiceDLabel.Name = "choiceDLabel";
            choiceDLabel.Size = new Size(0, 30);
            choiceDLabel.TabIndex = 7;
            // 
            // choiceCLabel
            // 
            choiceCLabel.AutoSize = true;
            choiceCLabel.Font = new Font("Segoe UI", 13F);
            choiceCLabel.ForeColor = Color.FromArgb(50, 56, 87);
            choiceCLabel.Location = new Point(8, 73);
            choiceCLabel.Margin = new Padding(2, 0, 2, 0);
            choiceCLabel.Name = "choiceCLabel";
            choiceCLabel.Size = new Size(0, 30);
            choiceCLabel.TabIndex = 6;
            // 
            // choiceBLabel
            // 
            choiceBLabel.AutoSize = true;
            choiceBLabel.Font = new Font("Segoe UI", 13F);
            choiceBLabel.ForeColor = Color.FromArgb(50, 56, 87);
            choiceBLabel.Location = new Point(8, 44);
            choiceBLabel.Margin = new Padding(2, 0, 2, 0);
            choiceBLabel.Name = "choiceBLabel";
            choiceBLabel.Size = new Size(0, 30);
            choiceBLabel.TabIndex = 5;
            // 
            // choiceALabel
            // 
            choiceALabel.AutoSize = true;
            choiceALabel.Font = new Font("Segoe UI", 13F);
            choiceALabel.ForeColor = Color.FromArgb(50, 56, 87);
            choiceALabel.Location = new Point(8, 15);
            choiceALabel.Margin = new Padding(2, 0, 2, 0);
            choiceALabel.Name = "choiceALabel";
            choiceALabel.Size = new Size(0, 30);
            choiceALabel.TabIndex = 4;
            // 
            // questionNumLabel
            // 
            questionNumLabel.AutoSize = true;
            questionNumLabel.Font = new Font("Segoe UI", 13F);
            questionNumLabel.ForeColor = Color.White;
            questionNumLabel.Location = new Point(19, 62);
            questionNumLabel.Margin = new Padding(2, 0, 2, 0);
            questionNumLabel.Name = "questionNumLabel";
            questionNumLabel.Size = new Size(93, 30);
            questionNumLabel.TabIndex = 1;
            questionNumLabel.Text = "20 of 20";
            // 
            // borderPanel
            // 
            borderPanel.BackColor = Color.FromArgb(222, 225, 241);
            borderPanel.Location = new Point(114, 12);
            borderPanel.Margin = new Padding(2, 2, 2, 2);
            borderPanel.Name = "borderPanel";
            borderPanel.Size = new Size(3, 120);
            borderPanel.TabIndex = 2;
            // 
            // problemStmtLabel
            // 
            problemStmtLabel.AutoSize = true;
            problemStmtLabel.Font = new Font("Segoe UI", 13F);
            problemStmtLabel.ForeColor = Color.White;
            problemStmtLabel.Location = new Point(134, 12);
            problemStmtLabel.Margin = new Padding(2, 0, 2, 0);
            problemStmtLabel.Name = "problemStmtLabel";
            problemStmtLabel.Size = new Size(0, 30);
            problemStmtLabel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(166, 176, 230);
            panel1.Location = new Point(0, 314);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 5);
            panel1.TabIndex = 4;
            // 
            // QuestionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(50, 56, 87);
            Controls.Add(panel1);
            Controls.Add(problemStmtLabel);
            Controls.Add(borderPanel);
            Controls.Add(questionNumLabel);
            Controls.Add(answersPanel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "QuestionUserControl";
            Size = new Size(726, 319);
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
        private Panel panel1;
    }
}
