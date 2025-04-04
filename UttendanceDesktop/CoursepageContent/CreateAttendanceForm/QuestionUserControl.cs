using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UttendanceDesktop.CoursepageContent.CreateAttendanceForm
{
    public partial class QuestionUserControl : UserControl
    {
        public QuestionUserControl()
        {
            InitializeComponent();
            choiceALabel.Text = "sjdfhbgkjshdbfkjshdbfj,hsbdfjbsdjkfvsjdlbhfkhjsdbhfjhksdvbfjkhshvbdfjlshvbdkjfhbsdjkfbjsdkhbfkjshdhvfjhshdbfjhksdbfkjsdbhfjdsh";
        }

        private void QuestionUserControl_Load(object sender, EventArgs e)
        {

        }

        public string QuestionNumberText
        {
            get => questionNumLabel.Text;
            set => questionNumLabel.Text = value;
        }

        public string ChoiceA
        {
            get => choiceALabel.Text;
            set => choiceALabel.Text = value;
        }
        public string ChoiceB
        {
            get => choiceBLabel.Text;
            set => choiceBLabel.Text = value;
        }
        public string ChoiceC
        {
            get => choiceCLabel.Text;
            set => choiceCLabel.Text = value;
        }
        public string ChoiceD
        {
            get => choiceDLabel.Text;
            set => choiceDLabel.Text = value;
        }
        public string ProblemStatement
        {
            get => problemStmtLabel.Text;
            set => problemStmtLabel.Text = value;
        }
    }
}
