namespace UttendanceDesktop.CoursepageContent.CreateAttendanceForm
{
    partial class ImportQuestionModal
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
            importPanel = new Panel();
            importBtn = new Button();
            cancelBtn = new Button();
            importFlowPanel = new FlowLayoutPanel();
            qBankDropdown = new ComboBox();
            qBankLabel = new Label();
            importPanel.SuspendLayout();
            SuspendLayout();
            // 
            // importPanel
            // 
            importPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            importPanel.BackColor = Color.FromArgb(166, 176, 230);
            importPanel.Controls.Add(importBtn);
            importPanel.Controls.Add(cancelBtn);
            importPanel.Controls.Add(importFlowPanel);
            importPanel.Controls.Add(qBankDropdown);
            importPanel.Controls.Add(qBankLabel);
            importPanel.Location = new Point(-3, 0);
            importPanel.Name = "importPanel";
            importPanel.Size = new Size(854, 561);
            importPanel.TabIndex = 0;
            // 
            // importBtn
            // 
            importBtn.BackColor = Color.FromArgb(233, 117, 2);
            importBtn.Cursor = Cursors.Hand;
            importBtn.FlatAppearance.BorderSize = 0;
            importBtn.FlatStyle = FlatStyle.Flat;
            importBtn.Font = new Font("Segoe UI", 10F);
            importBtn.ForeColor = Color.White;
            importBtn.Location = new Point(726, 506);
            importBtn.Margin = new Padding(3, 4, 3, 4);
            importBtn.Name = "importBtn";
            importBtn.Size = new Size(99, 33);
            importBtn.TabIndex = 32;
            importBtn.Text = "Import";
            importBtn.UseVisualStyleBackColor = false;
            importBtn.Click += importBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(88, 101, 168);
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 10F);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(608, 506);
            cancelBtn.Margin = new Padding(3, 4, 3, 4);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(99, 33);
            cancelBtn.TabIndex = 31;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // importFlowPanel
            // 
            importFlowPanel.AutoScroll = true;
            importFlowPanel.Location = new Point(50, 147);
            importFlowPanel.MaximumSize = new Size(775, 667);
            importFlowPanel.MinimumSize = new Size(23, 27);
            importFlowPanel.Name = "importFlowPanel";
            importFlowPanel.Size = new Size(775, 339);
            importFlowPanel.TabIndex = 13;
            // 
            // qBankDropdown
            // 
            qBankDropdown.Font = new Font("Segoe UI", 12F);
            qBankDropdown.FormattingEnabled = true;
            qBankDropdown.Location = new Point(50, 87);
            qBankDropdown.Name = "qBankDropdown";
            qBankDropdown.Size = new Size(571, 36);
            qBankDropdown.TabIndex = 12;
            qBankDropdown.SelectedIndexChanged += qBankDropdown_SelectedIndexChanged;
            // 
            // qBankLabel
            // 
            qBankLabel.AutoSize = true;
            qBankLabel.BackColor = Color.FromArgb(166, 176, 230);
            qBankLabel.Font = new Font("Segoe UI", 15F);
            qBankLabel.ForeColor = Color.FromArgb(37, 42, 69);
            qBankLabel.Location = new Point(50, 33);
            qBankLabel.Name = "qBankLabel";
            qBankLabel.Size = new Size(249, 35);
            qBankLabel.TabIndex = 11;
            qBankLabel.Text = "Question Bank Name";
            // 
            // ImportQuestionModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 560);
            Controls.Add(importPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImportQuestionModal";
            Text = "Import Question";
            importPanel.ResumeLayout(false);
            importPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel importPanel;
        private Label qBankLabel;
        private ComboBox qBankDropdown;
        private FlowLayoutPanel importFlowPanel;
        private Button importBtn;
        private Button cancelBtn;
    }
}