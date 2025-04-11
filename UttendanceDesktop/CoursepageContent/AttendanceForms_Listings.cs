using UttendanceDesktop.CoursepageContent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Ocsp;

namespace UttendanceDesktop
{
    // Aendri: 3/28/2025
    public partial class AttendanceForms_Listings : Form
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";
        
        private readonly int courseNum;

        private attendanceFormItem[] attendanceListItems;
        private int numItemsToDelete = 0;

        //Aendri: 3/28/2025
        public AttendanceForms_Listings(int course)
        {
            this.courseNum = course;
            InitializeComponent();
            PopulateAttendanceFormList();
        }

        // Aendri: Populate the list of Attendence Form Items
        private void PopulateAttendanceFormList()
        {
            // Open Connection to Database
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            MySqlDataReader reader;
            int numAttendanceForms;

            try
            {
                connection.Open();

                // Get a count of all forms associated with this course
                cmd = new MySqlCommand(
                    "SELECT COUNT(*)" +
                    "FROM form " +
                    "WHERE FK_CourseNum=@CourseNum "
                    , connection);
                cmd.Parameters.AddWithValue("@CourseNum", courseNum);

                // Process result
                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    System.Diagnostics.Debug.WriteLine("Null - NO FORMS FOUND!");
                    return;
                }
                numAttendanceForms = Convert.ToInt32(result);
                System.Diagnostics.Debug.WriteLine("NUM FORMS: " + numAttendanceForms);

                // Exit if NO Attendence forms
                if (numAttendanceForms == 0) { Console.WriteLine("NO FORMS FOUND!"); return; }

                // CREATE ATTENDENCE FORM OBJECTS:
                attendanceListItems = new attendanceFormItem[numAttendanceForms];

                // Clear the flow layout panel
                if (attendanceflowLayoutPanel.Controls.Count > 0)
                {
                    attendanceflowLayoutPanel.Controls.Clear();
                }

                // Get a list of all forms associated with this course
                cmd = new MySqlCommand(
                        "SELECT FormID, ReleaseDateTime, CloseDateTime " +
                        "FROM form " +
                        "WHERE FK_CourseNum=@CourseNum " +
                        "ORDER BY ReleaseDateTime"
                    , connection);
                cmd.Parameters.AddWithValue("@CourseNum", courseNum);
                reader = cmd.ExecuteReader();

                // Process results
                int i = 0;
                attendanceFormItem.AttendenceFormStatusOptions status;
                DateTime start;
                DateTime end;
                DateTime currentTime = DateTime.Now;
                while (reader.Read() && i < attendanceListItems.Length)
                {

                    attendanceListItems[i] = new attendanceFormItem();

                    attendanceListItems[i].FormID = Convert.ToInt32(reader[0]);
                    attendanceListItems[i].Date = Convert.ToDateTime(reader[1]);
                    attendanceListItems[i].OnFormSelectChange += new EventHandler(child_checkbox_CheckedChanged);

                    start = Convert.ToDateTime(reader[1]);

                    // CALCULATE FORM STATUS:
                    if (reader[2] == null || reader[2] == System.DBNull.Value) // Form has no end time
                    {
                        if (start > currentTime) // releases later 
                        {
                            status = attendanceFormItem.AttendenceFormStatusOptions.Upcoming;
                        }
                        else //released
                        {
                            status = attendanceFormItem.AttendenceFormStatusOptions.Open;
                        }

                    }
                    else // Form has a start and end time
                    {
                        end = Convert.ToDateTime(reader[2]);

                        // start, end, curr
                        // 1. start end curr -> closed
                        // 2. start curr end -> open
                        // 3. end start curr -> invalid
                        // 4. end curr start -> invalid
                        // 5. curr end start -> invalid
                        // 6. curr start end -> upcoming

                        if (start > end)
                        {
                            System.Diagnostics.Debug.WriteLine("ERROR: in AttendanceForms_Listings.cs/PopulateAttendanceFormList(): Start date cannot be greater than end date! (FormID = " + attendanceListItems[i].FormID + ")");
                            connection.Close();
                            return;
                        }
                        else if (end < currentTime) // released and closed
                        {
                            status = attendanceFormItem.AttendenceFormStatusOptions.Closed;
                        }
                        else if (start > currentTime) // releases later
                        {
                            status = attendanceFormItem.AttendenceFormStatusOptions.Upcoming;
                        }
                        else // released and not closed
                        {
                            status = attendanceFormItem.AttendenceFormStatusOptions.Open;
                        }
                    }

                    attendanceListItems[i].Status = status;

                    // add object to panel
                    attendanceflowLayoutPanel.Controls.Add(attendanceListItems[i]);

                    i++;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: AttendanceForms_Listings.cs/PopulateAttendanceFormList() : " + ex.ToString());
                connection.Close();
                return;
            }

            connection.Close();

            // Update Page Icons
            numItemsToDelete = 0;
            UpdateIcon();
        }

        //Aendri 4/3/2025
        // On click, filter forms displayed based on the filter and date
        // filterDropdown, dateTimePicker, statusDropDown
        private void filterButton_Click(object sender, EventArgs e)
        {
            int status;
            int filter;
            //Set Status
            if (statusDropDown.SelectedItem == null) status = -1;
            else { status = statusDropDown.SelectedIndex; }
            //Set Filter
            if (filterDropdown.SelectedItem == null) filter = -1;
            else { filter = filterDropdown.SelectedIndex; }

            DateTime time = dateTimePicker.Value;

            PopulateAttendanceFormList(); //REFRESH LIST

            // Clear the flow layout panel
            if (attendanceflowLayoutPanel.Controls.Count > 0)
            {
                attendanceflowLayoutPanel.Controls.Clear();
            }

            // Iterate through AttendenceListItems and ONLY add items that match the filter
            for (int i = 0; i < attendanceListItems.Length; i++)
            {
                if (DoesMatchFilter(attendanceListItems[i], status, filter, time))
                {
                    attendanceflowLayoutPanel.Controls.Add(attendanceListItems[i]);
                }
            }
        }

        //Aendri 4/3/2025
        // Returns a boolean indicating if the item matches the filter or not
        private bool DoesMatchFilter(attendanceFormItem item, int status, int filter, DateTime time)
        {
            bool matchFilter;
            bool matchStatus;

            // Time Date filter
            switch (filter)
            {
                case 0: //BEFORE
                    matchFilter = item.Date.Date < time.Date;
                    break;
                case 1: //AFTER
                    matchFilter = item.Date.Date > time.Date;
                    break;
                case 2: //ON
                    matchFilter = item.Date.Date == time.Date;
                    break;
                default: //ALL
                    matchFilter = true;
                    break;
            }

            // Status Filter
            switch (status)
            {
                case 0: //UPCOMING
                    matchStatus = item.Status == attendanceFormItem.AttendenceFormStatusOptions.Upcoming;
                    break;
                case 1: //OPEN
                    matchStatus = item.Status == attendanceFormItem.AttendenceFormStatusOptions.Open;
                    break;
                case 2: //CLOSED
                    matchStatus = item.Status == attendanceFormItem.AttendenceFormStatusOptions.Closed;
                    break;
                default: //ALL
                    matchStatus = true;
                    break;
            }

            return matchStatus && matchFilter; //True if both cases are true
        }

        //Aendri 4/3/2025
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

        // Aendri 4/3/2025
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
                    "FROM form " +
                    "WHERE FormID IN (";

                // Build warning message
                String dialog = "Removing " + numItemsToDelete + " form(s):\n";

                for (int j = 0; j < attendanceListItems.Length; j++)
                {
                    if (attendanceListItems[j].Selected)
                    {
                        deleteQuery += attendanceListItems[j].FormID + ",";
                        dialog += attendanceListItems[j].Date.ToString("MM/dd/yy") + ", ";
                    }
                }

                //Remove last comma:
                deleteQuery = deleteQuery.Substring(0, deleteQuery.Length-1); 
                deleteQuery += ")";

                dialog = dialog.Substring(0, dialog.Length - 2); 
                dialog += "\nFrom course " + courseNum + "?";

                // Prompt user to verify deletion
                warnResult = MessageBox.Show(dialog, "Remove Form(s)", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (warnResult != DialogResult.Yes) { return; } // EXIT if user cancels!

                // Run deletion query
                cmd = new MySqlCommand(deleteQuery, connection);
                int result = cmd.ExecuteNonQuery();

                // Error check:
                if (result <= 0)
                {
                    System.Diagnostics.Debug.WriteLine("ERROR: AttendanceForms_Listings.cs/DeleteItems(): NOTHING DELETED!");
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: AttendanceForms_Listings.cs/DeleteItems(): " + ex.ToString());
                connection.Close();
                return;
            }

            connection.Close();

            PopulateAttendanceFormList(); // Update Page with new list
        }

        //Aendri 4/3/2025
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

            System.Diagnostics.Debug.WriteLine("A TEXTBOX WAS CHANGED! ");
        }

        // Aendri 4/4/2025
        // On click of icon...
        // Edit mode: delete selected items and refresh page
        // New mode: go to create new form page
        private void SaveEditIcon_Click(object sender, EventArgs e)
        {
            if (numItemsToDelete > 0) //EDIT Mode
            {              
                DeleteItems();
            } else //NEW Mode (written by Lee)
            {
                GlobalResource.COURSEPAGE.loadForm(new CreateAttendanceFormPage());
            }
        }
    }
}
