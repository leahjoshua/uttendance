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
        }
    }
}
