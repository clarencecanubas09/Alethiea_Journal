using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Alethiea2.Login;

namespace Alethiea2
{
    public partial class PersonalityTestP2 : Form
    {
        string connectionString = "Server=localhost;Database=oop_finals;User ID=root;Pooling=true;";
        private readonly string macroResult;
        private List<string[]> currentChoices;
        private int currentIndex = 0;

        // Counters
        int countS, countN, countT, countF, countP, countJ;

        public PersonalityTestP2(string macroResult)
        {
            InitializeComponent();
            this.macroResult = macroResult;
        }

        private void PersonalityTestP2_Load(object sender, EventArgs e)
        {
            LoadChoices();
            ShowChoiceSet(currentChoices, currentIndex);
        }

        private void LoadChoices()
        {
            switch (macroResult)
            {
                case "Extroverted Analyst": currentChoices = macroAChoices; break;
                case "Extroverted Diplomat": currentChoices = macroBChoices; break;
                case "Introverted Analyst": currentChoices = macroCChoices; break;
                case "Introverted Diplomat": currentChoices = macroDChoices; break;
                default: currentChoices = new List<string[]>(); break;
            }
        }

        List<string[]> macroAChoices = new List<string[]>
        {
            new string[]
            { "A. I trust facts and real examples",
                "B. I trust facts and real examples",
                "C. I compare systems and frameworks",
                "D. I act spontaneously based on ideas" },
            new string[]
            { "A. I prefer detailed instructions",
                "B. I imagine different outcomes",
                "C. I decide based on logic",
                "D. I stay flexible with final decisions"
            },
            new string[]
            { "A. Practical and hands-on",
                "B. Innovative and abstract",
                "C. Objective and firm",
                "D. Adaptive and exploratory"
            },
            new string[]
            { "A. Notice small details",
                "B. See the bigger picture",
                "C. Apply rules and systems",
                "D. Keep things open-ended"
            },
            new string[]
            { "A. Prefer proven methods",
                "B. Prefer unique approaches",
                "C. Value correctness",
                "D. Value experimentation"
            },
        };
        List<string[]> macroBChoices = new List<string[]>
        {
            new string[]
            {"A. I like practical tasks",
             "B. I enjoy exploring ideas",
             "C. I rely on empathy",
             "D. I adapt quickly"
            },

            new string[]
            {"A. I follow proven methods",
             "B. I focus on possibilities",
             "C. I help others decide emotionally",
             "D. I stay open and spontaneous"
            },

            new string[]
            {"A. Down-to-earth",
             "B. Imaginative",
             "C. Compassionate",
             "D. Flexible"
            },

            new string[]
            {"A. Detail-focused",
             "B. Big-picture",
             "C. Value-driven",
             "D. Easygoing"
            },

            new string[]
            {"A. Practical",
             "B. Intuitive",
             "C. Feeling-oriented",
             "D. Adaptable"
            },
        };

        List<string[]> macroCChoices = new List<string[]>
        {
            new string[]
            {"A. I rely on facts",
             "B. I rely on ideas",
             "C. I decide logically",
             "D. I keep options open"
            },

            new string[]
            {"A. I follow proven steps",
             "B. I look for future possibilities",
             "C. I choose objectivity",
             "D. I experiment"
            },

            new string[]
            {"A. Detail-oriented",
             "B. Conceptual",
             "C. Structured thinking",
             "D. Spontaneous"
            },

            new string[]
            {"A. Practical",
             "B. Visionary",
             "C. Firm decisions",
             "D. Flexible plans"
            },

            new string[]
            {"A. Trust experience",
             "B. Trust imagination",
             "C. Logic first",
             "D. Adaptable"
            },
        };

        List<string[]> macroDChoices = new List<string[]>
        {
            new string[]
            {"A. Notice real details",
             "B. Focus on meanings",
             "C. Rely on feelings",
             "D. Prefer flexibility"
            },

            new string[]
            {"A. Stick to what works",
             "B. Seek deeper symbolism",
             "C. Empathy first",
             "D. Go with the flow"
            },

            new string[]
            {"A. Practical helper",
             "B. Idealistic dreamer",
             "C. Warm and considerate",
             "D. Adaptive and gentle"
            },

            new string[]
            {"A. Down-to-earth",
             "B. Future-oriented",
             "C. Emotion-conscious",
             "D. Free-spirited"
            },

            new string[]
            {"A. Stable and grounded",
             "B. Imaginative",
             "C. Values-driven",
             "D. Open-minded"
            },
        };

        private void ShowChoiceSet(List<string[]> choiceSets, int index)
        {
            string[] choices = choiceSets[index];
            btnA2.Text = choices[0];
            btnB2.Text = choices[1];
            btnC2.Text = choices[2];
            btnD2.Text = choices[3];
            lblProgress2.Text = $"Choice {index + 1} of {choiceSets.Count}";
        }

        private void btnA2_Click(object sender, EventArgs e) => HandleChoice('A');
        private void btnB2_Click(object sender, EventArgs e) => HandleChoice('A');
        private void btnC2_Click(object sender, EventArgs e) => HandleChoice('C');
        private void btnD2_Click(object sender, EventArgs e) => HandleChoice('D');

        private void HandleChoice(char choice)
        {
            // tally counts
            switch (macroResult)
            {
                case "Extroverted Analyst":
                    if (choice == 'A') countS++;
                    else if (choice == 'B') countN++;
                    else if (choice == 'C') countT++;
                    else if (choice == 'D') countP++;
                    break;

                case "Extroverted Diplomat":
                    if (choice == 'A') countS++;
                    else if (choice == 'B') countN++;
                    else if (choice == 'C') countF++;
                    else if (choice == 'D') countP++;
                    break;

                case "Introverted Analyst":
                    if (choice == 'A') countS++;
                    else if (choice == 'B') countN++;
                    else if (choice == 'C') countT++;
                    else if (choice == 'D') countP++;
                    break;

                case "Introverted Diplomat":
                    if (choice == 'A') countS++;
                    else if (choice == 'B') countN++;
                    else if (choice == 'C') countF++;
                    else if (choice == 'D') countP++;
                    break;
            }

            if (choice != 'D') countJ++; // J implied when not P

            currentIndex++;
            if (currentIndex < currentChoices.Count)
            {
                ShowChoiceSet(currentChoices, currentIndex);
            }
            else
            {
                string mbti = DetermineMBTI(macroResult);
                MessageBox.Show($"Your MBTI type is: {mbti}", "Result");

                SavePersonalityToUser(mbti);
                Close();

                Home_Page home = new Home_Page();
                home.Show();
            }
        }

        private string DetermineMBTI(string macroResult)
        {
            switch (macroResult)
            {
                case "Extroverted Analyst":
                    return (countS > countN)
                        ? (countP > countJ ? "ESTP" : "ESTJ")
                        : (countP > countJ ? "ENTP" : "ENTJ");

                case "Extroverted Diplomat":
                    return (countS > countN)
                        ? (countP > countJ ? "ESFP" : "ESFJ")
                        : (countP > countJ ? "ENFP" : "ENFJ");

                case "Introverted Analyst":
                    return (countS > countN)
                        ? (countP > countJ ? "ISTP" : "ISTJ")
                        : (countP > countJ ? "INTP" : "INTJ");

                case "Introverted Diplomat":
                    return (countS > countN)
                        ? (countP > countJ ? "ISFP" : "ISFJ")
                        : (countP > countJ ? "INFP" : "INFJ");
            }
            return "Unknown";
        }

        private void SavePersonalityToUser(string mbti)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Lookup personality_id
                string lookup = "SELECT personality_id FROM Personalities WHERE code = @code LIMIT 1";
                int personalityId = -1;
                using (var cmd = new MySqlCommand(lookup, conn))
                {
                    cmd.Parameters.AddWithValue("@code", mbti);
                    var result = cmd.ExecuteScalar();
                    if (result != null) personalityId = Convert.ToInt32(result);
                }

                if (personalityId != -1)
                {
                    string update = "UPDATE Users SET personality_id = @pid WHERE user_id = @uid";
                    using (var cmd = new MySqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", personalityId);
                        cmd.Parameters.AddWithValue("@uid", UserSession.UserID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
