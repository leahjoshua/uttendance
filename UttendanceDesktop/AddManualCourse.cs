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
//parisa
namespace UttendanceDesktop
{
    public partial class AddManualCourse : Form
    {
        public AddManualCourse()
        {
            InitializeComponent();
        }

        private void CourseNameTextBox_Enter(object sender, EventArgs e)
        {
            if (courseNameTextBox.Text == "Enter course name (E.g. Computer Science Project)")
            {
                courseNameTextBox.Text = "";
                courseNameTextBox.ForeColor = Color.Black;
            }
        }

        private void CourseNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(courseNameTextBox.Text))
            {
                courseNameTextBox.Text = "Enter course name (E.g. Computer Science Project)";
                courseNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void CourseNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (courseNameTextBox.Text.Length > 0 && courseNameTextBox.ForeColor == Color.Gray)
            {
                courseNameTextBox.ForeColor = Color.Black;
            }
        }

        private void ClassPrefixTextBox_Enter(object sender, EventArgs e)
        {
            if (classPrefixTextBox.Text == "E.g. CS")
            {
                classPrefixTextBox.Text = "";
                classPrefixTextBox.ForeColor = Color.Black;
            }
        }

        private void ClassPrefixTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(classPrefixTextBox.Text))
            {
                classPrefixTextBox.Text = "E.g. CS";
                classPrefixTextBox.ForeColor = Color.Gray;
            }
        }

        private void ClassPrefixTextBox_TextChanged(object sender, EventArgs e)
        {
            if (classPrefixTextBox.Text.Length > 0 && classPrefixTextBox.ForeColor == Color.Gray)
            {
                classPrefixTextBox.ForeColor = Color.Black;
            }
        }
        private void ClassNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (classNumberTextBox.Text == "E.g. 4485")
            {
                classNumberTextBox.Text = "";
                classNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void ClassNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(classNumberTextBox.Text))
            {
                classNumberTextBox.Text = "E.g. 4485";
                classNumberTextBox.ForeColor = Color.Gray;
            }
        }

        private void ClassNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (classNumberTextBox.Text.Length > 0 && classNumberTextBox.ForeColor == Color.Gray)
            {
                classNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace, and control keys 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block non-numeric input
            }
        }

        private void SectionNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (sectionNumberTextBox.Text == "E.g. 0W3")
            {
                sectionNumberTextBox.Text = "";
                sectionNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void SectionNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sectionNumberTextBox.Text))
            {
                sectionNumberTextBox.Text = "E.g. 0W3";
                sectionNumberTextBox.ForeColor = Color.Gray;
            }
        }

        private void SectionNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sectionNumberTextBox.Text.Length > 0 && sectionNumberTextBox.ForeColor == Color.Gray)
            {
                sectionNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void ClassIDTextBox_Enter(object sender, EventArgs e)
        {
            if (classIDTextBox.Text == "E.g. 21868")
            {
                classIDTextBox.Text = "";
                classIDTextBox.ForeColor = Color.Black;
            }
        }

        private void ClassIDTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(classIDTextBox.Text))
            {
                classIDTextBox.Text = "E.g. 21868";
                classIDTextBox.ForeColor = Color.Gray;
            }
        }

        private void ClassIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (classIDTextBox.Text.Length > 0 && classIDTextBox.ForeColor == Color.Gray)
            {
                classIDTextBox.ForeColor = Color.Black;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string name = courseNameTextBox.ForeColor == Color.Gray ? "" : courseNameTextBox.Text;
            string prefix = classPrefixTextBox.ForeColor == Color.Gray ? "" : classPrefixTextBox.Text;
            string number1 = classNumberTextBox.ForeColor == Color.Gray ? "" : classNumberTextBox.Text;
            string section1 = sectionNumberTextBox.ForeColor == Color.Gray ? "" : sectionNumberTextBox.Text;
            string classId1 = classIDTextBox.ForeColor == Color.Gray ? "" : classIDTextBox.Text;

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

            int.TryParse(section1, out int section);
            int.TryParse(number1, out int number);
            int.TryParse(classId1, out int classId);

            Class cls = new Class();
            string result = cls.AddClass(name, prefix, number, section, classId);

            MessageBox.Show(result);

            if (result.StartsWith("Course added"))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Course could not be added");
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
