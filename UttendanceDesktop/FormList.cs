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
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting April 26, 2025.
    // NetID: jxy210012
    // Wrote the FormList class
    public partial class FormList : Form
    {
        private string InstructorID;
        private static string[] displayList = { "Class", "Class Name", "Date", "Release", "Close", "Password"};
        public FormList(string id)
        {
            InstructorID = id;
            InitializeComponent();

            populateFormsTable();
        }

        //Fills the table with information on each class and each form
        private void populateFormsTable()
        {
            FormsListDAO forms = new FormsListDAO();
            this.formsTable.DataSource = forms.getAllForms(displayList, InstructorID);

            //Make the class names column longer
            formsTable.Columns["Class Name"].Width = 200;

            //Make the time columns shorter
            formsTable.Columns["Date"].Width = 75;
            formsTable.Columns["Release"].Width = 75;
            formsTable.Columns["Close"].Width = 75;
        }
    }
}
