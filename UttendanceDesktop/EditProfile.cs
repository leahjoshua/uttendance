/******************************************************************************
* EditProfile Form for the UttendanceDesktop application.
* This form allows users to edit their profile information (first name, last name,
* password) and delete their account. It interacts with the MySQL database to
* fetch, update, and delete instructor records. Deletion also removes associated
* course assignments from the teaches table to maintain referential integrity.
* Written by Parisa Nawar (pxn210032) for CS4485.0W1 at The University of Texas at Dallas
* starting April 10, 2025.
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
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace UttendanceDesktop
{
    public partial class EditProfile : Form
    {
        // Properties to store profile data
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? password { get; set; }

        /**************************************************************************
         * Constructor for EditProfile form.
         * Initializes components and loads current user data into text boxes.
         **************************************************************************/
        public EditProfile()
        {
            //Initialize EditProfile Form and show user information
            InitializeComponent();
            RetrieveAndPopulateTextBoxes();
        }

        /**************************************************************************
         * Retrieves current user data from the database and populates text boxes.
         * Uses GlobalResource.INetID to identify the current user.
         **************************************************************************/
        public void RetrieveAndPopulateTextBoxes()
        {
            string netID = GlobalResource.INetID;
            string connectionString = GlobalResource.CONNECTION_STRING;

            // Query to fetch first name, last name, and password
            string query = "SELECT IFName, ILName, IPassword FROM instructor WHERE INetID = @globalNetID";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        // Parameterized query 
                        cmd.Parameters.AddWithValue("@globalNetID", netID);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate text boxes with database values
                                FirstNameTextbox.Text = reader["IFName"].ToString();
                                LastNameTextbox.Text = reader["ILName"].ToString();
                                PasswordTextbox.Text = reader["IPassword"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No record found.", "Not Found",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /**************************************************************************
         * Enables editing mode when the Edit button is clicked.
         * Makes text boxes writable and shows the Save button.
         **************************************************************************/
        private void EditButton_Click(object sender, EventArgs e)
        {
            // Toggle button visibility
            DeleteButton.Visible = false;
            EditButton.Visible = false;
            SaveButton.Visible = true;

            // Change text box appearance for editing
            FirstNameTextbox.BackColor = Color.White;
            LastNameTextbox.BackColor = Color.White;
            PasswordTextbox.BackColor = Color.White;

            // Enable editing
            FirstNameTextbox.ReadOnly = false;
            LastNameTextbox.ReadOnly = false;
            PasswordTextbox.ReadOnly = false;
        }

        /**************************************************************************
         * Saves updated profile information to the database.
         * Validates inputs and shows success/error messages.
         **************************************************************************/
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string netID = GlobalResource.INetID;
            string connectionString = GlobalResource.CONNECTION_STRING;

            // Parameterized UPDATE query
            string query = @"UPDATE instructor 
                            SET IFName = @firstName, 
                                ILName = @lastName, 
                                IPassword = @password 
                            WHERE INetID = @inetId";

            // Get values from text boxes
            string firstName = FirstNameTextbox.Text;
            string lastName = LastNameTextbox.Text;
            string password = PasswordTextbox.Text;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        // Add parameters 
                        cmd.Parameters.AddWithValue("@inetId", netID);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found.", "Not Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Reset UI to non-editing state
            DeleteButton.Visible = true;
            EditButton.Visible = true;
            SaveButton.Visible = false;
        }

        /**************************************************************************
         * Deletes the user's account and all associated course assignments.
         * Uses a transaction to ensure data integrity.
         **************************************************************************/
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Confirm deletion with user
            DialogResult result = MessageBox.Show(
                "WARNING: You are about to delete your UTtenDance account. Are you sure you would like to proceed?",
                "Delete Account",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("We are so sad to see you go! Your account will be deleted. Thank you for your service!",
                    "Account Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                string netID = GlobalResource.INetID;
                string connectionString = GlobalResource.CONNECTION_STRING;

                // Delete from child table first then parent table to maintain database
                string deleteChildQuery = "DELETE FROM teaches WHERE FK_INetID = @netid";
                string deleteParentQuery = "DELETE FROM instructor WHERE INetID = @netid";

                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Delete from teaches table
                            using (var cmdChild = new MySqlCommand(deleteChildQuery, connection, transaction))
                            {
                                cmdChild.Parameters.AddWithValue("@netid", netID);
                                cmdChild.ExecuteNonQuery();
                            }

                            // Delete from instructor table
                            using (var cmdParent = new MySqlCommand(deleteParentQuery, connection, transaction))
                            {
                                cmdParent.Parameters.AddWithValue("@netid", netID);
                                cmdParent.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("All data deleted successfully.");

                            // Restart application after account deletion
                            Application.Restart();
                        }
                        catch (Exception ex)
                        {
                            // Rollback if any operation fails
                            transaction.Rollback();
                            MessageBox.Show($"Error: {ex.Message}", "Deletion Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
