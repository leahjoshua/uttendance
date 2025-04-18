/******************************************************************************
 * Homepage class for the UttendanceDesktop application.
 * This form serves as the main dashboard after login. It displays the user's
 * courses as interactive tiles and provides options to add, import, and
 * delete courses, as well as edit profile and logout features.
 * Written by Parisa Nawar (pxn210032) for CS4485.0W1 at The University of Texas at Dallas
 * starting March 7, 2025.
 ******************************************************************************/
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

namespace UttendanceDesktop
{
    public partial class Homepage : Form
    {
        private bool isEditMode = false;
        /**************************************************************************
        * Constructor for Homepage.
        * Initializes UI components and loads the class tiles for the current user.
        **************************************************************************/
        public Homepage()
        {
            //Initialize UI and load existing tiles
            InitializeComponent();
            LoadClassTiles();
        }

        /**************************************************************************
        * Handles the click event for the "Add Course Manually" button.
        * Opens a dialog to allow the user to manually add a new course.
        **************************************************************************/
        private void addCourseManualButton_Click(object sender, EventArgs e)
        {
            //Create new AddManualCourse Form and show it
            AddManualCourse addCourseForm = new AddManualCourse();
            addCourseForm.ShowDialog();
        }

        /**************************************************************************
        * Handles the click event for the "Import Course" button.
        * Opens a dialog to allow the user to import course data.
        **************************************************************************/
        private void importCourseButton_Click(object sender, EventArgs e)
        {
            //Create new ImportCourseForm and show it
            ImportCourse importCourseForm = new ImportCourse();
            importCourseForm.ShowDialog();
        }

        /**************************************************************************
        * Handles the click event for the "Edit" button.
        * Toggles the visibility of the add course controls and trash icons
        * on course tiles to enable or disable course deletion mode.
        **************************************************************************/
        private void editButton_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the Add Course picture box.
            AddCoursePictureBox.Visible = !AddCoursePictureBox.Visible;

            //Toggle Edit Mode to the opposite mode
            isEditMode = !isEditMode;

            // Hide the manual and import course buttons when editing.
            addCourseManualButton.Visible = false;
            importCourseButton.Visible = false;

            // Find the panel that contains the course tiles.
            Panel scrollablePanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "scrollablePanel");

            // If the scrollable panel exists, toggle the trash icon on each tile.
            if (scrollablePanel != null)
            {
                // Loop through each course tile in the panel.
                foreach (Panel tile in scrollablePanel.Controls.OfType<Panel>())
                {
                    // Find the trash icon in the current tile.
                    PictureBox trashIcon = tile.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Name == "trashIcon");

                    // Toggle the visibility of the trash icon to enable/disable delete mode.
                    if (trashIcon != null)
                        trashIcon.Visible = isEditMode;
                }
            }
        }

        /**************************************************************************
        * Loads the class tiles for the current user from the database.
        * Each tile represents a course and displays course information.
        * Tiles are dynamically created and added to a scrollable panel.
        * Handles tile layout, hover effects, and click events.
        * If the scrollable panel does not exist, it is created.
        * Catches and displays any errors that occur during loading.
        **************************************************************************/
        private void LoadClassTiles()
        {
            // Connection string for the database
            string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

            // SQL query to select all classes taught by the current user
            string query = @"
SELECT c.CourseNum, c.SectionNum, c.ClassSubject, c.ClassNum, c.ClassName
FROM class AS c
INNER JOIN teaches AS t ON c.CourseNum = t.FK_CourseNum
WHERE t.FK_INetID = @netID";

            try
            {
                // Open a connection to the database
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Prepare the SQL command with the current user's NetID
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@netID", GlobalResource.INetID);

                        // Execute the query and read the results
                        using (var reader = cmd.ExecuteReader())
                        {
                            // Find or create the scrollable panel for class tiles
                            Panel scrollablePanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "scrollablePanel");
                            if (scrollablePanel == null)
                            {
                                // If the panel doesn't exist, create and add it to the form
                                scrollablePanel = new Panel
                                {
                                    Name = "scrollablePanel",
                                    AutoScroll = true,
                                    Dock = DockStyle.Fill,
                                };
                                this.Controls.Add(scrollablePanel);
                            }

                            // Clear any existing tiles before adding new ones
                            scrollablePanel.Controls.Clear();

                            // Layout settings for the tiles
                            int tileWidth = 400, tileHeight = 300;
                            int horizontalSpacing = 20, verticalSpacing = 20, tilesPerRow = 3;
                            int startX = 50, startY = 220, currentX = startX, currentY = startY, columnCount = 0;

                            // Loop through each class record returned by the query
                            while (reader.Read())
                            {
                                // Extract course information from the current record
                                string courseName = reader["ClassName"].ToString();
                                string classPrefix = reader["ClassSubject"].ToString();
                                string classNumber = reader["ClassNum"].ToString();
                                string sectNumber = reader["SectionNum"].ToString();
                                string courseNum = reader["CourseNum"].ToString();

                                // Create a panel to represent the class tile
                                Panel tilePanel = new Panel
                                {
                                    Size = new Size(tileWidth, tileHeight),
                                    Location = new Point(currentX, currentY),
                                    BackColor = Color.FromArgb(222, 225, 241),
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Tag = courseNum // Store course number for reference
                                };

                                // Create a label to display course name and section
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

                                // Define default and hover colors for the tile
                                Color tileDefaultColor = Color.FromArgb(222, 225, 241);
                                Color tileHoverColor = Color.FromArgb(200, 210, 230);

                                // Add mouse hover effects to the tile and label
                                tilePanel.MouseEnter += (s, e) => { tilePanel.BackColor = tileHoverColor; };
                                tilePanel.MouseLeave += (s, e) => { tilePanel.BackColor = tileDefaultColor; };
                                infoLabel.MouseEnter += (s, e) => { tilePanel.BackColor = tileHoverColor; };
                                infoLabel.MouseLeave += (s, e) => { tilePanel.BackColor = tileDefaultColor; };

                                // Create a hidden trash icon for deletion mode
                                PictureBox trashIcon = new PictureBox
                                {
                                    Name = "trashIcon",
                                    Image = Properties.Resources.trash_icon2,
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    Size = new Size(32, 32),
                                    Location = new Point(10, 10),
                                    Cursor = Cursors.Hand,
                                    Visible = false // Only visible in edit mode
                                };
                                trashIcon.Click += trashPictureBox_Click;
                                tilePanel.Controls.Add(trashIcon);

                                // Add click events to the tile and label for selection
                                tilePanel.Click += TilePanel_Click;
                                infoLabel.Click += TilePanel_Click;

                                // Add the completed tile to the scrollable panel
                                scrollablePanel.Controls.Add(tilePanel);

                                // Update layout for the next tile
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
                // Show an error message if something goes wrong
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**************************************************************************
        * Handles the click event for the trash icon on a course tile.
        * Prompts the user for confirmation, then deletes the course from the
        * database and removes the tile from the UI. Repositions remaining tiles.
        * Displays an error message if deletion fails.
        **************************************************************************/
        private void trashPictureBox_Click(object sender, EventArgs e)
        {
            // Ensure the sender is a PictureBox inside a Panel (the course tile)
            if (sender is PictureBox trashIcon && trashIcon.Parent is Panel tilePanel)
            {
                // Prompt the user for confirmation before deleting the course
                var result = MessageBox.Show(
                    "WARNING: Deleting a course cannot be recovered. Are you sure you would like to delete this course?",
                    "Delete Course",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Find the scrollable panel containing all course tiles
                    Panel scrollablePanel = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "scrollablePanel");
                    if (scrollablePanel != null)
                    {
                        // Retrieve the course number from the tile's Tag property
                        string courseNum = tilePanel.Tag?.ToString();
                        if (string.IsNullOrEmpty(courseNum))
                        {
                            // Show an error if the course number is missing
                            MessageBox.Show("Error: Course not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Connection string for the database
                        string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";
                        try
                        {
                            // Open a connection and start a transaction for safe deletion
                            using (var connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();
                                using (var transaction = connection.BeginTransaction())
                                {
                                    // Delete the record from the teaches table for this course and user
                                    string deleteTeachesQuery = @"DELETE FROM teaches WHERE FK_CourseNum = @courseNum AND FK_INetID = @netID";
                                    using (var cmd = new MySqlCommand(deleteTeachesQuery, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@courseNum", courseNum);
                                        cmd.Parameters.AddWithValue("@netID", GlobalResource.INetID);
                                        cmd.ExecuteNonQuery();
                                    }

                                    // Delete the course from the class table
                                    string deleteClassQuery = @"DELETE FROM class WHERE CourseNum = @courseNum";
                                    using (var cmd = new MySqlCommand(deleteClassQuery, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@courseNum", courseNum);
                                        cmd.ExecuteNonQuery();
                                    }

                                    // Commit the transaction to finalize deletion
                                    transaction.Commit();
                                }
                            }

                            // Remove the deleted course tile from the UI
                            scrollablePanel.Controls.Remove(tilePanel);

                            // Rearrange the remaining tiles to fill the gap left by the deleted tile
                            int tileWidth = 400, tileHeight = 300;
                            int horizontalSpacing = 20, verticalSpacing = 20, tilesPerRow = 3;
                            int startX = 50, startY = 220;
                            int currentX = startX, currentY = startY, columnCount = 0;

                            // Loop through each remaining tile and update its position
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
                            // Show an error message if the deletion fails
                            MessageBox.Show($"Error deleting course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        /**************************************************************************
        * Handles the click event for a course tile or its label.
        * Sets the selected course as the current class in the global resource.
        * Notifies the user that the class ID has been updated.
        **************************************************************************/
        private void TilePanel_Click(object sender, EventArgs e)
        {
            // If still in Edit Mode, then Tiles should not be clickable
            if(isEditMode)
            {
                return;
            }

            // Attempt to cast sender to Panel. If sender is a Label, get its parent Panel.
            Panel tilePanel = sender as Panel;
            if (tilePanel == null && sender is Label label && label.Parent is Panel)
                tilePanel = label.Parent as Panel;

            // If a valid tile panel was found, proceed to update the current class ID
            if (tilePanel != null)
            {
                // Retrieve the course number from the tile's Tag property
                string courseNum = tilePanel.Tag?.ToString();
                if (!string.IsNullOrEmpty(courseNum))
                {
                    // Update the global resource with the selected course ID
                    GlobalResource.CURRENT_CLASS_ID = Convert.ToInt32(courseNum);

                    // Open up the CoursePage corresponding to the Course 
                    var coursePage = GlobalResource.COURSEPAGE;
                    coursePage.Show();
                    this.Hide();
                }
            }
        }

        /**************************************************************************
        * Handles the click event for the profile picture box.
        * Toggles the visibility of the edit profile and logout buttons.
        **************************************************************************/
        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            //Reverse the visibility of EditProfileButton and LogoutButton
            EditProfileButton.Visible = !EditProfileButton.Visible;
            LogoutButton.Visible = !LogoutButton.Visible;
        }

        /**************************************************************************
        * Handles the click event for the add course picture box.
        * Toggles the visibility of the add course and import course buttons.
        **************************************************************************/
        private void AddCoursePictureBox_Click(object sender, EventArgs e)
        {
            //Reverse the addCourseManualButton and importCourseButton visibility
            addCourseManualButton.Visible = !addCourseManualButton.Visible;
            importCourseButton.Visible = !importCourseButton.Visible;
        }

        /**************************************************************************
        * Handles the click event for the logout button.
        * Closes the current form and opens the login screen.
        **************************************************************************/
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            //Close homepage and return to the LoginScreen
            this.Close();
            LoginScreen logoutNewLogin = new LoginScreen();
            logoutNewLogin.Show();

        }

        /**************************************************************************
        * Handles the click event for the edit profile button.
        * Opens the edit profile dialog for the user.
        **************************************************************************/
        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            //Open a new EditProfile Form
            EditProfile newEditProfile = new EditProfile();
            newEditProfile.Show();
        }
    }
}
