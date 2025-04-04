using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent.models;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class CreateAttendanceFormPage : Form
    {
        //private CreateFormQuestion createQMod = new CreateFormQuestion();
        private List<Question> questions = new List<Question>();

        public CreateAttendanceFormPage()
        {
            InitializeComponent();
        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            using (CreateFormQuestion createQMod = new CreateFormQuestion())
            {
                if (createQMod.ShowDialog() == DialogResult.OK)
                {
                    questions.Add(createQMod.question);
                }
            }
        }
    }
}
