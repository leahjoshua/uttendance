using static System.Net.Mime.MediaTypeNames;

namespace UttendanceDesktop
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            String netID = login.login(netIDTxtBox.Text);
            if (netID == "Incorrect NetID")
            {
                MessageBox.Show("Incorrect NetID");
            }
            else
            {
                MessageBox.Show("Logged in as: " + netID);
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
    }
}
