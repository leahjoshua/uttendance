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

using static UttendanceDesktop.GlobalResource;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 28, 2025.
    // NetID: jxy210012
    public partial class Students : Form
    {
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;
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
        public Students()
        {
            InitializeComponent();
            PopulateStudentTable();
        }

        private void PopulateStudentTable()
        {
            DataTable dataTable = new DataTable();

            //Create the columns
            for(int i = 0; i < displayList.Length; i++)
            {
                dataTable.Columns.Add(displayList[i]);
            }

            try
            {
                //Open database connection
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
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

                this.studentTable.DataSource = dataTable;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to populate.\n" + ex.ToString());
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
            //manually add
            addPanel.Visible = false;
        }

        //Displays the module to import students
        private void importStudentsBtn_Click(object sender, EventArgs e)
        {
            importMod.Show();
            addPanel.Visible = false;
        }
    }
}
