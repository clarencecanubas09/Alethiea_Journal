using MySql.Data.MySqlClient;

namespace Alethiea2
{
    public partial class Login : Form
    {
        string connectionString = "Server=localhost;Database=oop_finals;User ID=root;Pooling=true;";
        public Login()
        {
            CreateAllTables();
            SeedMacroAndPersonalities();
            InitializeComponent();
        }

        public void CreateAllTables()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                        CREATE DATABASE IF NOT EXISTS OOP_Finals;
                        USE OOP_Finals;
                        
                        CREATE TABLE IF NOT EXISTS MacroPersonalities (
                            macro_id INT AUTO_INCREMENT PRIMARY KEY,
                            macro_name VARCHAR(100) NOT NULL UNIQUE
                        );

                        CREATE TABLE IF NOT EXISTS Personalities (
                            personality_id INT AUTO_INCREMENT PRIMARY KEY,
                            code VARCHAR(10) NOT NULL UNIQUE,
                            macro_id INT NOT NULL,
                            CONSTRAINT fk_personality_macro FOREIGN KEY (macro_id) REFERENCES MacroPersonalities(macro_id) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS Users (
                            user_id INT AUTO_INCREMENT PRIMARY KEY,
                            personality_id INT NOT NULL,
                            email VARCHAR(100) NOT NULL UNIQUE,
                            username VARCHAR(50) NOT NULL,
                            password VARCHAR(255) NOT NULL
                        );

                        CREATE TABLE IF NOT EXISTS Moods (
                            mood_id INT AUTO_INCREMENT PRIMARY KEY,
                            user_id INT NOT NULL,
                            mood_amazing VARCHAR(20) NOT NULL,
                            mood_happy VARCHAR(20) NOT NULL,
                            mood_neutral VARCHAR(20) NOT NULL,
                            mood_sad VARCHAR(20) NOT NULL,
                            mood_depressed VARCHAR(20) NOT NULL,
                            CONSTRAINT fk_moods_users FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS Notes (
                            notes_id INT AUTO_INCREMENT PRIMARY KEY,
                            user_id INT NOT NULL,
                            notes VARCHAR(500) NOT NULL,
                            CONSTRAINT fk_notes_users FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE
                        );
                ";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void SeedMacroAndPersonalities()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string macros = @"
                    INSERT IGNORE INTO MacroPersonalities (macro_name) VALUES
                    ('Extraverted Analysts'),
                    ('Extraverted Diplomats'),
                    ('Introverted Analysts'),
                    ('Introverted Diplomats');
                ";

                using (var cmd = new MySqlCommand(macros, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                string mbti = @"
                    INSERT IGNORE INTO Personalities (code, macro_id) VALUES
                    -- Extraverted Analysts (macro_id, 1)
                    ('ENTJ', 1), ('ENTP', 1),
                    ('ESTJ', 1), ('ESTP', 1),

                    -- Extraverted Diplomats (macro_id, 2)
                    ('ENFJ', 2), ('ENFP', 2),
                    ('ESFJ', 2), ('ESFP', 2),

                    -- Introverted Analysts (macro_id, 3)
                    ('INTJ', 3), ('INTP', 3),
                    ('ISTJ', 3), ('ISTP', 3),

                    -- Introverted Diplomats (macro_id, 4)
                    ('INFJ', 4), ('INFP', 4),
                    ('ISFJ', 4), ('ISFP', 4);
                ";
                using (var cmd = new MySqlCommand(mbti, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static class UserSession
        {
            public static int UserID { get; set; }
            public static string Email { get; set; }
            public static int PersonalityId { get; set; }

            public static void Clear()
            {
                UserID = 0;
                Email = string.Empty;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Sign_Up signUpForm = new Sign_Up();
            signUpForm.ShowDialog(this);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
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

                string query = "SELECT user_id, personality_id, password FROM users WHERE email = @email";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int user_id = Convert.ToInt32(reader["user_id"]);
                        string storedHashedPassword = reader["password"].ToString();
                        int personalityId = reader.IsDBNull(reader.GetOrdinal("personality_id")) ? 0 : reader.GetInt32("personality_id");

                        bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);

                        if (isPasswordValid)
                        {
                            // Store current user info
                            UserSession.UserID = user_id;
                            UserSession.Email = email;
                            UserSession.PersonalityId = personalityId;

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
    }
}
