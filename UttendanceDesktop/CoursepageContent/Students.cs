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
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;
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
            DataTable dataTable = new DataTable();

            //Create the columns
            for (int i = 0; i < displayList.Length; i++)
            {
                dataTable.Columns.Add(displayList[i]);
            }

            try
            {
                //Open database connection
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //Select all student information from all students enrolled in the current class
                var query = "SELECT student.* FROM student " +
                    "INNER JOIN attends ON student.UTDID=attends.FK_UTDID " +
                    "WHERE attends.FK_CourseNum=" + GlobalResource.CURRENT_CLASS_ID +
                    " ORDER BY student.SLName;";

                //Execute query
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Read result
                MySqlDataReader databaseReader = cmd.ExecuteReader();
                while (databaseReader.Read())
                {
                    var row = dataTable.NewRow();

                    row[displayList[0]] = databaseReader["SLName"].ToString();
                    row[displayList[1]] = databaseReader["SFName"].ToString();
                    row[displayList[2]] = databaseReader["SNetID"].ToString();
                    row[displayList[3]] = databaseReader["UTDID"].ToString();

                    dataTable.Rows.Add(row);
                }
                databaseReader.Close();
                connection.Close();
                //Send data to data table
                this.studentTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to populate.");
            }
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
                    //Open database connection
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    for (int i = 0; i < numRows; i++)
                    {
                        DataGridViewRow selectedRow = studentTable.SelectedRows[i];
                        //Get the primary key of the selected row
                        string utdID = selectedRow.Cells["UTD-ID"].Value.ToString();
                        removeStudent(utdID, connection);
                    }

                    connection.Close();
                    PopulateStudentTable();
                }
            }

        }

        //Remove a student from the class given their UTD-ID
        private void removeStudent(string id, MySqlConnection connection)
        {
            //Remove student from the attends table
            MySqlCommand cmd = new MySqlCommand("DELETE FROM attends WHERE FK_UTDID=@fkUtdID AND FK_CourseNum=@courseNum;", connection);
            cmd.Parameters.AddWithValue("@fkUtdID", id);
            cmd.Parameters.AddWithValue("@courseNum", courseNum);
            cmd.ExecuteNonQuery();

            //Check if the student is enrolled in any other classes
            cmd = new MySqlCommand("SELECT COUNT(*) FROM attends WHERE FK_UTDID=@fkUtdID2;", connection);
            cmd.Parameters.AddWithValue("@fkUtdID2", id);
            //Read result
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();

            //If not, then remove them from the student table
            if(count == 0)
            {
                cmd = new MySqlCommand("DELETE FROM student WHERE UTDID=@utdID;", connection);
                cmd.Parameters.AddWithValue("@utdID", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
