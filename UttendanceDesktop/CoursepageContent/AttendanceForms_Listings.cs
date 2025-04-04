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

namespace UttendanceDesktop
{
    // Aendri: 3/28/2025
    public partial class AttendanceForms_Listings : Form
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";
        private int courseNum = 123456; //temp value 
        private attendanceFormItem[] attendanceListItems;

        //Aendri: 3/28/2025
        public AttendanceForms_Listings()
        {
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
                        "WHERE FK_CourseNum=@CourseNum "
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
                    attendanceListItems[i].Date = Convert.ToDateTime(reader[1]); //DateOnly.Parse(reader.GetString(1));

                    start = Convert.ToDateTime(reader[1]);

                    // CALCULATE FORM STATUS:
                    if (reader[2] == null) // Form has no end time
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
    }
}
