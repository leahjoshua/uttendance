namespace UttendanceDesktop.CoursepageContent.QUESTIONBANK
{
    partial class BankModal
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
            createUpdateButton = new Button();
            cancelButton = new Button();
            nameTextbox = new TextBox();
            nameLabel = new Label();
            asteriskLabel = new Label();
            SuspendLayout();
            // 
            // createUpdateButton
            // 
            createUpdateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            createUpdateButton.BackColor = Color.FromArgb(233, 117, 2);
            createUpdateButton.Cursor = Cursors.Hand;
            createUpdateButton.FlatAppearance.BorderSize = 0;
            createUpdateButton.FlatStyle = FlatStyle.Flat;
            createUpdateButton.Font = new Font("Segoe UI", 10F);
            createUpdateButton.ForeColor = Color.White;
            createUpdateButton.Location = new Point(440, 120);
            createUpdateButton.Margin = new Padding(3, 4, 3, 4);
            createUpdateButton.Name = "createUpdateButton";
            createUpdateButton.Size = new Size(99, 33);
            createUpdateButton.TabIndex = 32;
            createUpdateButton.Text = "Create";
            createUpdateButton.UseVisualStyleBackColor = false;
            createUpdateButton.Click += createUpdateButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.BackColor = Color.FromArgb(88, 101, 168);
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 10F);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(322, 120);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(99, 33);
            cancelButton.TabIndex = 31;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(33, 63);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(340, 27);
            nameTextbox.TabIndex = 33;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 13F);
            nameLabel.ForeColor = Color.FromArgb(37, 42, 69);
            nameLabel.Location = new Point(33, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(217, 30);
            nameLabel.TabIndex = 34;
            nameLabel.Text = "Question Bank Name";
            // 
            // asteriskLabel
            // 
            asteriskLabel.AutoSize = true;
            asteriskLabel.BackColor = Color.Transparent;
            asteriskLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            asteriskLabel.ForeColor = Color.FromArgb(146, 67, 133);
            asteriskLabel.Location = new Point(256, 29);
            asteriskLabel.Name = "asteriskLabel";
            asteriskLabel.Size = new Size(24, 31);
            asteriskLabel.TabIndex = 35;
            asteriskLabel.Text = "*";
            // 
            // BankModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(551, 166);
            Controls.Add(asteriskLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameTextbox);
            Controls.Add(createUpdateButton);
            Controls.Add(cancelButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "BankModal";
            Text = "Question Bank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createUpdateButton;
        private Button cancelButton;
        private TextBox nameTextbox;
        private Label nameLabel;
        private Label asteriskLabel;
    }
}