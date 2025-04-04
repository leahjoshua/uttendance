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

namespace UttendanceDesktop.CoursepageContent
{
    public partial class attendanceFormItem : UserControl
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

        private DateTime _date;
        private AttendenceFormStatusOptions _statusOption;
        private int formId;
        private bool isEditMode = false;

        public event EventHandler OnFormSelectChange;

        public attendanceFormItem()
        {
            InitializeComponent();
        }

        // Aendri: Fix the height and width of the component
        protected override void SetBoundsCore(int x, int y,
            int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, 750, 62, specified);
        }

        //Aendri 4/3/2025
        // On selection/deselection of the form, create event and raise to parent control. 
        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(titleLabel.Text + "SELECTED!");
            if (OnFormSelectChange != null)
                OnFormSelectChange(checkbox.Checked, null);
        }

        // Aendri: Options for the status of an attendence form
        public enum AttendenceFormStatusOptions
        {
            Upcoming,
            Open,
            Closed
        }


        // Aendri
        [Category("Item Values")]
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                titleLabel.Text = value.ToString("MM/dd/yyyy") + " Attendence Form";
            }
        }

        // Aendri
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

        // Aendri 
        [Category("Item Values")]
        public int FormID
        {
            get { return formId; }
            set { formId = value; }
        }

        // Aendri 4/3/2025 
        [Category("Item Values")]
        public bool Selected
        {
            get { return checkbox.Checked; }
            set { checkbox.Checked = value; }
        }

    }
}
