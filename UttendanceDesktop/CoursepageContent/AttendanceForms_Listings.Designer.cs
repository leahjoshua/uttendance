using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    partial class AttendanceForms_Listings
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
            listingsLabel = new Label();
            attendanceFormsLabel = new Label();
            attendanceFormPagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // attendanceFormPagePanel
            // 
            attendanceFormPagePanel.Controls.Add(listingsLabel);
            attendanceFormPagePanel.Controls.Add(attendanceFormsLabel);
            attendanceFormPagePanel.Dock = DockStyle.Fill;
            attendanceFormPagePanel.Location = new Point(0, 0);
            attendanceFormPagePanel.Name = "attendanceFormPagePanel";
            attendanceFormPagePanel.Size = new Size(800, 450);
            attendanceFormPagePanel.TabIndex = 0;
            // 
            // listingsLabel
            // 
            listingsLabel.AutoSize = true;
            listingsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listingsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            listingsLabel.Location = new Point(58, 69);
            listingsLabel.Name = "listingsLabel";
            listingsLabel.Size = new Size(75, 25);
            listingsLabel.TabIndex = 1;
            listingsLabel.Text = "Listings";
            // 
            // attendanceFormsLabel
            // 
            attendanceFormsLabel.AutoSize = true;
            attendanceFormsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceFormsLabel.ForeColor = GlobalStyle.DARKEST_PURPLE;
            attendanceFormsLabel.Location = new Point(43, 37);
            attendanceFormsLabel.Name = "attendanceFormsLabel";
            attendanceFormsLabel.Size = new Size(208, 32);
            attendanceFormsLabel.TabIndex = 0;
            attendanceFormsLabel.Text = "Attendance Forms";
            // 
            // AttendanceForms_Listings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(800, 450);
            Controls.Add(attendanceFormPagePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttendanceForms_Listings";
            Text = "Uttendance";
            attendanceFormPagePanel.ResumeLayout(false);
            attendanceFormPagePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel attendanceFormPagePanel;
        private Label attendanceFormsLabel;
        private Label listingsLabel;
    }
}