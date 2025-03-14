using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    partial class AttendanceForms
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
            attendanceFormPagePanel = new Panel();
            attendanceFormsLabel = new Label();
            attendanceFormPagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // attendanceFormPagePanel
            // 
            attendanceFormPagePanel.Controls.Add(attendanceFormsLabel);
            attendanceFormPagePanel.Location = new Point(1, 3);
            attendanceFormPagePanel.Name = "attendanceFormPagePanel";
            attendanceFormPagePanel.Size = new Size(800, 449);
            attendanceFormPagePanel.TabIndex = 0;
            // 
            // attendanceFormsLabel
            // 
            attendanceFormsLabel.AutoSize = true;
            attendanceFormsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceFormsLabel.Location = new Point(40, 24);
            attendanceFormsLabel.Name = "attendanceFormsLabel";
            attendanceFormsLabel.Size = new Size(208, 32);
            attendanceFormsLabel.TabIndex = 0;
            attendanceFormsLabel.Text = "Attendance Forms";
            // 
            // AttendanceForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(800, 450);
            Controls.Add(attendanceFormPagePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttendanceForms";
            Text = "Uttendance";
            attendanceFormPagePanel.ResumeLayout(false);
            attendanceFormPagePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel attendanceFormPagePanel;
        private Label attendanceFormsLabel;
    }
}