namespace Alethiea2
{
    partial class PersonalityTestP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalityTestP2));
            lblPersonalityTestPart2 = new Label();
            btnD2 = new Button();
            btnB2 = new Button();
            btnC2 = new Button();
            btnA2 = new Button();
            lblProgress2 = new Label();
            SuspendLayout();
            // 
            // lblPersonalityTestPart2
            // 
            lblPersonalityTestPart2.AutoSize = true;
            lblPersonalityTestPart2.BackColor = Color.Transparent;
            lblPersonalityTestPart2.Font = new Font("Imprint MT Shadow", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonalityTestPart2.ForeColor = Color.FloralWhite;
            lblPersonalityTestPart2.Location = new Point(382, 77);
            lblPersonalityTestPart2.Name = "lblPersonalityTestPart2";
            lblPersonalityTestPart2.Size = new Size(750, 79);
            lblPersonalityTestPart2.TabIndex = 27;
            lblPersonalityTestPart2.Text = "PERSONALITY TEST";
            // 
            // btnD2
            // 
            btnD2.BackColor = Color.FromArgb(255, 192, 255);
            btnD2.Font = new Font("Imprint MT Shadow", 12F);
            btnD2.Location = new Point(931, 585);
            btnD2.Name = "btnD2";
            btnD2.Size = new Size(400, 150);
            btnD2.TabIndex = 26;
            btnD2.Text = "btnD";
            btnD2.UseVisualStyleBackColor = false;
            btnD2.Click += btnD2_Click;
            // 
            // btnB2
            // 
            btnB2.BackColor = Color.FromArgb(255, 192, 255);
            btnB2.Font = new Font("Imprint MT Shadow", 12F);
            btnB2.Location = new Point(931, 403);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(400, 150);
            btnB2.TabIndex = 25;
            btnB2.Text = "btnB";
            btnB2.UseVisualStyleBackColor = false;
            btnB2.Click += btnB2_Click;
            // 
            // btnC2
            // 
            btnC2.BackColor = Color.FromArgb(255, 192, 255);
            btnC2.Font = new Font("Imprint MT Shadow", 12F);
            btnC2.Location = new Point(212, 585);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(400, 150);
            btnC2.TabIndex = 24;
            btnC2.Text = "btnC";
            btnC2.UseVisualStyleBackColor = false;
            btnC2.Click += btnC2_Click;
            // 
            // btnA2
            // 
            btnA2.BackColor = Color.FromArgb(255, 192, 255);
            btnA2.Font = new Font("Imprint MT Shadow", 12F);
            btnA2.Location = new Point(212, 403);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(400, 150);
            btnA2.TabIndex = 23;
            btnA2.Text = "btnA";
            btnA2.UseVisualStyleBackColor = false;
            btnA2.Click += btnA2_Click;
            // 
            // lblProgress2
            // 
            lblProgress2.BackColor = Color.Transparent;
            lblProgress2.Font = new Font("Imprint MT Shadow", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress2.ForeColor = Color.FloralWhite;
            lblProgress2.Location = new Point(214, 187);
            lblProgress2.MaximumSize = new Size(1138, 140);
            lblProgress2.Name = "lblProgress2";
            lblProgress2.Size = new Size(1097, 56);
            lblProgress2.TabIndex = 22;
            lblProgress2.Text = ".....";
            lblProgress2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PersonalityTestP2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1542, 813);
            Controls.Add(lblPersonalityTestPart2);
            Controls.Add(btnD2);
            Controls.Add(btnB2);
            Controls.Add(btnC2);
            Controls.Add(btnA2);
            Controls.Add(lblProgress2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalityTestP2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PersonalityTestP2";
            Load += PersonalityTestP2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPersonalityTestPart2;
        private Button btnD2;
        private Button btnB2;
        private Button btnC2;
        private Button btnA2;
        private Label lblProgress2;
    }
}