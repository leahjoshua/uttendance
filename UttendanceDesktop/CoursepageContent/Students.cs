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
        private static string[] attributeList = { "Last Name", "First Name", "UTD-ID", "Net-ID" };
        private ImportModule importMod = new ImportModule("Students", attributeList);
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
