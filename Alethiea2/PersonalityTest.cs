using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Alethiea2.Login;

namespace Alethiea2
{
    public partial class PersonalityTest : Form
    {
        string connectionString = "Server=localhost;Database=oop_finals;User ID=root;Pooling=true;";
        public PersonalityTest()
        {
            InitializeComponent();
        }

        // Questions for Macro-Personality
        List<string> questions = new List<string>
        {
            "How do you usually respond when meeting new people?",
            "When solving a problem, what’s your natural method?",
            "Where do you prefer to spend most of your time?",
            "What influences your decisions most?",
            "What type of task energizes you the most?",
            "How do you prefer to approach new challenges?",
            "Which statement sounds most like you?",
            "When you're overwhelmed, what helps you regain balance?",
            "What type of conversations do you prefer?",
            "Which environment fits you best?"
        };

        // Choices for Macro-Personality
        List<string> answersA = new List<string>
        {
            "I take initiative and lead the conversation.",
            "Break it down logically and create a strategy.",
            " Busy, productive environments where things get done.",
            " Effectiveness and long-term goals.",
            "Leading, planning, or initiating a challenge.",
            "Create a plan and take charge immediately.",
            "“I enjoy leading and improving systems.”",
            "Focusing on goals and regaining control.",
            "Debates, ideas, and productivity topics.",
            "Fast-paced, competitive, driven to achieve results."
        };
        List<string> answersB = new List<string>
        {
            "I smile, connect, and try to make everyone feel comfortable.",
            "Understand how people feel about it and collaborate.",
            "Social places where I can connect with others.",
            "Harmony and how it affects people..",
            "Encouraging others or working in a team.",
            "Work with others and keep everyone motivated.",
            "“I enjoy connecting with people and uplifting them.”",
            "Talking to someone and seeking emotional connection.",
            "Personal stories, shared energy, and lively discussions.",
            "Friendly, collaborative, full of social energy."
        };
        List<string> answersC = new List<string>
        {
            "I observe first and only speak when needed.",
            "Analyze quietly and focus on details and accuracy.",
            "In organized, quiet spaces where I can think.",
            "Logic, correctness, and proof.",
            "Working alone with structure and clarity.",
            "Study quietly first, then move step-by-step.",
            "“I enjoy analyzing how things work.”",
            "Organizing tasks or thinking logically.",
            "Technical, logical, or informational topics.",
            "Calm, structured, focused on precision and tasks."
        };
        List<string> answersD = new List<string>
        {
            "I stay quiet and respond thoughtfully and gently.",
            "Reflect on meanings, values, and intuition.",
            "In peaceful, creative spaces where I can reflect.",
            "Personal values, feelings, and inner meaning.",
            "Helping quietly or working creatively in your own flow.",
            "Reflect internally and approach at your own pace.",
            "“I enjoy understanding people’s emotions and inner worlds.”",
            "Retreating into quiet reflection or creativity.",
            "Deep emotional or imaginative conversations.",
            "Peaceful, reflective, emotionally comfortable."
        };

        // Track current question
        int currentQuestionIndex = 0;
        int currentOptionA = 0;
        int currentOptionB = 0;
        int currentOptionC = 0;
        int currentOptionD = 0;

        // Personality counters
        int scoreA = 0; // Extroverted Analysts
        int scoreB = 0; // Extroverted Diplomats
        int scoreC = 0; // Introverted Analysts
        int scoreD = 0; // Introverted Diplomats

        private void PersonalityTest_Load(object sender, EventArgs e)
        {
            int userId = Login.UserSession.UserID;

            if (UserAlreadyHasPersonality(userId))
            {
                MessageBox.Show("You already completed the personality test.");

                Home_Page home = new Home_Page();
                home.Show();
                this.Close();
                return;
            }
            ShowQuestion(currentQuestionIndex);
        }

        private void ShowQuestion(int index)
        {
            lblQuestion.Text = questions[index];
            lblProgress.Text = $"Question {index + 1} of {questions.Count}";
            btnA.Text = answersA[index];
            btnB.Text = answersB[index];
            btnC.Text = answersC[index];
            btnD.Text = answersD[index];
        }

        private void btnClicked(char choice)
        {
            if (currentQuestionIndex != 9)
            {
                currentQuestionIndex++;

                switch (choice)
                {
                    case 'A': scoreA++; break;
                    case 'B': scoreB++; break;
                    case 'C': scoreC++; break;
                    case 'D': scoreD++; break;
                }
            }
            else
            {
                int maxScore = Math.Max(Math.Max(scoreA, scoreB), Math.Max(scoreC, scoreD));
                string macroPersonality = "";
                string personality = "";

                if (maxScore == scoreA)
                    macroPersonality = "Extroverted Analyst";
                else if (maxScore == scoreB)
                    macroPersonality = "Extroverted Diplomat";
                else if (maxScore == scoreC)
                    macroPersonality = "Introverted Analyst";
                else if (maxScore == scoreD)
                    macroPersonality = "Introverted Diplomat";

                int macro_id = GetMacroId(macroPersonality);
                List<string> possiblePersonalities = GetPersonalitiesByMacroId(macro_id);

                string resultPersonality = $"Macro Personality: {macroPersonality}\n" +
                                $"Possible MBTI Types: {string.Join(", ", possiblePersonalities)}";

                string result = $"Results:\n" +
                               $"Extroverted Analysts (A): {scoreA}\n" +
                               $"Extroverted Diplomats (B): {scoreB}\n" +
                               $"Introverted Analysts (C): {scoreC}\n" +
                               $"Introverted Diplomats (D): {scoreD}\n" +
                               $"Your macro-personality type is: {macroPersonality}\n" +
                               $"Proceed to next part to determine your MBTI Personality";

                MessageBox.Show(result, "Quiz Finished");

                PersonalityTestP2 part2 = new PersonalityTestP2(macroPersonality);
                part2.Show();
                Hide(); // or this.Close();

            }
            currentOptionA = currentQuestionIndex;
            currentOptionB = currentQuestionIndex;
            currentOptionC = currentQuestionIndex;
            currentOptionD = currentQuestionIndex;
            lblQuestion.Text = questions[currentQuestionIndex];
            btnA.Text = answersA[currentOptionA];
            btnB.Text = answersB[currentOptionB];
            btnC.Text = answersC[currentOptionC];
            btnD.Text = answersD[currentOptionD];

            lblProgress.Text = $"Question {currentQuestionIndex + 1} of {questions.Count}";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnClicked('A');
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnClicked('B');
        }

        private void btnC_Clicked(object sender, EventArgs e)
        {
            btnClicked('C');
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnClicked('D');
        }

        private int GetMacroId(string macroPersonality)
        {
            int macroId = -1; // default if not found

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT macro_id FROM MacroPersonalities WHERE macro_name = @name LIMIT 1";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", macroPersonality);

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        macroId = Convert.ToInt32(result);
                    }
                }
            }
            return macroId;
        }

        private List<string> GetPersonalitiesByMacroId(int macroId)
        {
            List<string> personalities = new List<string>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT code FROM Personalities WHERE macro_id = @macroId";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@macroId", macroId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personalities.Add(reader["code"].ToString());
                        }
                    }
                }
            }
            return personalities;
        }

        private bool UserAlreadyHasPersonality(int userId)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                const string sql = @"SELECT personality_id FROM Users WHERE user_id = @uid LIMIT 1";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);
                    var result = cmd.ExecuteScalar();

                    // Not found or NULL → no personality set
                    if (result == null || result == DBNull.Value)
                        return false;

                    // If INT, treat 0 as NOT set; > 0 means set
                    int personalityId;
                    if (int.TryParse(result.ToString(), out personalityId))
                        return personalityId > 0;

                    // If stored as string, treat empty as NOT set
                    var str = result.ToString().Trim();
                    return !string.IsNullOrEmpty(str);
                }
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnClicked();
        }
    }
}
