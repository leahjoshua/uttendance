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
            importPanel.Controls.Add(importFlowPanel);
            importPanel.Controls.Add(qBankDropdown);
            importPanel.Controls.Add(qBankLabel);
            importPanel.Location = new Point(-3, 0);
            importPanel.Name = "importPanel";
            importPanel.Size = new Size(592, 488);
            importPanel.TabIndex = 0;
            // 
            // importFlowPanel
            // 
            importFlowPanel.Location = new Point(30, 116);
            importFlowPanel.MaximumSize = new Size(538, 324);
            importFlowPanel.MinimumSize = new Size(538, 324);
            importFlowPanel.Name = "importFlowPanel";
            importFlowPanel.Size = new Size(538, 324);
            importFlowPanel.TabIndex = 13;
            // 
            // qBankDropdown
            // 
            qBankDropdown.Font = new Font("Segoe UI", 12F);
            qBankDropdown.FormattingEnabled = true;
            qBankDropdown.Location = new Point(30, 64);
            qBankDropdown.Name = "qBankDropdown";
            qBankDropdown.Size = new Size(538, 36);
            qBankDropdown.TabIndex = 12;
            qBankDropdown.SelectedIndexChanged += qBankDropdown_SelectedIndexChanged;
            // 
            // qBankLabel
            // 
            qBankLabel.AutoSize = true;
            qBankLabel.BackColor = Color.FromArgb(166, 176, 230);
            qBankLabel.Font = new Font("Segoe UI", 13F);
            qBankLabel.ForeColor = Color.FromArgb(37, 42, 69);
            qBankLabel.Location = new Point(24, 21);
            qBankLabel.Name = "qBankLabel";
            qBankLabel.Size = new Size(217, 30);
            qBankLabel.TabIndex = 11;
            qBankLabel.Text = "Question Bank Name";
            // 
            // ImportQuestionModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 487);
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
    }
}