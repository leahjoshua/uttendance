/******************************************************************************
* CreateAttendanceFormPage for the UttendanceDesktop application.
* 
* This class represents the create attendance form page, where professors
* can enter information to create attenance forms for their class. This includes
* the option to add questions or import them from the question bank.
* 
* The Professor is required to at least enter a release and close time as well
* as a password.
*
* Written by Leah Joshua (lej210003) 
* and Aendri Singh (axs210369) 
* for CS4485.0W1 at The University of Texas at Dallas
* starting April 3, 2025.
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
using UttendanceDesktop.CoursepageContent.CreateAttendanceForm;
using UttendanceDesktop.CoursepageContent.models;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class CreateAttendanceFormPage : Form
    {
        //private CreateFormQuestion createQMod = new CreateFormQuestion();
        private List<Question> questions = new List<Question>();
        private List<QuestionUserControl> questionListings = new List<QuestionUserControl>();

        private List<QuestionItem.QuestionItem> questionList = new List<QuestionItem.QuestionItem>();
        private FormDAO DB = new FormDAO();

        /**************************************************************************
        * Intializes the Create Attendance Form page.
        * Sets the default times to the class times, day will be tomorrow by
        * default.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        public CreateAttendanceFormPage()
        {
            InitializeComponent();
            releaseTimePicker.MinDate = DateTime.Now;
            closeTimePicker.MinDate = DateTime.Now;

            // set times to class times by default
            List<TimeSpan> times = DB.GetTimes(GlobalResource.CURRENT_CLASS_ID);
            releaseTimePicker.Value = DateTime.Today.AddDays(1) + times[0];
            closeTimePicker.Value = DateTime.Today.AddDays(1) + times[1];

            PopulateQuestions();
        }

        /**************************************************************************
        * Clears the current questions and readds them to the display based
        * on the questionList, which is changed when questions are added or
        * removed.
        * 
        * Written by Leah Joshua and Aendri Singh.
        **************************************************************************/
        public void PopulateQuestions()
        {
            flowLayoutPanel.Controls.Clear();
            if (questionList != null)
            {
                for (int i = 0; i < questionList.Count; i++)
                {
                    questionList[i].QuestionNumber = i + 1;
                    flowLayoutPanel.Controls.Add(questionList[i]);
                }
            }

            /*var questionUserControls = createFormPanel.Controls.OfType<QuestionUserControl>().ToList();
            foreach (var control in questionUserControls)
            {
                createFormPanel.Controls.Remove(control);
            }

            // Add questions to page:
            //questionsListingPanel.Controls.Clear();

            for (int i = 0; i < questionList.Count; i++)
            {
                questionList[i].QuestionNumber = i + 1; // Number the questions

                // Set location
                questionList[i].Location = new Point(
                    questionsListingPanel.Location.X,
                    questionsListingPanel.Location.Y + (i * questionList[i].Height)
                );
                createFormPanel.Controls.Add(questionList[i]);
            }*/

            /*var questionUserControls = createFormPanel.Controls.OfType<QuestionUserControl>().ToList();

            foreach (var control in questionUserControls)
            {
                createFormPanel.Controls.Remove(control);
        }

        /**************************************************************************
        * Triggers on the plus sign button click. Makes the Add question and
        * import question buttons visible so the professor can choose an option.
        * 
        * Written by Leah Joshua and Aendri Singh.
        **************************************************************************/
        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            addQuestionBtn.Visible = true;
            importQuestionBtn.Visible = true;
        }

        /**************************************************************************
        * Triggers on the save button click. Checks input fields to make sure
        * user entered data is valid, saves the form to the DB (and questions if 
        * there are any), and closes the create page.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pwdTxtBox.Text))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            var todaysDate = DateTime.Now;
            if (releaseTimePicker.Value < todaysDate || closeTimePicker.Value < todaysDate)
            {
                MessageBox.Show("Dates/Times cannot be in the past.");
                return;
            }

            if (releaseTimePicker.Value > closeTimePicker.Value)
            {
                MessageBox.Show("Close time cannot be before Release time.");
                return;
            }

            AttendanceForm newForm = new AttendanceForm
            {
                PassWd = pwdTxtBox.Text,
                ReleaseDateTime = releaseTimePicker.Value,
                CloseDateTime = closeTimePicker.Value,
                CourseNum = GlobalResource.CURRENT_CLASS_ID
            };

            FormDAO formSaver = new FormDAO();
            int FormID = formSaver.SaveForm(newForm);
            if (questionList.Count > 0)
            {
                formSaver.SaveQuestions(questionList, FormID);
            }

            GlobalResource.COURSEPAGE.loadForm(new AttendanceForms_Listings(GlobalResource.CURRENT_CLASS_ID));
            this.Close();
        }

        /**************************************************************************
        * Triggers on the cancel button click. Loads the form listing page and
        * closes the create page.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            GlobalResource.COURSEPAGE.loadForm(new AttendanceForms_Listings(GlobalResource.CURRENT_CLASS_ID));
            this.Close();
        }

        /**************************************************************************
        * Triggers on the add question button click. Opens a separate window for
        * adding an individual question. Repopulates the displayed questions after
        * the window is closed.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void addQuestionBtn_Click_1(object sender, EventArgs e)
        {
            addQuestionBtn.Visible = false;
            importQuestionBtn.Visible = false;
            using (CreateFormQuestion createQMod = new CreateFormQuestion())
            {
                if (createQMod.ShowDialog() == DialogResult.OK)
                {
                    questions.Add(createQMod.question);

                    questionList.Add(new QuestionItem.QuestionItem(
                        createQMod.questionItem.QuestionValue,
                        createQMod.questionItem.AnswerList
                        ));

                    defaultQuestionsTxt.Visible = false;
                    PopulateQuestions();
                }
            }
        }

        /**************************************************************************
        * Triggers on the import question button click. Opens the window for
        * importing a question from a question bank. Repopulates the displayed 
        * questions after the window is closed.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void importQuestionBtn_Click(object sender, EventArgs e)
        {
            addQuestionBtn.Visible = false;
            importQuestionBtn.Visible = false;
            using (ImportQuestionModal importQMod = new ImportQuestionModal())
            {
                if (importQMod.ShowDialog() == DialogResult.OK)
                {
                    questionList.AddRange(importQMod.selectedQuestions);
                    defaultQuestionsTxt.Visible = false;
                    PopulateQuestions();
                }
            }
        }
    }
}
