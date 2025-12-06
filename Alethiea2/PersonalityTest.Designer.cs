namespace Alethiea2
{
    partial class PersonalityTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalityTest));
            lblQuestion = new Label();
            lblProgress = new Label();
            btnA = new Button();
            btnC = new Button();
            btnB = new Button();
            btnD = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Imprint MT Shadow", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.FloralWhite;
            lblQuestion.Location = new Point(237, 270);
            lblQuestion.MaximumSize = new Size(1138, 140);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(1097, 56);
            lblQuestion.TabIndex = 7;
            lblQuestion.Text = "question";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.Click += lblQuestion_Click;
            // 
            // lblProgress
            // 
            lblProgress.BackColor = Color.Transparent;
            lblProgress.Font = new Font("Imprint MT Shadow", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress.ForeColor = Color.FloralWhite;
            lblProgress.Location = new Point(237, 180);
            lblProgress.MaximumSize = new Size(1138, 140);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(1097, 56);
            lblProgress.TabIndex = 8;
            lblProgress.Text = ".....";
            lblProgress.TextAlign = ContentAlignment.MiddleCenter;
            lblProgress.Click += lblProgress_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(255, 192, 255);
            btnA.Font = new Font("Imprint MT Shadow", 12F);
            btnA.Location = new Point(235, 396);
            btnA.Name = "btnA";
            btnA.Size = new Size(400, 150);
            btnA.TabIndex = 10;
            btnA.Text = "btnA";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(255, 192, 255);
            btnC.Font = new Font("Imprint MT Shadow", 12F);
            btnC.Location = new Point(235, 578);
            btnC.Name = "btnC";
            btnC.Size = new Size(400, 150);
            btnC.TabIndex = 11;
            btnC.Text = "btnC";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Clicked;
            // 
            // btnB
            // 
            btnB.BackColor = Color.FromArgb(255, 192, 255);
            btnB.Font = new Font("Imprint MT Shadow", 12F);
            btnB.Location = new Point(954, 396);
            btnB.Name = "btnB";
            btnB.Size = new Size(400, 150);
            btnB.TabIndex = 12;
            btnB.Text = "btnB";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(255, 192, 255);
            btnD.Font = new Font("Imprint MT Shadow", 12F);
            btnD.Location = new Point(954, 578);
            btnD.Name = "btnD";
            btnD.Size = new Size(400, 150);
            btnD.TabIndex = 13;
            btnD.Text = "btnD";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Imprint MT Shadow", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FloralWhite;
            label9.Location = new Point(405, 70);
            label9.Name = "label9";
            label9.Size = new Size(750, 79);
            label9.TabIndex = 20;
            label9.Text = "PERSONALITY TEST";
            // 
            // PersonalityTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1542, 813);
            Controls.Add(label9);
            Controls.Add(btnD);
            Controls.Add(btnB);
            Controls.Add(btnC);
            Controls.Add(btnA);
            Controls.Add(lblProgress);
            Controls.Add(lblQuestion);
            DoubleBuffered = true;
            Name = "PersonalityTest";
            Text = "PersonalityTest";
            Load += PersonalityTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private Label lblProgress;
        private Button btnA;
        private Button btnB;
        private Button btnD;
        private Button btnC;
        private Label label9;
    }
}