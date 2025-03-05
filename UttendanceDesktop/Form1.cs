namespace UttendanceDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            MessageBox.Show("You entered: " + text);
        }
    }
}
