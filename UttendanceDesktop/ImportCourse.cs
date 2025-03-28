using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//parisa
namespace UttendanceDesktop
{
    public partial class ImportCourse : Form
    {
        public ImportCourse()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            //Open a File Popup
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",  
                Title = "Browse .csv Files", 
                Filter = "CSV files (*.csv)|*.csv", // File filter
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



        }
    }
}
