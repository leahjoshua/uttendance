using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 28, 2025.
    // NetID: jxy210012
    // Wrote the whole Students class
    partial class Students
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
            studentsPagePanel = new Panel();
            studentsLabel = new Label();
            addPanel = new Panel();
            importStudentsBtn = new Button();
            addStudentsBtn = new Button();
            studentTable = new DataGridView();
            deleteBtn = new Button();
            addBtn = new Button();
            studentsPagePanel.SuspendLayout();
            addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentTable).BeginInit();
            SuspendLayout();
            // 
            // studentsPagePanel
            // 
            studentsPagePanel.BackColor = Color.FromArgb(166, 176, 230);
            studentsPagePanel.Controls.Add(studentsLabel);
            studentsPagePanel.Controls.Add(addPanel);
            studentsPagePanel.Controls.Add(studentTable);
            studentsPagePanel.Controls.Add(deleteBtn);
            studentsPagePanel.Controls.Add(addBtn);
            studentsPagePanel.Dock = DockStyle.Fill;
            studentsPagePanel.Location = new Point(0, 0);
            studentsPagePanel.Margin = new Padding(3, 4, 3, 4);
            studentsPagePanel.Name = "studentsPagePanel";
            studentsPagePanel.Size = new Size(914, 600);
            studentsPagePanel.TabIndex = 0;
            studentsPagePanel.Click += studentsPagePanel_Click;
            // 
            // studentsLabel
            // 
            studentsLabel.AutoSize = true;
            studentsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            studentsLabel.Location = new Point(49, 49);
            studentsLabel.Name = "studentsLabel";
            studentsLabel.Size = new Size(134, 41);
            studentsLabel.TabIndex = 0;
            studentsLabel.Text = "Students";
            // 
            // addPanel
            // 
            addPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addPanel.Controls.Add(importStudentsBtn);
            addPanel.Controls.Add(addStudentsBtn);
            addPanel.Location = new Point(770, 419);
            addPanel.Margin = new Padding(3, 4, 3, 4);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(130, 88);
            addPanel.TabIndex = 4;
            addPanel.Visible = false;
            // 
            // importStudentsBtn
            // 
            importStudentsBtn.BackColor = Color.FromArgb(224, 224, 224);
            importStudentsBtn.FlatStyle = FlatStyle.Flat;
            importStudentsBtn.ForeColor = Color.FromArgb(37, 42, 69);
            importStudentsBtn.Location = new Point(0, 44);
            importStudentsBtn.Margin = new Padding(3, 4, 3, 4);
            importStudentsBtn.Name = "importStudentsBtn";
            importStudentsBtn.Size = new Size(126, 44);
            importStudentsBtn.TabIndex = 5;
            importStudentsBtn.Text = "Import Students";
            importStudentsBtn.UseVisualStyleBackColor = false;
            importStudentsBtn.Click += importStudentsBtn_Click;
            // 
            // addStudentsBtn
            // 
            addStudentsBtn.Anchor = AnchorStyles.Top;
            addStudentsBtn.BackColor = Color.FromArgb(224, 224, 224);
            addStudentsBtn.FlatStyle = FlatStyle.Flat;
            addStudentsBtn.ForeColor = Color.FromArgb(37, 42, 69);
            addStudentsBtn.Location = new Point(0, 0);
            addStudentsBtn.Margin = new Padding(3, 4, 3, 4);
            addStudentsBtn.Name = "addStudentsBtn";
            addStudentsBtn.Size = new Size(126, 48);
            addStudentsBtn.TabIndex = 5;
            addStudentsBtn.Text = "Add Students";
            addStudentsBtn.UseVisualStyleBackColor = false;
            addStudentsBtn.Click += addStudentsBtn_Click;
            // 
            // studentTable
            // 
            studentTable.AllowUserToAddRows = false;
            studentTable.AllowUserToDeleteRows = false;
            studentTable.AllowUserToResizeColumns = false;
            studentTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(206, 212, 244);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(88, 101, 168);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            studentTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            studentTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentTable.BackgroundColor = Color.FromArgb(37, 42, 69);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 42, 69);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            studentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(222, 225, 241);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(88, 101, 168);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            studentTable.DefaultCellStyle = dataGridViewCellStyle3;
            studentTable.EnableHeadersVisualStyles = false;
            studentTable.GridColor = Color.FromArgb(37, 42, 69);
            studentTable.Location = new Point(69, 137);
            studentTable.Margin = new Padding(3, 4, 3, 4);
            studentTable.Name = "studentTable";
            studentTable.RowHeadersVisible = false;
            studentTable.RowHeadersWidth = 51;
            studentTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentTable.Size = new Size(738, 397);
            studentTable.TabIndex = 0;
            studentTable.TabStop = false;
            studentTable.CellBeginEdit += studentTable_CellBeginEdit;
            studentTable.CellClick += studentTable_CellClick;
            studentTable.CellEndEdit += studentTable_CellEndEdit;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Image = Properties.Resources.trash_icon;
            deleteBtn.Location = new Point(830, 504);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(54, 67);
            deleteBtn.TabIndex = 6;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Visible = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Image = Properties.Resources.add_icon;
            addBtn.Location = new Point(830, 504);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(54, 67);
            addBtn.TabIndex = 1;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(914, 600);
            Controls.Add(studentsPagePanel);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Students";
            Text = "Students";
            studentsPagePanel.ResumeLayout(false);
            studentsPagePanel.PerformLayout();
            addPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel studentsPagePanel;
        private Label studentsLabel;
        private Button addBtn;
        private Panel addPanel;
        private Button addStudentsBtn;
        private Button importStudentsBtn;
        private Button deleteBtn;
        private DataGridView studentTable;
    }
}