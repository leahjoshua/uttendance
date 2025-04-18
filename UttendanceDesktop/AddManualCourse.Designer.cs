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
            createLabel = new Label();
            overlayPanel.SuspendLayout();
            SuspendLayout();
            // 
            // overlayPanel
            // 
            overlayPanel.BackColor = Color.FromArgb(166, 176, 230);
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
            overlayPanel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            overlayPanel.ForeColor = Color.Silver;
            overlayPanel.Location = new Point(23, 62);
            overlayPanel.Margin = new Padding(2);
            overlayPanel.Name = "overlayPanel";
            overlayPanel.Size = new Size(863, 394);
            overlayPanel.TabIndex = 0;
            // 
            // classIDTextBox
            // 
            classIDTextBox.ForeColor = Color.FromArgb(168, 180, 228);
            classIDTextBox.Location = new Point(639, 148);
            classIDTextBox.Margin = new Padding(2);
            classIDTextBox.MaxLength = 11;
            classIDTextBox.Name = "classIDTextBox";
            classIDTextBox.Size = new Size(155, 34);
            classIDTextBox.TabIndex = 18;
            classIDTextBox.Text = "E.g. 21868";
            classIDTextBox.TextChanged += ClassIDTextBox_TextChanged;
            classIDTextBox.Enter += ClassIDTextBox_Enter;
            classIDTextBox.KeyPress += OnlyNumber_KeyPress;
            classIDTextBox.Leave += ClassIDTextBox_Leave;
            // 
            // sectionNumberTextBox
            // 
            sectionNumberTextBox.ForeColor = Color.FromArgb(168, 180, 228);
            sectionNumberTextBox.Location = new Point(409, 148);
            sectionNumberTextBox.Margin = new Padding(2);
            sectionNumberTextBox.MaxLength = 11;
            sectionNumberTextBox.Name = "sectionNumberTextBox";
            sectionNumberTextBox.Size = new Size(134, 34);
            sectionNumberTextBox.TabIndex = 17;
            sectionNumberTextBox.Text = "E.g. 0W3";
            sectionNumberTextBox.TextChanged += SectionNumberTextBox_TextChanged;
            sectionNumberTextBox.Enter += SectionNumberTextBox_Enter;
            sectionNumberTextBox.KeyPress += OnlyNumber_KeyPress;
            sectionNumberTextBox.Leave += SectionNumberTextBox_Leave;
            // 
            // classNumberTextBox
            // 
            classNumberTextBox.ForeColor = Color.FromArgb(168, 180, 228);
            classNumberTextBox.Location = new Point(204, 148);
            classNumberTextBox.Margin = new Padding(2);
            classNumberTextBox.MaxLength = 11;
            classNumberTextBox.Name = "classNumberTextBox";
            classNumberTextBox.Size = new Size(134, 34);
            classNumberTextBox.TabIndex = 16;
            classNumberTextBox.Text = "E.g. 4485";
            classNumberTextBox.TextChanged += ClassNumberTextBox_TextChanged;
            classNumberTextBox.Enter += ClassNumberTextBox_Enter;
            classNumberTextBox.KeyPress += OnlyNumber_KeyPress;
            classNumberTextBox.Leave += ClassNumberTextBox_Leave;
            // 
            // classPrefixTextBox
            // 
            classPrefixTextBox.ForeColor = Color.FromArgb(168, 180, 228);
            classPrefixTextBox.Location = new Point(34, 148);
            classPrefixTextBox.Margin = new Padding(2);
            classPrefixTextBox.MaxLength = 5;
            classPrefixTextBox.Name = "classPrefixTextBox";
            classPrefixTextBox.Size = new Size(102, 34);
            classPrefixTextBox.TabIndex = 15;
            classPrefixTextBox.Text = "E.g. CS";
            classPrefixTextBox.TextChanged += ClassPrefixTextBox_TextChanged;
            classPrefixTextBox.Enter += ClassPrefixTextBox_Enter;
            classPrefixTextBox.Leave += ClassPrefixTextBox_Leave;
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.ForeColor = Color.FromArgb(168, 180, 228);
            courseNameTextBox.Location = new Point(34, 60);
            courseNameTextBox.Margin = new Padding(2);
            courseNameTextBox.MaxLength = 40;
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(692, 34);
            courseNameTextBox.TabIndex = 14;
            courseNameTextBox.Text = "Enter course name (E.g. Computer Science Project)";
            courseNameTextBox.TextChanged += CourseNameTextBox_TextChanged;
            courseNameTextBox.Enter += CourseNameTextBox_Enter;
            courseNameTextBox.Leave += CourseNameTextBox_Leave;
            // 
            // CIDStarLabel
            // 
            CIDStarLabel.AutoSize = true;
            CIDStarLabel.ForeColor = Color.Red;
            CIDStarLabel.Location = new Point(730, 117);
            CIDStarLabel.Margin = new Padding(2, 0, 2, 0);
            CIDStarLabel.Name = "CIDStarLabel";
            CIDStarLabel.Size = new Size(23, 29);
            CIDStarLabel.TabIndex = 13;
            CIDStarLabel.Text = "*";
            // 
            // SNStarLabel
            // 
            SNStarLabel.AutoSize = true;
            SNStarLabel.ForeColor = Color.Red;
            SNStarLabel.Location = new Point(581, 117);
            SNStarLabel.Margin = new Padding(2, 0, 2, 0);
            SNStarLabel.Name = "SNStarLabel";
            SNStarLabel.Size = new Size(23, 29);
            SNStarLabel.TabIndex = 12;
            SNStarLabel.Text = "*";
            // 
            // CNuStarLabel
            // 
            CNuStarLabel.AutoSize = true;
            CNuStarLabel.ForeColor = Color.Red;
            CNuStarLabel.Location = new Point(355, 116);
            CNuStarLabel.Margin = new Padding(2, 0, 2, 0);
            CNuStarLabel.Name = "CNuStarLabel";
            CNuStarLabel.Size = new Size(23, 29);
            CNuStarLabel.TabIndex = 11;
            CNuStarLabel.Text = "*";
            // 
            // CPStarLabel
            // 
            CPStarLabel.AutoSize = true;
            CPStarLabel.ForeColor = Color.Red;
            CPStarLabel.Location = new Point(158, 116);
            CPStarLabel.Margin = new Padding(2, 0, 2, 0);
            CPStarLabel.Name = "CPStarLabel";
            CPStarLabel.Size = new Size(23, 29);
            CPStarLabel.TabIndex = 10;
            CPStarLabel.Text = "*";
            // 
            // CNStarLabel
            // 
            CNStarLabel.AutoSize = true;
            CNStarLabel.ForeColor = Color.Red;
            CNStarLabel.Location = new Point(184, 29);
            CNStarLabel.Margin = new Padding(2, 0, 2, 0);
            CNStarLabel.Name = "CNStarLabel";
            CNStarLabel.Size = new Size(23, 29);
            CNStarLabel.TabIndex = 9;
            CNStarLabel.Text = "*";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(88, 101, 168);
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Microsoft Sans Serif", 15.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(601, 327);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(107, 43);
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
            createButton.Font = new Font("Microsoft Sans Serif", 15.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createButton.ForeColor = Color.White;
            createButton.Location = new Point(730, 327);
            createButton.Margin = new Padding(2);
            createButton.Name = "createButton";
            createButton.Size = new Size(107, 43);
            createButton.TabIndex = 5;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += CreateButton_Click;
            // 
            // classIDLabel
            // 
            classIDLabel.AutoSize = true;
            classIDLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classIDLabel.ForeColor = Color.FromArgb(37, 42, 69);
            classIDLabel.Location = new Point(629, 116);
            classIDLabel.Margin = new Padding(2, 0, 2, 0);
            classIDLabel.Name = "classIDLabel";
            classIDLabel.Size = new Size(102, 29);
            classIDLabel.TabIndex = 4;
            classIDLabel.Text = "Class ID";
            // 
            // sectionNumberLabel
            // 
            sectionNumberLabel.AutoSize = true;
            sectionNumberLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sectionNumberLabel.ForeColor = Color.FromArgb(37, 42, 69);
            sectionNumberLabel.Location = new Point(399, 116);
            sectionNumberLabel.Margin = new Padding(2, 0, 2, 0);
            sectionNumberLabel.Name = "sectionNumberLabel";
            sectionNumberLabel.Size = new Size(187, 29);
            sectionNumberLabel.TabIndex = 3;
            sectionNumberLabel.Text = "Section Number";
            // 
            // classNumberLabel
            // 
            classNumberLabel.AutoSize = true;
            classNumberLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classNumberLabel.ForeColor = Color.FromArgb(37, 42, 69);
            classNumberLabel.Location = new Point(195, 116);
            classNumberLabel.Margin = new Padding(2, 0, 2, 0);
            classNumberLabel.Name = "classNumberLabel";
            classNumberLabel.Size = new Size(166, 29);
            classNumberLabel.TabIndex = 2;
            classNumberLabel.Text = "Class Number";
            // 
            // classPrefixLabel
            // 
            classPrefixLabel.AutoSize = true;
            classPrefixLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classPrefixLabel.ForeColor = Color.FromArgb(37, 42, 69);
            classPrefixLabel.Location = new Point(28, 116);
            classPrefixLabel.Margin = new Padding(2, 0, 2, 0);
            classPrefixLabel.Name = "classPrefixLabel";
            classPrefixLabel.Size = new Size(140, 29);
            classPrefixLabel.TabIndex = 1;
            classPrefixLabel.Text = "Class Prefix";
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseNameLabel.ForeColor = Color.FromArgb(37, 42, 69);
            courseNameLabel.Location = new Point(28, 28);
            courseNameLabel.Margin = new Padding(2, 0, 2, 0);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new Size(162, 29);
            courseNameLabel.TabIndex = 0;
            courseNameLabel.Text = "Course Name";
            // 
            // createLabel
            // 
            createLabel.AutoSize = true;
            createLabel.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createLabel.ForeColor = Color.FromArgb(37, 42, 69);
            createLabel.Location = new Point(23, 12);
            createLabel.Margin = new Padding(2, 0, 2, 0);
            createLabel.Name = "createLabel";
            createLabel.Size = new Size(274, 42);
            createLabel.TabIndex = 1;
            createLabel.Text = "Create Course";
            // 
            // AddManualCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(166, 176, 230);
            ClientSize = new Size(903, 469);
            Controls.Add(createLabel);
            Controls.Add(overlayPanel);
            Margin = new Padding(2);
            Name = "AddManualCourse";
            Text = "Create Course";
            overlayPanel.ResumeLayout(false);
            overlayPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel overlayPanel;
        private Label createLabel;
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
    }
}