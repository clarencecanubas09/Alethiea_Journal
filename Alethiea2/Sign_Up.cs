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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        public static class UserStore
        {
            public static string Email { get; set; }
            public static string Username { get; set; }
            public static string Password { get; set; }
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp1_Click(object sender, EventArgs e)
        {
            // Save entered credentials into a simple store
            UserStore.Username = txtUsername1.Text;
            UserStore.Password = txtpPassword1.Text;
            UserStore.Email = txtEmail.Text;

            MessageBox.Show("Account created successfully!");

            // Optionally return to Login form
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}
