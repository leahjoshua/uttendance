using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//parisa
namespace UttendanceDesktop
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addCourseManualButton.Visible = true;
            importCourseButton.Visible = true;
        }

        private void addCourseManualButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddManualCourse form
            AddManualCourse addCourseForm = new AddManualCourse();

            // Show the form as a modal dialog
            addCourseForm.ShowDialog();
        }

        private void importCourseButton_Click(object sender, EventArgs e)
        {
            ImportCourse importCourseForm = new ImportCourse();
            importCourseForm.ShowDialog();
        }
    }
}
