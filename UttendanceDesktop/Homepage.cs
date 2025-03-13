using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//parisa made this
namespace UttendanceDesktop
{
    public partial class Homepage : Form
    {
        private bool optionsVisible = false;

        public Homepage()
        {
            InitializeComponent();
            ConfigureInitialState();
        }

        private void ConfigureInitialState()
        {
            //Trying to set initial buttons (hidden)
            addCourseBtn.Visible = false;
            dltCourseBtn.Visible = false;

            //Styling the button
            plusBtn.FlatStyle = FlatStyle.Flat;
            plusBtn.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
            plusBtn.Size = new Size(40, 40);
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            //Toggle visibility
            optionsVisible = !obtionsVisible;
            addCourseBtn.Visible = optionsVisible;
            dltCourseBtn.Visible = optionsVisible;
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            using(AddCourse newCourse = new AddCourse())
            {
                if(newCourse.ShowDialog() == DialogResult.OK)
                {
                    //Refresh the course list after adding
                    RefreshCourseCards();
                }
            }
        }

        private void dltCourseBtn_Click(object sender, EventArgs e)
        {
            using (DeleteCourse dltCourse = new DeleteCourse())
            {
                if (dltCourse.ShowDialog() == DialogResult.OK)
                {
                    //Refresh the course list after adding
                    RefreshCourseCards();
                }
            }
        }

        private void RefreshCourseCards()
        {

        }

        private void CourseCard_Click(object sender, EventArgs e)
        {
            var clickCard = (Panel)sender;
        }

    }
}