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

namespace UttendanceDesktop
{
    public partial class AttendanceForms_QuestionBank : Form
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

        private readonly int courseNum;
        private readonly String INetID;

        private QuestionBankItem[] bankListItems;
        private int numItemsToDelete = 0;


        public AttendanceForms_QuestionBank()
        {
            InitializeComponent();
            PopulateBankList();
        }

        // Aendri 4/4/2025
        // Populate the list of question bank list items
        private void PopulateBankList()
        {
            // Open Connection to Database
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            MySqlDataReader reader;
            int numBanks;

            try
            {
                connection.Open();

                // Get a count of all question banks associated with the professor
                /*cmd = new MySqlCommand(
                    "SELECT COUNT(*)" +
                    "FROM bank " +
                    "WHERE FK_INetID=@INetID "
                    , connection);
                cmd.Parameters.AddWithValue("@INetId", INetID);*/

                // Process result
                /*object result = cmd.ExecuteScalar();
                if (result == null) { return; }
                numBanks = Convert.ToInt32(result);
                System.Diagnostics.Debug.WriteLine("NUM QUESTION BANKS: " + numBanks);*/

                numBanks = 5; //TEMP VALUE FOR TESTING

                // Exit if NO Attendence forms
                if (numBanks == 0) { return; }

                // CREATE QUESTION BANK ITEMS LIST:
                bankListItems = new QuestionBankItem[numBanks];

                // Clear the flow layout panel
                if (flowLayoutPanel.Controls.Count > 0)
                {
                    flowLayoutPanel.Controls.Clear();
                }

                // Get a list of all question banks associated with this course
                // along with their id, title, and question count
                /*cmd = new MySqlCommand(
                        "SELECT BankID, BankTitle,  " +
                        "FROM bank " +
                        "WHERE FK_INetID=@INetID "
                    , connection);
                cmd.Parameters.AddWithValue("@INetId", INetID); 
                reader = cmd.ExecuteReader();*/

                // Process results
                int i = 0;
                while (i < bankListItems.Length)//reader.Read() && i < bankListItems.Length)
                {

                    bankListItems[i] = new QuestionBankItem();

                    bankListItems[i].BankID = i; //Convert.ToInt32(reader[0]);
                    bankListItems[i].Title = "Title"; //reader[1].ToString();
                    bankListItems[i].Count = 4; //Convert.ToInt32(reader[2]);
                    bankListItems[i].OnBankSelectChange += new EventHandler(child_checkbox_CheckedChanged);

                    // add object to panel
                    flowLayoutPanel.Controls.Add(bankListItems[i]);
                    i++;
                }
                //reader.Close();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(
                    "ERROR: AttendanceForms_QuestionBank.cs/PopulateBankList() : " + ex.ToString());
                connection.Close();
                return;
            }

            connection.Close();

            // Update Page Icons
            numItemsToDelete = 0;
            UpdateIcon();
        }

        //Aendri 4/4/2025
        // Update page icon to delete icon if items are selected, otherwise add icon
        private void UpdateIcon()
        {
            if (numItemsToDelete > 0)
            {
                //Set icon to delete
                SaveEditIcon.BackColor = Color.Red;
            }
            else
            {
                //Set icon to add
                SaveEditIcon.BackColor = Color.Green;
            }
        }

        // Aendri 4/4/2025
        // Deletes the selected items by updating the database and repopulating the list 
        private void DeleteItems()
        {
            // If no items to delete, exit
            if (numItemsToDelete == 0) { return; }

            // Open Connection to Database
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            DialogResult warnResult;

            try
            {
                connection.Open();

                // Build deleted items query:
                String deleteQuery =
                    "DELETE " +
                    "FROM bank " +
                    "WHERE BankID IN (";

                // Build warning message
                String dialog = "Removing " + numItemsToDelete + " question banks(s):\n";

                for (int j = 0; j < bankListItems.Length; j++)
                {
                    if (bankListItems[j].Selected)
                    {
                        deleteQuery += bankListItems[j].BankID + ",";
                        dialog += bankListItems[j].Title + ", ";
                    }
                }
                //Remove last comma:
                deleteQuery = deleteQuery.Substring(0, deleteQuery.Length - 1); 
                deleteQuery += ")";

                dialog = dialog.Substring(0, dialog.Length - 2);

                // Prompt user to verify deletion
                warnResult = MessageBox.Show(dialog, "Remove Question Bank(s)", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (warnResult != DialogResult.Yes) { return; } // EXIT if user cancels!

                // Run deletion query
                /*cmd = new MySqlCommand(deleteQuery, connection);
                int result = cmd.ExecuteNonQuery();

                // Error check:
                if (result <= 0)
                {
                    System.Diagnostics.Debug.WriteLine("ERROR: AttendanceForms_Listings.cs/DeleteItems(): NOTHING DELETED!");
                }*/

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(
                    "ERROR: AttendanceForms_QuestionBank.cs/DeleteItems(): " + ex.ToString());
                connection.Close();
                return;
            }

            connection.Close();

            PopulateBankList(); // Update Page with new list
        }

        //Aendri 4/4/2025
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

        //Aendri 4/4/2025
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
                PopulateBankList();
            }
        }
    }
}
