using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent;
using static UttendanceDesktop.GlobalResource;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 28, 2025.
    // NetID: jxy210012
    public partial class Students : Form
    {
        private int CourseNum; //TEMP VALUE, receive from prev page in constructor
        private static string[] displayList = { "Last Name", "First Name", "Net-ID", "UTD-ID" };
        private StudentImportModal importMod;

        private object editOldValue;

        public Students(int courseNum)
        {
            CourseNum = courseNum;
            InitializeComponent();
            studentTable.Width = studentsPagePanel.Width - 30;
            studentTable.Height = studentsPagePanel.Height - 130;
            populateStudentTable();
            //Subscribe to event to repopulate the data grid after import module is finished
            importMod = new StudentImportModal(CourseNum);
            importMod.DatabaseUpdated += populateStudentTable;
        }

        //Populates the datagrid with information of all the students in the current class
        private void populateStudentTable()
        {
            StudentsDAO studentInfo = new StudentsDAO();
            this.studentTable.DataSource = studentInfo.getAllStudentInfo(displayList, CourseNum);

            //for(int i = 0; i < 4; i++)
            //{
            //    studentTable.Columns[i].Width = studentTable.Width / 4;
            //}
        }

        //Displays the options for adding students
        private void addBtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible = true;
        }

        //Displays the module to manually add students
        private void addStudentsBtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible = false;
            StudentAddModal studMod = new StudentAddModal(CourseNum);
            studMod.StudentAdded += populateStudentTable;
            studMod.Show();
        }

        //Displays the module to import students
        private void importStudentsBtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible = false;
            importMod.Show();
        }

        //Replace add button with trash when user selects a cell
        private void studentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addPanel.Visible = false;
            addBtn.Visible = false;
            deleteBtn.Visible = true;
        }

        //Unselects the selected row when user clicks outside the data grid
        private void studentsPagePanel_Click(object sender, EventArgs e)
        {
            studentTable.ClearSelection();
            deleteBtn.Visible = false;
            addPanel.Visible = false;
            addBtn.Visible = true;
        }

        //Gets the list of selected rows and deletes them from the databse when the delete button is clicked
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int numRows = studentTable.SelectedRows.Count;
            if (numRows > 0)
            {
                //Confirmation message
                string confirmMsg = "Remove " + numRows + " student(s) from this class?\n All submissions by these students will be removed.";
                DialogResult result = MessageBox.Show(confirmMsg, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    StudentsDAO studentInfo = new StudentsDAO();
                    for (int i = 0; i < numRows; i++)
                    {
                        DataGridViewRow selectedRow = studentTable.SelectedRows[i];
                        //Get the primary key of the selected row
                        var utdID = selectedRow.Cells["UTD-ID"].Value.ToString();
                        studentInfo.removeStudentsFromClass(utdID, CourseNum);
                    }
                    populateStudentTable();
                }
            }

            deleteBtn.Visible = false;
            addPanel.Visible = false;
            addBtn.Visible = true;
        }

        //Keep track of the old value when the user starts editing a cell
        private void studentTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editOldValue = studentTable[e.ColumnIndex, e.RowIndex].Value;
        }

        //Updates the database based on the new value in the cell
        private void studentTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editNewValue = studentTable[e.ColumnIndex, e.RowIndex].Value.ToString();
            int col = e.ColumnIndex;

            //If the value changed
            if (!Equals(editOldValue, editNewValue))
            {
                StudentsDAO studentInfo = new StudentsDAO();
                //If the UTD-ID is being changed
                if (col == 3)
                {
                    //Check if the inputted value is an int
                    if(editNewValue != null && int.TryParse(editNewValue.ToString(), out int newID)
                        && editOldValue !=null && int.TryParse(editOldValue.ToString(), out int oldID))
                    {
                        //If the update was unsucessful, display error message
                        if(!studentInfo.updateStudentID(oldID, newID))
                        {
                            MessageBox.Show("UTD-ID " + newID + " is already taken");
                            studentTable[e.ColumnIndex, e.RowIndex].Value = editOldValue;
                        }
                            
                    }
                    else
                    {
                        //Display error message for invalid input
                        MessageBox.Show("Invalid Input.");
                        studentTable[e.ColumnIndex, e.RowIndex].Value = editOldValue;
                    }
                }
                else
                {
                    // Get the student ID
                    var tryStudentID = studentTable.Rows[e.RowIndex].Cells["UTD-ID"].Value;
                    //Make sure the field isn't empty and that the student ID is an integer
                    if (!string.IsNullOrWhiteSpace(editNewValue) && editOldValue != null
                        && tryStudentID != null && int.TryParse(tryStudentID.ToString(), out int studentID))
                    {
                        studentInfo.updateStudentInfo(studentID, col, editNewValue?.ToString());
                    }
                    else
                    {
                        //Display error message for invalid input
                        MessageBox.Show("Invalid Input.");
                        studentTable[e.ColumnIndex, e.RowIndex].Value = editOldValue;
                    }
                }
            }

        }



    }
}
