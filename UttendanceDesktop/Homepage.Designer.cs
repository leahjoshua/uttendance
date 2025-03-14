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
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(234, 117, 7);
            addButton.Location = new Point(1242, 683);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 58);
            addButton.TabIndex = 0;
            addButton.Text = "Click Me";
            addButton.UseVisualStyleBackColor = false;
            // 
            // YourCoursesLabel
            // 
            YourCoursesLabel.AutoSize = true;
            YourCoursesLabel.Font = new Font("Afacad Medium", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YourCoursesLabel.Location = new Point(3, 98);
            YourCoursesLabel.Name = "YourCoursesLabel";
            YourCoursesLabel.Size = new Size(541, 128);
            YourCoursesLabel.TabIndex = 1;
            YourCoursesLabel.Text = "Your Courses";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(1379, 753);
            Controls.Add(YourCoursesLabel);
            Controls.Add(addButton);
            Name = "Homepage";
            Text = "Uttendance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Label label1;
        private Label YourCoursesLabel;
    }
}