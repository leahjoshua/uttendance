using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent.CreateAttendanceForm;
using UttendanceDesktop.CoursepageContent.models;
using static System.Net.Mime.MediaTypeNames;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class CreateAttendanceFormPage : Form
    {
        //private CreateFormQuestion createQMod = new CreateFormQuestion();
        private List<Question> questions = new List<Question>();
        private List<QuestionUserControl> questionListings = new List<QuestionUserControl>();

        public CreateAttendanceFormPage()
        {
            InitializeComponent();
            PopulateQuestions();
            /*var og = new QuestionUserControl();
            questionsListingPanel.Controls.Add(og);
            var test = new QuestionUserControl();
            test.Location = new Point(
                test.Location.X,
                test.Location.Y + og.Height + 5
            );
            questionsListingPanel.Controls.Add(test);*/
        }
        public void PopulateQuestions()
        {
            if (questionsListingPanel.Controls.Count > 0)
            {
                questionsListingPanel.Controls.Clear();
            }

            for (int i = 0; i < questions.Count; i++)
            {
                var questionAdding = new QuestionUserControl();
                questionAdding.QuestionNumberText = i + 1 + " of " + questions.Count;
                questionAdding.Location = new Point(
                    questionAdding.Location.X,
                    questionAdding.Location.Y + (i * questionAdding.Height) + 5
                );

                questionAdding.ChoiceA = "A. " + questions[i].AnswerChoices[0].AnswerStatement;
                questionAdding.ChoiceB = "B. " + questions[i].AnswerChoices[1].AnswerStatement;
                if (questions[i].AnswerChoices.Count >= 3)
                {
                    questionAdding.ChoiceC = "C. " + questions[i].AnswerChoices[2].AnswerStatement;
                }
                if (questions[i].AnswerChoices.Count == 4)
                {
                    questionAdding.ChoiceD = "D. " + questions[i].AnswerChoices[3].AnswerStatement;
                }
                questionAdding.ProblemStatement = questions[i].ProblemStatement;

                questionsListingPanel.Controls.Add(questionAdding);
            }
        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            using (CreateFormQuestion createQMod = new CreateFormQuestion())
            {
                if (createQMod.ShowDialog() == DialogResult.OK)
                {
                    questions.Add(createQMod.question);
                    PopulateQuestions();
                }
            }
        }
    }
}
