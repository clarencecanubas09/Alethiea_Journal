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
    public partial class Home_Page : Form
    {
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
    }
}
