using System.Xml.Linq;
using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 27, 2025.
    // NetID: jxy210012
    // Wrote the whole StudentImportModal class
    partial class StudentImportModal
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
            importPagePanel = new Panel();
            cancelBtn = new Button();
            openBtn = new Button();
            formatExampleLabel = new Label();
            formatMsgLabel = new Label();
            importPagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // importPagePanel
            // 
            importPagePanel.BackColor = Color.FromArgb(166, 176, 230);
            importPagePanel.Controls.Add(cancelBtn);
            importPagePanel.Controls.Add(openBtn);
            importPagePanel.Controls.Add(formatExampleLabel);
            importPagePanel.Controls.Add(formatMsgLabel);
            importPagePanel.Location = new Point(-1, 0);
            importPagePanel.Name = "importPagePanel";
            importPagePanel.Size = new Size(447, 194);
            importPagePanel.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(88, 101, 168);
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(263, 156);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // openBtn
            // 
            openBtn.BackColor = Color.FromArgb(146, 67, 133);
            openBtn.FlatAppearance.BorderSize = 0;
            openBtn.FlatStyle = FlatStyle.Flat;
            openBtn.ForeColor = Color.White;
            openBtn.Location = new Point(355, 156);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(75, 23);
            openBtn.TabIndex = 2;
            openBtn.Text = "Open";
            openBtn.UseVisualStyleBackColor = false;
            openBtn.Click += openBtn_Click;
            // 
            // formatExampleLabel
            // 
            formatExampleLabel.AutoSize = true;
            formatExampleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formatExampleLabel.ForeColor = Color.FromArgb(37, 42, 69);
            formatExampleLabel.Location = new Point(38, 84);
            formatExampleLabel.Name = "formatExampleLabel";
            formatExampleLabel.Size = new Size(0, 19);
            formatExampleLabel.TabIndex = 1;
            formatExampleLabel.Text = "\"Last Name\", \"First Name\", \"Net-ID\", \"UTD-ID\"";
            // 
            // formatMsgLabel
            // 
            formatMsgLabel.Anchor = AnchorStyles.Top;
            formatMsgLabel.AutoSize = true;
            formatMsgLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formatMsgLabel.ForeColor = Color.FromArgb(37, 42, 69);
            formatMsgLabel.Location = new Point(17, 22);
            formatMsgLabel.Name = "formatMsgLabel";
            formatMsgLabel.Size = new Size(417, 38);
            formatMsgLabel.TabIndex = 0;
            formatMsgLabel.Text = "Make sure the file is a .csv file and has the following column names\r\n(or similar) in the following order:\r\n";
            // 
            // ImportStudentModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 192);
            Controls.Add(importPagePanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ImportStudentModal";
            Text = "Import Students";
            importPagePanel.ResumeLayout(false);
            importPagePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel importPagePanel;
        private Label formatMsgLabel;
        private Label formatExampleLabel;
        private Button cancelBtn;
        private Button openBtn;
    }
}