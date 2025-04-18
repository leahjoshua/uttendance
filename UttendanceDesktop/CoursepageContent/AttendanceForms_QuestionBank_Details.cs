using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent;
using UttendanceDesktop.CoursepageContent.CreateAttendanceForm;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class AttendanceForms_QuestionBank_Details: Form
    {
        private int bankID;
        private String bankTitle;
        private QuestionItem.QuestionItem[] questionList;
        private FormDAO DB = new FormDAO();
        public AttendanceForms_QuestionBank_Details(int bankId, String bankTitle)
        {
            InitializeComponent();

            this.bankID = bankId;
            this.bankTitle = bankTitle;
            questionList = DB.GetBankQuestionList(bankID);

            //Update Page Title
            bankTitleLabel.Text = bankTitle;
            PopulateQuestionList();
        }

        // Aendri 4/17/2025
        // Updates page elements to match the database
        public void UpdatePage()
        {
            
            PopulateQuestionList();
        }

        // Aendri 4/13/2025
        // Populates the list of questions
        private void PopulateQuestionList()
        {
            // Get list of Bank Questions
            questionList = DB.GetBankQuestionList(bankID);

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
            int questionID = Convert.ToInt32(sender);

            MessageBox.Show("EDIT SELECTED FOR " + questionID);

            // *** OPEN EDIT QUESTION MODULE HERE!!! ***

            PopulateQuestionList();
        }

    }
}
