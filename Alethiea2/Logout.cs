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
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear session
            Login login = new Login();
            login.Show();

            // Close or hide current form
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home_Page home = new Home_Page();
            home.Show();

            this.Close();
        }
    }
}
