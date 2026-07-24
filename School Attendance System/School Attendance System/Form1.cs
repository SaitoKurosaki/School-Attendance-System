namespace School_Attendance_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }
    }
}
