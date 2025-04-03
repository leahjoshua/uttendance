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

        private string r_tableName;
        private string[] r_attributes;
        private string[] r_types;
        private string r_fkey1;
        private string r_fkey2;
        //Creates an import module based on the input passed
        public ImportModule(string name, string table_name, string[] attributeList, string[] displayList, string[] typeList,
            string relationTableName, string[] fkeysList, string[] fkeyTypeList, string fkey1, string pkeyName)
        {
            tableName = table_name;
            attributes = attributeList;
            display = displayList;
            types = typeList;

            r_tableName = relationTableName;
            r_attributes = fkeysList;
            r_types = fkeyTypeList;
            r_fkey1 = fkey1;
            r_fkey2 = pkeyName;

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
                Visible = false;
                // Retrieve the selected file path
                string filePath = openFileDialog.FileName;
                MessageBox.Show($"Selected File: {filePath}", "File Selected");

                addToDatabase(filePath);
            }
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
                            var sql = formatEntry(tableName, attributes, types, values);
                            var cmd = new MySqlCommand();
                            cmd.CommandText = sql;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();

                            if(r_tableName != null)
                            {
                                Console.WriteLine("Adding to relational");
                                string[] r_values = [r_fkey1, values[Array.IndexOf(attributes, r_fkey2)]];
                                sql = formatEntry(r_tableName, r_attributes, r_types, r_values);

                                cmd.CommandText = sql;
                                cmd.CommandType = System.Data.CommandType.Text;
                                cmd.ExecuteNonQuery();
                            }
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

        private bool isDuplicateEntry(string pkey)
        {
            return false;
        }
        private string formatEntry(string table, string[] attri, string[] type, string[] values)
        {
            //Specify the column order
            int length = values.Length;
            var sql = "INSERT INTO `" + table + "` (";
            for (int i = 0; i < length - 1; i++)
            {
                sql += "`" + attri[i] + "`,";
            }
            sql += "`" + attri[length - 1] + "`)\n";
            
            //Specify the values
            sql += "VALUES(";
            for (int i = 0; i < length - 1; i++)
            {
                if (type[i] == "int")
                    sql += values[i];
                else
                    sql += "'" + values[i] + "'";
                sql += ", ";
            }
            if (type[length - 1] == "int")
                sql += values[length - 1];
            else
                sql += "'" + values[length - 1] + "'";
            sql += ");";

            return sql;
        }
    }
}
