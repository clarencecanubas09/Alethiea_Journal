using MySql.Data.MySqlClient;
using BCrypt.Net;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Alethiea2.Login;

namespace Alethiea2
{
    public partial class Home_Page : Form
    {
        string connectionString = "Server=localhost;Database=oop_finals;User ID=root;Pooling=true;";
        public Home_Page()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            string[] greetings = { "“It’s okay not to be okay. It’s not okay to stay that way.”", "“Your mental health is more important than any test, meeting, or deadline.”", "“You don’t have to control your thoughts; you just have to stop letting them control you.”", "“Healing isn’t linear — some days you’ll move forward, other days backward, and both are part of the journey.”" };
            Random rand = new Random();
            lblQuote.Text = greetings[rand.Next(greetings.Length)];
        }

        private void button26_Click(object sender, EventArgs e)
        {
            tabPage5 = new TabPage();
            tabPage5.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        enum BreathPhase { Inhale, Hold1, Exhale, Hold2 }
        BreathPhase currentPhase = BreathPhase.Inhale;
        int phaseTime = 40;
        int elapsed = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsed++;

            progressBarBreath.Value = elapsed;

            if (elapsed >= phaseTime)
            {
                // Move to next phase
                elapsed = 0;
                progressBarBreath.Value = 0;

                switch (currentPhase)
                {
                    case BreathPhase.Inhale:
                        currentPhase = BreathPhase.Hold1;
                        lblInstruction.Text = "Hold";
                        break;
                    case BreathPhase.Hold1:
                        currentPhase = BreathPhase.Exhale;
                        lblInstruction.Text = "Exhale";
                        break;
                    case BreathPhase.Exhale:
                        currentPhase = BreathPhase.Hold2;
                        lblInstruction.Text = "Hold";
                        break;
                    case BreathPhase.Hold2:
                        currentPhase = BreathPhase.Inhale;
                        lblInstruction.Text = "Inhale";
                        break;
                }
            }
        }

        private void btnBreath_Click(object sender, EventArgs e)
        {
            currentPhase = BreathPhase.Inhale;
            lblInstruction.Text = "Inhale";
            elapsed = 0;

            progressBarBreath.Maximum = phaseTime;
            progressBarBreath.Value = 0;

            timer1.Start();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void btnNavigateHome_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 0;


        private void btnNavigateEntry_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnNavigateSummary_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            LoadMoodSummary();
        }

        private void btnNavigateHistory_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            int userId = Login.UserSession.UserID;
            List<string> notes = LoadUserNotes(userId);
            DisplayNotes(notes);
        }

        private void btnNavigateProfile_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            LoadUserInfo();
        }
        private void btnNavigateBreathing_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout();
            logout.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int userId = Login.UserSession.UserID;
            string moodColumn = "mood_" + lblMood.Text.ToLower();   // example: mood_happy
            string notes = txtNotesEntry.Text.Trim();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // -------------------------
                // 1) Update Mood Counter
                // -------------------------
                string moodSql = $@"
                    INSERT INTO Moods (user_id, {moodColumn})
                    VALUES (@userId, 1)
                    ON DUPLICATE KEY UPDATE
                    {moodColumn} = {moodColumn};
                ";

                using (var moodCmd = new MySqlCommand(moodSql, conn))
                {
                    moodCmd.Parameters.AddWithValue("@userId", userId);
                    moodCmd.ExecuteNonQuery();
                }

                // -------------------------
                // 2) Insert Notes in Notes Table
                // -------------------------
                if (!string.IsNullOrEmpty(notes))
                {
                    string noteSql = @"
                        INSERT INTO Notes (user_id, notes)
                        VALUES (@userId, @notes);
                    ";

                    using (var noteCmd = new MySqlCommand(noteSql, conn))
                    {
                        noteCmd.Parameters.AddWithValue("@userId", userId);
                        noteCmd.Parameters.AddWithValue("@notes", notes);
                        noteCmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Mood and note saved!");
        }


        private void mood_Depressed_Click(object sender, EventArgs e)
        {
            lblMood.Text = "Depressed";
        }

        private void mood_Sad_Click(object sender, EventArgs e)
        {
            lblMood.Text = "Sad";
        }

        private void mood_Neutral_Click(object sender, EventArgs e)
        {
            lblMood.Text = "Neutral";
        }
        private void mood_Happy_Click(object sender, EventArgs e)
        {
            lblMood.Text = "Happy";
        }
        private void mood_Amazing_Click(object sender, EventArgs e)
        {
            lblMood.Text = "Amazing";
        }

        private void LoadMoodSummary()
        {
            int userId = Login.UserSession.UserID;

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
            SELECT 
                SUM(mood_depressed) AS dep,
                SUM(mood_sad) AS sad,
                SUM(mood_neutral) AS neu,
                SUM(mood_happy) AS happy,
                SUM(mood_amazing) AS amazing
            FROM moods
            WHERE user_id = @uid;
        ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int dep = SafeInt(reader["dep"]);
                            int sad = SafeInt(reader["sad"]);
                            int neu = SafeInt(reader["neu"]);
                            int happy = SafeInt(reader["happy"]);
                            int amazing = SafeInt(reader["amazing"]);

                            lblDepressed.Text = dep.ToString();
                            lblSad.Text = sad.ToString();
                            lblNeutral.Text = neu.ToString();
                            lblHappy.Text = happy.ToString();
                            lblAmazing.Text = amazing.ToString();

                            ShowMessageBasedOnMood(dep, sad, neu, happy, amazing);
                        }
                        else
                        {
                            lblDepressed.Text = lblSad.Text = lblNeutral.Text =
                            lblHappy.Text = lblAmazing.Text = "0";

                            lblMessage.Text = "No mood entries yet.";
                        }
                    }
                }
            }
        }




        // Helper to safely convert DB fields to int
        private int SafeInt(object value)
        {
            if (value == null || value == DBNull.Value)
                return 0;

            int result;
            return int.TryParse(value.ToString(), out result) ? result : 0;
        }


        private void ShowMessageBasedOnMood(int dep, int sad, int neu, int happy, int amazing)
        {
            int max = Math.Max(dep, Math.Max(sad, Math.Max(neu, Math.Max(happy, amazing))));

            if (max == 0)
            {
                lblMessage.Text = "You haven't recorded any mood yet.";
                return;
            }

            if (max == dep)
                lblMessage.Text = "You've been feeling down lately. It's okay to take a break.";
            else if (max == sad)
                lblMessage.Text = "You've experienced sadness—remember to care for yourself.";
            else if (max == neu)
                lblMessage.Text = "A balanced state—steady and grounded.";
            else if (max == happy)
                lblMessage.Text = "You've been feeling good! Keep that energy going!";
            else if (max == amazing)
                lblMessage.Text = "You've been feeling fantastic! Great to see!";
        }

        private List<string> LoadUserNotes(int userId)
        {
            List<string> notesList = new List<string>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"SELECT notes FROM Notes WHERE user_id = @uid ORDER BY notes_id DESC;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notesList.Add(reader["notes"].ToString());
                        }
                    }
                }
            }

            return notesList;
        }


        private void DisplayNotes(List<string> notes)
        {
            flowNotes.Controls.Clear(); // Clear old notes

            foreach (string note in notes)
            {
                // --- Create Panel ---
                Panel notePanel = new Panel();
                notePanel.Width = flowNotes.Width - 25;   // to fit nicely
                notePanel.Height = 80;
                notePanel.BorderStyle = BorderStyle.FixedSingle;
                notePanel.Margin = new Padding(5);
                notePanel.BackColor = Color.White; // optional

                // --- Create Label ---
                Label lblNote = new Label();
                lblNote.Text = note;
                lblNote.Dock = DockStyle.Fill;
                lblNote.Padding = new Padding(8);
                lblNote.Font = new Font("Imprint MT Shadow", 16);
                lblNote.AutoSize = false;

                // --- Add to panel ---
                notePanel.Controls.Add(lblNote);

                // --- Add to FlowLayoutPanel ---
                flowNotes.Controls.Add(notePanel);
            }
        }

        private void LoadUserInfo()
        {
            int userId = Login.UserSession.UserID;

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"SELECT username FROM users WHERE user_id = @uid LIMIT 1;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblUsername.Text = reader["username"].ToString();
                        }
                    }
                }
            }
        }


        public void UpdateAccount(int userId, string newUsername, string newPassword, string retypePassword)
        {
            if (string.IsNullOrWhiteSpace(newUsername) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(retypePassword))
            {
                MessageBox.Show("Please fill out all fields!");
                return;
            }

            if (newPassword != retypePassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if username already exists for another user
                    string checkQuery = @"
                        SELECT COUNT(*) 
                        FROM Users 
                        WHERE username = @username AND user_id != @id;
                    ";

                    using (var checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", newUsername);
                        checkCmd.Parameters.AddWithValue("@id", userId);

                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (exists > 0)
                        {
                            MessageBox.Show("This username is already taken!");
                            return;
                        }
                    }

                    // Hash the password with BCrypt before saving
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                    // Update account details
                    string updateQuery = @"
                        UPDATE Users 
                        SET username = @username, password = @password 
                        WHERE user_id = @id;
                    ";

                    using (var updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@username", newUsername);
                        updateCmd.Parameters.AddWithValue("@password", hashedPassword);
                        updateCmd.Parameters.AddWithValue("@id", userId);

                        int rows = updateCmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Account updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No account was updated. Please check the user ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating account: " + ex.Message, "Database Error");
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount(
                UserSession.UserID,
                txtNewUsername.Text,
                txtNewPassword.Text,
                txtRetypePassword.Text
            );
        }
    }
}

