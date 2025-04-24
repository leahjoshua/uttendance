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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            summaryPagePanel.Name = "summaryPagePanel";
            summaryPagePanel.Size = new Size(800, 450);
            summaryPagePanel.TabIndex = 0;
            // 
            // keyLabel
            // 
            keyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            keyLabel.AutoSize = true;
            keyLabel.BackColor = Color.FromArgb(222, 225, 241);
            keyLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            keyLabel.ForeColor = Color.FromArgb(37, 42, 69);
            keyLabel.Location = new Point(439, 104);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(243, 34);
            keyLabel.TabIndex = 0;
            keyLabel.Text = "Key: \r\nP = Present    E = Excused    A = Absent\r\n";
            // 
            // totalCountLabel
            // 
            totalCountLabel.AutoSize = true;
            totalCountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCountLabel.ForeColor = Color.FromArgb(37, 42, 69);
            totalCountLabel.Location = new Point(71, 120);
            totalCountLabel.Name = "totalCountLabel";
            totalCountLabel.Size = new Size(253, 34);
            totalCountLabel.TabIndex = 1;
            totalCountLabel.Text = "Total (Closed) Attendance Form Count: \r\n\r\n";
            // 
            // summaryTable
            // 
            summaryTable.AllowUserToAddRows = false;
            summaryTable.AllowUserToDeleteRows = false;
            summaryTable.AllowUserToResizeColumns = false;
            summaryTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(206, 212, 244);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(88, 101, 168);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            summaryTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            summaryTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            summaryTable.BackgroundColor = Color.FromArgb(37, 42, 69);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 42, 69);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            summaryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            summaryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(222, 225, 241);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(88, 101, 168);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            summaryTable.DefaultCellStyle = dataGridViewCellStyle3;
            summaryTable.EnableHeadersVisualStyles = false;
            summaryTable.GridColor = Color.FromArgb(37, 42, 69);
            summaryTable.Location = new Point(71, 157);
            summaryTable.Name = "summaryTable";
            summaryTable.RowHeadersVisible = false;
            summaryTable.RowHeadersWidth = 51;
            summaryTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            summaryTable.Size = new Size(646, 254);
            summaryTable.TabIndex = 0;
            summaryTable.TabStop = false;
            summaryTable.CellBeginEdit += summaryTable_CellBeginEdit;
            summaryTable.CellClick += summaryTable_CellClick;
            summaryTable.CellEndEdit += summaryTable_CellEndEdit;
            summaryTable.ColumnHeaderMouseClick += summaryTable_ColumnHeaderMouseClick;
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            summaryLabel.ForeColor = Color.FromArgb(37, 42, 69);
            summaryLabel.Location = new Point(43, 37);
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