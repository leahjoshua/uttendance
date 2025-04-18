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
            importCoursesLabel = new Label();
            panel1 = new Panel();
            importDirectionsLabel4 = new Label();
            importDirectionsLabel3 = new Label();
            importDirectionsLabel2 = new Label();
            importDirectionsLabel1 = new Label();
            cancelButton = new Button();
            openButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // importCoursesLabel
            // 
            importCoursesLabel.AutoSize = true;
            importCoursesLabel.Font = new Font("Afacad Medium", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            importCoursesLabel.ForeColor = Color.White;
            importCoursesLabel.Location = new Point(34, 19);
            importCoursesLabel.Name = "importCoursesLabel";
            importCoursesLabel.Size = new Size(291, 59);
            importCoursesLabel.TabIndex = 2;
            importCoursesLabel.Text = "Import Courses";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(166, 176, 230);
            panel1.Controls.Add(importDirectionsLabel4);
            panel1.Controls.Add(importDirectionsLabel3);
            panel1.Controls.Add(importDirectionsLabel2);
            panel1.Controls.Add(importDirectionsLabel1);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(openButton);
            panel1.Location = new Point(22, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 527);
            panel1.TabIndex = 3;
            // 
            // importDirectionsLabel4
            // 
            importDirectionsLabel4.AutoSize = true;
            importDirectionsLabel4.Font = new Font("Afacad Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            importDirectionsLabel4.Location = new Point(43, 259);
            importDirectionsLabel4.Name = "importDirectionsLabel4";
            importDirectionsLabel4.Size = new Size(552, 53);
            importDirectionsLabel4.TabIndex = 11;
            importDirectionsLabel4.Text = "“Section Number”, and “Class ID”";
            // 
            // importDirectionsLabel3
            // 
            importDirectionsLabel3.AutoSize = true;
            importDirectionsLabel3.Font = new Font("Afacad Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            importDirectionsLabel3.Location = new Point(43, 206);
            importDirectionsLabel3.Name = "importDirectionsLabel3";
            importDirectionsLabel3.Size = new Size(782, 53);
            importDirectionsLabel3.TabIndex = 10;
            importDirectionsLabel3.Text = "“Course Name”, “Class Prefix”, “Class Number”, ";
            // 
            // importDirectionsLabel2
            // 
            importDirectionsLabel2.AutoSize = true;
            importDirectionsLabel2.Font = new Font("Afacad Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            importDirectionsLabel2.Location = new Point(43, 108);
            importDirectionsLabel2.Name = "importDirectionsLabel2";
            importDirectionsLabel2.Size = new Size(549, 53);
            importDirectionsLabel2.TabIndex = 9;
            importDirectionsLabel2.Text = "column names (any order is fine):";
            // 
            // importDirectionsLabel1
            // 
            importDirectionsLabel1.AutoSize = true;
            importDirectionsLabel1.Font = new Font("Afacad Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            importDirectionsLabel1.Location = new Point(43, 55);
            importDirectionsLabel1.Name = "importDirectionsLabel1";
            importDirectionsLabel1.Size = new Size(820, 53);
            importDirectionsLabel1.TabIndex = 8;
            importDirectionsLabel1.Text = "Make sure the file is a .csv file and has the following";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(88, 101, 168);
            cancelButton.Font = new Font("Afacad", 15.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(744, 452);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(134, 54);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // openButton
            // 
            openButton.BackColor = Color.FromArgb(146, 67, 133);
            openButton.Font = new Font("Afacad", 15.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openButton.ForeColor = Color.White;
            openButton.Location = new Point(920, 452);
            openButton.Name = "openButton";
            openButton.Size = new Size(134, 54);
            openButton.TabIndex = 6;
            openButton.Text = "Create";
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += OpenButton_Click;
            // 
            // ImportCourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 56, 87);
            ClientSize = new Size(1150, 642);
            Controls.Add(panel1);
            Controls.Add(importCoursesLabel);
            Name = "ImportCourse";
            Text = "Import Courses";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label importCoursesLabel;
        private Panel panel1;
        private Button openButton;
        private Button cancelButton;
        private Label importDirectionsLabel1;
        private Label importDirectionsLabel4;
        private Label importDirectionsLabel3;
        private Label importDirectionsLabel2;
    }
}