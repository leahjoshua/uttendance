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
//parisa 
namespace UttendanceDesktop
{
    public partial class EditProfile : Form
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? password { get; set; }

        public EditProfile()
        {
            InitializeComponent();
            RetrieveAndPopulateTextBoxes();
        }

        public void RetrieveAndPopulateTextBoxes()
        {
            string netID = GlobalVariables.INetID;
            string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";
            string query = "SELECT IFName, ILName, IPassword FROM instructor WHERE INetID = @globalNetID";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@globalNetID", netID);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FirstNameTextbox.Text = reader["IFName"].ToString();
                                LastNameTextbox.Text = reader["ILName"].ToString();
                                PasswordTextbox.Text = reader["IPassword"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No record found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DeleteButton.Visible = false;
            EditButton.Visible = false;
            SaveButton.Visible = true;

            FirstNameTextbox.BackColor = Color.White;
            LastNameTextbox.BackColor = Color.White;
            PasswordTextbox.BackColor = Color.White;

            FirstNameTextbox.ReadOnly = false;
            LastNameTextbox.ReadOnly = false;
            PasswordTextbox.ReadOnly = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string netID = GlobalVariables.INetID;
            string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";
            string query = "UPDATE instructor SET IFName = @firstName, ILName = @lastName, IPassword = @password WHERE INetID = @inetId";

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
                        cmd.Parameters.AddWithValue("@inetId", netID);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DeleteButton.Visible = true;
            EditButton.Visible = true;
            SaveButton.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("WARNING: You are about to delete your UTtenDance account. Are you sure you would like to proceed?", "Delete Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("We are so sad to see you go! Your account will be deleted. Thank you for your service!", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string netID = GlobalVariables.INetID;
                string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

                string deleteChildQuery = "DELETE FROM teaches WHERE FK_INetID = @netid";
                string deleteParentQuery = "DELETE FROM instructor WHERE INetID = @netid";

                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (var cmdChild = new MySqlCommand(deleteChildQuery, connection, transaction))
                            {
                                cmdChild.Parameters.AddWithValue("@netid", netID);
                                cmdChild.ExecuteNonQuery();
                            }

                            using (var cmdParent = new MySqlCommand(deleteParentQuery, connection, transaction))
                            {
                                cmdParent.Parameters.AddWithValue("@netid", netID);
                                cmdParent.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("All data deleted successfully.");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error: {ex.Message}", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                Application.Restart();
            }
        }
    }
}
