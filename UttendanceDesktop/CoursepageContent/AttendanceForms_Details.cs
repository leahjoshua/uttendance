using Google.Protobuf.WellKnownTypes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class AttendanceForms_Details: Form
    {
        private AttendanceForm formData = new AttendanceForm();
        private QuestionItem.QuestionItem[] questionList;
        private FormDAO DB = new FormDAO();

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

            // Update DATE

            // Update SUBMISSION DATA

            // Update Question Bank
            PopulateQuestionList();
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
                    flowLayoutPanel.Controls.Add(questionList[i]);
                }
            }

        }
    }
}
