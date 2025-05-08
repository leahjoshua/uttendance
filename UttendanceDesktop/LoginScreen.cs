/******************************************************************************
* LoginScreen for the UttendanceDesktop application.
* 
* This class servers as the login screen into the desktop, as well as the
* create account screen. The user enters their NetID and password to log in.
* 
* Clicking Remember Me will cause the application to remember the user's NetID.
* 
* Clicking create new account will send the user to a different panel where 
* they must enter information to create a new account. Creating a new account or
* pressing the back button will send them back to the login panel.
*
* Written by Leah Joshua (lej210003) 
* and Parisa Nawar (pxn210032) 
* for CS4485.0W1 at The University of Texas at Dallas
* starting March 5, 2025.
******************************************************************************/

using static System.Net.Mime.MediaTypeNames;

namespace UttendanceDesktop
{
    public partial class LoginScreen : Form
    {
        private Instructor? currentInstructor;

        /**************************************************************************
        * Initializes the login screen and all its components. Hides the create
        * account panel at first, and dynamically sets the app's screen size based
        * on the user's screen size (about half).
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        public LoginScreen()
        {
            InitializeComponent();
            createAccountPanel.Visible = false;
            logInPanel.Visible = true;

            // Sets the app's screen size based on the user's screen size (about half).
            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            Size = new Size(w, h);
        }

        /**************************************************************************
        * Triggers on click of the sign in button. Uses the LoginDAO to send over
        * the user entered NetID and password to login. If incorrect, incorrect
        * message appears in a MessageBox. 
        * 
        * Stores the NetID in the Project's default properties when Remember Me
        * is checked.
        * 
        * Loads the Home Page on a successful log in.
        * 
        * Written by Leah Joshua and Parisa Nawar.
        **************************************************************************/
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            LoginDAO login = new LoginDAO();
            currentInstructor = login.login(netIDTxtBox.Text, pwdTxtBox.Text);
            GlobalResource.INetID = currentInstructor.INetID;

            if (currentInstructor.INetID == null)
            {
                MessageBox.Show("Incorrect NetID or Password");
            }
            else // login is successful
            {
                // Stores the NetID in the Project's default properties when Remember Me
                // is checked.
                if (rmbrMeCheck.Checked)
                {
                    Properties.Settings.Default.netID = currentInstructor.INetID;
                    Properties.Settings.Default.Save();
                }
                //MessageBox.Show("Logged in as: " + currentInstructor.INetID);
                Homepage newHomepage = new Homepage();
                newHomepage.Show();
                this.Hide();
            }

        }

        /**************************************************************************
        * Triggers onload of the login screen. If there is NetID in the project's
        * default properties (stored if remember me was selected on a previous
        * login), fill the NetID textbox with that NetId and set color to black.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = logInPanel;
            if (Properties.Settings.Default.netID != string.Empty)
            {
                netIDTxtBox.Text = Properties.Settings.Default.netID;
                netIDTxtBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
        * Triggers on create account button click in the create account panel. 
        * Uses LoginDAO to add the new account to the instructor table. Resets
        * the input fields to their placeholder text.
        * 
        * Written by Leah Joshua and Parisa Nawar.
        **************************************************************************/
        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor
            {
                INetID = createNetID.Text,
                IFName = createFName.Text,
                ILName = createLName.Text
            };

            LoginDAO login = new LoginDAO();
            int result = login.createAccount(instructor, createPwd.Text);

            if (result > 0)
            {
                MessageBox.Show("Account created for: " + instructor.IFName + " " + instructor.ILName + ".");
                createAccountPanel.Visible = false;
                logInPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Error in creating Account");
            }

            resetText(createFName, "Enter your First Name");
            resetText(createLName, "Enter your Last Name");
            resetText(createNetID, "Enter your NetID");
            resetText(createPwd, "Enter your Password");
        }

        /**************************************************************************
        * When the NetID textbox is clicked on and there's placeholder text, clears
        * the placeholder text and sets the color to black.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void netIDTxtBox_Enter(object sender, EventArgs e)
        {
            if (netIDTxtBox.Text == "Enter your NetID")
            {
                netIDTxtBox.Text = "";
                netIDTxtBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
        * When the user clicks off the NetID textbox and it's empty, refill it with
        * the placeholder text.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void netIDTxtBox_Leave(object sender, EventArgs e)
        {
            if (netIDTxtBox.Text == "")
            {
                netIDTxtBox.Text = "Enter your NetID";
                netIDTxtBox.ForeColor = Color.Silver;
            }
        }

        /**************************************************************************
        * When the password textbox is clicked on and there's placeholder text, 
        * clears the placeholder text and sets the color to black.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void pwdTxtBox_Enter(object sender, EventArgs e)
        {
            if (pwdTxtBox.Text == "Enter your Password")
            {
                pwdTxtBox.PasswordChar = '*';
                pwdTxtBox.Text = "";
                pwdTxtBox.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
        * When the user clicks off the password textbox and it's empty, refill it 
        * with the placeholder text.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void pwdTxtBox_Leave(object sender, EventArgs e)
        {
            if (pwdTxtBox.Text == "")
            {
                pwdTxtBox.PasswordChar = '\0';
                pwdTxtBox.Text = "Enter your Password";
                pwdTxtBox.ForeColor = Color.Silver;
            }
        }

        /**************************************************************************
        * When the create first name textbox is clicked on and there's placeholder 
        * text, clears the placeholder text and sets the color to black.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void createFName_Enter(object sender, EventArgs e)
        {
            if (createFName.Text == "Enter your First Name")
            {
                createFName.Text = "";
                createFName.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
        * When the user clicks off the create first name textbox and it's empty, 
        * refill it with the placeholder text.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void createFName_Leave(object sender, EventArgs e)
        {
            if (createFName.Text == "")
            {
                createFName.Text = "Enter your First Name";
                createFName.ForeColor = Color.Silver;
            }
        }

        /**************************************************************************
        * When the create last name textbox is clicked on and there's placeholder 
        * text, clears the placeholder text and sets the color to black.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void createLName_Enter(object sender, EventArgs e)
        {
            if (createLName.Text == "Enter your Last Name")
            {
                createLName.Text = "";
                createLName.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
        * When the user clicks off the create last name textbox and it's empty, 
        * refill it with the placeholder text.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void createLName_Leave(object sender, EventArgs e)
        {
            if (createLName.Text == "")
            {
                createLName.Text = "Enter your Last Name";
                createLName.ForeColor = Color.Silver;
            }
        }

        /**************************************************************************
        * When the create NetID textbox is clicked on and there's placeholder text, 
        * clears the placeholder text and sets the color to black.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void createNetID_Enter(object sender, EventArgs e)
        {
            if (createNetID.Text == "Enter your NetID")
            {
                createNetID.Text = "";
                createNetID.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
        * When the user clicks off the create NetID textbox and it's empty, refill 
        * it with the placeholder text.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void createNetID_Leave(object sender, EventArgs e)
        {
            if (createNetID.Text == "")
            {
                createNetID.Text = "Enter your NetID";
                createNetID.ForeColor = Color.Silver;
            }
        }

        /**************************************************************************
        * When the create password textbox is clicked on and there's placeholder 
        * text, clears the placeholder text and sets the color to black.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void createPwd_Enter(object sender, EventArgs e)
        {
            if (createPwd.Text == "Enter your Password")
            {
                createPwd.Text = "";
                createPwd.ForeColor = Color.Black;
            }
        }

        /**************************************************************************
        * When the user clicks off the create password textbox and it's empty, 
        * refill it with the placeholder text.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void createPwd_Leave(object sender, EventArgs e)
        {
            if (createPwd.Text == "")
            {
                createPwd.Text = "Enter your Password";
                createPwd.ForeColor = Color.Silver;
            }
        }

        /**************************************************************************
        * Resets the text of the parameter txtbox to the string specified by 
        * placeholder, and sets the text color to Silver 
        * 
        * Used for setting placeholder text.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void resetText(TextBox txtbox, string? placeholder)
        {
            txtbox.Text = placeholder;
            txtbox.ForeColor = Color.Silver;
        }

        /**************************************************************************
        * When back to login button is clicked, make the create account invisible
        * and login panel visible.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void backToLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            createAccountPanel.Visible = false;
            logInPanel.Visible = true;
        }

        /**************************************************************************
        * When create account is clicked, make the create account visible and
        * login panel invisible.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private void createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInPanel.Visible = false;
            createAccountPanel.Visible = true;
        }
    }
}
