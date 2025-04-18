using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent.models;

namespace UttendanceDesktop.CoursepageContent.QuestionItem
{
    public partial class QuestionItem : UserControl
    {
        private QuestionAnswerItem[] _answersList;
        private String _questionValue;
        private int _questionNumber;
        private bool isMinimized = true;
        private int _questionID;
        private bool _isSelectable = false;
        private bool isBankQuestion = false;

        private Question question = new Question();

        public event EventHandler OnQuestionSelectChange;
        public event EventHandler OnClickEdit;

        public QuestionItem()
        {
            InitializeComponent();
            ShowHideList();
            ToggleSelect();
        }

        public QuestionItem(String questionValue, QuestionAnswerItem[] answersList)
        {
            InitializeComponent();
            ShowHideList();
            ToggleSelect();

            QuestionValue = questionValue;
            AnswerList = answersList;
        }

        // ------ Item Values ------ //
        // Aendri 4/13/2025
        // The number of the question
        [Category("Item Values")]
        public int QuestionNumber
        {
            get { return _questionNumber; }
            set
            {
                _questionNumber = value;
                questionChoiceLabel.Text = value.ToString();
            }
        }

        // Aendri 4/13/2025
        // The question value
        [Category("Item Values")]
        public String QuestionValue
        {
            get { return _questionValue; }
            set
            {
                _questionValue = value;
                if (value != null)
                {
                    QuestionLabel.Text = value.ToString();
                }

            }
        }

        // Aendri 4/13/2025
        // The list of answers
        [Category("Item Values")]
        public QuestionAnswerItem[] AnswerList
        {
            get { return _answersList; }
            set
            {
                if (value != null)
                {
                    _answersList = value;
                    FillAnswerChoices();
                }
            }
        }

        // Aendri 4/14/2025
        // The question ID associated with the question
        [Category("Item Values")]
        public int QuestionID
        {
            get { return _questionID; }
            set { _questionID = value; }
        }

        // Aendri 4/17/2025
        // If the question is selectable or not
        [Category("Item Values")]
        public bool IsSelectable
        {
            get { return _isSelectable; }
            set
            {
                _isSelectable = value;
                ToggleSelect();
            }
        }

        // Aendri 4/17/2025
        [Category("Item Values")]
        public bool Selected
        {
            get { return checkbox.Checked; }
            set { checkbox.Checked = value; }
        }

        // Lee 4/18/2025
        [Category("Item Values")]
        public bool IsChecked
        {
            get { return checkbox.Checked; }
            set { checkbox.Checked = value; }
        }

        // Lee 4/18/2025
        [Category("Item Values")]
        public bool IsBankQuestion
        {
            get { return isBankQuestion; }
            set { isBankQuestion = value; }
        }

        // ----- SPECIAL FUNCTIONS ------ //

        // Aendri 4/13/2025 
        // Fills the layout panel with the answer choices 
        private void FillAnswerChoices()
        {
            answerChoiceTable.Controls.Clear();
            if (_answersList != null)
            {
                for (int i = 0; i < _answersList.Count(); i++)
                {
                    answerChoiceTable.Controls.Add(_answersList[i]);
                }
            }
            ShowHideList();
        }

        // Aendri 4/14/2025
        // Shows or hides the answer choice list based on the state of the question item
        private void ShowHideList()
        {
            answerChoiceTable.Visible = !isMinimized;
        }

        // Aendri 4/17/2025
        // Display mode: hide select box, show label
        // Select mode: show select box, hide label
        private void ToggleSelect()
        {
            checkbox.Visible = _isSelectable;
            questionChoiceLabel.Visible = !_isSelectable;
        }

        // ----------- EVENTS ----------- //
        // Aendri 4/13/2025 
        // On click switch the state and update
        private void QuestionLabel_Click(object sender, EventArgs e)
        {
            isMinimized = !isMinimized; //Flip the state
            ShowHideList();
        }

        // Aendri 4/13/2025 
        // On click switch the state and update
        private void questionChoiceLabel_Click(object sender, EventArgs e)
        {
            isMinimized = !isMinimized; //Flip the state
            ShowHideList();
        }

        // Aendri 4/13/2025 
        // On click switch the state and update
        private void topFlowLayout_Click(object sender, EventArgs e)
        {
            isMinimized = !isMinimized; //Flip the state
            ShowHideList();
        }

        // Aendri 4/17/2025 (updated by Lee 4/17)
        // On selection/deselection of the item, create event and raise to parent control. 
        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnQuestionSelectChange != null)
            {
                //question.QuestionID = _questionID;
                //question.IsSelected = checkbox.Checked;
                OnQuestionSelectChange(this, null);
            }
        }

        // Aendri 4/17/2025
        // On click, creates an event and raises it to the parent control with the question's ID
        private void editButton_Click(object sender, EventArgs e)
        {
            if (OnClickEdit != null)
            {
                OnClickEdit(this, null);
            }
        }
    }
}
