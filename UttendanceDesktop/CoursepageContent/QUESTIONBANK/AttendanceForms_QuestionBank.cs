﻿/******************************************************************************
* AttendanceForms_QuestionBank for the UttendanceDesktop application.
* 
* This class represents the display question banks page, where professors
* can view information on question banks for their class. This includes
* the option to add banks or delete them from the course.
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using UttendanceDesktop.CoursepageContent.models;
using UttendanceDesktop.CoursepageContent.CreateAttendanceForm;
using UttendanceDesktop.CoursepageContent.QUESTIONBANK;

namespace UttendanceDesktop
{
    public partial class AttendanceForms_QuestionBank : Form
    {
        private FormDAO DB = new FormDAO();
        private QuestionBankItem[] bankListItems;
        private int numItemsToDelete = 0;

        public AttendanceForms_QuestionBank()
        {
            InitializeComponent();
            //Set panel size
            attendanceFormPagePanel.Size = Size;

            //Set the grid height
            int width = attendanceFormPagePanel.Width - 50;
            int height = attendanceFormPagePanel.Height - 75;

            flowLayoutPanel.Width = width;
            flowLayoutPanel.Height = height;
            flowLayoutPanel.MaximumSize = new Size(width, height);
            flowLayoutPanel.MinimumSize = new Size(width, height);

            PopulateBankList();
        }

        // Aendri Singh (axs210369)
        // Populate the list of question bank list items
        private void PopulateBankList()
        {
            bankListItems = DB.GetBankList();
            
            // Clear the flow layout panel
            if (flowLayoutPanel.Controls.Count > 0)
            {
                flowLayoutPanel.Controls.Clear();
            }

            // Add to Control Flow: 
            for (int i = 0; i < bankListItems.Length; i++) {
                bankListItems[i].OnBankSelectChange += new EventHandler(child_checkbox_CheckedChanged);

                // add object to panel
                flowLayoutPanel.Controls.Add(bankListItems[i]);
            }

            // Update Page Icons
            numItemsToDelete = 0;
            UpdateIcon();
        }

        // Aendri Singh (axs210369)
        // Update page icon to delete icon if items are selected, otherwise add icon
        private void UpdateIcon()
        {
            if (numItemsToDelete > 0)
            {
                //Set icon to delete
                SaveEditIcon.BackgroundImage = Properties.Resources.trash_icon;
            }
            else
            {
                //Set icon to add
                SaveEditIcon.BackgroundImage = Properties.Resources.add_icon;
            }
        }

        // Aendri Singh (axs210369)
        // Deletes the selected items by updating the database and repopulating the list 
        private void DeleteItems()
        {
            if (DB.DeleteBankItems(bankListItems, numItemsToDelete))
            {
                PopulateBankList(); // Update Page with new list
            }
            
        }

        // Aendri Singh (axs210369)
        // Receive event from child form item on selection. Update list of changes and deletion icon. 
        void child_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = (bool)sender;

            if (isChecked) { numItemsToDelete++; }
            else { numItemsToDelete--; }

            // If first item selected, enter EDIT mode
            // If no items selected, exit EDIT mode
            if (numItemsToDelete == 0 || numItemsToDelete == 1)
            {
                UpdateIcon();
            }

            //System.Diagnostics.Debug.WriteLine("A TEXTBOX WAS CHANGED! ");
        }

        // Aendri Singh (axs210369)
        // On click of icon...
        // Edit mode: delete selected items and refresh page
        // New mode: open new question bank module
        private void SaveEditIcon_Click(object sender, EventArgs e)
        {
            if (numItemsToDelete > 0) //EDIT Mode
            {
                DeleteItems();
            }
            else //NEW Mode
            {
                // Open the new question bank module
                using (BankModal createBank = new BankModal())
                {
                    bool result = createBank.ShowDialog() == DialogResult.OK;
                }
                PopulateBankList();
            }
        }
    }
}
