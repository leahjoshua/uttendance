namespace UttendanceDesktop.CoursepageContent
{
    partial class CreateAttendanceFormModal
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
            createFormPanel = new Panel();
            label2 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            questionBankLabel = new Label();
            attendanceFormsLabel = new Label();
            addQuestionBtn = new Button();
            defaultQuestionsTxt = new Label();
            createFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // createFormPanel
            // 
            createFormPanel.BackColor = Color.FromArgb(166, 176, 230);
            createFormPanel.Controls.Add(defaultQuestionsTxt);
            createFormPanel.Controls.Add(label2);
            createFormPanel.Controls.Add(dateTimePicker4);
            createFormPanel.Controls.Add(label4);
            createFormPanel.Controls.Add(dateTimePicker1);
            createFormPanel.Controls.Add(label1);
            createFormPanel.Controls.Add(questionBankLabel);
            createFormPanel.Controls.Add(attendanceFormsLabel);
            createFormPanel.Location = new Point(0, 0);
            createFormPanel.Name = "createFormPanel";
            createFormPanel.Size = new Size(1143, 750);
            createFormPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(37, 42, 69);
            label2.Location = new Point(83, 254);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(210, 40);
            label2.TabIndex = 9;
            label2.Text = "Quiz Questions";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CustomFormat = "MMMMdd, yyyy  |  hh:mm tt";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(489, 207);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(340, 31);
            dateTimePicker4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(37, 42, 69);
            label4.Location = new Point(489, 165);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 7;
            label4.Text = "Close Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMMdd, yyyy  |  hh:mm tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(111, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(340, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(37, 42, 69);
            label1.Location = new Point(111, 165);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 3;
            label1.Text = "Release Date";
            // 
            // questionBankLabel
            // 
            questionBankLabel.AutoSize = true;
            questionBankLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionBankLabel.ForeColor = Color.FromArgb(37, 42, 69);
            questionBankLabel.Location = new Point(83, 119);
            questionBankLabel.Margin = new Padding(4, 0, 4, 0);
            questionBankLabel.Name = "questionBankLabel";
            questionBankLabel.Size = new Size(103, 40);
            questionBankLabel.TabIndex = 2;
            questionBankLabel.Text = "Details";
            // 
            // attendanceFormsLabel
            // 
            attendanceFormsLabel.AutoSize = true;
            attendanceFormsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceFormsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            attendanceFormsLabel.Location = new Point(61, 62);
            attendanceFormsLabel.Margin = new Padding(4, 0, 4, 0);
            attendanceFormsLabel.Name = "attendanceFormsLabel";
            attendanceFormsLabel.Size = new Size(376, 48);
            attendanceFormsLabel.TabIndex = 1;
            attendanceFormsLabel.Text = "New Attendance Form";
            // 
            // addQuestionBtn
            // 
            addQuestionBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addQuestionBtn.BackColor = Color.FromArgb(166, 176, 230);
            addQuestionBtn.Cursor = Cursors.Hand;
            addQuestionBtn.FlatAppearance.BorderSize = 0;
            addQuestionBtn.FlatStyle = FlatStyle.Flat;
            addQuestionBtn.Image = Properties.Resources.add_icon;
            addQuestionBtn.Location = new Point(1037, 630);
            addQuestionBtn.Margin = new Padding(4, 5, 4, 5);
            addQuestionBtn.Name = "addQuestionBtn";
            addQuestionBtn.Size = new Size(67, 83);
            addQuestionBtn.TabIndex = 2;
            addQuestionBtn.UseVisualStyleBackColor = false;
            addQuestionBtn.Click += addQuestionBtn_Click;
            // 
            // defaultQuestionsTxt
            // 
            defaultQuestionsTxt.AutoSize = true;
            defaultQuestionsTxt.Font = new Font("Segoe UI", 12F);
            defaultQuestionsTxt.ForeColor = Color.FromArgb(58, 64, 99);
            defaultQuestionsTxt.Location = new Point(111, 310);
            defaultQuestionsTxt.Margin = new Padding(4, 0, 4, 0);
            defaultQuestionsTxt.Name = "defaultQuestionsTxt";
            defaultQuestionsTxt.Size = new Size(823, 64);
            defaultQuestionsTxt.TabIndex = 10;
            defaultQuestionsTxt.Text = "Looks like you currently don’t have any questions!\nLeave this section blank if you wish to create a default Attendance Check-in";
            // 
            // CreateAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(addQuestionBtn);
            Controls.Add(createFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAttendanceForm";
            Text = "CreateAttendanceForm";
            createFormPanel.ResumeLayout(false);
            createFormPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel createFormPanel;
        private Label attendanceFormsLabel;
        private Label questionBankLabel;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker4;
        private Label label4;
        private Label label2;
        private Button addQuestionBtn;
        private Label defaultQuestionsTxt;
    }
}