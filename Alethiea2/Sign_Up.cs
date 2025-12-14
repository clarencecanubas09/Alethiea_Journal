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
using Org.BouncyCastle.Crypto.Prng;

namespace Alethiea2
{
    public partial class Sign_Up : Form
    {
        string connectionString = "Server=localhost;Database=oop_finals;User ID=root;Pooling=true;";
        public Sign_Up()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public static class UserStore
        {
            public static string Email { get; set; }
            public static string Username { get; set; }
            public static string Password { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp1_Click(object sender, EventArgs e)
        {
            string username = txtUsername1.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword1.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is required.");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return;
            }

            try
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO users (email, username, password) VALUES (@Email, @Username, @Password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);


                        cmd.ExecuteNonQuery();
                    }
                }
                UserStore.Username = txtUsername1.Text;
                UserStore.Password = txtPassword1.Text;
                UserStore.Email = txtEmail.Text;

                MessageBox.Show("Sign up successful!");
                this.Close();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Username or email already exists. Please choose another.");
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }


            MessageBox.Show("Account created successfully!");
            this.Close();
        }
    }
}
