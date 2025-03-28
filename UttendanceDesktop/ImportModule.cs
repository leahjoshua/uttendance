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
    public partial class ImportModule : Form
    {
        public ImportModule(string name, string[] attributeList)
        {
            InitializeComponent(name, attributeList);
        }

        private string listToStr(string[] list)
        {
            string ret = "";
            for (int i = 0; i < list.Length - 1; i++)
            {
                ret += "\"" +  list[i] + "\", ";
            }
            ret += "\"" + list[list.Length - 1] + "\"";

            return ret;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
