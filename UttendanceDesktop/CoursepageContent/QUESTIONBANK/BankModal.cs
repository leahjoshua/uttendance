﻿/******************************************************************************
* Bank Modal for the UttendanceDesktop application.
* 
* This class represents the edit question bank modal, where professors
* can create or edit the question bank's name.
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

        // Aendri Singh (axs210369)
        // Constructor for a NEW question bank
        public BankModal()
        {
            InitializeComponent();
        }

        // Aendri Singh (axs210369)
        // Constructor for UPDATING a question bank
        public BankModal(int bankID, String bankTitle)
        {
            InitializeComponent();
            this.bankID = bankID;
            this.bankTitle = bankTitle;

            isUpdate = true;

            nameTextbox.Text = bankTitle;
            createUpdateButton.Text = "Update";
        }

        // Aendri Singh (axs210369)
        // Verify and create new question bank entry 
        private void CreateNewBank()
        {
            // CREATE New question bank item
            if (VerifyBankTitle())
            {
                bankID = DB.CreateNewBank(bankTitle);
                this.Close();
                // Open page
                GlobalResource.COURSEPAGE.loadForm(new AttendanceForms_QuestionBank_Details(bankID, bankTitle));
            }
        }

        // Aendri Singh (axs210369)
        // Update a bank's name
        private void UpdateBank()
        {
            if (VerifyBankTitle())
            {
                DB.UpdateBank(bankID, bankTitle);
                this.Close();
            }
        }

        // Aendri Singh (axs210369)
        // Verifies if the bank's title is valid to use
        // Displays error messages if invalid
        private bool VerifyBankTitle()
        {
            // Title too short/only has spaces
            if (string.IsNullOrWhiteSpace(bankTitle))
            {
                MessageBox.Show("Title too short!", "Invalid Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Title too long
            else if (bankTitle.Length > 64)
            {
                MessageBox.Show("Title too long! Max length is 64 characters.", "Invalid Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Title already in use
            else if (!DB.IsValidBankTitle(bankTitle))
            {
                MessageBox.Show("Title already in use! Please use a different title.", "Invalid Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // VALID name
            else
            {
                return true;
        }
            return false;
        }

        // ************ EVENTS ************* //

        // Aendri Singh (axs210369)
        // Cancel the update/create
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Aendri Singh (axs210369)
        // Creates or updates the question bank depending on the mode.
        private void createUpdateButton_Click(object sender, EventArgs e)
        {
            bankTitle = nameTextbox.Text;

            if (isUpdate) { UpdateBank(); }
            else { CreateNewBank();  }
        }
    }
}
