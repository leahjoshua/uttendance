namespace UttendanceDesktop
{
    partial class Homepage
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
            addButton = new Button();
            YourCoursesLabel = new Label();
            homepageBanner = new Panel();
            uttendanceLabel = new Label();
            editButton = new Button();
            addCourseManualButton = new Button();
            importCourseButton = new Button();
            homepageBanner.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(234, 117, 7);
            addButton.Font = new Font("Afacad", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(1190, 526);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 58);
            addButton.TabIndex = 0;
            addButton.Text = "+";
            addButton.UseCompatibleTextRendering = true;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // YourCoursesLabel
            // 
            YourCoursesLabel.AutoSize = true;
            YourCoursesLabel.Font = new Font("Afacad Medium", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YourCoursesLabel.Location = new Point(33, 135);
            YourCoursesLabel.Name = "YourCoursesLabel";
            YourCoursesLabel.Size = new Size(315, 75);
            YourCoursesLabel.TabIndex = 1;
            YourCoursesLabel.Text = "Your Courses";
            // 
            // homepageBanner
            // 
            homepageBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            homepageBanner.BackColor = Color.FromArgb(50, 56, 87);
            homepageBanner.Controls.Add(uttendanceLabel);
            homepageBanner.Location = new Point(3, 3);
            homepageBanner.Name = "homepageBanner";
            homepageBanner.Size = new Size(1328, 125);
            homepageBanner.TabIndex = 2;
            // 
            // uttendanceLabel
            // 
            uttendanceLabel.AutoSize = true;
            uttendanceLabel.BackColor = Color.FromArgb(50, 56, 87);
            uttendanceLabel.Font = new Font("Afacad", 25.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uttendanceLabel.ForeColor = Color.FromArgb(166, 176, 230);
            uttendanceLabel.Location = new Point(41, 32);
            uttendanceLabel.Name = "uttendanceLabel";
            uttendanceLabel.Size = new Size(286, 69);
            uttendanceLabel.TabIndex = 0;
            uttendanceLabel.Text = "UTtenDance";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editButton.BackColor = Color.FromArgb(234, 117, 7);
            editButton.Font = new Font("Afacad", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(1179, 149);
            editButton.Name = "editButton";
            editButton.Size = new Size(112, 61);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            // 
            // addCourseManualButton
            // 
            addCourseManualButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addCourseManualButton.BackColor = Color.FromArgb(217, 217, 217);
            addCourseManualButton.Font = new Font("Afacad", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCourseManualButton.ForeColor = SystemColors.ControlText;
            addCourseManualButton.Location = new Point(1190, 581);
            addCourseManualButton.Name = "addCourseManualButton";
            addCourseManualButton.Size = new Size(112, 24);
            addCourseManualButton.TabIndex = 4;
            addCourseManualButton.Text = "Create Course";
            addCourseManualButton.UseVisualStyleBackColor = false;
            addCourseManualButton.Visible = false;
            addCourseManualButton.Click += addCourseManualButton_Click;
            // 
            // importCourseButton
            // 
            importCourseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            importCourseButton.BackColor = Color.FromArgb(217, 217, 217);
            importCourseButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            importCourseButton.Font = new Font("Afacad", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importCourseButton.Location = new Point(1190, 602);
            importCourseButton.Name = "importCourseButton";
            importCourseButton.Size = new Size(112, 26);
            importCourseButton.TabIndex = 5;
            importCourseButton.Text = "Import Course";
            importCourseButton.UseVisualStyleBackColor = false;
            importCourseButton.Visible = false;
            importCourseButton.Click += importCourseButton_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(1330, 646);
            Controls.Add(importCourseButton);
            Controls.Add(addCourseManualButton);
            Controls.Add(editButton);
            Controls.Add(homepageBanner);
            Controls.Add(YourCoursesLabel);
            Controls.Add(addButton);
            Name = "Homepage";
            Text = "Uttendance";
            homepageBanner.ResumeLayout(false);
            homepageBanner.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Label uttendanceLabel;
        private Label YourCoursesLabel;
        private Panel homepageBanner;
        private Button editButton;
        private Button addCourseManualButton;
        private Button importCourseButton;
    }
}