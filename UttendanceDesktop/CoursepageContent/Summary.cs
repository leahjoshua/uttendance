/******************************************************************************
* Summary Class for the UttendanceDesktop application.
* This class serves as a summary page, displaying a table with the students'
* information (last name, first name, Net-ID) for the given course
* number (class id). Each student has an attendance status for every closed
* form in the class. The professor has the ability to overwrite their status.
* The professor can also view their IP Address corresponding to each submission. 
* There is also a summarized count of number of abscences.
* Uses SummaryDAO to access and update the information.
* Written by Joanna Yang(jxy210012) 
* for CS4485.0W1 at The University of Texas at Dallas starting April 25, 2025.
******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent;
using static UttendanceDesktop.GlobalResource;
using static UttendanceDesktop.GlobalStyle;

namespace UttendanceDesktop
{
    public partial class Summary : Form
    {
        private int CourseNum;
        //Stores the old cell value when the user starts editing.
        private object editOldValue;
        //Tracks the previously selected column
        private int prevSelectedCol = 0;

        /**************************************************************************
        * Constructs the Summary upon initilization and stores the given
        * course number to pull information from. Displays total (closed) 
        * attendance forms count for the class.
        * Written by Joanna Yang
        **************************************************************************/
        public Summary(int courseNum)
        {
            CourseNum = courseNum;
            InitializeComponent();

            //Set panel size
            summaryPagePanel.Size = Size;

            //Set the datagrid size
            int width = summaryPagePanel.Width - 20;
            int height = summaryPagePanel.Height - 75;

            summaryTable.Width = width;
            summaryTable.Height = height;
            summaryTable.MaximumSize = new Size(width, height);
            summaryTable.MinimumSize = new Size(width, height);

            //Set up the total form count
            SummaryDAO summaryInfo = new SummaryDAO();
            totalCountLabel.Text = "Total (Closed) Attendance Form Count: " + summaryInfo.getClosedFormCount(CourseNum);
            //Populate the summary table
            populateSummaryTable();
        }

        /**************************************************************************
        * Populates the datagrid with data from the database using SummaryDAO.
        * Displays each student with their information and submission status 
        * for each form.
        * Written by Joanna Yang
        **************************************************************************/
        private void populateSummaryTable()
        {
            SummaryDAO summaryInfo = new SummaryDAO();
            //Sort by last name by default
            DataTable table = summaryInfo.getSummaryInfo(CourseNum);
            table.DefaultView.Sort = "Last Name ASC";
            this.summaryTable.DataSource = table;

            //Make the student info column and attendance count column readonly and sticky, and resizeable
            for (int i = 0; i < 6; i++)
            {
                summaryTable.Columns[i].ReadOnly = true;
                summaryTable.Columns[i].Frozen = true;
                summaryTable.Columns[i].Width = 120;
                summaryTable.Columns[i].MinimumWidth = 50;
                summaryTable.Columns[i].Resizable = DataGridViewTriState.True;
            }

            //Make the absence column shorter
            summaryTable.Columns[4].Width = 50;

            //Set the form columns to be smaller
            for (int i = 6; i < summaryTable.Columns.Count; i++)
            {
                summaryTable.Columns[i].Width = 70;
            }

            //Hide the column with UTD-ID from UI to make the table less cluttered
            summaryTable.Columns["UTD-ID"].Visible = false;
        }

        //Saves the old attendance status value when user starts editing the cell
        private void summaryTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editOldValue = summaryTable[e.ColumnIndex, e.RowIndex].Value;
        }

        /**************************************************************************
        * Handles Summary Table cell end edit.
        * Updates the attendance status if the new input is valid. Uses SummaryDAO
        * to perform update
        * Written by Joanna Yang
        **************************************************************************/
        private void summaryTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editNewValue = summaryTable[e.ColumnIndex, e.RowIndex].Value.ToString();
            //Set value to be uppercase
            editNewValue = editNewValue.ToUpper();
            summaryTable[e.ColumnIndex, e.RowIndex].Value = editNewValue;

            //If the value changed
            if (!Equals(editOldValue, editNewValue))
            {
                //Input validation, can either be 'P', 'E', or 'A'
                if (editNewValue == "P" || editNewValue == "E" || editNewValue == "A")
                {
                    SummaryDAO summaryInfo = new SummaryDAO();

                    //Get the form ID from the column header
                    DataTable boundTable = (DataTable)summaryTable.DataSource;
                    string colName = summaryTable.Columns[e.ColumnIndex].Name;
                    DataColumn col = boundTable.Columns[colName];
                    int formID = int.Parse(col.ExtendedProperties["FormID"].ToString());

                    //Get the UTD-ID from the selected row
                    int studentID = int.Parse(summaryTable.Rows[e.RowIndex].Cells["UTD-ID"].Value.ToString());
                    summaryInfo.updateStatus(studentID, formID, editNewValue);

                    //Update the Abscene count
                    //If original value was absent, decrease the count by 1
                    if (editOldValue.ToString() == "A")
                        summaryTable[4, e.RowIndex].Value = int.Parse(summaryTable[4, e.RowIndex].Value.ToString()) - 1;
                    //If the new value is absent, increase the count by 1
                    if (editNewValue.ToString() == "A")
                        summaryTable[4, e.RowIndex].Value = int.Parse(summaryTable[4, e.RowIndex].Value.ToString()) + 1;
                }
                else
                {
                    //Unable to update status due to invalid input
                    MessageBox.Show("Invalid input. Please enter either a \'P\', \'E\', or \'A\'");
                    summaryTable[e.ColumnIndex, e.RowIndex].Value = editOldValue.ToString().ToUpper();
                }
            }
        }

        /**************************************************************************
        * Handles Summary Table cell click.
        * Calls selectColumn() with the column index when a cell is clicked.
        * Written by Joanna Yang
        **************************************************************************/
        private void summaryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex >= 0)
            {
                selectColumn(e.ColumnIndex);
            }
        }

        /**************************************************************************
        * Handles Summary Table column header mouse click.
        * Waits until finished sorting before calling selectColumn() with the 
        * column index when a header is clicked.
        * Written by Joanna Yang
        **************************************************************************/
        private void summaryTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                selectColumn(e.ColumnIndex);
            }));
        }

        /**************************************************************************
        * Performs manual highlighting of the selected column if it's a form column
        * and unhighlights the previously selected column. Also uses SummaryDAO to
        * update the IP Adress column to reflect the IP Address for each student's
        * submission for the selected form column.
        * Written by Joanna Yang
        **************************************************************************/
        private void selectColumn(int selectedCol)
        {
            //If user selects a form column
            if (selectedCol > 5)
            {
                //Get the formID
                DataTable boundTable = (DataTable)summaryTable.DataSource;
                string colName = summaryTable.Columns[selectedCol].Name;
                DataColumn col = boundTable.Columns[colName];
                int formID = int.Parse(col.ExtendedProperties["FormID"].ToString());

                SummaryDAO submissionInfo = new SummaryDAO();
                //Update the table to display the IP addresses
                for (int i = 0; i < summaryTable.RowCount; i++)
                {
                    int id = int.Parse(summaryTable["UTD-ID", i].Value.ToString());

                    string ip = submissionInfo.getIPAddress(formID, id);
                    summaryTable["IP Address", i].Value = ip;
                }

                //Unhighlight the previously selected column
                if (selectedCol != prevSelectedCol)
                {
                    foreach (DataGridViewRow row in summaryTable.Rows)
                    {
                        Color resetColor = (row.Index % 2 == 0)
                            ? summaryTable.DefaultCellStyle.BackColor
                            : summaryTable.AlternatingRowsDefaultCellStyle.BackColor;

                        row.Cells[prevSelectedCol].Style.BackColor = resetColor;
                        row.Cells[prevSelectedCol].Style.ForeColor = Color.Black;
                    }

                    prevSelectedCol = selectedCol;
                }

                //Highlights the newly selected column
                foreach (DataGridViewRow row in summaryTable.Rows)
                {
                    row.Cells[selectedCol].Style.BackColor = GlobalStyle.PASTEL_BLUE;
                    row.Cells[selectedCol].Style.ForeColor = Color.White;
                }
            }
            else if (prevSelectedCol > 5)
            {
                //Keep the selected column highlighted after refresh of ordering
                foreach (DataGridViewRow row in summaryTable.Rows)
                {
                    row.Cells[prevSelectedCol].Style.BackColor = GlobalStyle.PASTEL_BLUE;
                    row.Cells[prevSelectedCol].Style.ForeColor = Color.White;
                }
            }
        }

        /**************************************************************************
        * Manulally right aligns the absence column for readability of numbers
        * Written by Joanna Yang
        **************************************************************************/
        private void summaryTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                summaryTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }
}
