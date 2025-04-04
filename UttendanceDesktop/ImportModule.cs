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
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static UttendanceDesktop.GlobalResource;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 27, 2025.
    // NetID: jxy210012
    public partial class ImportModule : Form
    {
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;
        private string tableName;
        private string[] attributes;
        private string[] display;
        private string[] types;

        private string r_tableName;
        private string[] r_attributes;
        private string[] r_types;
        private string r_fkey2;
        private string pkey_fkey1;
        //Creates an import module based on the input passed
        public ImportModule(string name, string table_name, string[] attributeList, string[] displayList, string[] typeList,
            string pkeyName, string relationTableName, string[] fkeysList, string[] fkeyTypeList, string fkey1)
        {
            tableName = table_name;
            attributes = attributeList;
            display = displayList;
            types = typeList;

            r_tableName = relationTableName;
            r_attributes = fkeysList;
            r_types = fkeyTypeList;
            r_fkey2 = fkey1;
            pkey_fkey1 = pkeyName;

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
                // Imports the data into the database
                addToDatabase(filePath);
            }
        }
        
        //Reads each line of data from the given file and adds it to the appropriate table in the database
        private void addToDatabase(string path)
        {
            try
            {
                //Open database connection
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                //Open and read the file
                StreamReader fileReader = new StreamReader(File.OpenRead(path));
                int lineNum = 0;
                while (!fileReader.EndOfStream)
                {
                    //Read each line
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');
                    int length = values.Length;

                    //Ignore the heading & check if input has the correct number of columns
                    if (lineNum != 0 && length == types.Length)
                    {
                        string query;
                        MySqlCommand cmd;

                        //Ignore duplicate entries with the same primary key
                        var pkey = values[Array.IndexOf(attributes, pkey_fkey1)];
                        string t = types[Array.IndexOf(attributes, pkey_fkey1)];
                        if (!isDuplicateEntry_1_key(pkey, t, connection))
                        {
                            //Add entry to database
                            query = formatEntry(tableName, attributes, types, values);
                            cmd = new MySqlCommand(query, connection);
                            cmd.ExecuteNonQuery();
                        }

                        //Check if there is a relational table that needs to be updated
                        if (r_tableName != null)
                        {
                            string[] pkeys = [pkey, r_fkey2];
                            //Ignore duplicate entries with the same primary keys
                            if(!isDuplicateEntry_2_key(pkeys, connection))
                            {
                                //Add entry to database
                                string[] r_values = [values[Array.IndexOf(attributes, pkey_fkey1)], r_fkey2];
                                query = formatEntry(r_tableName, r_attributes, r_types, r_values);
                                cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    lineNum++;
                }

                //Close connection
                fileReader.Close();
                connection.Close();

                MessageBox.Show("Successfully imported!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to import.\n" + ex.ToString());
            }

        }

        private bool isDuplicateEntry_1_key(string pkey, string type, MySqlConnection connection)
        {
           //Format the query
            var query = "SELECT COUNT(*) FROM `"+ tableName + "` WHERE " + pkey_fkey1 + "=";
            if (type == "int")
                query += pkey;
            else
                query += "\'" + pkey + "\'";
            query += ";";

            //Execute query
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Read result
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();

            //Return true if there already exists an entry with the same primary key
            return count != 0;
        }

        private bool isDuplicateEntry_2_key(string[] pkeys, MySqlConnection connection)
        {
            //Format the query
            var query = "SELECT COUNT(*) FROM `" + r_tableName + "` WHERE " + r_attributes[0] + "=";
            if (r_types[0] == "int")
                query += pkeys[0];
            else
                query += "\'" + pkeys[0] + "\'";

            query += " AND " + r_attributes[1] + "=";

            if (r_types[1] == "int")
                query += pkeys[1];
            else
                query += "\'" + pkeys[1] + "\'";

            query += ";";

            //Execute query
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Read result
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();

            //Return true if there already exists an entry with the same primary key
            return count != 0;
        }

        //Formats the query string
        private string formatEntry(string table, string[] attri, string[] type, string[] values)
        {
            //Specify the column order
            int length = values.Length;
            string query = "INSERT INTO `" + table + "` (";
            for (int i = 0; i < length - 1; i++)
            {
                query += "`" + attri[i] + "`,";
            }
            query += "`" + attri[length - 1] + "`)\n";
            
            //Specify the values
            query += "VALUES(";
            for (int i = 0; i < length - 1; i++)
            {
                if (type[i] == "int")
                    query += values[i];
                else
                    query += "\'" + values[i] + "\'";
                query += ", ";
            }
            if (type[length - 1] == "int")
                query += values[length - 1];
            else
                query += "\'" + values[length - 1] + "\'";
            query += ");";

            return query;
        }
    }
}
