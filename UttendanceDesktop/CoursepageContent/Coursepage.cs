/******************************************************************************
* Coursepage Class for the UttendanceDesktop application.
* This class serves as a coursepage after a course is selected from the homepage
* The Coursepage has a collapsable sidebar that allows the user to navigate to
* the following pages: Homepage, Attendance Forms Listing, Attendance Forms Question 
* Bank, Students, and Summary.
* Written by Joanna Yang and Parisa Nawar (jxy210012, pxn210032) 
* for CS4485.0W1 at The University of Texas at Dallas starting March 14, 2025.
******************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using UttendanceDesktop;

namespace UttendanceDesktop
{
    // Written by Joanna Yang and Parisa Nawar for CS4485.0w1, Uttendance, starting March 14, 2025.
    //
    // NetID: jxy210012, pxn210032
    public partial class Coursepage : Form
    {
        //Boolean to track whether or not the sidebar is expanded
        bool sidebarExpand = true;
        //Boolean to track whether or not the attendance label is collapsed
        bool attendanceCollapsed = false;

        private int CourseNum;
        private string InstructorID;

        /**************************************************************************
        * Constructs the Coursepage upon initilization and stores the given
        * course number to display and the associated instructor's Net-ID.
        * Written by Joanna Yang
        **************************************************************************/
        public Coursepage(int CourseNum, string instructorID)
        {
            InitializeComponent();

            //Sets the position and size of the form
            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            Size = new Size(w, h);

            this.CourseNum = CourseNum;
            InstructorID = instructorID;

            //Display the course information
            setCourseLabels();

            //Make the Attendance Form the default first page that loads
            loadForm(new AttendanceForms_Listings(CourseNum));
        }

        /**************************************************************************
        * Sets the labels in the page header and the side bar to display
        * the course information: class subject, class number, section number,
        * course number (class ID), and class name.
        * Written by Parisa.
        **************************************************************************/
        public void setCourseLabels()
        {
            //Retrieve the Course information from database 
            string connectionString = GlobalResource.CONNECTION_STRING;
            string query = @"
        SELECT c.CourseNum, c.SectionNum, c.ClassSubject, c.ClassNum, c.ClassName
        FROM class AS c
        INNER JOIN teaches AS t ON c.CourseNum = t.FK_CourseNum
        WHERE t.FK_INetID = @netID
        AND c.CourseNum = @courseNum";

            using (var connection = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@netID", GlobalResource.INetID);
                cmd.Parameters.AddWithValue("@courseNum", CourseNum);

                connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //Get the information from the database
                        string courseName = reader["ClassName"].ToString();
                        string classPrefix = reader["ClassSubject"].ToString();
                        string classNumber = reader["ClassNum"].ToString();
                        string sectionNumber = reader["SectionNum"].ToString();
                        string courseNum = reader["CourseNum"].ToString();

                        sectionNumber = sectionNumber.PadLeft(3, '0');

                        //Create specialized strings to rewrite the label texts
                        string labelText1 = $"{classPrefix} {classNumber}.{sectionNumber} -" +
                            $"\n{courseName}";
                        string labelText2 = $"{classPrefix} {classNumber}.{sectionNumber} - {courseName}";
                        headerPathTxt.Text = labelText2;
                        courseLabel.Text = labelText1;
                    }
                }
            }
        }

        /**************************************************************************
        * Dynamically loads the page that is defined by input 'Form' as the page 
        * content, keeping the sidebar and header.
        * Written by Joanna Yang
        **************************************************************************/
        public void loadForm(object Form)
        {
            //If the main panel is already occupied, remove the content
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            //Make the form fill the main panel
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        /**************************************************************************
        * Animates the sidebar to expand and collapse to a specified maximum 
        * and minimum size.
        * Written by Joanna Yang
        **************************************************************************/
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //If the sidebar is explanded, then minimize it
            if (sidebarExpand)
            {
                //Adjust the size a little at a time
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
                //Adjust the size a little at a time
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        /**************************************************************************
        * Animates the Attendance Forms submenu to expand and collapse 
        * to a specified maximum and minimum size.
        * Written by Joanna Yang
        **************************************************************************/
        private void attendanceFormsTimer_Tick(object sender, EventArgs e)
        {
            //If the submenu is collapsed, then expand it
            if (attendanceCollapsed)
            {
                //Adjust the size a little at a time
                attendanceFormsContainerPanel.Height += 10;
                if (attendanceFormsContainerPanel.Height == attendanceFormsContainerPanel.MaximumSize.Height)
                {
                    attendanceCollapsed = false;
                    attendanceFormsTimer.Stop();
                }
            }
            else
            {
                //else, collapse it
                //Adjust the size a little at a time
                attendanceFormsContainerPanel.Height -= 10;
                if (attendanceFormsContainerPanel.Height == attendanceFormsContainerPanel.MinimumSize.Height)
                {
                    attendanceCollapsed = true;
                    attendanceFormsTimer.Stop();
                }
            }
        }

        /**************************************************************************
        * Handles the Menu button click. Starts the sidebar animation 
        * when the user clicks on 'Menu' button in the sidebar.
        * Written by Joanna Yang
        **************************************************************************/
        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        /**************************************************************************
        * Handles the Attendance Form button click. Starts the submenu animation 
        * when the user clicks on 'Attendance Forms' button in the sidebar.
        * Calls the loadForm() method to load the Attendance Forms 'Listings' 
        * page as the default
        * Written by Joanna Yang
        **************************************************************************/
        private void attendanceFormsPanelBtn_Click(object sender, EventArgs e)
        {
            attendanceFormsTimer.Start();
            loadForm(new AttendanceForms_Listings(CourseNum));
        }

        /**************************************************************************
        * Handles the Attendance Form Listing button click.
        * Calls the loadForm() method to load the Attendance Forms 'Listings' 
        * Written by Joanna Yang
        **************************************************************************/
        private void listingsBtn_Click(object sender, EventArgs e)
        {
            loadForm(new AttendanceForms_Listings(CourseNum));
        }

        /**************************************************************************
        * Handles the Question Bank button click.
        * Calls the loadForm() method to load the Attendance Forms 'Question Banks' 
        * Written by Joanna Yang
        **************************************************************************/
        private void questionBankBtn_Click(object sender, EventArgs e)
        {
            loadForm(new AttendanceForms_QuestionBank());
        }

        /**************************************************************************
        * Handles the Students button click.
        * Calls the loadForm() method to load the 'Students' 
        * Written by Joanna Yang
        **************************************************************************/
        private void studentsPanelBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Students(CourseNum));
        }

        /**************************************************************************
        * Handles the Summary button click.
        * Calls the loadForm() method to load the 'Summary' 
        * Written by Joanna Yang
        **************************************************************************/
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

        /**************************************************************************
        * Handles Your Course button click.
        * Returns the user back to the home page when they click on "Your Courses"
        * Written by Parisa Nawar
        **************************************************************************/
        private void yourCoursesBtn_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(InstructorID);
            homepage.Show();
            this.Close();
        }
    }
}
