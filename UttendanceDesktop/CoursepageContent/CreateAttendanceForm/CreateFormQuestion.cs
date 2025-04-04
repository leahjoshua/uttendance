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
        public CreateFormQuestion()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            var choices = new List<AnswerChoice>();
            bool currentIsCorrect = false;
            int numChoices = 0;

            if (!string.IsNullOrWhiteSpace(choiceATextbox.Text))
            {
                if (correctABtn.Checked)
                {
                    currentIsCorrect = true;
                }
                else
                {
                    currentIsCorrect = false;
                }

                choices.Add(new AnswerChoice
                {
                    isCorrect = currentIsCorrect,
                    AnswerStatement = choiceATextbox.Text
                });
                numChoices++;
            }
            if (!string.IsNullOrWhiteSpace(choiceBTextbox.Text)) 
            {
                if (correctBBtn.Checked)
                {
                    currentIsCorrect = true;
                }
                else
                {
                    currentIsCorrect = false;
                }

                choices.Add(new AnswerChoice
                {
                    isCorrect = currentIsCorrect,
                    AnswerStatement = choiceBTextbox.Text
                });
                numChoices++;
            }
            if (!string.IsNullOrWhiteSpace(choiceCTextbox.Text)) 
            {
                if (correctCBtn.Checked)
                {
                    currentIsCorrect = true;
                }
                else
                {
                    currentIsCorrect = false;
                }

                choices.Add(new AnswerChoice
                {
                    isCorrect = currentIsCorrect,
                    AnswerStatement = choiceCTextbox.Text
                });
                numChoices++;
            }
            if (!string.IsNullOrWhiteSpace(choiceDTextbox.Text)) 
            {
                if (correctDBtn.Checked)
                {
                    currentIsCorrect = true;
                }
                else
                {
                    currentIsCorrect = false;
                }

                choices.Add(new AnswerChoice
                {
                    isCorrect = currentIsCorrect,
                    AnswerStatement = choiceDTextbox.Text
                });
                numChoices++;
            }

            if (numChoices < 2 || string.IsNullOrWhiteSpace(problemStmtTextbox.Text))
            {
                return;
            }

            question = new Question
            { 
                ProblemStatement = problemStmtTextbox.Text,
                AnswerChoices = choices
            };

            // Set the dialog result to OK so the parent form knows it was saved not just closed
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
