using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static UttendanceDesktop.GlobalResource;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 27, 2025.
    // NetID: jxy210012
    public partial class ImportModule : Form
    {
        private readonly string connectionString = GlobalResource.CONNECTION_STRING;
        private string tableName;
        private string[] attributes;
        private string[] display;
        private string[] types;
        //Creates an import module based on the input passed
        public ImportModule(string name, string table_name, string[] attributeList, string[] displayList, string[] typeList)
        {
            tableName = table_name;
            attributes = attributeList;
            display = displayList;
            types = typeList;

            InitializeComponent();
            Text += name;
            formatExampleLabel.Text = listToStr(display);

            
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

                addToDatabase(filePath);
            }
            Visible = false;
        }

        private string formatEntry(string[] values, int length)
        {
            //Specify the column order
            var sql = "INSERT INTO `" + tableName + "` (";
            for (int i = 0; i < length - 1; i++)
            {
                sql += "`" + attributes[i] + "`,";
            }
            sql += "`" + attributes[length - 1] + "`)\n";
            
            //Specify the values
            sql += "VALUES(";
            for (int i = 0; i < length - 1; i++)
            {
                if (types[i] == "int")
                    sql += values[i];
                else
                    sql += "'" + values[i] + "'";
                sql += ", ";
            }
            if (types[length - 1] == "int")
                sql += values[length - 1];
            else
                sql += "'" + values[length - 1] + "'";
            sql += ");";

            return sql;
        }
        private void addToDatabase(string path)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                //Open and read the file
                StreamReader reader = new StreamReader(File.OpenRead(path));
                int lineNum = 0;
                while (!reader.EndOfStream)
                {
                    //Read each line
                    var line = reader.ReadLine();
                    Console.WriteLine("Adding " + line);
                    var values = line.Split(',');
                    int length = values.Length;
                    //Ignore the heading & check if input has the correct number of columns
                    if (lineNum != 0)
                    {
                        //Check 
                        if (length == types.Length)
                        {
                            var sql = formatEntry(values, length);
                            var cmd = new MySqlCommand();
                            cmd.CommandText = sql;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                        }

                    }
                    lineNum++;

                }
                reader.Close();
                connection.Close();

                MessageBox.Show("Student's successfully imported!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
                MessageBox.Show("Failed to import students. " + ex.ToString());
            }

        }
    }
}
