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
using static UttendanceDesktop.GlobalResource;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting April 15, 2025.
    // NetID: jxy210012
    public partial class Summary: Form
    {
        private static readonly int courseNum = GlobalResource.CURRENT_CLASS_ID;

        public Summary()
        {
            InitializeComponent();
            populateSummaryTable();
        }

        private void populateSummaryTable()
        {
            SummaryDAO summaryInfo = new SummaryDAO();
            this.summaryTable.DataSource = summaryInfo.getSummaryInfo(courseNum);


            //Make the student info column and attendance count column readonly and sticky
            for(int i = 0; i < 5; i++)
            {
                summaryTable.Columns[i].ReadOnly = true;
                summaryTable.Columns[i].Frozen = true;
                summaryTable.Columns[i].Width = 120;
            }

            //Set the unexcused absence count column to be smaller
            summaryTable.Columns[2].Width = 90;
            summaryTable.Columns[3].Width = 90;
            summaryTable.Columns[4].Width = 90;

            for (int i = 5; i < summaryTable.Columns.Count; i++)
            {
                summaryTable.Columns[i].Width = 70;
            }
        }
    }
}
