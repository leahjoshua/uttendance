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
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 27, 2025.
    // NetID: jxy210012
    // Wrote the whole StudentAddModal class
    public partial class StudentAddModal : Form
    {
        public event Action? StudentAdded;
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;
        private int CourseNum;
        public StudentAddModal(int courseNum)
        {
            CourseNum = courseNum;
            InitializeComponent();
        }

        //Hides the modal when user clicks cancel
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        //Adds student to database using information from text field
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int? parseUTDID = null;
                if (int.TryParse(createUTDID.Text, out int tempID))
                    parseUTDID = tempID;

                //Create a student object
                Student student = new Student
                {
                    SUTDID = Int32.Parse(createUTDID.Text),
                    SNetID = createNetID.Text,
                    SFName = createFName.Text,
                    SLName = createLName.Text
                };

                //Input validation
                if(!student.SUTDID.HasValue || student.SNetID == "" || student.SFName == "" || student.SLName == "")
                {
                    MessageBox.Show("Please fill in all of the fields");
                }
                else
                {
                    //Add student to the class
                    StudentsDAO studentInfo = new StudentsDAO();
                    if(studentInfo.addStudent(student, CourseNum))
                    {
                        StudentAdded?.Invoke();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Student with UTD-ID \'" + student.SUTDID.Value + "\' already exists in this class");
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
