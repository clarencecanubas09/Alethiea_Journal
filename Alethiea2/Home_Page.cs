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
            progressBarBreath.Minimum = 0;
            progressBarBreath.Maximum = phaseTime; // phaseTime = number of ticks per phase
            progressBarBreath.Value = 0;



        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            string[] greetings = { "“It’s okay not to be okay. It’s not okay to stay that way.”", "“Your mental health is more important than any test, meeting, or deadline.”", "“You don’t have to control your thoughts; you just have to stop letting them control you.”", "“Healing isn’t linear — some days you’ll move forward, other days backward, and both are part of the journey.”" };
            Random rand = new Random();
            lblQuote.Text = greetings[rand.Next(greetings.Length)];
        }

        private void button26_Click(object sender, EventArgs e)
        {
            tabViewProfile = new TabPage();
            tabViewProfile.Show();
        }

        enum BreathPhase { Inhale, Hold1, Exhale, Hold2 }
        BreathPhase currentPhase = BreathPhase.Inhale;
        int phaseTime = 40;
        int elapsed = 0;

        int cycleCount = 0;
        int totalCycles = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsed++;

            progressBarBreath.Value = elapsed;

            elapsed++;
            progressBarBreath.Value = elapsed;
            progressBarBreath.Value = Math.Min(progressBarBreath.Maximum, progressBarBreath.Value);

            if (elapsed >= phaseTime)
            {
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
                        lblInstruction.Text = "exhale";
                        break;

                    case BreathPhase.Exhale:
                        cycleCount++;
                        if (cycleCount >= totalCycles)
                        {
                            timer1.Stop();
                            lblInstruction.Text = "Finished!";
                            btnBreath.Text = "Start";
                            return;
                        }
                        currentPhase = BreathPhase.Inhale;
                        lblInstruction.Text = "Inhale";
                        break;

                        // Start next cycle
                        currentPhase = BreathPhase.Inhale;
                        lblInstruction.Text = "Inhale";
                        break;
                }
            }
            }
        bool isPaused = false;  
        private void btnBreath_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                // Pause
                timer1.Stop();
                btnBreath.Text = "Start";
                isPaused = true;
            }
            else
            {
                if (!isPaused)
                {
                    // Starting fresh → reset everything
                    cycleCount = 0;
                    elapsed = 0;
                    currentPhase = BreathPhase.Inhale;
                    lblInstruction.Text = "Inhale";
                    progressBarBreath.Value = 0;
                }

                // Start/resume timer
                timer1.Start();
                btnBreath.Text = "Pause";
                isPaused = false;
            }
        }


        private void btnNavigateHome_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 0;


        private void btnNavigateEntry_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 1;


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
        private void btnNavigateBreathing_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 5;

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

            HandleMoodSelection(lblMood.Text.ToLower());
        }



        private string GetMessageForMood(string mood, int personalityId)
        {
            mood = mood.ToLower();

            if (personalityId >= 1 && personalityId <= 4) // Group A
            {
                if (mood == "amazing") return "“You’re on fire today! I’m proud of you. If you want to share what made your day this great, I’m all ears.”";
                if (mood == "happy") return "“I love seeing you in a good mood! Let’s use that energy what are you excited about today?”";
                if (mood == "neutral") return "“Just checking in if there’s anything on your mind or anything you want to sort out, you can always talk to me.”";
                if (mood == "sad") return "“I can see you’re not okay, and that’s completely valid. If you want to walk through what’s bothering you or think it through together, I’m here.”";
                if (mood == "depressed") return "“Hey, I know things feel really heavy right now. You don’t have to solve everything at once. I’m here to help you break things down or just sit with you if you don’t feel like talking.”";
            }
            else if (personalityId >= 5 && personalityId <= 8) // Group B
            {
                if (mood == "amazing") return "“You’re glowing today! Whatever happened, I’m so happy for you. Keep that beautiful energy shining.”";
                if (mood == "happy") return "“It makes me so happy to see you smiling! I hope that good feeling stays with you all day.”";
                if (mood == "neutral") return "“Hey, just checking in. How’s your heart today? I’m always here if you want to talk.”";
                if (mood == "sad") return "“I can tell your heart feels heavy today. If you want to express what you’re feeling, I’m here to listen and support you.”";
                if (mood == "depressed") return "“I’m so sorry you’re feeling this way. You bring so much to the people around you, and you deserve just as much care. I’m here for you always.”";
            }
            else if (personalityId >= 9 && personalityId <= 12) // Group C
            {
                if (mood == "amazing") return "“It’s great seeing you in such a good place. Whatever you accomplished, you should be proud.”";
                if (mood == "happy") return "“Glad to hear you’re feeling good today. I hope your peace lasts and if you ever want to share what’s going well, I’m here.”";
                if (mood == "neutral") return "“Hope your day is steady. If there’s anything on your mind you want to reason through, I’m always ready.”";
                if (mood == "sad") return "“I noticed you’re down. No pressure to talk, but if you want someone who’ll listen without judgment, I’m here.”";
                if (mood == "depressed") return "“I’m really sorry you’re going through something this heavy. You don’t owe anyone an explanation, but I’m here anytime you want a calm space to share or reflect.”";
            }
            else if (personalityId >= 13 && personalityId <= 16) // Group D
            {
                if (mood == "amazing") return "“You seem so light and bright today it’s beautiful to see. I hope that warmth stays with you for a long time.”";
                if (mood == "happy") return "“It’s nice to feel your calm happiness. I’m glad today is kind to you.”";
                if (mood == "neutral") return "“Just checking on your heart today. Even if things are steady, you don’t have to hold things in alone.”";
                if (mood == "sad") return "“I can sense something is weighing on you. Take your time. I’m here to listen with care whenever you’re ready.”";
                if (mood == "depressed") return "“I’m really sorry you’re hurting. You feel deeply, and that’s part of your strength. You don’t have to face this pain alone I’m here softly, patiently, whenever you need me.”";
            }

            return "Stay mindful of your emotions.";
        }

        private void HandleMoodSelection(string mood)
        {

            int personalityId = UserSession.PersonalityId;

            // Generate personality-based message
            string messageText = GetMessageForMood(mood, personalityId);

            // Show in TabPage2
            lblMessagesForMood.Text = messageText;
            tabControl1.SelectedIndex = 6;

            // Optionally save mood + notes to DB here if you want
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
                        WHERE username = @username AND user_id != @uid;
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

        private void progressBarBreath_Click(object sender, EventArgs e)
        {

        }
    }
}

