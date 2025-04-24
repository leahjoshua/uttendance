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

namespace UttendanceDesktop.CoursepageContent
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting March 27, 2025.
    // NetID: jxy210012
    // Wrote the whole StudentAddModal class
    public partial class StudentAddModal : Form
    {
        public event Action? StudentAdded;
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;
        private static readonly int courseNum = GlobalResource.CURRENT_CLASS_ID;
        public StudentAddModal()
        {
            InitializeComponent();
        }

        //Hides the modal when user clicks cancel
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        //Adds student to database
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int? parseUTDID = null;
                if (int.TryParse(createUTDID.Text, out int tempID))
                    parseUTDID = tempID;

                Student student = new Student
                {
                    SUTDID = Int32.Parse(createUTDID.Text),
                    SNetID = createNetID.Text,
                    SFName = createFName.Text,
                    SLName = createLName.Text
                };

                if(!student.SUTDID.HasValue || student.SNetID == "" || student.SFName == "" || student.SLName == "")
                {
                    MessageBox.Show("Please fill in all of the fields");
                }
                else
                {
                    //Open database connection
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    //Ignore if student already exists in student table
                    if(!checkDuplicateInStudent(student.SUTDID.Value, connection))
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO student (SLName, SFName, SNetID, UTDID) \n"
                            + "VALUES(@lName, @fName, @netID, @utdID);", connection);
                        cmd.Parameters.AddWithValue("@lName", student.SLName);
                        cmd.Parameters.AddWithValue("@fName", student.SFName);
                        cmd.Parameters.AddWithValue("@netID", student.SNetID);
                        cmd.Parameters.AddWithValue("@utdID", student.SUTDID);

                        cmd.ExecuteNonQuery();
                    }

                    //Ignore if student is already in the class
                    if (!checkDuplicateInAttends(student.SUTDID.Value, connection))
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO attends (`FK_UTDID`, `FK_CourseNum`) \n"
                            + "VALUES(@utdID, @courseNum);", connection);
                        cmd.Parameters.AddWithValue("@utdID", student.SUTDID);
                        cmd.Parameters.AddWithValue("@courseNum", courseNum);

                        cmd.ExecuteNonQuery();
                        StudentAdded?.Invoke();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Student with UTD-ID \'" + student.SUTDID.Value + "\' already exists in this class");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private bool checkDuplicateInStudent(int pKey, MySqlConnection connection)
        {
            //Format query
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM `student` WHERE UTDID=@pKey;", connection);
            cmd.Parameters.AddWithValue("@pKey", pKey);
            //Read result
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();

            //Return true if there already exists an entry with the same primary key
            return count != 0;
        }

        private bool checkDuplicateInAttends(int utdID, MySqlConnection connection)
        {
            //Format query
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM `attends` WHERE FK_UTDID=@utdID AND FK_CourseNum=@courseNum;", connection);
            cmd.Parameters.AddWithValue("@utdID", utdID);
            cmd.Parameters.AddWithValue("@courseNum", courseNum);
            //Read result
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();

            //Return true if there already exists an entry with the same primary key
            return count != 0;
        }
    }
}
