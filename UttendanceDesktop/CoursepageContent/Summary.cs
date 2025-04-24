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
    public partial class Summary : Form
    {
        private static readonly int courseNum = GlobalResource.CURRENT_CLASS_ID;
        private object editOldValue;
        private int prevSelectedCol = 0;

        public Summary()
        {
            InitializeComponent();
            summaryTable.Width = summaryPagePanel.Width - 30;
            summaryTable.Height = summaryPagePanel.Height - 130;
            SummaryDAO summaryInfo = new SummaryDAO();
            totalCountLabel.Text = "Total (Closed) Attendance Form Count: " + summaryInfo.getClosedFormCount(courseNum);
            populateSummaryTable(-1);
        }

        //Populates the datagrid with data from the database
        //Displays each student with their submission status for each form
        private void populateSummaryTable(int selectedForm)
        {
            SummaryDAO summaryInfo = new SummaryDAO();
            //Sort by last name by default
            DataTable table = summaryInfo.getSummaryInfo(courseNum, selectedForm);
            table.DefaultView.Sort = "Last Name ASC";
            this.summaryTable.DataSource = table;


            //Make the student info column and attendance count column readonly and sticky
            for (int i = 0; i < 6; i++)
            {
                summaryTable.Columns[i].ReadOnly = true;
                summaryTable.Columns[i].Frozen = true;
                summaryTable.Columns[i].Width = 120;
            }

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
                    summaryInfo.updateStatus(studentID, formID, editNewValue, courseNum);

                    //Update the Abscene count
                    if (editOldValue.ToString() == "A")
                        summaryTable[4, e.RowIndex].Value = int.Parse(summaryTable[4, e.RowIndex].Value.ToString()) - 1;
                    if (editNewValue.ToString() == "A")
                        summaryTable[4, e.RowIndex].Value = int.Parse(summaryTable[4, e.RowIndex].Value.ToString()) + 1;
                }
                else
                {
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

        //Populates the IP Address column with the IP Address of the corresponding student and form submission
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
                //Update the table to display the IP addresses
                //populateSummaryTable(formID);

                //Highlight the selected column
                if (selectedCol != prevSelectedCol)
                {
                    //Unhighlights the previously selected column
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
        }
    }
}
