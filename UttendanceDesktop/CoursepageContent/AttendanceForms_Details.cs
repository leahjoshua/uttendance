using Google.Protobuf.WellKnownTypes;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent.Controls.QuestionItem;
using UttendanceDesktop.CoursepageContent.CreateAttendanceForm;
using UttendanceDesktop.CoursepageContent.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class AttendanceForms_Details : Form
    {
        private AttendanceForm formData = new AttendanceForm();
        private QuestionItem.QuestionItem[] questionList;
        private FormDAO DB = new FormDAO();
        private StudentsDAO StudentDB = new StudentsDAO();
        private bool isEditMode = false;

        Color[,] tableColors = new Color[1, 2] {
            { SystemColors.Control, SystemColors.Control },
        };

        public AttendanceForms_Details()
        {
            InitializeComponent();
        }

        public AttendanceForms_Details(int formID)
        {
            InitializeComponent();
            formData.FormID = formID;

            UpdatePage();
        }

        // Updated 4/16/2025 by Aendri
        // Updated 4/25/2025 by Leah
        // Updates page elements from the database
        private void UpdatePage()
        {
            // Get updated form data:
            formData = DB.GetFormData(formData.FormID);

            // Check for error:
            if (formData.FormID < 0)
            {
                MessageBox.Show("No Attendance Form Data Found!");
                return;
            }

            // Update TITLE
            formTitleLabel.Text =
                formData.ReleaseDateTime.ToString("MM/dd/yy") +
                " Attendance Form (" + formData.ReleaseDateTime.ToString("hh:mm tt") + ")";

            // Update PASSWORD
            pwdTxtBox.Text = formData.PassWd;

            // Update DATE
            releaseTimePicker.Value = formData.ReleaseDateTime;
            closeTimePicker.Value = formData.CloseDateTime;

            // Update SUBMISSION DATA
            UpdateStats();

            // Update Question Bank
            PopulateQuestionList();
        }

        /******************************************************************************
        * Updates the submission statistics. Adds % submitted and % not submitted
        * to a bar graph.
        *
        * Written by Leah Joshua.
        ******************************************************************************/
        private void UpdateStats()
        {
            submissionStats.Controls.Clear();

            if (formData.TotalStudents <= 0)
            {
                // Create a label to show that there are no students
                Label label = new Label();
                label.Text = "No data: No students in class.";
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(255, 50, 56, 88);
                label.BackColor = tableColors[0, 0];
                // Add it to cell [0, 0]
                submissionStats.Controls.Add(label, 0, 0);
            }
            else if (formData.ReleaseDateTime > DateTime.Now)
            {
                // Create a label to show that there's no data
                Label label = new Label();
                label.Text = "No data: Form not released yet.";
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(255, 50, 56, 88);
                label.BackColor = tableColors[0, 0];
                // Add it to cell [0, 0]
                submissionStats.Controls.Add(label, 0, 0);
            }
            else
            {
                double percentSubmitted = ((double)formData.TotalSubmissions / formData.TotalStudents) * 100;
                int percentSubmittedRounded = (int)Math.Round(percentSubmitted);

                // Apply to column widths
                submissionStats.ColumnStyles[0].SizeType = SizeType.Percent;
                submissionStats.ColumnStyles[1].SizeType = SizeType.Percent;

                submissionStats.ColumnStyles[0].Width = percentSubmittedRounded;
                submissionStats.ColumnStyles[1].Width = 100 - percentSubmittedRounded;

                // Clear any existing controls in the cell
                submissionStats.Controls.Clear();

                // format submission data table
                tableColors[0, 0] = Color.FromArgb(255, 1, 173, 1);
                tableColors[0, 1] = Color.FromArgb(255, 50, 56, 88);
                submissionStats.Refresh();

                // Check ensures label wont be cut off
                if (percentSubmittedRounded >= 25)
                {
                    // Create a label to show the percentage submitted
                    Label percentSubmittedLabel = new Label();
                    percentSubmittedLabel.Text = $"{percentSubmittedRounded}%";
                    percentSubmittedLabel.Dock = DockStyle.Fill;
                    percentSubmittedLabel.TextAlign = ContentAlignment.MiddleCenter;
                    percentSubmittedLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    percentSubmittedLabel.ForeColor = Color.FromArgb(255, 50, 56, 88);
                    percentSubmittedLabel.BackColor = tableColors[0, 0];
                    // Add it to cell [0, 0]
                    submissionStats.Controls.Add(percentSubmittedLabel, 0, 0);
                }

                // Check ensures label wont be cut off
                if ((100 - percentSubmittedRounded) >= 25)
                {
                    // other label
                    Label percentNotSubmittedLabel = new Label();
                    percentNotSubmittedLabel.Text = $"{100 - percentSubmittedRounded}%";
                    percentNotSubmittedLabel.Dock = DockStyle.Fill;
                    percentNotSubmittedLabel.TextAlign = ContentAlignment.MiddleCenter;
                    percentNotSubmittedLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    percentNotSubmittedLabel.ForeColor = Color.White;
                    percentNotSubmittedLabel.BackColor = tableColors[0, 1];

                    submissionStats.Controls.Add(percentNotSubmittedLabel, 1, 0);
                }
            }
        }

        // Aendri 4/16/2025
        // Populates the list of questions
        private void PopulateQuestionList()
        {
            // Get list of Bank Questions
            questionList = DB.GetFormQuestionList(formData.FormID);

            // Add questions to page:
            flowLayoutPanel.Controls.Clear();
            if (questionList != null)
            {
                for (int i = 0; i < questionList.Length; i++)
                {
                    questionList[i].OnClickEdit += new EventHandler(child_question_OnSelectEdit);
                    flowLayoutPanel.Controls.Add(questionList[i]);
                }
            }

        }

        // Aendri 4/17/2025
        // Receive event from child question item when edit is clicked.
        // Open edit question module
        void child_question_OnSelectEdit(object sender, EventArgs e)
        {
            QuestionItem.QuestionItem questionItem = (QuestionItem.QuestionItem)sender;

            // GET ANSWER CHOICES
            List<AnswerChoice> answerChoiceList = new List<AnswerChoice>();
            for (int i = 0; i < questionItem.AnswerList.Length; i++)
            {
                answerChoiceList.Add(new AnswerChoice
                {
                    AnswerID = questionItem.AnswerList[i].AnswerID,
                    isCorrect = questionItem.AnswerList[i].IsCorrect,
                    AnswerStatement = questionItem.AnswerList[i].AnswerValue
                });
            }
            // GET QUESTION DATA
            Question questionData = new Question
            {
                QuestionID = questionItem.QuestionID,
                AnswerChoices = answerChoiceList,
                ProblemStatement = questionItem.QuestionValue
            };

            // OPEN MODAL
            using (EditQuestionModal createBank = new EditQuestionModal(questionData, formData.FormID))
            {
                DialogResult result = createBank.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    PopulateQuestionList();
                }
            }
        }

        // Aendri 4/18/2025 updated by Lee
        // On click...
        // Edit Mode: Enable editing
        // Save Mode: Save changes
        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            // EDIT MODE
            if (!isEditMode)
            {
                saveEditBtn.BackColor = GlobalStyle.GREEN;
                saveEditBtn.Text = "Save";
                cancelBtn.Visible = true;
                releaseTimePicker.Enabled = true;
                closeTimePicker.Enabled = true;
                pwdTxtBox.Enabled = true;
            }
            // SAVE MODE
            else
            {
                // validation
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

                // switch back to edit button
                saveEditBtn.BackColor = GlobalStyle.BURNT_ORANGE;
                saveEditBtn.Text = "Edit";

                // update form in db
                int rows = DB.UpdateForm(releaseTimePicker.Value, closeTimePicker.Value, pwdTxtBox.Text, formData.FormID);
                if (rows <= 0)
                {
                    MessageBox.Show("Couldn't update form.");
                }

                // make input fields uneditable
                cancelBtn.Visible = false;
                releaseTimePicker.Enabled = false;
                closeTimePicker.Enabled = false;
                pwdTxtBox.Enabled = false;
                UpdatePage();
            }

            isEditMode = !isEditMode;
        }

        private void pwdTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        /**************************************************************************
        * Paints the bar graph specific colors to match its values.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void submissionStats_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var b = new SolidBrush(tableColors[e.Row, e.Column]))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }

        /**************************************************************************
        * Cancel editing mode of form information.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            saveEditBtn.BackColor = GlobalStyle.BURNT_ORANGE;
            saveEditBtn.Text = "Edit";

            cancelBtn.Visible = false;
            releaseTimePicker.Enabled = false;
            closeTimePicker.Enabled = false;
            pwdTxtBox.Enabled = false;

            UpdatePage();

            isEditMode = !isEditMode;
        }
    }
}