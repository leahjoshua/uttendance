namespace UttendanceDesktop.CoursepageContent
{
    partial class QuestionBankItem
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
            QuestionLabel = new Label();
            TitleLabel = new Label();
            checkboxPadding = new Label();
            checkbox = new CheckBox();
            QuestionDisplayLabel = new Label();
            SuspendLayout();
            // 
            // QuestionLabel
            // 
            QuestionLabel.Dock = DockStyle.Right;
            QuestionLabel.Font = new Font("Segoe UI", 10F);
            QuestionLabel.ForeColor = Color.FromArgb(222, 225, 241);
            QuestionLabel.Location = new Point(563, 10);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(96, 42);
            QuestionLabel.TabIndex = 5;
            QuestionLabel.Text = "Questions";
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            QuestionLabel.Click += QuestionLabel_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = Color.FromArgb(222, 225, 241);
            TitleLabel.Dock = DockStyle.Left;
            TitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            TitleLabel.ForeColor = Color.FromArgb(50, 56, 87);
            TitleLabel.Location = new Point(62, 10);
            TitleLabel.Margin = new Padding(4);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Padding = new Padding(8);
            TitleLabel.Size = new Size(494, 42);
            TitleLabel.TabIndex = 9;
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            TitleLabel.Click += TitleLabel_Click;
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
            checkboxPadding.TabIndex = 7;
            checkboxPadding.Text = "XX/XX/XX Attendence Form";
            checkboxPadding.TextAlign = ContentAlignment.MiddleLeft;
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
            checkbox.TabIndex = 8;
            checkbox.TextAlign = ContentAlignment.MiddleCenter;
            checkbox.UseVisualStyleBackColor = true;
            checkbox.CheckedChanged += checkbox_CheckedChanged;
            // 
            // QuestionDisplayLabel
            // 
            QuestionDisplayLabel.Dock = DockStyle.Right;
            QuestionDisplayLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            QuestionDisplayLabel.ForeColor = Color.White;
            QuestionDisplayLabel.Location = new Point(659, 10);
            QuestionDisplayLabel.Margin = new Padding(10);
            QuestionDisplayLabel.Name = "QuestionDisplayLabel";
            QuestionDisplayLabel.Size = new Size(81, 42);
            QuestionDisplayLabel.TabIndex = 6;
            QuestionDisplayLabel.Text = "0";
            QuestionDisplayLabel.TextAlign = ContentAlignment.MiddleCenter;
            QuestionDisplayLabel.Click += QuestionDisplayLabel_Click;
            // 
            // QuestionBankItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 56, 87);
            Controls.Add(QuestionLabel);
            Controls.Add(TitleLabel);
            Controls.Add(checkboxPadding);
            Controls.Add(checkbox);
            Controls.Add(QuestionDisplayLabel);
            Name = "QuestionBankItem";
            Padding = new Padding(10);
            Size = new Size(750, 62);
            Click += QuestionBankItem_Click;
            ResumeLayout(false);
        }

        #endregion

        private Label QuestionLabel;
        private Label TitleLabel;
        private Label checkboxPadding;
        private CheckBox checkbox;
        private Label QuestionDisplayLabel;
    }
}
