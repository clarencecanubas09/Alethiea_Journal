using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            { "A. I trust facts and real examples (S)",
                "B. I trust facts and real examples (N)",
                "C. I compare systems and frameworks (T)", 
                "D. I act spontaneously based on ideas (P)" }, 
            new string[] 
            { "A. I prefer detailed instructions (S)", 
                "B. I imagine different outcomes (N)", 
                "C. I decide based on logic (T)", 
                "D. I stay flexible with final decisions (P)" 
            }, 
            new string[] 
            { "A. Practical and hands-on (S)", 
                "B. Innovative and abstract (N)", 
                "C. Objective and firm (T)", 
                "D. Adaptive and exploratory (P)" 
            }, 
            new string[] 
            { "A. Notice small details (S)", 
                "B. See the bigger picture (N)",
                "C. Apply rules and systems (T)", 
                "D. Keep things open-ended (P)" 
            }, 
            new string[]
            { "A. Prefer proven methods (S)", 
                "B. Prefer unique approaches (N)", 
                "C. Value correctness (T)", 
                "D. Value experimentation (P)" 
            }, 
        };
        List<string[]> macroBChoices = new List<string[]>
        {
            new string[]
            {"A. I like practical tasks (S)",
             "B. I enjoy exploring ideas (N)",
             "C. I rely on empathy (F)",
             "D. I adapt quickly (P)"
            },

            new string[]
            {"A. I follow proven methods (S)",
             "B. I focus on possibilities (N)",
             "C. I help others decide emotionally (F)",
             "D. I stay open and spontaneous (P)"
            },

            new string[]
            {"A. Down-to-earth (S)",
             "B. Imaginative (N)",
             "C. Compassionate (F)",
             "D. Flexible (P)"
            },

            new string[]
            {"A. Detail-focused (S)",
             "B. Big-picture (N)",
             "C. Value-driven (F)",
             "D. Easygoing (P)"
            },

            new string[]
            {"A. Practical (S)",
             "B. Intuitive (N)",
             "C. Feeling-oriented (F)",
             "D. Adaptable (P)"
            },
        };

        List<string[]> macroCChoices = new List<string[]>
        {
            new string[]
            {"A. I rely on facts (S)",
             "B. I rely on ideas (N)",
             "C. I decide logically (T)",
             "D. I keep options open (P)"
            },

            new string[]
            {"A. I follow proven steps (S)",
             "B. I look for future possibilities (N)",
             "C. I choose objectivity (T)",
             "D. I experiment (P)"
            },

            new string[]
            {"A. Detail-oriented (S)",
             "B. Conceptual (N)",
             "C. Structured thinking (T)",
             "D. Spontaneous (P)"
            },

            new string[]
            {"A. Practical (S)",
             "B. Visionary (N)",
             "C. Firm decisions (T)",
             "D. Flexible plans (P)"
            },

            new string[]
            {"A. Trust experience (S)",
             "B. Trust imagination (N)",
             "C. Logic first (T)",
             "D. Adaptable (P)"
            },
        };

        List<string[]> macroDChoices = new List<string[]>
        {
            new string[]
            {"A. Notice real details (S)",
             "B. Focus on meanings (N)",
             "C. Rely on feelings (F)",
             "D. Prefer flexibility (P)"
            },

            new string[]
            {"A. Stick to what works (S)",
             "B. Seek deeper symbolism (N)",
             "C. Empathy first (F)",
             "D. Go with the flow (P)"
            },

            new string[]
            {"A. Practical helper (S)",
             "B. Idealistic dreamer (N)",
             "C. Warm and considerate (F)",
             "D. Adaptive and gentle (P)"
            },

            new string[]
            {"A. Down-to-earth (S)",
             "B. Future-oriented (N)",
             "C. Emotion-conscious (F)",
             "D. Free-spirited (P)"
            },

            new string[]
            {"A. Stable and grounded (S)",
             "B. Imaginative (N)",
             "C. Values-driven (F)",
             "D. Open-minded (P)"
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
