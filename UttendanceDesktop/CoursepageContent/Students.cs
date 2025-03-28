using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UttendanceDesktop
{
    public partial class Students : Form
    {
        private static string[] attributeList = { "Last Name", "First Name", "UTD-ID", "Net-ID"};
        private ImportModule importMod = new ImportModule("Students", attributeList);
        public Students()
        {
            InitializeComponent();
        }

        private void addStudentsBtn_Click(object sender, EventArgs e)
        {
            importMod.Show();
        }
    }
}
