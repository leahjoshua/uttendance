using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 28, 2025.
    // NetID: jxy210012
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
            studentsPagePanel = new Panel();
            studentsLabel = new Label();
            addPanel = new Panel();
            importStudentsBtn = new Button();
            addStudentsBtn = new Button();
            studentTablePanel = new Panel();
            studentTable = new DataGridView();
            addBtn = new Button();
            studentsPagePanel.SuspendLayout();
            addPanel.SuspendLayout();
            studentTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentTable).BeginInit();
            SuspendLayout();
            // 
            // studentsPagePanel
            // 
            studentsPagePanel.BackColor = Color.FromArgb(166, 176, 230);
            studentsPagePanel.Controls.Add(studentsLabel);
            studentsPagePanel.Controls.Add(addPanel);
            studentsPagePanel.Controls.Add(studentTablePanel);
            studentsPagePanel.Controls.Add(addBtn);
            studentsPagePanel.Dock = DockStyle.Fill;
            studentsPagePanel.Location = new Point(0, 0);
            studentsPagePanel.Name = "studentsPagePanel";
            studentsPagePanel.Size = new Size(800, 450);
            studentsPagePanel.TabIndex = 0;
            // 
            // studentsLabel
            // 
            studentsLabel.AutoSize = true;
            studentsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            studentsLabel.Location = new Point(43, 37);
            studentsLabel.Name = "studentsLabel";
            studentsLabel.Size = new Size(107, 32);
            studentsLabel.TabIndex = 0;
            studentsLabel.Text = "Students";
            // 
            // addPanel
            // 
            addPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addPanel.Controls.Add(importStudentsBtn);
            addPanel.Controls.Add(addStudentsBtn);
            addPanel.Location = new Point(674, 314);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(114, 66);
            addPanel.TabIndex = 4;
            addPanel.Visible = false;
            // 
            // importStudentsBtn
            // 
            importStudentsBtn.BackColor = Color.FromArgb(224, 224, 224);
            importStudentsBtn.FlatStyle = FlatStyle.Flat;
            importStudentsBtn.ForeColor = Color.FromArgb(37, 42, 69);
            importStudentsBtn.Location = new Point(0, 33);
            importStudentsBtn.Name = "importStudentsBtn";
            importStudentsBtn.Size = new Size(110, 33);
            importStudentsBtn.TabIndex = 5;
            importStudentsBtn.Text = "Import Students";
            importStudentsBtn.UseVisualStyleBackColor = false;
            importStudentsBtn.Click += importStudentsBtn_Click;
            // 
            // addStudentsBtn
            // 
            addStudentsBtn.BackColor = Color.FromArgb(224, 224, 224);
            addStudentsBtn.FlatStyle = FlatStyle.Flat;
            addStudentsBtn.ForeColor = Color.FromArgb(37, 42, 69);
            addStudentsBtn.Location = new Point(0, 0);
            addStudentsBtn.Name = "addStudentsBtn";
            addStudentsBtn.Size = new Size(110, 36);
            addStudentsBtn.TabIndex = 5;
            addStudentsBtn.Text = "Add Students";
            addStudentsBtn.UseVisualStyleBackColor = false;
            addStudentsBtn.Click += addStudentsBtn_Click;
            // 
            // studentTablePanel
            // 
            studentTablePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentTablePanel.Controls.Add(studentTable);
            studentTablePanel.Location = new Point(43, 130);
            studentTablePanel.Name = "studentTablePanel";
            studentTablePanel.Size = new Size(677, 298);
            studentTablePanel.TabIndex = 5;
            // 
            // studentTable
            // 
            studentTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentTable.BackgroundColor = Color.FromArgb(37, 42, 69);
            studentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentTable.Location = new Point(19, 3);
            studentTable.MultiSelect = false;
            studentTable.Name = "studentTable";
            studentTable.RowHeadersVisible = false;
            studentTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentTable.Size = new Size(638, 266);
            studentTable.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Image = Properties.Resources.add_icon;
            addBtn.Location = new Point(726, 378);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(47, 50);
            addBtn.TabIndex = 1;
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(800, 450);
            Controls.Add(studentsPagePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Students";
            Text = "Students";
            studentsPagePanel.ResumeLayout(false);
            studentsPagePanel.PerformLayout();
            addPanel.ResumeLayout(false);
            studentTablePanel.ResumeLayout(false);
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
        private Panel studentTablePanel;
        private DataGridView studentTable;
    }
}