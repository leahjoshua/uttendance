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
        public Homepage()
        {
            InitializeComponent();
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            AddCourse newCourse = new AddCourse();
            newCourse.show();
        }

        private void dltCourseBtn_Click(object sender, EventArgs e)
        {
            DeleteCourse dltCourse = new DeleteCourse();
            dltCourse.show();
        }

        private void CourseCard_Click(object sender, EventArgs e)
        {
            CourseCard
        }

    }
}