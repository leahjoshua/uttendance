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

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting April 15, 2025.
    // NetID: jxy210012
    public partial class Summary : Form
    {
        private static readonly int courseNum = GlobalResource.CURRENT_CLASS_ID;
        private object editOldValue;

        public Summary()
        {
            InitializeComponent();
            summaryTable.Width = summaryPagePanel.Width - 30;
            summaryTable.Height = summaryPagePanel.Height - 130;
            SummaryDAO summaryInfo = new SummaryDAO();
            totalCountLabel.Text = "Total (Closed) Attendance Form Count: " + summaryInfo.getClosedFormCount(courseNum);
            populateSummaryTable();
        }

        private void populateSummaryTable()
        {
            SummaryDAO summaryInfo = new SummaryDAO();
            this.summaryTable.DataSource = summaryInfo.getSummaryInfo(courseNum);


            //Make the student info column and attendance count column readonly and sticky
            for (int i = 0; i < 5; i++)
            {
                summaryTable.Columns[i].ReadOnly = true;
                summaryTable.Columns[i].Frozen = true;
                summaryTable.Columns[i].Width = 120;
            }

            //Set the unexcused absence count column to be smaller
            //summaryTable.Columns[2].Width = 90;
            //summaryTable.Columns[3].Width = 90;
            //summaryTable.Columns[4].Width = 90;

            for (int i = 5; i < summaryTable.Columns.Count; i++)
            {
                summaryTable.Columns[i].Width = 70;
            }
        }

        private void summaryTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editOldValue = summaryTable[e.ColumnIndex, e.RowIndex].Value;
        }

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
                    if(editNewValue.ToString() == "A")
                        summaryTable[4, e.RowIndex].Value = int.Parse(summaryTable[4, e.RowIndex].Value.ToString()) + 1;
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter either a \'P\', \'E\', or \'A\'");
                    summaryTable[e.ColumnIndex, e.RowIndex].Value = editOldValue.ToString().ToUpper();
                }
            }
        }
    }
}
