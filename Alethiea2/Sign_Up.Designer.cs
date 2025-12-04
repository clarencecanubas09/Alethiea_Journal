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
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSignUp1 = new Button();
            txtUsername1 = new TextBox();
            txtpPassword1 = new TextBox();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(224, 144);
            label3.Name = "label3";
            label3.Size = new Size(61, 24);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(224, 171);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 40);
            txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(224, 214);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(224, 284);
            label5.Name = "label5";
            label5.Size = new Size(93, 24);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // btnSignUp1
            // 
            btnSignUp1.BackColor = Color.FromArgb(0, 0, 192);
            btnSignUp1.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp1.ForeColor = Color.White;
            btnSignUp1.Location = new Point(327, 384);
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
            txtUsername1.Size = new Size(300, 40);
            txtUsername1.TabIndex = 9;
            // 
            // txtpPassword1
            // 
            txtpPassword1.Font = new Font("Imprint MT Shadow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpPassword1.Location = new Point(224, 311);
            txtpPassword1.Multiline = true;
            txtpPassword1.Name = "txtpPassword1";
            txtpPassword1.PasswordChar = '*';
            txtpPassword1.Size = new Size(300, 40);
            txtpPassword1.TabIndex = 10;
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(782, 453);
            Controls.Add(txtpPassword1);
            Controls.Add(txtUsername1);
            Controls.Add(btnSignUp1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sign_Up";
            Text = "Sign In";
            Load += Sign_Up_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private Button btnSignUp1;
        private TextBox txtUsername1;
        private TextBox txtpPassword1;

        

    }
}