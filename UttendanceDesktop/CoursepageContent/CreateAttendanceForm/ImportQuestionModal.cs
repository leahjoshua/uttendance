using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using UttendanceDesktop.CoursepageContent.QuestionItem;
using UttendanceDesktop.CoursepageContent.models;

namespace UttendanceDesktop.CoursepageContent.CreateAttendanceForm
{
    public partial class ImportQuestionModal : Form
    {
        public List<int> importQuestionIDs = new List<int>();
        public List<QuestionItem.QuestionItem> selectedQuestions = new List<QuestionItem.QuestionItem>();
        
        private QuestionBankItem selectedBank;
        private List<QuestionBankItem> qBankList = new List<QuestionBankItem>();
        private List<QuestionItem.QuestionItem> questionList = new List<QuestionItem.QuestionItem>();
        public ImportQuestionModal()
        {
            InitializeComponent();

            FormDAO qBankLoader = new FormDAO();
            qBankList = qBankLoader.GetBankList().ToList();

            qBankDropdown.DataSource = qBankList;
            qBankDropdown.DisplayMember = "Title";
            qBankDropdown.ValueMember = "BankID";

            Console.WriteLine();
            qBankDropdown.SelectedIndex = -1;
        }

        private void qBankDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            qBankDropdown.DataSource = qBankList;
            qBankDropdown.DisplayMember = "Title";
            qBankDropdown.ValueMember = "BankID";
            importFlowPanel.Controls.Clear();
            int bankID = 0;
            if (qBankDropdown.SelectedIndex >= 0)
            {
                bankID = Convert.ToInt32(qBankDropdown.SelectedValue);
                if (bankID >= 0)
                {
                    FormDAO qBankLoader = new FormDAO();
                    questionList = qBankLoader.GetBankQuestionList(bankID).ToList();

                    for (int i = 0; i < questionList.Count; i++)
                    {
                        questionList[i].IsSelectable = true;
                        questionList[i].OnQuestionSelectChange += new EventHandler(child_question_OnQuestionSelectChange);
                        importFlowPanel.Controls.Add(questionList[i]);
                    }
                }
            }
        }
        void child_question_OnQuestionSelectChange(object sender, EventArgs e)
        {
            QuestionItem.QuestionItem question = (QuestionItem.QuestionItem)sender;
            if (question.IsChecked)
            {
                selectedQuestions.Add(question);
            }
            else
            {
                selectedQuestions.RemoveAll(n => n.QuestionID == question.QuestionID);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            foreach(QuestionItem.QuestionItem question in selectedQuestions)
            {
                question.IsSelectable = false;
                question.IsBankQuestion = true;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
