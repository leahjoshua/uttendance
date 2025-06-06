﻿using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 14, 2025.
    // NetID: jxy210012
    partial class Coursepage
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
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            titleSideBarPanel = new Panel();
            courseLabel = new Label();
            yourCoursesBtn = new Button();
            menuBtn = new Button();
            attendanceFormsContainerPanel = new Panel();
            questionBankBtnPanel = new Panel();
            questionBankBtn = new Button();
            listingsBtnPanel = new Panel();
            listingsBtn = new Button();
            attendanceFormsPanel = new Panel();
            attendanceFormsPanelBtn = new Button();
            studentsPanel = new Panel();
            studentsPanelBtn = new Button();
            summaryPanel = new Panel();
            summaryPanelBtn = new Button();
            headerPanel = new Panel();
            headerPathTxt = new Label();
            mainPanel = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            attendanceFormsTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            titleSideBarPanel.SuspendLayout();
            attendanceFormsContainerPanel.SuspendLayout();
            questionBankBtnPanel.SuspendLayout();
            listingsBtnPanel.SuspendLayout();
            attendanceFormsPanel.SuspendLayout();
            studentsPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(37, 42, 69);
            sidebar.Controls.Add(titleSideBarPanel);
            sidebar.Controls.Add(attendanceFormsContainerPanel);
            sidebar.Controls.Add(studentsPanel);
            sidebar.Controls.Add(summaryPanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 38);
            sidebar.MaximumSize = new Size(200, 750);
            sidebar.MinimumSize = new Size(55, 750);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 750);
            sidebar.TabIndex = 0;
            // 
            // titleSideBarPanel
            // 
            titleSideBarPanel.Controls.Add(courseLabel);
            titleSideBarPanel.Controls.Add(yourCoursesBtn);
            titleSideBarPanel.Controls.Add(menuBtn);
            titleSideBarPanel.Location = new Point(3, 3);
            titleSideBarPanel.Name = "titleSideBarPanel";
            titleSideBarPanel.Size = new Size(197, 159);
            titleSideBarPanel.TabIndex = 0;
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.ForeColor = Color.White;
            courseLabel.Location = new Point(53, 66);
            courseLabel.Margin = new Padding(4, 0, 4, 0);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new Size(122, 45);
            courseLabel.TabIndex = 0;
            courseLabel.Text = "CS 4485.0w1 - \r\nCOMPUTER SCIENCE \r\nPROJECT";
            // 
            // yourCoursesBtn
            // 
            yourCoursesBtn.FlatAppearance.BorderSize = 0;
            yourCoursesBtn.FlatStyle = FlatStyle.Flat;
            yourCoursesBtn.ForeColor = Color.White;
            yourCoursesBtn.Image = Properties.Resources.home_icon;
            yourCoursesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            yourCoursesBtn.Location = new Point(0, 3);
            yourCoursesBtn.Name = "yourCoursesBtn";
            yourCoursesBtn.Padding = new Padding(7, 0, 0, 0);
            yourCoursesBtn.Size = new Size(200, 50);
            yourCoursesBtn.TabIndex = 0;
            yourCoursesBtn.Text = "      YOUR COURSES";
            yourCoursesBtn.TextAlign = ContentAlignment.MiddleLeft;
            yourCoursesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            yourCoursesBtn.UseVisualStyleBackColor = true;
            yourCoursesBtn.Click += yourCoursesBtn_Click;
            // 
            // menuBtn
            // 
            menuBtn.Cursor = Cursors.Hand;
            menuBtn.FlatAppearance.BorderSize = 0;
            menuBtn.FlatStyle = FlatStyle.Flat;
            menuBtn.ForeColor = Color.White;
            menuBtn.Image = Properties.Resources.menu_icon;
            menuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            menuBtn.Location = new Point(-3, 114);
            menuBtn.Name = "menuBtn";
            menuBtn.Padding = new Padding(10, 0, 0, 0);
            menuBtn.Size = new Size(197, 42);
            menuBtn.TabIndex = 1;
            menuBtn.Text = "     Menu";
            menuBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuBtn.UseVisualStyleBackColor = true;
            menuBtn.Click += menuBtn_Click;
            // 
            // attendanceFormsContainerPanel
            // 
            attendanceFormsContainerPanel.Controls.Add(questionBankBtnPanel);
            attendanceFormsContainerPanel.Controls.Add(listingsBtnPanel);
            attendanceFormsContainerPanel.Controls.Add(attendanceFormsPanel);
            attendanceFormsContainerPanel.Location = new Point(3, 168);
            attendanceFormsContainerPanel.MaximumSize = new Size(197, 134);
            attendanceFormsContainerPanel.MinimumSize = new Size(197, 46);
            attendanceFormsContainerPanel.Name = "attendanceFormsContainerPanel";
            attendanceFormsContainerPanel.Size = new Size(197, 134);
            attendanceFormsContainerPanel.TabIndex = 4;
            // 
            // questionBankBtnPanel
            // 
            questionBankBtnPanel.Controls.Add(questionBankBtn);
            questionBankBtnPanel.Location = new Point(0, 90);
            questionBankBtnPanel.Name = "questionBankBtnPanel";
            questionBankBtnPanel.Size = new Size(197, 40);
            questionBankBtnPanel.TabIndex = 2;
            // 
            // questionBankBtn
            // 
            questionBankBtn.Cursor = Cursors.Hand;
            questionBankBtn.FlatAppearance.BorderSize = 0;
            questionBankBtn.FlatStyle = FlatStyle.Flat;
            questionBankBtn.ForeColor = Color.White;
            questionBankBtn.Location = new Point(0, 3);
            questionBankBtn.Name = "questionBankBtn";
            questionBankBtn.Padding = new Padding(75, 0, 0, 0);
            questionBankBtn.Size = new Size(197, 30);
            questionBankBtn.TabIndex = 0;
            questionBankBtn.Text = "Question Banks";
            questionBankBtn.TextAlign = ContentAlignment.MiddleLeft;
            questionBankBtn.UseVisualStyleBackColor = true;
            questionBankBtn.Click += questionBankBtn_Click;
            // 
            // listingsBtnPanel
            // 
            listingsBtnPanel.Controls.Add(listingsBtn);
            listingsBtnPanel.Location = new Point(0, 51);
            listingsBtnPanel.Name = "listingsBtnPanel";
            listingsBtnPanel.Size = new Size(197, 40);
            listingsBtnPanel.TabIndex = 1;
            // 
            // listingsBtn
            // 
            listingsBtn.Cursor = Cursors.Hand;
            listingsBtn.FlatAppearance.BorderSize = 0;
            listingsBtn.FlatStyle = FlatStyle.Flat;
            listingsBtn.ForeColor = Color.White;
            listingsBtn.Location = new Point(0, 3);
            listingsBtn.Name = "listingsBtn";
            listingsBtn.Padding = new Padding(75, 0, 0, 0);
            listingsBtn.Size = new Size(197, 30);
            listingsBtn.TabIndex = 0;
            listingsBtn.Text = "Listings";
            listingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            listingsBtn.UseVisualStyleBackColor = true;
            listingsBtn.Click += listingsBtn_Click;
            // 
            // attendanceFormsPanel
            // 
            attendanceFormsPanel.Controls.Add(attendanceFormsPanelBtn);
            attendanceFormsPanel.Location = new Point(0, 3);
            attendanceFormsPanel.Name = "attendanceFormsPanel";
            attendanceFormsPanel.Size = new Size(197, 42);
            attendanceFormsPanel.TabIndex = 1;
            // 
            // attendanceFormsPanelBtn
            // 
            attendanceFormsPanelBtn.Cursor = Cursors.Hand;
            attendanceFormsPanelBtn.FlatAppearance.BorderColor = Color.FromArgb(50, 56, 87);
            attendanceFormsPanelBtn.FlatStyle = FlatStyle.Flat;
            attendanceFormsPanelBtn.ForeColor = Color.White;
            attendanceFormsPanelBtn.Location = new Point(-3, 0);
            attendanceFormsPanelBtn.Margin = new Padding(3, 4, 3, 4);
            attendanceFormsPanelBtn.Name = "attendanceFormsPanelBtn";
            attendanceFormsPanelBtn.Padding = new Padding(50, 0, 0, 0);
            attendanceFormsPanelBtn.Size = new Size(200, 42);
            attendanceFormsPanelBtn.TabIndex = 0;
            attendanceFormsPanelBtn.Text = "Attendance Forms";
            attendanceFormsPanelBtn.TextAlign = ContentAlignment.MiddleLeft;
            attendanceFormsPanelBtn.UseVisualStyleBackColor = false;
            attendanceFormsPanelBtn.Click += attendanceFormsPanelBtn_Click;
            // 
            // studentsPanel
            // 
            studentsPanel.Controls.Add(studentsPanelBtn);
            studentsPanel.Location = new Point(3, 308);
            studentsPanel.Name = "studentsPanel";
            studentsPanel.Size = new Size(197, 42);
            studentsPanel.TabIndex = 2;
            // 
            // studentsPanelBtn
            // 
            studentsPanelBtn.Cursor = Cursors.Hand;
            studentsPanelBtn.FlatAppearance.BorderColor = Color.FromArgb(50, 56, 87);
            studentsPanelBtn.FlatStyle = FlatStyle.Flat;
            studentsPanelBtn.ForeColor = Color.White;
            studentsPanelBtn.Location = new Point(-3, 0);
            studentsPanelBtn.Margin = new Padding(3, 4, 3, 4);
            studentsPanelBtn.Name = "studentsPanelBtn";
            studentsPanelBtn.Padding = new Padding(50, 0, 0, 0);
            studentsPanelBtn.Size = new Size(200, 42);
            studentsPanelBtn.TabIndex = 0;
            studentsPanelBtn.Text = "Students";
            studentsPanelBtn.TextAlign = ContentAlignment.MiddleLeft;
            studentsPanelBtn.UseVisualStyleBackColor = false;
            studentsPanelBtn.Click += studentsPanelBtn_Click;
            // 
            // summaryPanel
            // 
            summaryPanel.Controls.Add(summaryPanelBtn);
            summaryPanel.Location = new Point(3, 356);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(197, 42);
            summaryPanel.TabIndex = 3;
            // 
            // summaryPanelBtn
            // 
            summaryPanelBtn.Cursor = Cursors.Hand;
            summaryPanelBtn.FlatAppearance.BorderColor = Color.FromArgb(50, 56, 87);
            summaryPanelBtn.FlatStyle = FlatStyle.Flat;
            summaryPanelBtn.ForeColor = Color.White;
            summaryPanelBtn.Location = new Point(-3, 0);
            summaryPanelBtn.Margin = new Padding(3, 4, 3, 4);
            summaryPanelBtn.Name = "summaryPanelBtn";
            summaryPanelBtn.Padding = new Padding(50, 0, 0, 0);
            summaryPanelBtn.Size = new Size(200, 39);
            summaryPanelBtn.TabIndex = 0;
            summaryPanelBtn.Text = "Summary";
            summaryPanelBtn.TextAlign = ContentAlignment.MiddleLeft;
            summaryPanelBtn.UseVisualStyleBackColor = false;
            summaryPanelBtn.Click += summaryPanelBtn_Click;
            // 
            // headerPanel
            // 
            headerPanel.BorderStyle = BorderStyle.Fixed3D;
            headerPanel.Controls.Add(headerPathTxt);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(996, 38);
            headerPanel.TabIndex = 2;
            // 
            // headerPathTxt
            // 
            headerPathTxt.AutoSize = true;
            headerPathTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerPathTxt.Location = new Point(12, 9);
            headerPathTxt.Name = "headerPathTxt";
            headerPathTxt.Size = new Size(235, 15);
            headerPathTxt.TabIndex = 0;
            headerPathTxt.Text = "CS 4485.0w1 - Computer Science Project";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(166, 176, 230);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 38);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(796, 524);
            mainPanel.TabIndex = 4;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // attendanceFormsTimer
            // 
            attendanceFormsTimer.Interval = 10;
            attendanceFormsTimer.Tick += attendanceFormsTimer_Tick;
            // 
            // Coursepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 562);
            Controls.Add(mainPanel);
            Controls.Add(sidebar);
            Controls.Add(headerPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Coursepage";
            Text = "Uttendance";
            sidebar.ResumeLayout(false);
            titleSideBarPanel.ResumeLayout(false);
            titleSideBarPanel.PerformLayout();
            attendanceFormsContainerPanel.ResumeLayout(false);
            questionBankBtnPanel.ResumeLayout(false);
            listingsBtnPanel.ResumeLayout(false);
            attendanceFormsPanel.ResumeLayout(false);
            studentsPanel.ResumeLayout(false);
            summaryPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel titleSideBarPanel;
        private Panel attendanceFormsPanel;
        private Button attendanceFormsPanelBtn;
        private Panel headerPanel;
        private Panel mainPanel;
        private Panel studentsPanel;
        private Button studentsPanelBtn;
        private Panel summaryPanel;
        private Button summaryPanelBtn;
        private Label headerPathTxt;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button yourCoursesBtn;
        private Button menuBtn;
        private Panel attendanceFormsContainerPanel;
        private Button listingsBtn;
        private Panel listingsBtnPanel;
        private Panel questionBankBtnPanel;
        private Button questionBankBtn;
        private System.Windows.Forms.Timer attendanceFormsTimer;
        private Label courseLabel;
    }
}