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
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 27, 2025.
    // NetID: jxy210012
    // Wrote the whole StudentImportModal class
    public partial class StudentImportModal : Form
    {
        public event Action? DatabaseUpdated;
        private int courseNum;

        //Creates an import module based on the input passed
        public StudentImportModal(int classID)
        {
            InitializeComponent();
            courseNum = classID;
        }


        //Hides the import module to return user back to page when click 'Cancel'
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        //Opens the file explorer to let user select .csv file to import
        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:",
                Title = "Browse .csv Files",
                Filter = "CSV files (*.csv)|*.csv", // File filter
                FilterIndex = 1,
                RestoreDirectory = true
            };

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Visible = false;
                // Retrieve the selected file path
                string filePath = openFileDialog.FileName;
                DialogResult result = MessageBox.Show($"Selected File: {filePath}", "File Selected", MessageBoxButtons.OKCancel);
                
                // Imports the data into the database
                if (result == DialogResult.OK)
                {
                    StudentsDAO studentImport = new StudentsDAO();
                    if (studentImport.importStudentsFromCSV(filePath, courseNum))
                    {
                        //Raise flag
                        DatabaseUpdated?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Failed to import. Pleae check your values.\n");
                    }
                }
            }
        }

    }
}
