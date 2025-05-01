/******************************************************************************
* StudentAddModal Class for the UttendanceDesktop application.
* This class serves as a modal for professor's to manually add students
* to their class.
* Written by Joanna Yang(jxy210012) 
* for CS4485.0W1 at The University of Texas at Dallas starting March 14, 2025.
******************************************************************************/
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class StudentAddModal : Form
    {
        //A flag to raise when a student has been added to the databse
        //Watched by the Students class
        public event Action? StudentAdded;
        private int CourseNum;

        /**************************************************************************
        * Constructs the StudentAddModal upon initilization and stores the given
        * course number to add the student to.
        * Written by Joanna Yang
        **************************************************************************/
        public StudentAddModal(int courseNum)
        {
            CourseNum = courseNum;
            InitializeComponent();
        }

        /**************************************************************************
        * Handles the 'Cancel' button click.
        * Hides this modal when user clicks cancel
        * Written by Joanna Yang
        **************************************************************************/
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        /**************************************************************************
       * Handles the 'Add' button click.
       * Uses StudentsDAO to add student to the class using information 
       * from the text fields.
       * Written by Joanna Yang
       **************************************************************************/
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Make sure the inputted UTD-ID is an integer
                int? parseUTDID = null;
                if (int.TryParse(createUTDID.Text, out int tempID))
                    parseUTDID = tempID;

                //Create a student object using the information in the text fields
                Student student = new Student
                {
                    SUTDID = Int32.Parse(createUTDID.Text),
                    SNetID = createNetID.Text,
                    SFName = createFName.Text,
                    SLName = createLName.Text
                };

                //Check to make sure all field have been filled
                if(!student.SUTDID.HasValue || student.SNetID == "" || student.SFName == "" || student.SLName == "")
                {
                    MessageBox.Show("Please fill in all of the fields");
                }
                else
                {
                    //Add student to the class
                    StudentsDAO studentInfo = new StudentsDAO();
                    //If the add was a success, hide the modal and raise flag
                    if(studentInfo.addStudent(student, CourseNum))
                    {
                        StudentAdded?.Invoke();
                        Visible = false;
                    }
                    else
                    {
                        //Else display error message
                        MessageBox.Show("Another student with UTD-ID \'" + student.SUTDID.Value + "\' already exists");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
