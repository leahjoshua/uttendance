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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class CreateFormQuestion : Form
    {
        public Question? question { get; private set; }

        public QuestionItem.QuestionItem? questionItem { get; private set; }

        public CreateFormQuestion()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Lee 
        // (Updated 4/15/25 by Aendri)
        // Create question item on create
        private void createBtn_Click(object sender, EventArgs e)
        {
            var choices = new List<AnswerChoice>();
            bool currentIsCorrect = false;
            bool selectedCorrect = false;

            int numChoices = 0;

            List<QuestionItem.QuestionAnswerItem> answerItemList = new List<QuestionItem.QuestionAnswerItem>();

            // Answer Choice A
            if (!string.IsNullOrWhiteSpace(choiceATextbox.Text))
            {
                if (correctABtn.Checked)
                {
                    currentIsCorrect = true;
                    selectedCorrect = true;
                }
                else
                {
                    currentIsCorrect = false;
                }

                // Create Answer item and add to list
                answerItemList.Add(new QuestionItem.QuestionAnswerItem(
                    'A', choiceATextbox.Text, currentIsCorrect
                    ));


                choices.Add(new AnswerChoice
                {
                    isCorrect = currentIsCorrect,
                    AnswerStatement = choiceATextbox.Text
                });
                numChoices++;
            }

            // Answer Choice B
            if (!string.IsNullOrWhiteSpace(choiceBTextbox.Text)) 
            {
                if (correctBBtn.Checked)
                {
                    currentIsCorrect = true;
                    selectedCorrect = true;
                }
                else
                {
                    currentIsCorrect = false;
                }

                // Create Answer item and add to list
                answerItemList.Add(new QuestionItem.QuestionAnswerItem(
                    'B', choiceBTextbox.Text, currentIsCorrect
                    ));

                choices.Add(new AnswerChoice
                {
                    isCorrect = currentIsCorrect,
                    AnswerStatement = choiceBTextbox.Text
                });
                numChoices++;
            }

            // Answer Choice C
            if (!string.IsNullOrWhiteSpace(choiceCTextbox.Text)) 
            {
                if (correctCBtn.Checked)
                {
                    currentIsCorrect = true;
                    selectedCorrect = true;
                }
                else
                {
                    currentIsCorrect = false;
                }

                // Create Answer item and add to list
                answerItemList.Add(new QuestionItem.QuestionAnswerItem(
                    'C', choiceCTextbox.Text, currentIsCorrect
                    ));

                choices.Add(new AnswerChoice
                {
                    isCorrect = currentIsCorrect,
                    AnswerStatement = choiceCTextbox.Text
                });
                numChoices++;
            }

            // Answer Choice D
            if (!string.IsNullOrWhiteSpace(choiceDTextbox.Text)) 
            {
                if (correctDBtn.Checked)
                {
                    currentIsCorrect = true;
                    selectedCorrect = true;
                }
                else
                {
                    currentIsCorrect = false;
                }

                // Create Answer item and add to list
                answerItemList.Add(new QuestionItem.QuestionAnswerItem(
                    'D', choiceDTextbox.Text, currentIsCorrect
                    ));


                choices.Add(new AnswerChoice
                {
                    isCorrect = currentIsCorrect,
                    AnswerStatement = choiceDTextbox.Text
                });
                numChoices++;
            }

            // Check if at least 2 answers:
            if (numChoices < 2 || string.IsNullOrWhiteSpace(problemStmtTextbox.Text) || !selectedCorrect)
            {
                MessageBox.Show("Make sure you have entered a problem statement and at least 2 answer choices, and a correct answer is selected for one filled in answer choice field.");
                return;
            }

            question = new Question
            { 
                ProblemStatement = problemStmtTextbox.Text,
                AnswerChoices = choices
            };

            // Create Question Item 
            questionItem = new QuestionItem.QuestionItem();
            questionItem.QuestionValue = problemStmtTextbox.Text;
            questionItem.AnswerList = answerItemList.ToArray();

            // Set the dialog result to OK so the parent form knows it was saved not just closed
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
