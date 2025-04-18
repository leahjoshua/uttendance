using System.Windows.Forms;
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            summaryPagePanel = new Panel();
            keyLabel = new Label();
            totalCountLabel = new Label();
            summaryTable = new DataGridView();
            summaryLabel = new Label();
            summaryPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)summaryTable).BeginInit();
            SuspendLayout();
            // 
            // summaryPagePanel
            // 
            summaryPagePanel.BackColor = Color.FromArgb(166, 176, 230);
            summaryPagePanel.Controls.Add(keyLabel);
            summaryPagePanel.Controls.Add(totalCountLabel);
            summaryPagePanel.Controls.Add(summaryTable);
            summaryPagePanel.Controls.Add(summaryLabel);
            summaryPagePanel.Dock = DockStyle.Fill;
            summaryPagePanel.Location = new Point(0, 0);
            summaryPagePanel.Margin = new Padding(3, 4, 3, 4);
            summaryPagePanel.Name = "summaryPagePanel";
            summaryPagePanel.Size = new Size(914, 600);
            summaryPagePanel.TabIndex = 0;
            // 
            // keyLabel
            // 
            keyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyLabel.AutoSize = true;
            keyLabel.BackColor = Color.FromArgb(222, 225, 241);
            keyLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            keyLabel.ForeColor = Color.FromArgb(37, 42, 69);
            keyLabel.Location = new Point(502, 138);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(317, 46);
            keyLabel.TabIndex = 0;
            keyLabel.Text = "Key: \r\nP = Present    E = Excused    A = Absent\r\n";
            // 
            // totalCountLabel
            // 
            totalCountLabel.AutoSize = true;
            totalCountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCountLabel.ForeColor = Color.FromArgb(37, 42, 69);
            totalCountLabel.Location = new Point(81, 160);
            totalCountLabel.Name = "totalCountLabel";
            totalCountLabel.Size = new Size(326, 46);
            totalCountLabel.TabIndex = 1;
            totalCountLabel.Text = "Total (Closed) Attendance Form Count: \r\n\r\n";
            // 
            // summaryTable
            // 
            summaryTable.AllowUserToAddRows = false;
            summaryTable.AllowUserToDeleteRows = false;
            summaryTable.AllowUserToResizeColumns = false;
            summaryTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(206, 212, 244);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(88, 101, 168);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            summaryTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            summaryTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            summaryTable.BackgroundColor = Color.FromArgb(37, 42, 69);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(37, 42, 69);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            summaryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            summaryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(222, 225, 241);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(88, 101, 168);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            summaryTable.DefaultCellStyle = dataGridViewCellStyle6;
            summaryTable.EnableHeadersVisualStyles = false;
            summaryTable.GridColor = Color.FromArgb(37, 42, 69);
            summaryTable.Location = new Point(81, 209);
            summaryTable.Margin = new Padding(3, 4, 3, 4);
            summaryTable.Name = "summaryTable";
            summaryTable.RowHeadersVisible = false;
            summaryTable.RowHeadersWidth = 51;
            summaryTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            summaryTable.Size = new Size(738, 339);
            summaryTable.TabIndex = 0;
            summaryTable.TabStop = false;
            summaryTable.CellBeginEdit += summaryTable_CellBeginEdit;
            summaryTable.CellEndEdit += summaryTable_CellEndEdit;
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            summaryLabel.ForeColor = Color.FromArgb(37, 42, 69);
            summaryLabel.Location = new Point(49, 49);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(143, 41);
            summaryLabel.TabIndex = 0;
            summaryLabel.Text = "Summary";
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(914, 600);
            Controls.Add(summaryPagePanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Summary";
            Text = "Summary";
            summaryPagePanel.ResumeLayout(false);
            summaryPagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)summaryTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel summaryPagePanel;
        private Label summaryLabel;
        private DataGridView summaryTable;
        private Label totalCountLabel;
        private Label keyLabel;
    }
}