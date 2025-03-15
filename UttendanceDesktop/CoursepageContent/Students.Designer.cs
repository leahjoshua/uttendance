using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    partial class Students
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
            studentsPagePanel = new Panel();
            studentsLabel = new Label();
            studentsPagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // studentsPagePanel
            // 
            studentsPagePanel.BackColor = Color.FromArgb(166, 176, 230);
            studentsPagePanel.Controls.Add(studentsLabel);
            studentsPagePanel.Dock = DockStyle.Fill;
            studentsPagePanel.Location = new Point(0, 0);
            studentsPagePanel.Name = "studentsPagePanel";
            studentsPagePanel.Size = new Size(800, 450);
            studentsPagePanel.TabIndex = 0;
            // 
            // studentsLabel
            // 
            studentsLabel.AutoSize = true;
            studentsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            studentsLabel.Location = GlobalStyle.HEADING_POSITION;
            studentsLabel.Name = "studentsLabel";
            studentsLabel.Size = new Size(107, 32);
            studentsLabel.TabIndex = 0;
            studentsLabel.Text = "Students";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(800, 450);
            Controls.Add(studentsPagePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Students";
            Text = "Students";
            studentsPagePanel.ResumeLayout(false);
            studentsPagePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel studentsPagePanel;
        private Label studentsLabel;
    }
}