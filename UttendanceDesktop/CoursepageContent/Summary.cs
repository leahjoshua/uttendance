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
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting April 15, 2025.
    // NetID: jxy210012
    // Wrote the whole Summary class
    public partial class Summary : Form
    {
        private int CourseNum;
        private object editOldValue;
        private int prevSelectedCol = 0;

        public Summary(int courseNum)
        {
            CourseNum = courseNum;
            InitializeComponent();
            //Set panel size
            summaryPagePanel.Size = Size;

            int width = summaryPagePanel.Width - 20;
            int height = summaryPagePanel.Height - 75;

            summaryTable.Width = width;
            summaryTable.Height = height;
            summaryTable.MaximumSize = new Size(width, height);
            summaryTable.MinimumSize = new Size(width, height);

            SummaryDAO summaryInfo = new SummaryDAO();
            totalCountLabel.Text = "Total (Closed) Attendance Form Count: " + summaryInfo.getClosedFormCount(CourseNum);
            populateSummaryTable();
        }

        //Populates the datagrid with data from the database
        //Displays each student with their submission status for each form
        private void populateSummaryTable()
        {
            SummaryDAO summaryInfo = new SummaryDAO();
            //Sort by last name by default
            DataTable table = summaryInfo.getSummaryInfo(CourseNum);
            table.DefaultView.Sort = "Last Name ASC";
            this.summaryTable.DataSource = table;


            //Make the student info column and attendance count column readonly and sticky
            for (int i = 0; i < 6; i++)
            {
                summaryTable.Columns[i].ReadOnly = true;
                summaryTable.Columns[i].Frozen = true;
                summaryTable.Columns[i].Width = 120;
            }

            //Make the absence column shorter
            summaryTable.Columns[4].Width = 70;

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

        //Updates the attendance status if valid
        private void summaryTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editNewValue = summaryTable[e.ColumnIndex, e.RowIndex].Value.ToString();
            editNewValue = editNewValue.ToUpper();
            summaryTable[e.ColumnIndex, e.RowIndex].Value = editNewValue;

            //If the value changed
            if (!Equals(editOldValue, editNewValue))
            {
                //Input validation
                if (editNewValue == "P" || editNewValue == "E" || editNewValue == "A")
                {
                    SummaryDAO summaryInfo = new SummaryDAO();

                    //Get the formID
                    DataTable boundTable = (DataTable)summaryTable.DataSource;
                    string colName = summaryTable.Columns[e.ColumnIndex].Name;
                    DataColumn col = boundTable.Columns[colName];
                    int formID = int.Parse(col.ExtendedProperties["FormID"].ToString());

                    int studentID = int.Parse(summaryTable.Rows[e.RowIndex].Cells["UTD-ID"].Value.ToString());
                    summaryInfo.updateStatus(studentID, formID, editNewValue, CourseNum);

                    //Update the Abscene count
                    if (editOldValue.ToString() == "A")
                        summaryTable[4, e.RowIndex].Value = int.Parse(summaryTable[4, e.RowIndex].Value.ToString()) - 1;
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

        //Calls selectColumn when a cell is clicked
        private void summaryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex >= 0)
            {
                selectColumn(e.ColumnIndex);
            }
        }

        //Waits until finished sorting before calling selectColumn when header is clicked
        private void summaryTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                selectColumn(e.ColumnIndex);
            }));
        }

        //Populates the IP Address column with the IP Address of the corresponding student and form id
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

        //Makes the absence column right align
        private void summaryTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                summaryTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }
}
