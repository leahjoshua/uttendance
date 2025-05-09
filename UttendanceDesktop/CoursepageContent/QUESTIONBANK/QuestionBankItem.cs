/******************************************************************************
* Question Bank Item for the UttendanceDesktop application.
* 
* This class represents a custom control for question bank items, 
* where professors can view a question bank's name and number of questions.
* Includes the option to select a question bank. 
* 
* Written by Aendri Singh (axs210369)
* for CS4485.0W1 at The University of Texas at Dallas
* starting April 3, 2025.
******************************************************************************/

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

        // Aendri Singh (axs210369)
        // Fixes the height and width of the component
        protected override void SetBoundsCore(int x, int y,
            int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, 750, 62, specified);
        }

        // ----- ITEM EVENTS ----- //

        // Aendri Singh (axs210369)
        // Opens question bank page on click
        private void TitleLabel_Click(object sender, EventArgs e)
        {
            openPage();
        }

        // Aendri Singh (axs210369)
        // Opens question bank page on click
        private void QuestionLabel_Click(object sender, EventArgs e)
        {
            openPage();
        }

        // Aendri Singh (axs210369)
        // Opens question bank page on click
        private void QuestionDisplayLabel_Click(object sender, EventArgs e)
        {
            openPage();
        }

        // Aendri Singh (axs210369)
        // Opens question bank page on click
        private void QuestionBankItem_Click(object sender, EventArgs e)
        {
            openPage();
        }

        // Aendri Singh (axs210369)
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

        // Aendri Singh (axs210369)
        // Opens the question bank page
        private void openPage()
        {
            GlobalResource.COURSEPAGE.loadForm(new AttendanceForms_QuestionBank_Details(_bankID, _title));
        }

        //---- DATA ----//

        // Aendri Singh (axs210369)
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

        // Aendri Singh (axs210369)
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

        // Aendri Singh (axs210369)
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
