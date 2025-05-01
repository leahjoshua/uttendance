namespace UttendanceDesktop
{
    partial class FormList
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
            formPagePanel = new Panel();
            formsTable = new DataGridView();
            formPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)formsTable).BeginInit();
            SuspendLayout();
            // 
            // formPagePanel
            // 
            formPagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formPagePanel.Controls.Add(formsTable);
            formPagePanel.Location = new Point(-4, -4);
            formPagePanel.Name = "formPagePanel";
            formPagePanel.Size = new Size(728, 456);
            formPagePanel.TabIndex = 0;
            // 
            // formsTable
            // 
            formsTable.AllowUserToAddRows = false;
            formsTable.AllowUserToDeleteRows = false;
            formsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(206, 212, 244);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(88, 101, 168);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            formsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            formsTable.BackgroundColor = Color.FromArgb(37, 42, 69);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 42, 69);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            formsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            formsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(222, 225, 241);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(88, 101, 168);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            formsTable.DefaultCellStyle = dataGridViewCellStyle3;
            formsTable.EnableHeadersVisualStyles = false;
            formsTable.GridColor = Color.FromArgb(37, 42, 69);
            formsTable.Location = new Point(37, 39);
            formsTable.Name = "formsTable";
            formsTable.ReadOnly = true;
            formsTable.RowHeadersVisible = false;
            formsTable.Size = new Size(654, 388);
            formsTable.TabIndex = 0;
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(720, 450);
            Controls.Add(formPagePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Forms";
            formPagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)formsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPagePanel;
        private DataGridView formsTable;
    }
}