using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    partial class Summary
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
            summaryPagePanel = new Panel();
            summaryLabel = new Label();
            summaryPagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // summaryPagePanel
            // 
            summaryPagePanel.BackColor = GlobalStyle.LAVENDER;
            summaryPagePanel.Controls.Add(summaryLabel);
            summaryPagePanel.Dock = DockStyle.Fill;
            summaryPagePanel.Location = new Point(0, 0);
            summaryPagePanel.Name = "summaryPagePanel";
            summaryPagePanel.Size = new Size(800, 450);
            summaryPagePanel.TabIndex = 0;
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            summaryLabel.ForeColor = Color.FromArgb(37, 42, 69);
            summaryLabel.Location = GlobalStyle.HEADING_POSITION;
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(115, 32);
            summaryLabel.TabIndex = 0;
            summaryLabel.Text = "Summary";
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(800, 450);
            Controls.Add(summaryPagePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Summary";
            Text = "Summary";
            summaryPagePanel.ResumeLayout(false);
            summaryPagePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel summaryPagePanel;
        private Label summaryLabel;
    }
}