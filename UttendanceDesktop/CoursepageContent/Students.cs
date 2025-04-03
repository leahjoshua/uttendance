using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 28, 2025.
    // NetID: jxy210012
    public partial class Students : Form
    {
        //Sets up parameter for import module
        private static string tableName = "student";
        private static string[] attributeList = { "SLName", "SFNAME", "SNetID", "UTDID" };
        private static string[] displayList = {"Last Name", "First Name", "Username", "Student ID"};
        private static string[] typeList = { "string", "string", "string", "int" };
        private static string pkeyName = "UTDID";

        private static string relationTableName = "attends";
        private static string[] fkeysList = {"FK_UTDID", "FK_CourseNum"};
        private static string[] fkeyTypeList = { "int", "int" };
        private static string fk1 = "" + GlobalResource.CURRENT_CLASS_ID;
        private ImportModule importMod = new ImportModule("Students", tableName, attributeList, displayList, typeList, 
            pkeyName, relationTableName, fkeysList, fkeyTypeList, fk1);
        public Students()
        {
            InitializeComponent();
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
