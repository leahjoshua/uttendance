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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UttendanceDesktop.CoursepageContent.QUESTIONBANK
{
    public partial class BankModal : Form
    {
        private FormDAO DB = new FormDAO();

        private String bankTitle;
        private int bankID;
        private bool isUpdate = false; // Default: NEW question bank 

        // Aendri 4/18/2025
        // Constructor for a NEW question bank
        public BankModal()
        {
            InitializeComponent();
        }

        // Aendri 4/18/2025
        // Constructor for UPDATING a question bank
        public BankModal(int bankID, String bankTitle)
        {
            InitializeComponent();
            bankID = bankID;
            bankTitle = bankTitle;
            isUpdate = true;

            nameTextbox.Text = bankTitle;
            createUpdateButton.Text = "Update";
        }

        // Aendri 4/18/2025
        // Verify and create new question bank entry 
        private void CreateNewBank()
        {
            // Title too short
            if (bankTitle.Length < 1)
            {
                MessageBox.Show("Title too short!", "Invalid Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Title too long
            else if (bankTitle.Length > 64)
            {
                MessageBox.Show("Title too long! Max length is 64 characters.", "Invalid Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Title already in sure
            else if (!DB.IsValidBankTitle(bankTitle))
            {
                MessageBox.Show("Title already in use! Please use a different title.", "Invalid Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // CREATE New question bank item
            else
            {
                bankID = DB.CreateNewBank(bankTitle);
                this.Close();
                // Open page
                GlobalResource.COURSEPAGE.loadForm(new AttendanceForms_QuestionBank_Details(bankID, bankTitle));
            }
        }

        private void UpdateBank()
        {

        }

        // ************ EVENTS ************* //
        // Cancel the update/create
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void createUpdateButton_Click(object sender, EventArgs e)
        {
            bankTitle = nameTextbox.Text;

            if (isUpdate) { UpdateBank(); }
            else { CreateNewBank();  }
        }
    }
}
