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
            "I enjoy engaging with others and thrive in social settings.",
            "I analyze data and facts to make informed decisions.",
            "I prefer bustling environments with lots of activity.",
            "Objective logic and evidence guide my choices.",
            "Leading group projects excites me the most.",
            "I dive into challenges headfirst, learning as I go.",
            "I am outgoing, assertive, and love being the center of attention.",
            "Talking with friends and family helps me regain balance.",
            "I enjoy deep, meaningful conversations about ideas and concepts.",
            "A lively urban environment suits me best."
        };

        List<string> answersB = new List<string>
        {
            "I enjoy engaging with others and thrive in social settings.",
            "I consider people's feelings and perspectives when making decisions.",
            "I prefer bustling environments with lots of activity.",
            "Empathy and harmony influence my choices.",
            "Helping others and collaborating energizes me the most.",
            "I seek advice and support from others when facing challenges.",
            "I am outgoing, empathetic, and enjoy connecting with others.",
            "Spending time in nature helps me regain balance.",
            "I enjoy light-hearted conversations about everyday topics.",
            "A lively urban environment suits me best."
        };

        List<string> answersC = new List<string>
        {
            "I prefer one-on-one interactions or small groups over large gatherings.",
            "I analyze data and facts to make informed decisions.",
            "I enjoy quiet, solitary environments where I can focus.",
            "Objective logic and evidence guide my choices.",
            "Working independently on complex tasks excites me the most.",
            "I take time to reflect and plan before tackling new challenges.",
            "I am reserved, thoughtful, and prefer deep connections with a few close friends.",
            "Engaging in solitary activities like reading or meditation helps me regain balance.",
            "I enjoy deep, meaningful conversations about ideas and concepts.",
            "A peaceful rural environment suits me best."
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

        private void btnA_Click(object sender, EventArgs e)
        {
            btnClicked();
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
            lblProgress.Text = $"Question {currentQuestionIndex + 1} of {questions.Count}";

            
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnClicked();
        }

        private void btnC_Clicked(object sender, EventArgs e)
        {
            btnClicked();
        }
    }
}
