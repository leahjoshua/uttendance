﻿/******************************************************************************
* Attendance form item for the UttendanceDesktop application.
* 
* This class represents a custom control for attendance form items, 
* where professors can view an attendance form's release date/time
* and release status. Includes the option to select. 
* 
* Written by Aendri Singh (axs210369)
* for CS4485.0W1 at The University of Texas at Dallas
* starting April 3, 2025.
******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class attendanceFormItem : UserControl
    {
        private DateTime _releaseDate;
        private DateTime _closeDate;
        private AttendenceFormStatusOptions _statusOption;
        private int _formId;
        private bool isEditMode = false;

        public event EventHandler OnFormSelectChange;

        public attendanceFormItem()
        {
            InitializeComponent();
        }

        // Aendri Singh (axs210369)
        public attendanceFormItem(DateTime releaseDate, AttendenceFormStatusOptions status, int formID)
        {
            InitializeComponent();

            ReleaseDate = releaseDate;
            Status = status;
            FormID = formID;
        }

        // Aendri Singh (axs210369)
        // Fix the height and width of the component
        protected override void SetBoundsCore(int x, int y,
            int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, 750, 62, specified);
        }

        // Aendri Singh (axs210369)
        // On selection/deselection of the form, create event and raise to parent control. 
        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnFormSelectChange != null)
            {
                OnFormSelectChange(checkbox.Checked, null);
            }
        }

        // ----- ITEM EVENTS ----- //

        // Aendri Singh (axs210369)
        // On click, open attendance form page
        private void attendanceFormItem_Click(object sender, EventArgs e)
        {
            openPage();
        }

        // Aendri Singh (axs210369)
        // On click, open attendance form page
        private void statusLabel_Click(object sender, EventArgs e)
        {
            openPage();
        }

        // Aendri Singh (axs210369)
        // On click, open attendance form page
        private void titleLabel_Click(object sender, EventArgs e)
        {
            openPage();
        }

        // Aendri Singh (axs210369)
        // On click, open attendance form page
        private void statusDisplayLabel_Click(object sender, EventArgs e)
        {
            openPage();
        }

        // ---- SPECIAL FUNCTIONS/ENUMS ---- //

        // Aendri Singh (axs210369)
        // Options for the status of an attendence form
        public enum AttendenceFormStatusOptions
        {
            Upcoming,
            Open,
            Closed
        }

        // Aendri Singh (axs210369)
        // Opens the form page
        private void openPage()
        {
            GlobalResource.COURSEPAGE.loadForm(new AttendanceForms_Details(FormID));
        }

        //---- DATA ----//

        // Aendri Singh (axs210369)
        // Release time of the attendance form
        [Category("Item Values")]
        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set
            {
                _releaseDate = value;
                titleLabel.Text = value.ToString("MM/dd/yyyy") + " Attendence Form (" + value.ToString("hh:mm tt") + ")";
            }
        }

        // Aendri Singh (axs210369)
        // Close time of the attendance form
        [Category("Item Values")]
        public DateTime CloseDate
        {
            get { return _closeDate; }
            set {  _closeDate = value; }
        }

        // Aendri Singh (axs210369)
        // Status of the attendance form
        [Category("Item Values")]
        public AttendenceFormStatusOptions Status
        {
            get { return _statusOption; }
            set
            {
                _statusOption = value;

                // Set Display Label text and color
                switch (_statusOption)
                {
                    case AttendenceFormStatusOptions.Upcoming:
                        statusDisplayLabel.Text = "UPCOMING";
                        statusDisplayLabel.ForeColor = System.Drawing.Color.FromArgb(1, 132, 140, 185); //Light Blue
                        break;

                    case AttendenceFormStatusOptions.Open:
                        statusDisplayLabel.Text = "OPEN";
                        statusDisplayLabel.ForeColor = System.Drawing.Color.FromArgb(1, 24, 162, 104); //Green
                        break;

                    case AttendenceFormStatusOptions.Closed:
                        statusDisplayLabel.Text = "CLOSED";
                        statusDisplayLabel.ForeColor = System.Drawing.Color.FromArgb(1, 233, 117, 2); //Orange
                        break;
                }

            }
        }

        // Aendri Singh (axs210369)
        // Attendance Form ID 
        [Category("Item Values")]
        public int FormID
        {
            get { return _formId; }
            set { _formId = value; }
        }

        // Aendri Singh (axs210369)
        // If the form selected
        [Category("Item Values")]
        public bool Selected
        {
            get { return checkbox.Checked; }
            set { checkbox.Checked = value; }
        }

    }
}
