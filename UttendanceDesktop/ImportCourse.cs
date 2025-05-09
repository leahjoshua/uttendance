/******************************************************************************
* ImportCourse Form for the UttendanceDesktop application.
* This form allows users to import multiple courses from a CSV file into the
* Uttendance system. The user selects a CSV file, and each row is parsed and
* added as a new course. The form provides feedback on the import process and
* refreshes the homepage to reflect the new courses.
* Written by Parisa Nawar (pxn210032) for CS4485.0W1 at The University of Texas at Dallas
* starting March 28, 2025.
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
using Microsoft.VisualBasic.Devices;

namespace UttendanceDesktop
{
    public partial class ImportCourse : Form
    {
        private string InstructorID;
        /**************************************************************************
         * Constructor for ImportCourse form.
         * Initializes the form and its components.
         **************************************************************************/
        public ImportCourse(string netID)
        {
            InstructorID = netID;
            InitializeComponent();
        }

        /**************************************************************************
         * Handles the click event for the Cancel button.
         * Closes the ImportCourse form without importing any courses.
         **************************************************************************/
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Close the ImportCourse form
            this.Close();
        }

        /**************************************************************************
         * Handles the click event for the Open button.
         * 
         * Opens a file dialog for the user to select a CSV file. Reads each row
         * from the file (skipping the header), parses course information, and
         * adds each course to the database. Notifies the user when import is
         * complete and refreshes the homepage.
         **************************************************************************/
        private void OpenButton_Click(object sender, EventArgs e)
        {
            // Create and configure the file dialog for CSV files
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse .csv Files",
                Filter = "CSV files (*.csv)|*.csv", // Only allow CSV files
                FilterIndex = 1,
                RestoreDirectory = true
            };

            string filePath = "";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Retrieve the selected file path
                filePath = openFileDialog.FileName;
                MessageBox.Show($"Selected File: {filePath}", "File Selected");
            }
            else
            {
                // If no file was selected, exit
                return;
            }

            // Read all lines from the selected CSV file
            string[] lines = File.ReadAllLines(filePath);

            // Loop through each line in the file
            for (int i = 1; i < lines.Length; i++)
            {
                // Split the line into columns based on commas
                string[] columns = lines[i].Split(',');

                // Extract and trim each field from the columns
                string CourseName = columns[0].Trim();
                string ClassPrefix = columns[1].Trim();
                int ClassNumber = int.Parse(columns[2].Trim());       
                int SectionNumber = int.Parse(columns[3].Trim());    
                int ClassID = int.Parse(columns[4].Trim());          
                TimeSpan ClassStartTime = TimeSpan.Parse(columns[5].Trim());
                TimeSpan ClassEndTime = TimeSpan.Parse(columns[6].Trim());

                // Create a new Class object and add the course to the database
                Class cls = new Class();
                string result = cls.AddClass(CourseName, ClassPrefix, ClassNumber, SectionNumber, ClassID, ClassStartTime, ClassEndTime);
            }

            // Notify the user that all courses have been imported
            MessageBox.Show("Courses Imported!");

            // Close any open Homepage forms to refresh the course list
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in openForms)
            {
                if (form.GetType() == typeof(Homepage))
                {
                    form.Close();
                }
            }

            // Open a new Homepage form
            Homepage newHomepage = new Homepage(InstructorID);
            newHomepage.Show();
        }
    }
}
