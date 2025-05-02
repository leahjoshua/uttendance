/******************************************************************************
* ImportCourse Form Designer for the UttendanceDesktop application.
* This form allows users to import multiple courses from a CSV file into the
* Uttendance system. The user selects a CSV file, and each row is parsed and
* added as a new course. The form provides feedback on the import process and
* refreshes the homepage to reflect the new courses.
* Written by Parisa Nawar (pxn210032) for CS4485.0W1 at The University of Texas at Dallas
* starting March 28, 2025.
******************************************************************************/
namespace UttendanceDesktop
{
    partial class ImportCourse
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
            panel1 = new Panel();
            importDirectionsLabel3 = new Label();
            importDirectionsLabel1 = new Label();
            cancelButton = new Button();
            openButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(166, 176, 230);
            panel1.Controls.Add(importDirectionsLabel3);
            panel1.Controls.Add(importDirectionsLabel1);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(openButton);
            panel1.Location = new Point(-4, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 211);
            panel1.TabIndex = 3;
            // 
            // importDirectionsLabel3
            // 
            importDirectionsLabel3.AutoSize = true;
            importDirectionsLabel3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            importDirectionsLabel3.Location = new Point(22, 77);
            importDirectionsLabel3.Margin = new Padding(2, 0, 2, 0);
            importDirectionsLabel3.Name = "importDirectionsLabel3";
            importDirectionsLabel3.Size = new Size(348, 60);
            importDirectionsLabel3.TabIndex = 10;
            importDirectionsLabel3.Text = "“Course Name”, “Class Prefix”, “Class Number”, \r\n“Section Number”, “Class ID”, \"Class Start Time\",\r\nand \"Class End Time\"\r\n";
            // 
            // importDirectionsLabel1
            // 
            importDirectionsLabel1.AutoSize = true;
            importDirectionsLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importDirectionsLabel1.Location = new Point(22, 24);
            importDirectionsLabel1.Margin = new Padding(2, 0, 2, 0);
            importDirectionsLabel1.Name = "importDirectionsLabel1";
            importDirectionsLabel1.Size = new Size(408, 40);
            importDirectionsLabel1.TabIndex = 8;
            importDirectionsLabel1.Text = "Make sure the file is a .csv file and has the following column \r\nnames (or similar) in the following order:";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(88, 101, 168);
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(256, 159);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 32);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // openButton
            // 
            openButton.BackColor = Color.FromArgb(146, 67, 133);
            openButton.FlatAppearance.BorderSize = 0;
            openButton.FlatStyle = FlatStyle.Flat;
            openButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openButton.ForeColor = Color.White;
            openButton.Location = new Point(351, 159);
            openButton.Margin = new Padding(2);
            openButton.Name = "openButton";
            openButton.Size = new Size(78, 32);
            openButton.TabIndex = 6;
            openButton.Text = "Create";
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += OpenButton_Click;
            // 
            // ImportCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(444, 208);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ImportCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import Courses";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button openButton;
        private Button cancelButton;
        private Label importDirectionsLabel1;
        private Label importDirectionsLabel3;
    }
}