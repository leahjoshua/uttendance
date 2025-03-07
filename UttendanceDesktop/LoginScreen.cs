using static System.Net.Mime.MediaTypeNames;

namespace UttendanceDesktop
{
    public partial class LoginScreen : Form
    {
        private Instructor? currentInstructor;

        public LoginScreen()
        {
            InitializeComponent();
        }

        // parisa and leah worked on this
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            LoginDAO login = new LoginDAO();
            currentInstructor = login.login(netIDTxtBox.Text, pwdTxtBox.Text);
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
                MessageBox.Show("Logged in as: " + currentInstructor.INetID);
            }

        }

        private void netIDTxtBox_Enter(object sender, EventArgs e)
        {
            if (netIDTxtBox.Text == "Enter your NetID")
            {
                netIDTxtBox.Text = "";
                netIDTxtBox.ForeColor = Color.Black;
            }
        }

        private void netIDTxtBox_Leave(object sender, EventArgs e)
        {
            if (netIDTxtBox.Text == "")
            {
                netIDTxtBox.Text = "Enter your NetID";
                netIDTxtBox.ForeColor = Color.Silver;
            }
        }

        private void pwdTxtBox_Enter(object sender, EventArgs e)
        {
            if (pwdTxtBox.Text == "Enter your Password")
            {
                pwdTxtBox.Text = "";
                pwdTxtBox.ForeColor = Color.Black;
            }
        }

        private void pwdTxtBox_Leave(object sender, EventArgs e)
        {
            if (pwdTxtBox.Text == "")
            {
                pwdTxtBox.Text = "Enter your Password";
                pwdTxtBox.ForeColor = Color.Silver;
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = logInPanel;
            if (Properties.Settings.Default.netID != string.Empty)
            {
                netIDTxtBox.Text = Properties.Settings.Default.netID;
                netIDTxtBox.ForeColor = Color.Black;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
