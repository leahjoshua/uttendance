namespace UttendanceDesktop.CoursepageContent
{
    partial class CreateAttendanceFormPage
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
            addQuestionBtn = new Button();
            saveBtn = new Button();
            questionsListingPanel = new Panel();
            defaultQuestionsTxt = new Label();
            label2 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            questionBankLabel = new Label();
            attendanceFormsLabel = new Label();
            createFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // createFormPanel
            // 
            createFormPanel.BackColor = Color.FromArgb(166, 176, 230);
            createFormPanel.Controls.Add(addQuestionBtn);
            createFormPanel.Controls.Add(saveBtn);
            createFormPanel.Controls.Add(questionsListingPanel);
            createFormPanel.Controls.Add(defaultQuestionsTxt);
            createFormPanel.Controls.Add(label2);
            createFormPanel.Controls.Add(dateTimePicker4);
            createFormPanel.Controls.Add(label4);
            createFormPanel.Controls.Add(dateTimePicker1);
            createFormPanel.Controls.Add(label1);
            createFormPanel.Controls.Add(questionBankLabel);
            createFormPanel.Controls.Add(attendanceFormsLabel);
            createFormPanel.Location = new Point(0, 0);
            createFormPanel.Margin = new Padding(2);
            createFormPanel.Name = "createFormPanel";
            createFormPanel.Size = new Size(914, 600);
            createFormPanel.TabIndex = 0;
            // 
            // addQuestionBtn
            // 
            addQuestionBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addQuestionBtn.BackColor = Color.Transparent;
            addQuestionBtn.Cursor = Cursors.Hand;
            addQuestionBtn.FlatAppearance.BorderSize = 0;
            addQuestionBtn.FlatStyle = FlatStyle.Flat;
            addQuestionBtn.Image = Properties.Resources.add_icon;
            addQuestionBtn.Location = new Point(779, 175);
            addQuestionBtn.Margin = new Padding(3, 4, 3, 4);
            addQuestionBtn.Name = "addQuestionBtn";
            addQuestionBtn.Size = new Size(54, 66);
            addQuestionBtn.TabIndex = 2;
            addQuestionBtn.UseVisualStyleBackColor = false;
            addQuestionBtn.Click += addQuestionBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(24, 162, 104);
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.Control;
            saveBtn.Location = new Point(742, 54);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 37);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // questionsListingPanel
            // 
            questionsListingPanel.AutoScroll = true;
            questionsListingPanel.Location = new Point(89, 244);
            questionsListingPanel.Margin = new Padding(2);
            questionsListingPanel.Name = "questionsListingPanel";
            questionsListingPanel.Size = new Size(747, 314);
            questionsListingPanel.TabIndex = 3;
            // 
            // defaultQuestionsTxt
            // 
            defaultQuestionsTxt.AutoSize = true;
            defaultQuestionsTxt.Font = new Font("Segoe UI", 12F);
            defaultQuestionsTxt.ForeColor = Color.FromArgb(58, 64, 99);
            defaultQuestionsTxt.Location = new Point(89, 244);
            defaultQuestionsTxt.Name = "defaultQuestionsTxt";
            defaultQuestionsTxt.Size = new Size(663, 56);
            defaultQuestionsTxt.TabIndex = 10;
            defaultQuestionsTxt.Text = "Looks like you currently don’t have any questions!\nLeave this section blank if you wish to create a default Attendance Check-in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(37, 42, 69);
            label2.Location = new Point(66, 194);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 9;
            label2.Text = "Quiz Questions";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CustomFormat = "MMMMdd, yyyy  |  hh:mm tt";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(391, 157);
            dateTimePicker4.Margin = new Padding(2);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(273, 27);
            dateTimePicker4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(37, 42, 69);
            label4.Location = new Point(391, 123);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 7;
            label4.Text = "Close Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMMdd, yyyy  |  hh:mm tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(89, 157);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(273, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(37, 42, 69);
            label1.Location = new Point(89, 123);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 3;
            label1.Text = "Release Date";
            // 
            // questionBankLabel
            // 
            questionBankLabel.AutoSize = true;
            questionBankLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionBankLabel.ForeColor = Color.FromArgb(37, 42, 69);
            questionBankLabel.Location = new Point(66, 91);
            questionBankLabel.Name = "questionBankLabel";
            questionBankLabel.Size = new Size(86, 32);
            questionBankLabel.TabIndex = 2;
            questionBankLabel.Text = "Details";
            // 
            // attendanceFormsLabel
            // 
            attendanceFormsLabel.AutoSize = true;
            attendanceFormsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceFormsLabel.ForeColor = Color.FromArgb(37, 42, 69);
            attendanceFormsLabel.Location = new Point(49, 46);
            attendanceFormsLabel.Name = "attendanceFormsLabel";
            attendanceFormsLabel.Size = new Size(315, 41);
            attendanceFormsLabel.TabIndex = 1;
            attendanceFormsLabel.Text = "New Attendance Form";
            // 
            // CreateAttendanceFormPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(createFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "CreateAttendanceFormPage";
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
        private Panel questionsListingPanel;
        private Button saveBtn;
    }
}