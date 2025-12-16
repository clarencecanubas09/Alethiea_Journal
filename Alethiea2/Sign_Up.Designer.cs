namespace Alethiea2
{
    partial class Sign_Up
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            btnSignUp1 = new Button();
            txtUsername1 = new TextBox();
            txtPassword1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Imprint MT Shadow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(95, 23);
            label1.Name = "label1";
            label1.Size = new Size(603, 52);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Aletheia Journal!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Imprint MT Shadow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(172, 85);
            label2.Name = "label2";
            label2.Size = new Size(441, 33);
            label2.TabIndex = 1;
            label2.Text = "Reflect on your moods and patterns";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(224, 171);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(300, 40);
            txtEmail.TabIndex = 3;
            // 
            // btnSignUp1
            // 
            btnSignUp1.BackColor = Color.FromArgb(0, 0, 192);
            btnSignUp1.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp1.ForeColor = Color.White;
            btnSignUp1.Location = new Point(319, 377);
            btnSignUp1.Name = "btnSignUp1";
            btnSignUp1.Size = new Size(100, 40);
            btnSignUp1.TabIndex = 8;
            btnSignUp1.Text = "Sign Up";
            btnSignUp1.UseVisualStyleBackColor = false;
            btnSignUp1.Click += btnSignUp1_Click;
            // 
            // txtUsername1
            // 
            txtUsername1.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername1.Location = new Point(224, 241);
            txtUsername1.Multiline = true;
            txtUsername1.Name = "txtUsername1";
            txtUsername1.PlaceholderText = "Enter your username";
            txtUsername1.Size = new Size(300, 40);
            txtUsername1.TabIndex = 9;
            // 
            // txtPassword1
            // 
            txtPassword1.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword1.Location = new Point(224, 311);
            txtPassword1.Multiline = true;
            txtPassword1.Name = "txtPassword1";
            txtPassword1.PasswordChar = '*';
            txtPassword1.PlaceholderText = "Enter your password";
            txtPassword1.Size = new Size(300, 40);
            txtPassword1.TabIndex = 10;
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(782, 453);
            Controls.Add(txtPassword1);
            Controls.Add(txtUsername1);
            Controls.Add(btnSignUp1);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sign_Up";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sign Up";
            Load += Sign_Up_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Button btnSignUp1;
        private TextBox txtUsername1;
        private TextBox txtPassword1;



    }
}