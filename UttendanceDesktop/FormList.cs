/******************************************************************************
* FormsList Class for the UttendanceDesktop application.
* This class is a form that displays a table containing a list of passwords for 
* each form for each class that the professor teaches.
* Written by Joanna Yang (jxy210012)
* for CS4485.0W1 at The University of Texas at Dallas starting April 26, 2025.
******************************************************************************/

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
    public partial class FormList : Form
    {
        //Net-ID of the instructor
        private string InstructorID;

        //Name of the column headers to display
        private static string[] displayList = { "Class", "Class Name", "Date", "Release", "Close", "Password"};

        /**************************************************************************
        * Constructs the FormList upon initialization and stores
        * the professor's Net-ID.
        **************************************************************************/
        public FormList(string id)
        {
            InstructorID = id;
            InitializeComponent();
            //Populates the form table
            populateFormsTable();
        }

        /**************************************************************************
        * Fills the table with information on each form for each class
        * the professor teaches using the FormListDAO class to pull from 
        * the database.
        **************************************************************************/
        private void populateFormsTable()
        {
            //Create the data table using FormsListDAO
            FormsListDAO forms = new FormsListDAO();
            this.formsTable.DataSource = forms.getAllForms(displayList, InstructorID);

            //Set the minimum size for all of the columns to 50
            for(int i = 0; i < displayList.Length; i++)
            {
                formsTable.Columns[i].MinimumWidth = 50;
            }

            //Make the class name column longer
            formsTable.Columns["Class Name"].Width = 200;

            //Make the time columns shorter
            formsTable.Columns["Date"].Width = 75;
            formsTable.Columns["Release"].Width = 75;
            formsTable.Columns["Close"].Width = 75;
        }
    }
}
