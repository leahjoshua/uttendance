namespace UttendanceDesktop.CoursepageContent
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
            formTitle = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            SaveEditIcon = new Button();
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
            // formTitle
            // 
            formTitle.AutoSize = true;
            formTitle.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            formTitle.ForeColor = Color.FromArgb(37, 42, 69);
            formTitle.Location = new Point(53, 48);
            formTitle.Name = "formTitle";
            formTitle.Size = new Size(75, 41);
            formTitle.TabIndex = 2;
            formTitle.Text = "Title";
            formTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(53, 148);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(779, 466);
            flowLayoutPanel.TabIndex = 15;
            // 
            // SaveEditIcon
            // 
            SaveEditIcon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveEditIcon.BackColor = Color.FromArgb(0, 192, 0);
            SaveEditIcon.FlatAppearance.BorderColor = Color.White;
            SaveEditIcon.FlatAppearance.BorderSize = 2;
            SaveEditIcon.FlatStyle = FlatStyle.Flat;
            SaveEditIcon.Location = new Point(862, 548);
            SaveEditIcon.Name = "SaveEditIcon";
            SaveEditIcon.Size = new Size(40, 40);
            SaveEditIcon.TabIndex = 16;
            SaveEditIcon.UseVisualStyleBackColor = false;
            // 
            // AttendanceForms_QuestionBank_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(914, 600);
            Controls.Add(SaveEditIcon);
            Controls.Add(flowLayoutPanel);
            Controls.Add(questionsLabel);
            Controls.Add(formTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttendanceForms_QuestionBank_Details";
            Text = "QuestionBank_Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionsLabel;
        private Label formTitle;
        private FlowLayoutPanel flowLayoutPanel;
        private Button SaveEditIcon;
    }
}