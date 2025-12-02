using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alethiea2
{
    public partial class PersonalityTest : Form
    {
        public PersonalityTest()
        {
            InitializeComponent();
        }

        // Question list
        List<string> questions = new List<string>
        {
            "How do you usually respond when meeting new people?",
            "When solving a problem, what’s your natural method?",
            "Where do you prefer to spend most of your time?",
            // … continue until Question 10
        };

        // Track current question
        int currentQuestionIndex = 0;

        // Personality counters
        int scoreA = 0; // Extroverted Analysts
        int scoreB = 0; // Extroverted Diplomats
        int scoreC = 0; // Introverted Analysts
        int scoreD = 0; // Introverted Diplomats


        private void PersonalityTest_Load(object sender, EventArgs e)
        {
            ShowQuestion(currentQuestionIndex);
        }

        private void ShowQuestion(int index)
        {
            lblQuestion.Text = questions[index];
            lblProgress.Text = $"Question {index + 1} of {questions.Count}";
        }

    }
}
