namespace Alethiea2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            picLogo = new PictureBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            btnLogIn = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.ALETHEIA_LOGO_no_bg__2;
            picLogo.Location = new Point(320, -160);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(900, 670);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.Font = new Font("Imprint MT Shadow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(590, 411);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(370, 54);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Gainsboro;
            txtPassword.Font = new Font("Imprint MT Shadow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(590, 510);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(370, 54);
            txtPassword.TabIndex = 2;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DarkBlue;
            btnSignUp.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(600, 600);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(120, 55);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DarkBlue;
            btnLogIn.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(830, 600);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(120, 55);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1542, 813);
            Controls.Add(btnLogIn);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(picLogo);
            Name = "Login";
            Text = "Log In";
            Click += btnLogIn_Click;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignUp;
        private Button btnLogIn;
    }
}
