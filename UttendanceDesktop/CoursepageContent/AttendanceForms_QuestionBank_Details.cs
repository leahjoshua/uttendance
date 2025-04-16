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
            PopulateQuestionBankList();
        }

        // Aendri 4/13/2025
        // Populates the list of questions
        private void PopulateQuestionBankList()
        {
            // Get list of Bank Questions
            questionList = DB.GetBankQuestionList(bankID);

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
