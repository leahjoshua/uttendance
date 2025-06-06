﻿/******************************************************************************
* AttendanceForms_QuestionBank_Details for the UttendanceDesktop application.
* 
* This class represents the view question bank details page, where professors
* can view information on a certain question banks. This includes
* the option to add questions or edit them.
* 
* Written by Aendri Singh (axs210369)
* for CS4485.0W1 at The University of Texas at Dallas
* starting April 3, 2025.
******************************************************************************/

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
using UttendanceDesktop.CoursepageContent.QuestionItem;
using UttendanceDesktop.CoursepageContent.models;
using UttendanceDesktop.CoursepageContent.QUESTIONBANK;
using UttendanceDesktop.CoursepageContent.Controls.QuestionItem;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class AttendanceForms_QuestionBank_Details : Form
    {
        private QuestionBank bankData;
        private int bankID;
        private String bankTitle;
        private QuestionItem.QuestionItem[] questionList;
        private FormDAO DB = new FormDAO();
        private int numItemsToDelete = 0;
        public AttendanceForms_QuestionBank_Details(int bankId, String bankTitle)
        {
            InitializeComponent();

            this.bankID = bankId;
            bankData = new QuestionBank();
            bankData.BankID = bankId;
            bankData.BankTitle = bankTitle;

            //Update Page Title
            bankTitleLabel.Text = bankTitle;
            PopulateQuestionList();
        }

        public AttendanceForms_QuestionBank_Details(int bankId)
        {
            InitializeComponent();

            this.bankID = bankId;

            UpdatePage();
        }

        // Aendri Singh (axs210369)
        // Updates page elements to match the database
        private void UpdatePage()
        {
            bankData = DB.GetBankData(bankID);

            bankTitleLabel.Text = bankData.BankTitle;
            PopulateQuestionList(bankData.QuestionBankList);
        }

        // Aendri Singh (axs210369)
        // Populates the list of questions
        private void PopulateQuestionList()
        {
            // Get list of Bank Questions
            bankData.QuestionBankList = DB.GetBankQuestionList(bankID);

            // Add questions to page:
            flowLayoutPanel.Controls.Clear();
            if (bankData.QuestionBankList != null)
            {
                for (int i = 0; i < bankData.QuestionBankList.Length; i++)
                {
                    bankData.QuestionBankList[i].OnClickEdit += new EventHandler(child_question_OnSelectEdit);
                    flowLayoutPanel.Controls.Add(bankData.QuestionBankList[i]);
                }
            }

        }

        // Aendri Singh (axs210369)
        // Populates the list of questions with a given question list
        private void PopulateQuestionList(QuestionItem.QuestionItem[] questionList)
        {
            // Add questions to page:
            flowLayoutPanel.Controls.Clear();
            if (bankData.QuestionBankList != null)
            {
                for (int i = 0; i < bankData.QuestionBankList.Length; i++)
                {
                    questionList[i].OnClickEdit += new EventHandler(child_question_OnSelectEdit);
                    flowLayoutPanel.Controls.Add(bankData.QuestionBankList[i]);
                }
            }

        }

        // Aendri Singh (axs210369)
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
            using (EditQuestionModal createBank = new EditQuestionModal(questionData))
            {
                DialogResult result = createBank.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    PopulateQuestionList();
                }
            }
            
        }

        // Aendri Singh (axs210369)
        // On click of icon open create question model
        private void newEditIcon_Click(object sender, EventArgs e)
        {
            using (CreateFormQuestion createQMod = new CreateFormQuestion())
            {
                if (createQMod.ShowDialog() == DialogResult.OK)
                {
                    DB.CreateNewQuestion(createQMod.question, bankID);
                    PopulateQuestionList();
                }
            }
        }

        private void edit_Click(object sender, EventArgs e) {   }

        // Aendri Singh (axs210369)
        // On click of bank title, open modal to update bank title
        private void bankTitleLabel_Click(object sender, EventArgs e)
        {
            using (BankModal createBank = new BankModal(bankData.BankID, bankData.BankTitle))
            {
                DialogResult result = createBank.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    UpdatePage();
                }
            }
        }
    }
}
