namespace UttendanceDesktop.CoursepageContent
{
    partial class attendanceFormItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusLabel = new Label();
            statusDisplayLabel = new Label();
            checkbox = new CheckBox();
            checkboxPadding = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Right;
            statusLabel.Font = new Font("Segoe UI", 10F);
            statusLabel.ForeColor = Color.FromArgb(222, 225, 241);
            statusLabel.Location = new Point(450, 10);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(113, 42);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "Status";
            statusLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // statusDisplayLabel
            // 
            statusDisplayLabel.Dock = DockStyle.Right;
            statusDisplayLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            statusDisplayLabel.ForeColor = Color.FromArgb(233, 117, 2);
            statusDisplayLabel.Location = new Point(563, 10);
            statusDisplayLabel.Margin = new Padding(10);
            statusDisplayLabel.Name = "statusDisplayLabel";
            statusDisplayLabel.Size = new Size(177, 42);
            statusDisplayLabel.TabIndex = 2;
            statusDisplayLabel.Text = "CLOSED";
            statusDisplayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkbox
            // 
            checkbox.Appearance = Appearance.Button;
            checkbox.Dock = DockStyle.Left;
            checkbox.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            checkbox.FlatAppearance.BorderSize = 2;
            checkbox.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            checkbox.FlatStyle = FlatStyle.Flat;
            checkbox.Font = new Font("Segoe UI", 20F);
            checkbox.ForeColor = Color.FromArgb(255, 128, 0);
            checkbox.Location = new Point(10, 10);
            checkbox.Margin = new Padding(20);
            checkbox.Name = "checkbox";
            checkbox.Padding = new Padding(10);
            checkbox.Size = new Size(42, 42);
            checkbox.TabIndex = 3;
            checkbox.TextAlign = ContentAlignment.MiddleCenter;
            checkbox.UseVisualStyleBackColor = true;
            checkbox.CheckedChanged += checkbox_CheckedChanged;
            // 
            // checkboxPadding
            // 
            checkboxPadding.Dock = DockStyle.Left;
            checkboxPadding.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            checkboxPadding.ForeColor = Color.FromArgb(50, 56, 87);
            checkboxPadding.Location = new Point(52, 10);
            checkboxPadding.Margin = new Padding(4);
            checkboxPadding.Name = "checkboxPadding";
            checkboxPadding.Padding = new Padding(8);
            checkboxPadding.Size = new Size(10, 42);
            checkboxPadding.TabIndex = 3;
            checkboxPadding.Text = "XX/XX/XX Attendence Form";
            checkboxPadding.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(222, 225, 241);
            titleLabel.Dock = DockStyle.Left;
            titleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            titleLabel.ForeColor = Color.FromArgb(50, 56, 87);
            titleLabel.Location = new Point(62, 10);
            titleLabel.Margin = new Padding(4);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(8);
            titleLabel.Size = new Size(351, 42);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "XX/XX/XX Attendence Form";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // attendanceFormItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 56, 87);
            Controls.Add(statusLabel);
            Controls.Add(titleLabel);
            Controls.Add(checkboxPadding);
            Controls.Add(checkbox);
            Controls.Add(statusDisplayLabel);
            Name = "attendanceFormItem";
            Padding = new Padding(10);
            Size = new Size(750, 62);
            ResumeLayout(false);
        }

        #endregion

        private Label statusDisplayLabel;
        private Label statusLabel;
        private CheckBox checkbox;
        private Label checkboxPadding;
        private Label titleLabel;
    }
}
