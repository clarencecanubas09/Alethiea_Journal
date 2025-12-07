using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static Alethiea2.Sign_Up;

namespace Alethiea2
{
    public partial class Login : Form
    {
        string connectionString = "Server=localhost;Database=oop_finals;User ID=root;Pooling=true;";
        public Login()
        {
            InitializeComponent();
        }

        public static class UserSession
        {
            public static int UserID { get; set; }
            public static string Email { get; set; }
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
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT user_id, password FROM users WHERE email = @email";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int user_id = Convert.ToInt32(reader["user_id"]);
                        string storedHashedPassword = reader["password"].ToString();

                        bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);

                        if (isPasswordValid)
                        {
                            // Store current user info
                            UserSession.UserID = user_id;
                            UserSession.Email = email;

                            MessageBox.Show("Login successful!");

                            PersonalityTest personalityTest = new PersonalityTest();
                            personalityTest.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }



        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
