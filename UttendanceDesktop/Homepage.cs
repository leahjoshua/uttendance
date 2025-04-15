using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//parisa
namespace UttendanceDesktop
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            LoadClassTiles();
        }

        private void addCourseManualButton_Click(object sender, EventArgs e)
        {
            AddManualCourse addCourseForm = new AddManualCourse();
            addCourseForm.ShowDialog();
        }

        private void importCourseButton_Click(object sender, EventArgs e)
        {
            ImportCourse importCourseForm = new ImportCourse();
            importCourseForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            AddCoursePictureBox.Visible = !AddCoursePictureBox.Visible;
            addCourseManualButton.Visible = false;
            importCourseButton.Visible = false;

            Panel scrollablePanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "scrollablePanel");
            if (scrollablePanel != null)
            {
                foreach (Panel tile in scrollablePanel.Controls.OfType<Panel>())
                {
                    PictureBox trashIcon = tile.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "trashIcon");
                    if (trashIcon != null)
                        trashIcon.Visible = !trashIcon.Visible;
                }
            }
        }

        private void LoadClassTiles()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";
            string query = @"
        SELECT c.CourseNum, c.SectionNum, c.ClassSubject, c.ClassNum, c.ClassName
        FROM class AS c
        INNER JOIN teaches AS t ON c.CourseNum = t.FK_CourseNum
        WHERE t.FK_INetID = @netID";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@netID", GlobalResource.INetID);

                        using (var reader = cmd.ExecuteReader())
                        {
                            Panel scrollablePanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "scrollablePanel");
                            if (scrollablePanel == null)
                            {
                                scrollablePanel = new Panel
                                {
                                    Name = "scrollablePanel",
                                    AutoScroll = true,
                                    Dock = DockStyle.Fill,
                                };
                                this.Controls.Add(scrollablePanel);
                            }

                            scrollablePanel.Controls.Clear();

                            int tileWidth = 400, tileHeight = 300;
                            int horizontalSpacing = 20, verticalSpacing = 20, tilesPerRow = 3;
                            int startX = 50, startY = 220, currentX = startX, currentY = startY, columnCount = 0;

                            while (reader.Read())
                            {
                                string courseName = reader["ClassName"].ToString();
                                string classPrefix = reader["ClassSubject"].ToString();
                                string classNumber = reader["ClassNum"].ToString();
                                string sectNumber = reader["SectionNum"].ToString();
                                string courseNum = reader["CourseNum"].ToString();

                                Panel tilePanel = new Panel
                                {
                                    Size = new Size(tileWidth, tileHeight),
                                    Location = new Point(currentX, currentY),
                                    BackColor = Color.FromArgb(222, 225, 241),
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Tag = courseNum 
                                };

                                Label infoLabel = new Label
                                {
                                    Text = $"{courseName}\n{classPrefix} {classNumber}.{sectNumber}",
                                    Font = new Font("Afacad", 10, FontStyle.Regular),
                                    AutoSize = false,
                                    Size = new Size(tileWidth - 40, tileHeight - 40),
                                    Location = new Point(20, 40),
                                    TextAlign = ContentAlignment.MiddleCenter
                                };
                                tilePanel.Controls.Add(infoLabel);

                                Color tileDefaultColor = Color.FromArgb(222, 225, 241);
                                Color tileHoverColor = Color.FromArgb(200, 210, 230);

                                tilePanel.MouseEnter += (s, e) => { tilePanel.BackColor = tileHoverColor; };
                                tilePanel.MouseLeave += (s, e) => { tilePanel.BackColor = tileDefaultColor; };
                                infoLabel.MouseEnter += (s, e) => { tilePanel.BackColor = tileHoverColor; };
                                infoLabel.MouseLeave += (s, e) => { tilePanel.BackColor = tileDefaultColor; };

                                PictureBox trashIcon = new PictureBox
                                {
                                    Name = "trashIcon",
                                    Image = Properties.Resources.trash_icon2,
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    Size = new Size(32, 32),
                                    Location = new Point(10, 10),
                                    Cursor = Cursors.Hand,
                                    Visible = false
                                };
                                trashIcon.Click += trashPictureBox_Click;
                                tilePanel.Controls.Add(trashIcon);

                                tilePanel.Click += TilePanel_Click;
                                infoLabel.Click += TilePanel_Click;

                                scrollablePanel.Controls.Add(tilePanel);

                                columnCount++;
                                if (columnCount < tilesPerRow)
                                {
                                    currentX += tileWidth + horizontalSpacing;
                                }
                                else
                                {
                                    columnCount = 0;
                                    currentX = startX;
                                    currentY += tileHeight + verticalSpacing;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trashPictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox trashIcon && trashIcon.Parent is Panel tilePanel)
            {
                var result = MessageBox.Show("WARNING: Deleting a course cannot be recovered. Are you sure you would like to delete this course?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Panel scrollablePanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "scrollablePanel");
                    if (scrollablePanel != null)
                    {
                        string courseNum = tilePanel.Tag?.ToString();
                        if (string.IsNullOrEmpty(courseNum))
                        {
                            MessageBox.Show("Error: Course not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";
                        try
                        {
                            using (var connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();
                                using (var transaction = connection.BeginTransaction())
                                {
                                    string deleteTeachesQuery = @" DELETE FROM teaches WHERE FK_CourseNum = @courseNum AND FK_INetID = @netID";

                                    using (var cmd = new MySqlCommand(deleteTeachesQuery, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@courseNum", courseNum);
                                        cmd.Parameters.AddWithValue("@netID", GlobalResource.INetID);
                                        cmd.ExecuteNonQuery();
                                    }

                                    string deleteClassQuery = @"DELETE FROM class WHERE CourseNum = @courseNum";

                                    using (var cmd = new MySqlCommand(deleteClassQuery, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@courseNum", courseNum);
                                        cmd.ExecuteNonQuery();
                                    }

                                    transaction.Commit();
                                }
                            }

                            scrollablePanel.Controls.Remove(tilePanel);

                            int tileWidth = 400, tileHeight = 300;
                            int horizontalSpacing = 20, verticalSpacing = 20, tilesPerRow = 3;
                            int startX = 50, startY = 220;
                            int currentX = startX, currentY = startY, columnCount = 0;

                            foreach (Panel remainingTile in scrollablePanel.Controls.OfType<Panel>())
                            {
                                remainingTile.Location = new Point(currentX, currentY);

                                columnCount++;
                                if (columnCount < tilesPerRow)
                                {
                                    currentX += tileWidth + horizontalSpacing;
                                }
                                else
                                {
                                    columnCount = 0;
                                    currentX = startX;
                                    currentY += tileHeight + verticalSpacing;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void TilePanel_Click(object sender, EventArgs e)
        {
            Panel tilePanel = sender as Panel;
            if (tilePanel == null && sender is Label label && label.Parent is Panel)
                tilePanel = label.Parent as Panel;

            if (tilePanel != null)
            {
                string courseNum = tilePanel.Tag?.ToString();
                if (!string.IsNullOrEmpty(courseNum))
                {
                    GlobalResource.CURRENT_CLASS_ID = Convert.ToInt32(courseNum);
                    var result = MessageBox.Show("WARNING: Deleting a course cannot be recovered. Are you sure you would like to delete this course?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            }
        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            EditProfileButton.Visible = !EditProfileButton.Visible;
            LogoutButton.Visible = !LogoutButton.Visible;
        }

        private void AddCoursePictureBox_Click(object sender, EventArgs e)
        {
            addCourseManualButton.Visible = !addCourseManualButton.Visible;
            importCourseButton.Visible = !importCourseButton.Visible;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen logoutNewLogin = new LoginScreen();
            logoutNewLogin.Show();

        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            EditProfile newEditProfile = new EditProfile();
            newEditProfile.Show();
        }
    }
}
