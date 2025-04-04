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
                        cmd.Parameters.AddWithValue("@netID", GlobalVariables.INetID);

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

                            // Clear existing tiles to avoid duplicates
                            scrollablePanel.Controls.Clear();

                            // Tile dimensions and spacing
                            int tileWidth = 400;
                            int tileHeight = 300;
                            int horizontalSpacing = 20; // Space between tiles horizontally
                            int verticalSpacing = 20;   // Space between rows
                            int tilesPerRow = 3;

                            // Starting position for the first tile
                            int startX = 50;
                            int startY = 220;

                            int currentX = startX;
                            int currentY = startY;
                            int columnCount = 0;

                            while (reader.Read())
                            {
                                // Retrieve data for each class
                                string courseName = reader["ClassName"].ToString();
                                string classPrefix = reader["ClassSubject"].ToString();
                                string classNumber = reader["ClassNum"].ToString();
                                string sectNumber = reader["SectionNum"].ToString();

                                Button tileButton = new Button
                                {
                                    Text = $"{courseName}\n{classPrefix} {classNumber}.{sectNumber}",
                                    Size = new Size(tileWidth, tileHeight),
                                    Location = new Point(currentX, currentY),
                                    BackColor = Color.FromArgb(222, 225, 241),
                                    Font = new Font("Afacad", 10, FontStyle.Regular),
                                    FlatStyle = FlatStyle.Flat
                                };
                                tileButton.FlatAppearance.BorderSize = 1;

                                // Add click event for the tile
                                tileButton.Click += (s, e) =>
                                {
                                    MessageBox.Show($"You clicked on {courseName}", "Tile Clicked");
                                };

                                // Add the tile to the scrollable panel
                                scrollablePanel.Controls.Add(tileButton);

                                // Update position for next tile
                                columnCount++;
                                if (columnCount < tilesPerRow)
                                {
                                    // Move right for the next tile in the same row
                                    currentX += tileWidth + horizontalSpacing;
                                }
                                else
                                {
                                    // Reset to start new row
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
