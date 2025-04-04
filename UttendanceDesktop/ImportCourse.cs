using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
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

            string filePath = "";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Retrieve the selected file path
                filePath = openFileDialog.FileName;
                MessageBox.Show($"Selected File: {filePath}", "File Selected");
            }

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');

                string CourseName = columns[0].Trim();
                string ClassPrefix = columns[1].Trim();
                int ClassNumber = int.Parse(columns[2].Trim());
                int SectionNumber = int.Parse(columns[3].Trim());
                int ClassID = int.Parse(columns[4].Trim());

                Class cls = new Class();
                string result = cls.AddClass(CourseName, ClassPrefix, ClassNumber, SectionNumber, ClassID);
            }

            MessageBox.Show("Courses Imported!");
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            foreach (Form form in openForms)
            {
                if (form.GetType() == typeof(Homepage))
                {
                    form.Close();
                }
            }
            Homepage newHomepage = new Homepage();
            newHomepage.Show();


        }
    }
}
