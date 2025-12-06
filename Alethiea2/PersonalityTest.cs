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
            "What influences your decisions most?",
            "What type of task energizes you the most?",
            "How do you prefer to approach new challenges?",
            "Which statement sounds most like you?",
            "When you're overwhelmed, what helps you regain balance?",
            "What type of conversations do you prefer?",
            "Which environment fits you best?"

            // … continue until Question 10
        };

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblProgress_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        void btnClicked()
        {
            if (currentQuestionIndex != 9)
            {
                currentQuestionIndex++;
            }
            else
            {
                //method for part 2 and next set of questions
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
            btnClicked();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnClicked();
        }

        private void btnC_Clicked(object sender, EventArgs e)
        {
            btnClicked();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnClicked();
        }
    }
}
