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
    public partial class Coursepage : Form
    {
        bool sidebarExpand = true;
        bool attendanceCollapsed = false;
        public Coursepage()
        {
            InitializeComponent();
            loadForm(new AttendanceForms_Listings());
        }

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
        //Joanna
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

        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void attendanceFormsPanelBtn_Click(object sender, EventArgs e)
        {
            attendanceFormsTimer.Start();
            loadForm(new AttendanceForms_Listings());
        }

        private void listingsBtn_Click(object sender, EventArgs e)
        {
            loadForm(new AttendanceForms_Listings());
        }

        private void questionBankBtn_Click(object sender, EventArgs e)
        {
            loadForm(new AttendanceForms_QuestionBank());
        }

        private void studentsPanelBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Students());
        }

        private void summaryPanelBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Summary());
        }

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
