namespace Alethiea2
{
    partial class Logout
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
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Imprint MT Shadow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(102, 71);
            label1.Name = "label1";
            label1.Size = new Size(540, 110);
            label1.TabIndex = 2;
            label1.Text = "Are you sure you want to log out?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDarkDark;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(177, 255);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 55);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.RoyalBlue;
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(447, 256);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 55);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Confirm";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Logout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.BgForDailyQuote;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "Logout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logout";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private Button btnLogout;
    }
}