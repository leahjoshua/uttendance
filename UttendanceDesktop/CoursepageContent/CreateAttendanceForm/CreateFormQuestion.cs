/******************************************************************************
* CreateFormQuestion for the UttendanceDesktop application.
* 
* This is class represents the Create Individual Question modal when creating
* an attendance form. It requires the user enter a problem statement and at
* least 2 answer choices, and makes sure they select one right answer.
*
* Written by Leah Joshua (lej210003) 
* and Aendri Singh (axs210369)
* for CS4485.0W1 at The University of Texas at Dallas
* starting March 14, 2025.
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
using UttendanceDesktop.CoursepageContent.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class CreateFormQuestion : Form
    {
        public Question? question { get; private set; }
        public QuestionItem.QuestionItem? questionItem { get; private set; }

        /**************************************************************************
        * Intializes the create form question modal.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        public CreateFormQuestion()
        {
            InitializeComponent();
        }

        /**************************************************************************
        * Triggers on click of the cancel button, closes the modal without
        * saving anything.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**************************************************************************
        * Validates all the user input and creates a QuestionItem based on the 
        * information the user entered, saving it to a variable the create
        * attendance page will use to display and save the list of questions for
        * the form
        * 
        * Written by Leah Joshua and Aendri Singh.
        **************************************************************************/
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
