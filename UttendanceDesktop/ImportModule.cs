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
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 27, 2025.
    // NetID: jxy210012
    public partial class ImportModule : Form
    {
        //Creates an import module based on the input passed
        public ImportModule(string name, string[] attributeList)
        {
            InitializeComponent();
            Text += name;
            formatExampleLabel.Text = listToStr(attributeList);
        }

        //Parses the attribute list into a string to display to the user
        private string listToStr(string[] list)
        {
            string ret = "";
            for (int i = 0; i < list.Length - 1; i++)
            {
                ret += "\"" + list[i] + "\", ";
            }
            ret += "\"" + list[list.Length - 1] + "\"";

            return ret;
        }

        //Hides the import module to return user back to page when click 'Cancel'
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        //Opens the file explorer to let user select .csv file to import
        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:",
                Title = "Browse .csv Files",
                Filter = "CSV files (.csv)|.csv", // File filter
                FilterIndex = 1,
                RestoreDirectory = true
            };

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Retrieve the selected file path
                string filePath = openFileDialog.FileName;
                MessageBox.Show($"Selected File: {filePath}", "File Selected");
            }

            Visible = false;
        }
    }
}
