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
            importPanel.Margin = new Padding(3, 2, 3, 2);
            importPanel.Name = "importPanel";
            importPanel.Size = new Size(584, 421);
            importPanel.TabIndex = 0;
            // 
            // importFlowPanel
            // 
            importFlowPanel.Location = new Point(44, 110);
            importFlowPanel.Margin = new Padding(3, 2, 3, 2);
            importFlowPanel.MaximumSize = new Size(500, 500);
            importFlowPanel.MinimumSize = new Size(20, 20);
            importFlowPanel.Name = "importFlowPanel";
            importFlowPanel.Size = new Size(500, 254);
            importFlowPanel.TabIndex = 13;
            // 
            // qBankDropdown
            // 
            qBankDropdown.Font = new Font("Segoe UI", 12F);
            qBankDropdown.FormattingEnabled = true;
            qBankDropdown.Location = new Point(44, 65);
            qBankDropdown.Margin = new Padding(3, 2, 3, 2);
            qBankDropdown.Name = "qBankDropdown";
            qBankDropdown.Size = new Size(500, 29);
            qBankDropdown.TabIndex = 12;
            qBankDropdown.SelectedIndexChanged += qBankDropdown_SelectedIndexChanged;
            // 
            // qBankLabel
            // 
            qBankLabel.AutoSize = true;
            qBankLabel.BackColor = Color.FromArgb(166, 176, 230);
            qBankLabel.Font = new Font("Segoe UI", 15F);
            qBankLabel.ForeColor = Color.FromArgb(37, 42, 69);
            qBankLabel.Location = new Point(44, 25);
            qBankLabel.Name = "qBankLabel";
            qBankLabel.Size = new Size(195, 28);
            qBankLabel.TabIndex = 11;
            qBankLabel.Text = "Question Bank Name";
            // 
            // ImportQuestionModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 420);
            Controls.Add(importPanel);
            Margin = new Padding(3, 2, 3, 2);
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