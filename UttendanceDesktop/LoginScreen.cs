using static System.Net.Mime.MediaTypeNames;

namespace UttendanceDesktop
{
    public partial class LoginScreen : Form
    {
        private Instructor? currentInstructor;

        //leah
        public LoginScreen()
        {
            InitializeComponent();
            createAccountPanel.Visible = false;
            logInPanel.Visible = true;
        }

        // parisa and leah worked on this
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            LoginDAO login = new LoginDAO();
            currentInstructor = login.login(netIDTxtBox.Text, pwdTxtBox.Text);
            GlobalVariables.INetID = currentInstructor.INetID;
            if (currentInstructor.INetID == null)
            {
                MessageBox.Show("Incorrect NetID or Password");
            }
            else
            {
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
        //leah
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = logInPanel;
            if (Properties.Settings.Default.netID != string.Empty)
            {
                netIDTxtBox.Text = Properties.Settings.Default.netID;
                netIDTxtBox.ForeColor = Color.Black;
            }
        }

        //leah (parisa added a couple lines)
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

        //leah
        private void netIDTxtBox_Enter(object sender, EventArgs e)
        {
            if (netIDTxtBox.Text == "Enter your NetID")
            {
                netIDTxtBox.Text = "";
                netIDTxtBox.ForeColor = Color.Black;
            }
        }

        //leah
        private void netIDTxtBox_Leave(object sender, EventArgs e)
        {
            if (netIDTxtBox.Text == "")
            {
                netIDTxtBox.Text = "Enter your NetID";
                netIDTxtBox.ForeColor = Color.Silver;
            }
        }

        //leah
        private void pwdTxtBox_Enter(object sender, EventArgs e)
        {
            if (pwdTxtBox.Text == "Enter your Password")
            {
                pwdTxtBox.Text = "";
                pwdTxtBox.ForeColor = Color.Black;
            }
        }

        //leah
        private void pwdTxtBox_Leave(object sender, EventArgs e)
        {
            if (pwdTxtBox.Text == "")
            {
                pwdTxtBox.Text = "Enter your Password";
                pwdTxtBox.ForeColor = Color.Silver;
            }
        }

        private void createFName_Enter(object sender, EventArgs e)
        {
            if (createFName.Text == "Enter your First Name")
            {
                createFName.Text = "";
                createFName.ForeColor = Color.Black;
            }
        }

        private void createFName_Leave(object sender, EventArgs e)
        {
            if (createFName.Text == "")
            {
                createFName.Text = "Enter your First Name";
                createFName.ForeColor = Color.Silver;
            }
        }

        private void createLName_Enter(object sender, EventArgs e)
        {
            if (createLName.Text == "Enter your Last Name")
            {
                createLName.Text = "";
                createLName.ForeColor = Color.Black;
            }
        }

        private void createLName_Leave(object sender, EventArgs e)
        {
            if (createLName.Text == "")
            {
                createLName.Text = "Enter your Last Name";
                createLName.ForeColor = Color.Silver;
            }
        }

        private void createNetID_Enter(object sender, EventArgs e)
        {
            if (createNetID.Text == "Enter your NetID")
            {
                createNetID.Text = "";
                createNetID.ForeColor = Color.Black;
            }
        }

        private void createNetID_Leave(object sender, EventArgs e)
        {
            if (createNetID.Text == "")
            {
                createNetID.Text = "Enter your NetID";
                createNetID.ForeColor = Color.Silver;
            }
        }

        private void createPwd_Enter(object sender, EventArgs e)
        {
            if (createPwd.Text == "Enter your Password")
            {
                createPwd.Text = "";
                createPwd.ForeColor = Color.Black;
            }
        }

        private void createPwd_Leave(object sender, EventArgs e)
        {
            if (createPwd.Text == "")
            {
                createPwd.Text = "Enter your Password";
                createPwd.ForeColor = Color.Silver;
            }
        }

        private void resetText(TextBox txtbox, string? placeholder)
        {
            txtbox.Text = placeholder;
            txtbox.ForeColor = Color.Silver;
        }

        private void backToLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            createAccountPanel.Visible = false;
            logInPanel.Visible = true;
        }

        private void createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInPanel.Visible = false;
            createAccountPanel.Visible = true;
        }
    }
}
