using MySql.Data.MySqlClient;
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
        }

        private void btnNavigateHistory_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btnNavigateProfile_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
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
    }
}
