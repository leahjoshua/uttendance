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
using UttendanceDesktop.CoursepageContent;
using static UttendanceDesktop.GlobalResource;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 28, 2025.
    // NetID: jxy210012
    public partial class Students : Form
    {
        private static readonly int courseNum = GlobalResource.CURRENT_CLASS_ID;

        //Sets up parameter for import module
        private static string tableName = "student";
        private static string[] attributeList = { "SLName", "SFNAME", "SNetID", "UTDID" };
        private static string[] displayList = { "Last Name", "First Name", "Net-ID", "UTD-ID" };
        private static string[] typeList = { "string", "string", "string", "int" };
        private static string pkeyName = "UTDID";

        private static string relationTableName = "attends";
        private static string[] fkeysList = { "FK_UTDID", "FK_CourseNum" };
        private static string[] fkeyTypeList = { "int", "int" };
        private static string fk1 = "" + GlobalResource.CURRENT_CLASS_ID;
        private ImportModule importMod = new ImportModule("Students", tableName, attributeList, displayList, typeList,
            pkeyName, relationTableName, fkeysList, fkeyTypeList, fk1);

        //private StudentModule studMod = new StudentModule();
        public Students()
        {
            InitializeComponent();
            PopulateStudentTable();
            //Subscribe to event to repopulate the data grid after import module is finished
            importMod.DatabaseUpdated += PopulateStudentTable;
        }

        //Pulls the list of all students enrolled in the current class and displays it on the data grid
        private void PopulateStudentTable()
        {
            StudentsDAO studentInfo = new StudentsDAO();
            this.studentTable.DataSource = studentInfo.getAllStudentInfo(displayList, courseNum);
        }

        //Displays the options for adding students
        private void addBtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible = true;
        }

        //Displays the module to manually add students
        private void addStudentsBtn_Click(object sender, EventArgs e)
        {
            StudentModule studMod = new StudentModule();
            studMod.StudentAdded += PopulateStudentTable;
            studMod.Show();
            addPanel.Visible = false;
        }

        //Displays the module to import students
        private void importStudentsBtn_Click(object sender, EventArgs e)
        {
            importMod.Show();
            addPanel.Visible = false;
        }

        //Replace add button with trash when user selects a cell
        private void studentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addBtn.Visible = false;
            deleteBtn.Visible = true;
        }

        //Unselects the selected row when user clicks outside the data grid
        private void studentsPagePanel_Click(object sender, EventArgs e)
        {
            studentTable.ClearSelection();
            deleteBtn.Visible = false;
            addBtn.Visible = true;
        }

        //Gets the list of selected rows and deletes them from the databse when the delete button is clicked
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int numRows = studentTable.SelectedRows.Count;
            if (numRows > 0)
            {
                //Confirmation message
                string confirmMsg = "Remove " + numRows + " student(s) from this class?";
                DialogResult result = MessageBox.Show(confirmMsg, "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    StudentsDAO studentInfo = new StudentsDAO();
                    for (int i = 0; i < numRows; i++)
                    {
                        DataGridViewRow selectedRow = studentTable.SelectedRows[i];
                        //Get the primary key of the selected row
                        string utdID = selectedRow.Cells["UTD-ID"].Value.ToString();
                        studentInfo.removeStudentsFromClass(utdID, courseNum);
                    }
                    PopulateStudentTable();
                }
            }

        }
    }
}
