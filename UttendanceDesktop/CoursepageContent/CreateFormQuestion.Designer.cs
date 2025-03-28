namespace UttendanceDesktop.CoursepageContent
{
    partial class CreateFormQuestion
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
            createQuestionPanel = new Panel();
            SuspendLayout();
            // 
            // createQuestionPanel
            // 
            createQuestionPanel.BackColor = Color.FromArgb(166, 176, 230);
            createQuestionPanel.Location = new Point(-1, 0);
            createQuestionPanel.Name = "createQuestionPanel";
            createQuestionPanel.Size = new Size(639, 323);
            createQuestionPanel.TabIndex = 0;
            // 
            // CreateFormQuestion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 320);
            Controls.Add(createQuestionPanel);
            Name = "CreateFormQuestion";
            Text = "CreateFormQuestion";
            ResumeLayout(false);
        }

        #endregion

        private Panel createQuestionPanel;
    }
}