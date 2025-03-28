using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 14, 2025.
    // NetID: jxy210012
    public partial class Coursepage : Form
    {
        bool sidebarExpand = true;
        bool attendanceCollapsed = false;
        public Coursepage()
        {
            InitializeComponent();
            //Make the Attendance Form the default first page that loads
            loadForm(new AttendanceForms_Listings());
        }

        // Loads the page that is defined by input 'Form', keeping the sidebar and header
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        //Animates the sidebar to expand and minimize
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //If sidebar is expanded,minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                //Else, expand it
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        //Starts the sidebar animation when the user clicks on 'Menu'
        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        //Starts the submenu animation when 'Attendance Forms' is clicked
        //Calls the loadForm() method to load the Attendance Forms 'Listings' page as the default
        private void attendanceFormsPanelBtn_Click(object sender, EventArgs e)
        {
            attendanceFormsTimer.Start();
            loadForm(new AttendanceForms_Listings());
        }

        //Calls the loadForm() method to load the Listings page when 'Listings' is clicked
        private void listingsBtn_Click(object sender, EventArgs e)
        {
            loadForm(new AttendanceForms_Listings());
        }

        //Calls the loadForm() method to load the Question Banks page when 'Question Banks' is clicked
        private void questionBankBtn_Click(object sender, EventArgs e)
        {
            loadForm(new AttendanceForms_QuestionBank());
        }

        //Calls the loadForm() method to load the Students page when 'Students' is clicked
        private void studentsPanelBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Students());
        }

        //Calls the loadForm() method to load the Summary page when 'Summary' is clicked
        private void summaryPanelBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Summary());
        }

        //Animates the submenu to expand and minimize
        private void attendanceFormsTimer_Tick(object sender, EventArgs e)
        {
            if (attendanceCollapsed)
            {
                attendanceFormsContainerPanel.Height += 10;
                if (attendanceFormsContainerPanel.Height == attendanceFormsContainerPanel.MaximumSize.Height)
                {
                    attendanceCollapsed = false;
                    attendanceFormsTimer.Stop();
                }
            }
            else
            {
                attendanceFormsContainerPanel.Height -= 10;
                if (attendanceFormsContainerPanel.Height == attendanceFormsContainerPanel.MinimumSize.Height)
                {
                    attendanceCollapsed = true;
                    attendanceFormsTimer.Stop();
                }
            }
        }
    }
}
