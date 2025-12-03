using static Alethiea2.Sign_Up;

namespace Alethiea2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sign_Up signUpForm = new Sign_Up();
            signUpForm.ShowDialog(this);
            
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == UserStore.Username && txtPassword.Text == UserStore.Password)
            {
                MessageBox.Show("Login successful!");
                // proceed to main app form
                PersonalityTest personality_page = new PersonalityTest();
                personality_page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
