using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UttendanceDesktop.CoursepageContent.QuestionItem
{
    public partial class QuestionAnswerItem: UserControl
    {
        public QuestionAnswerItem()
        {
            InitializeComponent();
        }

        private String _answerValue;
        private bool _isCorrect;
        private char _choiceLetter;
        private int _answerID;

        public QuestionAnswerItem(char choiceLetter, String problemStatement, bool isCorrect)
        {
            InitializeComponent();

            ChoiceLetter = choiceLetter;
            AnswerValue = problemStatement;
            IsCorrect = isCorrect;
        }

        // ------ Item Values ------ //
        // Aendri 4/13/2025
        // The answer value
        [Category("Item Values")]
        public String AnswerValue
        {
            get { return _answerValue; }
            set { 
                _answerValue = value;
                questionAnswerLabel.Text = value;
            }
        }

        // Aendri 4/13/2025
        // Determines if answer is correct or not
        [Category("Item Values")]
        public bool IsCorrect
        {
            get { return _isCorrect; }
            set { 
                _isCorrect = value;

                // Set Color Value
                if (_isCorrect)
                {
                    questionChoiceLabel.ForeColor = System.Drawing.Color.FromArgb(24, 162, 104); //GREEN
                } else
                {
                    questionChoiceLabel.ForeColor = System.Drawing.Color.FromArgb(50, 56, 87); //BLUE
                }
                
            }
        }

        // Aendri 4/13/2025
        // The letter associated with the answer 
        [Category("Item Values")]
        public char ChoiceLetter
        {
            get { return _choiceLetter; }
            set { 
                _choiceLetter = value;
                questionChoiceLabel.Text = value.ToString(); 
            }
        }


        // Aendri 4/13/2025
        // The answer id associated with the answer
        [Category("Item Values")]
        public int AnswerID
        {
            get { return _answerID; }
            set { _answerID = value; }
        }
    }
}
