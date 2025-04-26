namespace UttendanceDesktop
{
    partial class AddManualCourse
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
            overlayPanel = new Panel();
            classIDTextBox = new TextBox();
            sectionNumberTextBox = new TextBox();
            classNumberTextBox = new TextBox();
            classPrefixTextBox = new TextBox();
            courseNameTextBox = new TextBox();
            CIDStarLabel = new Label();
            SNStarLabel = new Label();
            CNuStarLabel = new Label();
            CPStarLabel = new Label();
            CNStarLabel = new Label();
            cancelButton = new Button();
            createButton = new Button();
            classIDLabel = new Label();
            sectionNumberLabel = new Label();
            classNumberLabel = new Label();
            classPrefixLabel = new Label();
            courseNameLabel = new Label();
            startTimePicker = new DateTimePicker();
            classStartTimeLabel = new Label();
            CSTStarLabel = new Label();
            label1 = new Label();
            classEndTimeLabel = new Label();
            endTimePicker = new DateTimePicker();
            overlayPanel.SuspendLayout();
            SuspendLayout();
            // 
            // overlayPanel
            // 
            overlayPanel.BackColor = Color.FromArgb(166, 176, 230);
            overlayPanel.Controls.Add(label1);
            overlayPanel.Controls.Add(classEndTimeLabel);
            overlayPanel.Controls.Add(endTimePicker);
            overlayPanel.Controls.Add(CSTStarLabel);
            overlayPanel.Controls.Add(classStartTimeLabel);
            overlayPanel.Controls.Add(startTimePicker);
            overlayPanel.Controls.Add(classIDTextBox);
            overlayPanel.Controls.Add(sectionNumberTextBox);
            overlayPanel.Controls.Add(classNumberTextBox);
            overlayPanel.Controls.Add(classPrefixTextBox);
            overlayPanel.Controls.Add(courseNameTextBox);
            overlayPanel.Controls.Add(CIDStarLabel);
            overlayPanel.Controls.Add(SNStarLabel);
            overlayPanel.Controls.Add(CNuStarLabel);
            overlayPanel.Controls.Add(CPStarLabel);
            overlayPanel.Controls.Add(CNStarLabel);
            overlayPanel.Controls.Add(cancelButton);
            overlayPanel.Controls.Add(createButton);
            overlayPanel.Controls.Add(classIDLabel);
            overlayPanel.Controls.Add(sectionNumberLabel);
            overlayPanel.Controls.Add(classNumberLabel);
            overlayPanel.Controls.Add(classPrefixLabel);
            overlayPanel.Controls.Add(courseNameLabel);
            overlayPanel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            overlayPanel.ForeColor = Color.Silver;
            overlayPanel.Location = new Point(0, 1);
            overlayPanel.Margin = new Padding(2);
            overlayPanel.Name = "overlayPanel";
            overlayPanel.Size = new Size(633, 274);
            overlayPanel.TabIndex = 0;
            // 
            // classIDTextBox
            // 
            classIDTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classIDTextBox.ForeColor = Color.FromArgb(168, 180, 228);
            classIDTextBox.Location = new Point(470, 111);
            classIDTextBox.Margin = new Padding(2);
            classIDTextBox.MaxLength = 11;
            classIDTextBox.Name = "classIDTextBox";
            classIDTextBox.Size = new Size(138, 27);
            classIDTextBox.TabIndex = 18;
            classIDTextBox.Text = "E.g. 21868";
            classIDTextBox.TextChanged += ClassIDTextBox_TextChanged;
            classIDTextBox.Enter += ClassIDTextBox_Enter;
            classIDTextBox.KeyPress += OnlyNumber_KeyPress;
            classIDTextBox.Leave += ClassIDTextBox_Leave;
            // 
            // sectionNumberTextBox
            // 
            sectionNumberTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sectionNumberTextBox.ForeColor = Color.FromArgb(168, 180, 228);
            sectionNumberTextBox.Location = new Point(310, 111);
            sectionNumberTextBox.Margin = new Padding(2);
            sectionNumberTextBox.MaxLength = 11;
            sectionNumberTextBox.Name = "sectionNumberTextBox";
            sectionNumberTextBox.Size = new Size(121, 27);
            sectionNumberTextBox.TabIndex = 17;
            sectionNumberTextBox.Text = "E.g. 0W3";
            sectionNumberTextBox.TextChanged += SectionNumberTextBox_TextChanged;
            sectionNumberTextBox.Enter += SectionNumberTextBox_Enter;
            sectionNumberTextBox.KeyPress += OnlyNumber_KeyPress;
            sectionNumberTextBox.Leave += SectionNumberTextBox_Leave;
            // 
            // classNumberTextBox
            // 
            classNumberTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classNumberTextBox.ForeColor = Color.FromArgb(168, 180, 228);
            classNumberTextBox.Location = new Point(152, 111);
            classNumberTextBox.Margin = new Padding(2);
            classNumberTextBox.MaxLength = 11;
            classNumberTextBox.Name = "classNumberTextBox";
            classNumberTextBox.Size = new Size(123, 27);
            classNumberTextBox.TabIndex = 16;
            classNumberTextBox.Text = "E.g. 4485";
            classNumberTextBox.TextChanged += ClassNumberTextBox_TextChanged;
            classNumberTextBox.Enter += ClassNumberTextBox_Enter;
            classNumberTextBox.KeyPress += OnlyNumber_KeyPress;
            classNumberTextBox.Leave += ClassNumberTextBox_Leave;
            // 
            // classPrefixTextBox
            // 
            classPrefixTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classPrefixTextBox.ForeColor = Color.FromArgb(168, 180, 228);
            classPrefixTextBox.Location = new Point(24, 111);
            classPrefixTextBox.Margin = new Padding(2);
            classPrefixTextBox.MaxLength = 5;
            classPrefixTextBox.Name = "classPrefixTextBox";
            classPrefixTextBox.Size = new Size(96, 27);
            classPrefixTextBox.TabIndex = 15;
            classPrefixTextBox.Text = "E.g. CS";
            classPrefixTextBox.TextChanged += ClassPrefixTextBox_TextChanged;
            classPrefixTextBox.Enter += ClassPrefixTextBox_Enter;
            classPrefixTextBox.Leave += ClassPrefixTextBox_Leave;
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseNameTextBox.ForeColor = Color.FromArgb(168, 180, 228);
            courseNameTextBox.Location = new Point(24, 45);
            courseNameTextBox.Margin = new Padding(2);
            courseNameTextBox.MaxLength = 40;
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(584, 27);
            courseNameTextBox.TabIndex = 14;
            courseNameTextBox.Text = "Enter course name (E.g. Computer Science Project)";
            courseNameTextBox.TextChanged += CourseNameTextBox_TextChanged;
            courseNameTextBox.Enter += CourseNameTextBox_Enter;
            courseNameTextBox.Leave += CourseNameTextBox_Leave;
            // 
            // CIDStarLabel
            // 
            CIDStarLabel.AutoSize = true;
            CIDStarLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CIDStarLabel.ForeColor = Color.Red;
            CIDStarLabel.Location = new Point(534, 83);
            CIDStarLabel.Margin = new Padding(2, 0, 2, 0);
            CIDStarLabel.Name = "CIDStarLabel";
            CIDStarLabel.Size = new Size(20, 25);
            CIDStarLabel.TabIndex = 13;
            CIDStarLabel.Text = "*";
            // 
            // SNStarLabel
            // 
            SNStarLabel.AutoSize = true;
            SNStarLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SNStarLabel.ForeColor = Color.Red;
            SNStarLabel.Location = new Point(431, 83);
            SNStarLabel.Margin = new Padding(2, 0, 2, 0);
            SNStarLabel.Name = "SNStarLabel";
            SNStarLabel.Size = new Size(20, 25);
            SNStarLabel.TabIndex = 12;
            SNStarLabel.Text = "*";
            // 
            // CNuStarLabel
            // 
            CNuStarLabel.AutoSize = true;
            CNuStarLabel.ForeColor = Color.Red;
            CNuStarLabel.Location = new Point(256, 83);
            CNuStarLabel.Margin = new Padding(2, 0, 2, 0);
            CNuStarLabel.Name = "CNuStarLabel";
            CNuStarLabel.Size = new Size(13, 17);
            CNuStarLabel.TabIndex = 11;
            CNuStarLabel.Text = "*";
            // 
            // CPStarLabel
            // 
            CPStarLabel.AutoSize = true;
            CPStarLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CPStarLabel.ForeColor = Color.Red;
            CPStarLabel.Location = new Point(114, 83);
            CPStarLabel.Margin = new Padding(2, 0, 2, 0);
            CPStarLabel.Name = "CPStarLabel";
            CPStarLabel.Size = new Size(20, 25);
            CPStarLabel.TabIndex = 10;
            CPStarLabel.Text = "*";
            // 
            // CNStarLabel
            // 
            CNStarLabel.AutoSize = true;
            CNStarLabel.BackColor = Color.Transparent;
            CNStarLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CNStarLabel.ForeColor = Color.Red;
            CNStarLabel.Location = new Point(125, 16);
            CNStarLabel.Margin = new Padding(2, 0, 2, 0);
            CNStarLabel.Name = "CNStarLabel";
            CNStarLabel.Size = new Size(20, 25);
            CNStarLabel.TabIndex = 9;
            CNStarLabel.Text = "*";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(88, 101, 168);
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(425, 223);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(84, 32);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // createButton
            // 
            createButton.BackColor = Color.FromArgb(233, 117, 2);
            createButton.FlatAppearance.BorderSize = 0;
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createButton.ForeColor = Color.White;
            createButton.Location = new Point(522, 223);
            createButton.Margin = new Padding(2);
            createButton.Name = "createButton";
            createButton.Size = new Size(84, 32);
            createButton.TabIndex = 5;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += CreateButton_Click;
            // 
            // classIDLabel
            // 
            classIDLabel.AutoSize = true;
            classIDLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            classIDLabel.ForeColor = Color.FromArgb(37, 42, 69);
            classIDLabel.Location = new Point(470, 87);
            classIDLabel.Margin = new Padding(2, 0, 2, 0);
            classIDLabel.Name = "classIDLabel";
            classIDLabel.Size = new Size(64, 20);
            classIDLabel.TabIndex = 4;
            classIDLabel.Text = "Class ID";
            // 
            // sectionNumberLabel
            // 
            sectionNumberLabel.AutoSize = true;
            sectionNumberLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sectionNumberLabel.ForeColor = Color.FromArgb(37, 42, 69);
            sectionNumberLabel.Location = new Point(310, 87);
            sectionNumberLabel.Margin = new Padding(2, 0, 2, 0);
            sectionNumberLabel.Name = "sectionNumberLabel";
            sectionNumberLabel.Size = new Size(122, 20);
            sectionNumberLabel.TabIndex = 3;
            sectionNumberLabel.Text = "Section Number";
            // 
            // classNumberLabel
            // 
            classNumberLabel.AutoSize = true;
            classNumberLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            classNumberLabel.ForeColor = Color.FromArgb(37, 42, 69);
            classNumberLabel.Location = new Point(152, 87);
            classNumberLabel.Margin = new Padding(2, 0, 2, 0);
            classNumberLabel.Name = "classNumberLabel";
            classNumberLabel.Size = new Size(106, 20);
            classNumberLabel.TabIndex = 2;
            classNumberLabel.Text = "Class Number";
            // 
            // classPrefixLabel
            // 
            classPrefixLabel.AutoSize = true;
            classPrefixLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            classPrefixLabel.ForeColor = Color.FromArgb(37, 42, 69);
            classPrefixLabel.Location = new Point(26, 87);
            classPrefixLabel.Margin = new Padding(2, 0, 2, 0);
            classPrefixLabel.Name = "classPrefixLabel";
            classPrefixLabel.Size = new Size(89, 20);
            classPrefixLabel.TabIndex = 1;
            classPrefixLabel.Text = "Class Prefix";
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courseNameLabel.ForeColor = Color.FromArgb(37, 42, 69);
            courseNameLabel.Location = new Point(24, 21);
            courseNameLabel.Margin = new Padding(2, 0, 2, 0);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new Size(103, 20);
            courseNameLabel.TabIndex = 0;
            courseNameLabel.Text = "Course Name";
            // 
            // startTimePicker
            // 
            startTimePicker.Format = DateTimePickerFormat.Time;
            startTimePicker.Location = new Point(24, 179);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new Size(119, 25);
            startTimePicker.TabIndex = 19;
            // 
            // classStartTimeLabel
            // 
            classStartTimeLabel.AutoSize = true;
            classStartTimeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            classStartTimeLabel.ForeColor = Color.FromArgb(37, 42, 69);
            classStartTimeLabel.Location = new Point(26, 156);
            classStartTimeLabel.Margin = new Padding(2, 0, 2, 0);
            classStartTimeLabel.Name = "classStartTimeLabel";
            classStartTimeLabel.Size = new Size(121, 20);
            classStartTimeLabel.TabIndex = 20;
            classStartTimeLabel.Text = "Class Start Time";
            // 
            // CSTStarLabel
            // 
            CSTStarLabel.AutoSize = true;
            CSTStarLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CSTStarLabel.ForeColor = Color.Red;
            CSTStarLabel.Location = new Point(148, 152);
            CSTStarLabel.Margin = new Padding(2, 0, 2, 0);
            CSTStarLabel.Name = "CSTStarLabel";
            CSTStarLabel.Size = new Size(20, 25);
            CSTStarLabel.TabIndex = 21;
            CSTStarLabel.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(288, 152);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 24;
            label1.Text = "*";
            // 
            // classEndTimeLabel
            // 
            classEndTimeLabel.AutoSize = true;
            classEndTimeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            classEndTimeLabel.ForeColor = Color.FromArgb(37, 42, 69);
            classEndTimeLabel.Location = new Point(175, 156);
            classEndTimeLabel.Margin = new Padding(2, 0, 2, 0);
            classEndTimeLabel.Name = "classEndTimeLabel";
            classEndTimeLabel.Size = new Size(113, 20);
            classEndTimeLabel.TabIndex = 23;
            classEndTimeLabel.Text = "Class End Time";
            // 
            // endTimePicker
            // 
            endTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.Location = new Point(173, 179);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(119, 25);
            endTimePicker.TabIndex = 22;
            // 
            // AddManualCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(629, 272);
            Controls.Add(overlayPanel);
            Margin = new Padding(2);
            Name = "AddManualCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Course";
            overlayPanel.ResumeLayout(false);
            overlayPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel overlayPanel;
        private Label courseNameLabel;
        private Label classPrefixLabel;
        private Label classNumberLabel;
        private Label sectionNumberLabel;
        private Button createButton;
        private Label classIDLabel;
        private Button cancelButton;
        private Label SNStarLabel;
        private Label CNuStarLabel;
        private Label CPStarLabel;
        private Label CNStarLabel;
        private Label CIDStarLabel;
        private TextBox classNumberTextBox;
        private TextBox classPrefixTextBox;
        private TextBox sectionNumberTextBox;
        private TextBox classIDTextBox;
        private TextBox courseNameTextBox;
        private Label label1;
        private Label classEndTimeLabel;
        private DateTimePicker endTimePicker;
        private Label CSTStarLabel;
        private Label classStartTimeLabel;
        private DateTimePicker startTimePicker;
    }
}