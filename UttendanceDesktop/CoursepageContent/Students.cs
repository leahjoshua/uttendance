/******************************************************************************
* Students Class for the UttendanceDesktop application.
* This class serves as a students page, displaying a table with the students'
* information (last name, first name, Net-ID, and UTD-ID) for the given course
* number (class id). The professor can import a csv of students, manually add
* students, remove students, or edit student information.
* Written by Joanna Yang(jxy210012) 
* for CS4485.0W1 at The University of Texas at Dallas starting March 28, 2025.
******************************************************************************/

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
        private int CourseNum;
        //Column header names for the table
        private static string[] displayList = { "Last Name", "First Name", "Net-ID", "UTD-ID" };
        //Import modal for this class
        private StudentImportModal importMod;
        //Tracks the cell's old value when the user starts editing the cell value
        private object editOldValue;

        /**************************************************************************
        * Constructs the StudentAddModal upon initilization and stores the given
        * course number to add the student to.
        * Written by Joanna Yang
        **************************************************************************/
        public Students(int courseNum)
        {
            CourseNum = courseNum;
            InitializeComponent();

            //Set panel size
            studentsPagePanel.Size = Size;

            //Set the grid width and height
            int width = studentsPagePanel.Width - 50;
            int height = studentsPagePanel.Height - 75;

            studentTable.Width = width;
            studentTable.Height = height;
            studentTable.MaximumSize = new Size(width, height);
            studentTable.MinimumSize = new Size(width, height);

            studentTable.DataBindingComplete += studentTable_DataBindingComplete;
            populateStudentTable();

            //Subscribe to event to repopulate the data grid after import module is finished
            importMod = new StudentImportModal(CourseNum);
            importMod.DatabaseUpdated += populateStudentTable;
        }

        /**************************************************************************
        * Populates the datagrid to display information of all the students in 
        * the current class using StudentsDAO
        * Written by Joanna Yang
        **************************************************************************/
        private void populateStudentTable()
        {
            StudentsDAO studentInfo = new StudentsDAO();
            this.studentTable.DataSource = studentInfo.getAllStudentInfo(displayList, CourseNum);
        }

        /**************************************************************************
        * Handles the 'Add' button click.
        * Displays the Add panel as options for adding students (add or import)
        * Written by Joanna Yang
        **************************************************************************/
        private void addBtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible = true;
        }

        /**************************************************************************
        * Handles the 'Add Students' button click.
        * Displays the StudentAddModal for the professor to input student
        * information to.
        * Written by Joanna Yang
        **************************************************************************/
        private void addStudentsBtn_Click(object sender, EventArgs e)
        {
            //Hide the Add panel
            addPanel.Visible = false;

            //Set up and show the StudentAddModal
            StudentAddModal studMod = new StudentAddModal(CourseNum);
            studMod.StudentAdded += populateStudentTable;
            studMod.Show();
        }

        /**************************************************************************
        * Handles the 'Import Students' button click.
        * Displays the StudentImportModal for the professor to import a list of
        * students using a csv file.
        * Written by Joanna Yang
        **************************************************************************/
        private void importStudentsBtn_Click(object sender, EventArgs e)
        {
            //Hide the Add panel
            addPanel.Visible = false;
            importMod.Show();
        }

        /**************************************************************************
        * Handles the Student Table cell click.
        * Displays the Delete Button when the user selects a cell/row.
        * Written by Joanna Yang
        **************************************************************************/
        private void studentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addPanel.Visible = false;
            addBtn.Visible = false;
            deleteBtn.Visible = true;
        }

        /**************************************************************************
        * Handles the Student Page Panel click.
        * Unselects the selected row when user clicks outside the data grid
        * Written by Joanna Yang
        **************************************************************************/
        private void studentsPagePanel_Click(object sender, EventArgs e)
        {
            studentTable.ClearSelection();
            deleteBtn.Visible = false;
            addPanel.Visible = false;
            addBtn.Visible = true;
        }

        /**************************************************************************
        * Handles the Delete button click.
        * Retreives the UTD-ID of the selected student(s) and confirms with 
        * user before removing. Uses StudentsDAO to update database.
        * Written by Joanna Yang
        **************************************************************************/
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int numRows = studentTable.SelectedRows.Count;
            //If at least one row is selected
            if (numRows > 0)
            {
                //Confirmation message
                string confirmMsg = "Remove " + numRows + " student(s) from this class?\n All submissions by these students will be removed.";
                DialogResult result = MessageBox.Show(confirmMsg, "Confirmation", MessageBoxButtons.OKCancel);
                
                //If select 'OK', remove each of the selected student
                if (result == DialogResult.OK)
                {
                    StudentsDAO studentInfo = new StudentsDAO();
                    for (int i = 0; i < numRows; i++)
                    {
                        DataGridViewRow selectedRow = studentTable.SelectedRows[i];
                        
                        //Get the primary key of the selected row
                        var utdID = selectedRow.Cells["UTD-ID"].Value.ToString();
                        studentInfo.removeStudentFromClass(utdID, CourseNum);
                    }
                    //Call populateStudentTable to update the table
                    populateStudentTable();
                }
            }

            //Hide delete button and show add button
             deleteBtn.Visible = false;
            addPanel.Visible = false;
            addBtn.Visible = true;
        }

        /**************************************************************************
        * Handles the Student Table cell begin edit.
        * Stores the old cell value when the user starts editing a cell.
        * Written by Joanna Yang
        **************************************************************************/
        private void studentTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editOldValue = studentTable[e.ColumnIndex, e.RowIndex].Value;
        }

        /**************************************************************************
        * Handles the Student Table cell end edit.
        * Updates the student information with the new value. Uses StudentsDAO
        * to update the database.
        * Written by Joanna Yang
        **************************************************************************/
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
                    if (editNewValue != null && int.TryParse(editNewValue.ToString(), out int newID)
                        && editOldValue != null && int.TryParse(editOldValue.ToString(), out int oldID))
                    {
                        //If the update was unsucessful, display error message
                        if (!studentInfo.updateStudentID(oldID, newID))
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

        /**************************************************************************
        * Handles the Student Table DataBinding complete.
        * Wait for data to be fully bounded and the columns to be created
        * before setting the column width.
        * Written by Joanna Yang
        **************************************************************************/
        private void studentTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //If all columns have been created, then set the width for all of them
            if (studentTable.Columns.Count >= 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    studentTable.Columns[i].Width = studentTable.Width / 4;
                }
            }
        }
    }
}
