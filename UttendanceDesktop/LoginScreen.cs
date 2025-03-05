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
            String netID = login.login(textBox1.Text);
            if (netID == "Incorrect NetID")
            {
                MessageBox.Show("Incorrect NetID");
            }
            else
            {
                MessageBox.Show("Logged in as: " + netID);
            }
            
        }
    }
}
