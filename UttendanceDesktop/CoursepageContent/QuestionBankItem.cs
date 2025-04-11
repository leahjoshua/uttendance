using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class QuestionBankItem : UserControl
    {
        public event EventHandler OnBankSelectChange;

        private String _title;
        private int _numQuestions;
        private int _bankID;

        public QuestionBankItem()
        {
            InitializeComponent();
        }

        // Aendri 4/4: Fix the height and width of the component
        protected override void SetBoundsCore(int x, int y,
            int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, 750, 62, specified);
        }

        // ----- ITEM EVENTS ----- //

        private void TitleLabel_Click(object sender, EventArgs e)
        {
            openPage();
        }

        private void QuestionLabel_Click(object sender, EventArgs e)
        {
            openPage();
        }

        private void QuestionDisplayLabel_Click(object sender, EventArgs e)
        {
            openPage();
        }

        private void QuestionBankItem_Click(object sender, EventArgs e)
        {
            openPage();
        }

        //Aendri 4/4/2025
        // On selection/deselection of the question bank, create event and raise to parent control. 
        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(titleLabel.Text + " CLICKED!");
            if (OnBankSelectChange != null)
            {
                OnBankSelectChange(checkbox.Checked, null);
            }
        }

        // ---- SPECIAL FUNCTIONS/ENUMS ---- //

        // Aendri (4/11/25): Opens the question bank page
        private void openPage()
        {
            //loadForm(new AttendanceForms_QuestionBank_Details());
            // *** REPLACE WITH PAGE LOADER CODE ***
            /*String dialog = "Loading " + _title + " (id = " + _bankID + ")";
            DialogResult warnResult = MessageBox.Show(dialog, "TEMP", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            */
        }

        //---- DATA ----//

        // Aendri 4/4/2025
        // Title of the question bank
        [Category("Item Values")]
        public String Title
        {
            get { return _title; }
            set
            {
                _title = value;
                TitleLabel.Text = _title;
            }
        }

        // Aendri 4/4/2025
        // Count of the number of questions in the question bank
        [Category("Item Values")]
        public int Count
        {
            get { return _numQuestions; }
            set
            {
                _numQuestions = value;
                QuestionDisplayLabel.Text = _numQuestions.ToString();
            }
        }

        // Aendri 4/4/2025
        // The ID used to identify the question bank
        [Category("Item Values")]
        public int BankID
        {
            get { return _bankID; }
            set { _bankID = value; }
        }

        // Aendri 4/4/2025 
        // If the item is seletced or not
        [Category("Item Values")]
        public bool Selected
        {
            get { return checkbox.Checked; }
            set { checkbox.Checked = value; }
        }
    }
}
