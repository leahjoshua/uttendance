/******************************************************************************
* AddManualCourse Form for the UttendanceDesktop application.
* This form allows users to manually add a new course to the Uttendance system.
* It provides text boxes for entering course details such as name, prefix,
* number, section, and class ID. The form validates user input, ensures only
* valid data is submitted, and interacts with the Class object to add the new
* course to the database. It also manages placeholder text and input formatting
* for a user-friendly experience.
* Written by Parisa Nawar (pxn210032) for CS4485.0W1 at The University of Texas at Dallas
* starting March 24, 2025.
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
    public partial class AddManualCourse : Form
    {
        private string InstructorID;
        /**************************************************************************
         * Constructor for AddManualCourse form.
         * Initializes the form and its components.
         **************************************************************************/
        public AddManualCourse(string netID)
        {
            InstructorID = netID;
            //Initialize UI of AddManualCourse Form
            InitializeComponent();

            //Set the start and end time to be the time of creation by default
            startTimePicker.Value = DateTime.Today;
            endTimePicker.Value = startTimePicker.Value.AddHours(1).AddMinutes(15);
        }

        /**************************************************************************
         * Handles the Enter event for the course name text box.
         * Clears the placeholder text when the user focuses on the text box.
         **************************************************************************/
        private void CourseNameTextBox_Enter(object sender, EventArgs e)
        {
            // If the text box contains the placeholder, clear it and set text color to black
            if (courseNameTextBox.Text == "Enter course name (E.g. Computer Science Project)")
            {
                courseNameTextBox.Text = "";
                courseNameTextBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
         * Handles the Leave event for the course name text box.
         * Restores the placeholder text if the text box is left empty.
         **************************************************************************/
        private void CourseNameTextBox_Leave(object sender, EventArgs e)
        {
            // If the text box is empty, restore the placeholder and set text color to gray
            if (string.IsNullOrEmpty(courseNameTextBox.Text))
            {
                courseNameTextBox.Text = "Enter course name (E.g. Computer Science Project)";
                courseNameTextBox.ForeColor = Color.Gray;
            }
        }

        /**************************************************************************
         * Handles the TextChanged event for the course name text box.
         * Ensures the text color is set to black when the user starts typing.
         **************************************************************************/
        private void CourseNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the user starts typing while the text is gray, change it to black
            if (courseNameTextBox.Text.Length > 0 && courseNameTextBox.ForeColor == Color.Gray)
            {
                courseNameTextBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
         * Handles the Enter event for the class prefix text box.
         * Clears the placeholder text when the user focuses on the text box.
         **************************************************************************/
        private void ClassPrefixTextBox_Enter(object sender, EventArgs e)
        {
            // If the text box contains the placeholder, clear it and set text color to black
            if (classPrefixTextBox.Text == "E.g. CS")
            {
                classPrefixTextBox.Text = "";
                classPrefixTextBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
         * Handles the Leave event for the class prefix text box.
         * Restores the placeholder text if the text box is left empty.
         **************************************************************************/
        private void ClassPrefixTextBox_Leave(object sender, EventArgs e)
        {
            // If the text box is empty, restore the placeholder and set text color to gray
            if (string.IsNullOrEmpty(classPrefixTextBox.Text))
            {
                classPrefixTextBox.Text = "E.g. CS";
                classPrefixTextBox.ForeColor = Color.Gray;
            }
        }

        /**************************************************************************
         * Handles the TextChanged event for the class prefix text box.
         * Ensures the text color is set to black when the user starts typing.
         **************************************************************************/
        private void ClassPrefixTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the user starts typing while the text is gray, change it to black
            if (classPrefixTextBox.Text.Length > 0 && classPrefixTextBox.ForeColor == Color.Gray)
            {
                classPrefixTextBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
         * Handles the Enter event for the class number text box.
         * Clears the placeholder text when the user focuses on the text box.
         **************************************************************************/
        private void ClassNumberTextBox_Enter(object sender, EventArgs e)
        {
            // If the text box contains the placeholder, clear it and set text color to black
            if (classNumberTextBox.Text == "E.g. 4485")
            {
                classNumberTextBox.Text = "";
                classNumberTextBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
         * Handles the Leave event for the class number text box.
         * Restores the placeholder text if the text box is left empty.
         **************************************************************************/
        private void ClassNumberTextBox_Leave(object sender, EventArgs e)
        {
            // If the text box is empty, restore the placeholder and set text color to gray
            if (string.IsNullOrEmpty(classNumberTextBox.Text))
            {
                classNumberTextBox.Text = "E.g. 4485";
                classNumberTextBox.ForeColor = Color.Gray;
            }
        }

        /**************************************************************************
         * Handles the TextChanged event for the class number text box.
         * Ensures the text color is set to black when the user starts typing.
         **************************************************************************/
        private void ClassNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the user starts typing while the text is gray, change it to black
            if (classNumberTextBox.Text.Length > 0 && classNumberTextBox.ForeColor == Color.Gray)
            {
                classNumberTextBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
         * Restricts input to only numbers in the relevant text box.
         * Blocks non-numeric input except for backspace and control keys.
         **************************************************************************/
        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and control keys in the text box
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block non-numeric input
            }
        }


        /**************************************************************************
         * Handles the Enter event for the section number text box.
         * Clears the placeholder text when the user focuses on the text box.
         **************************************************************************/
        private void SectionNumberTextBox_Enter(object sender, EventArgs e)
        {
            // If the text box contains the placeholder, clear it and set text color to black
            if (sectionNumberTextBox.Text == "E.g. 0W3")
            {
                sectionNumberTextBox.Text = "";
                sectionNumberTextBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
         * Handles the Leave event for the section number text box.
         * Restores the placeholder text if the text box is left empty.
         **************************************************************************/
        private void SectionNumberTextBox_Leave(object sender, EventArgs e)
        {
            // If the text box is empty, restore the placeholder and set text color to gray
            if (string.IsNullOrEmpty(sectionNumberTextBox.Text))
            {
                sectionNumberTextBox.Text = "E.g. 0W3";
                sectionNumberTextBox.ForeColor = Color.Gray;
            }
        }

        /**************************************************************************
         * Handles the TextChanged event for the section number text box.
         * Ensures the text color is set to black when the user starts typing.
         **************************************************************************/
        private void SectionNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the user starts typing while the text is gray, change it to black
            if (sectionNumberTextBox.Text.Length > 0 && sectionNumberTextBox.ForeColor == Color.Gray)
            {
                sectionNumberTextBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
         * Handles the Enter event for the class ID text box.
         * Clears the placeholder text when the user focuses on the text box.
         **************************************************************************/
        private void ClassIDTextBox_Enter(object sender, EventArgs e)
        {
            // If the text box contains the placeholder, clear it and set text color to black
            if (classIDTextBox.Text == "E.g. 21868")
            {
                classIDTextBox.Text = "";
                classIDTextBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
         * Handles the Leave event for the class ID text box.
         * Restores the placeholder text if the text box is left empty.
         **************************************************************************/
        private void ClassIDTextBox_Leave(object sender, EventArgs e)
        {
            // If the text box is empty, restore the placeholder and set text color to gray
            if (string.IsNullOrEmpty(classIDTextBox.Text))
            {
                classIDTextBox.Text = "E.g. 21868";
                classIDTextBox.ForeColor = Color.Gray;
            }
        }

        /**************************************************************************
         * Handles the TextChanged event for the class ID text box.
         * Ensures the text color is set to black when the user starts typing.
         **************************************************************************/
        private void ClassIDTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the user starts typing while the text is gray, change it to black
            if (classIDTextBox.Text.Length > 0 && classIDTextBox.ForeColor == Color.Gray)
            {
                classIDTextBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
         * Handles the click event for the Create button.
         * 
         * Validates all input fields, displays error messages for missing data,
         * and attempts to add the new course using the Class object. If the
         * course is added successfully, closes the form and refreshes the
         * homepage. Otherwise, displays an error message.
         **************************************************************************/
        private void CreateButton_Click(object sender, EventArgs e)
        {
            // Retrieve user input, ignoring placeholder text by checking text color
            string name = courseNameTextBox.ForeColor == Color.Gray ? "" : courseNameTextBox.Text;
            string prefix = classPrefixTextBox.ForeColor == Color.Gray ? "" : classPrefixTextBox.Text;
            string number1 = classNumberTextBox.ForeColor == Color.Gray ? "" : classNumberTextBox.Text;
            string section1 = sectionNumberTextBox.ForeColor == Color.Gray ? "" : sectionNumberTextBox.Text;
            string classId1 = classIDTextBox.ForeColor == Color.Gray ? "" : classIDTextBox.Text;
            TimeSpan start = startTimePicker.Value.TimeOfDay;
            TimeSpan end = endTimePicker.Value.TimeOfDay;

            // Validate each field and show an error if missing
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Course Name is required");
                return;
            }
            if (string.IsNullOrWhiteSpace(prefix))
            {
                MessageBox.Show("Class Prefix is required");
                return;
            }
            if (string.IsNullOrWhiteSpace(number1))
            {
                MessageBox.Show("Class Number is required");
                return;
            }
            if (string.IsNullOrWhiteSpace(section1))
            {
                MessageBox.Show("Section Number is required");
                return;
            }
            if (string.IsNullOrWhiteSpace(classId1))
            {
                MessageBox.Show("Class ID is required");
                return;
            }

            // Attempt to parse numeric fields 
            int.TryParse(section1, out int section); // Section number as integer
            int.TryParse(number1, out int number);   // Class number as integer
            int.TryParse(classId1, out int classId); // Class ID as integer

            // Create a new Class object and attempt to add the course
            Class cls = new Class();
            string result = cls.AddClass(name, prefix, number, section, classId, start, end);

            // Show the result of the add operation to the user
            MessageBox.Show(result);

            // If the course was added successfully, close this form
            if (result.StartsWith("Course added"))
            {
                this.Close();
            }
            else
            {
                // If not successful, show an error 
                MessageBox.Show("Course could not be added");
            }

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

        /**************************************************************************
         * Handles the click event for the Cancel button.
         * Closes the AddManualCourse form without saving any changes.
         **************************************************************************/
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close the form when the user clicks Cancel
            this.Close();
        }

        /**************************************************************************
         * Handles the value change event for the Start DateTime picker.
         * Adds 1 hour and 15 minute by default to the End DateTime picker.
         **************************************************************************/
        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endTimePicker.Value = startTimePicker.Value.AddHours(1).AddMinutes(15);
        }
    }
}
