﻿using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    partial class AttendanceForms_QuestionBank
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
            SaveEditIcon = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            attendanceFormsLabel = new Label();
            attendanceFormPagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // attendanceFormPagePanel
            // 
            attendanceFormPagePanel.Controls.Add(SaveEditIcon);
            attendanceFormPagePanel.Controls.Add(flowLayoutPanel);
            attendanceFormPagePanel.Controls.Add(attendanceFormsLabel);
            attendanceFormPagePanel.Dock = DockStyle.Fill;
            attendanceFormPagePanel.Location = new Point(0, 0);
            attendanceFormPagePanel.Margin = new Padding(3, 5, 3, 5);
            attendanceFormPagePanel.Name = "attendanceFormPagePanel";
            attendanceFormPagePanel.Size = new Size(914, 600);
            attendanceFormPagePanel.TabIndex = 0;
            // 
            // SaveEditIcon
            // 
            SaveEditIcon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveEditIcon.BackColor = Color.Transparent;
            SaveEditIcon.BackgroundImage = Properties.Resources.add_icon;
            SaveEditIcon.BackgroundImageLayout = ImageLayout.Zoom;
            SaveEditIcon.FlatAppearance.BorderColor = Color.White;
            SaveEditIcon.FlatAppearance.BorderSize = 0;
            SaveEditIcon.FlatStyle = FlatStyle.Flat;
            SaveEditIcon.Location = new Point(844, 533);
            SaveEditIcon.Name = "SaveEditIcon";
            SaveEditIcon.Size = new Size(58, 55);
            SaveEditIcon.TabIndex = 15;
            SaveEditIcon.UseVisualStyleBackColor = false;
            SaveEditIcon.Click += SaveEditIcon_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(75, 147);
            flowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(890, 676);
            flowLayoutPanel.TabIndex = 14;
            // 
            // attendanceFormsLabel
            // 
            attendanceFormsLabel.Anchor = AnchorStyles.Top;
            attendanceFormsLabel.AutoSize = true;
            attendanceFormsLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendanceFormsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            attendanceFormsLabel.Location = new Point(75, 73);
            attendanceFormsLabel.Name = "attendanceFormsLabel";
            attendanceFormsLabel.Size = new Size(232, 41);
            attendanceFormsLabel.TabIndex = 0;
            attendanceFormsLabel.Text = "Question Banks";
            // 
            // AttendanceForms_QuestionBank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(914, 600);
            Controls.Add(attendanceFormPagePanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "AttendanceForms_QuestionBank";
            Text = "Uttendance";
            attendanceFormPagePanel.ResumeLayout(false);
            attendanceFormPagePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel attendanceFormPagePanel;
        private Label attendanceFormsLabel;
        private Button SaveEditIcon;
        private FlowLayoutPanel flowLayoutPanel;
    }
}