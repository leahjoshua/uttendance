/******************************************************************************
* StudentImportModal Class for the UttendanceDesktop application.
* This class serves as a modal for professor's to import a csv with
* a list of student information into their class.
* Written by Joanna Yang and Parisa Nawar (jxy210012, pxn210032) 
* for CS4485.0W1 at The University of Texas at Dallas starting March 27, 2025.
******************************************************************************/

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
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace UttendanceDesktop
{
    
    public partial class StudentImportModal : Form
    {
        //A flag to raise when all students have been imported to the class
        public event Action? DatabaseUpdated;
        private int courseNum;

        /**************************************************************************
        * Constructs the StudentImportModal upon initilization and stores the given
        * course number to import the students into
        * Written by Joanna Yang
        **************************************************************************/
        public StudentImportModal(int classID)
        {
            InitializeComponent();
            courseNum = classID;
        }

        /**************************************************************************
        * Handles the 'Cancel' button click.
        * Hides the import module.
        * Written by Joanna Yang
        **************************************************************************/
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        /**************************************************************************
        * Handles the 'Open' button click.
        * Opens the file explorer to let user select .csv file to import.
        * Uses StudentsDAO to add the students to the class using information 
        * from the csv file
        * Written by Parisa and Joanna
        **************************************************************************/
        private void openBtn_Click(object sender, EventArgs e)
        {
            //Opens the file explorer to let user select .csv file to import
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:",
                Title = "Browse .csv Files",
                Filter = "CSV files (*.csv)|*.csv", // File filter for csv
                FilterIndex = 1,
                RestoreDirectory = true
            };

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Hide the import modal
                Visible = false;

                // Retrieve the selected file path
                string filePath = openFileDialog.FileName;
                DialogResult result = MessageBox.Show($"Selected File: {filePath}", "File Selected", MessageBoxButtons.OKCancel);
                
                // Imports the data into the database
                if (result == DialogResult.OK)
                {
                    StudentsDAO studentImport = new StudentsDAO();
                    //If student import was successful, then raise the flag
                    if (studentImport.importStudentsFromCSV(filePath, courseNum))
                    {
                        //Raise flag
                        DatabaseUpdated?.Invoke();
                    }
                    else
                    {
                        //else display error message
                        MessageBox.Show("Failed to import. Pleae check your values.\n");
                    }
                }
            }
        }

    }
}
