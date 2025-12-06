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
            label1 = new Label();
            btnA = new Button();
            btnC = new Button();
            btnB = new Button();
            btnD = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Imprint MT Shadow", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.Black;
            lblQuestion.Location = new Point(237, 199);
            lblQuestion.MaximumSize = new Size(1138, 140);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(195, 56);
            lblQuestion.TabIndex = 7;
            lblQuestion.Text = "question";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.Click += lblQuestion_Click;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.BackColor = Color.Transparent;
            lblProgress.Font = new Font("Imprint MT Shadow", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress.ForeColor = Color.Black;
            lblProgress.Location = new Point(593, 123);
            lblProgress.MaximumSize = new Size(1138, 140);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(79, 56);
            lblProgress.TabIndex = 8;
            lblProgress.Text = ".....";
            lblProgress.TextAlign = ContentAlignment.MiddleCenter;
            lblProgress.Click += lblProgress_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Imprint MT Shadow", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(237, 34);
            label1.MaximumSize = new Size(1138, 140);
            label1.Name = "label1";
            label1.Size = new Size(1097, 56);
            label1.TabIndex = 9;
            label1.Text = "Let's determine your personality before we get started";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(255, 192, 255);
            btnA.Location = new Point(272, 510);
            btnA.Name = "btnA";
            btnA.Size = new Size(300, 100);
            btnA.TabIndex = 10;
            btnA.Text = "btnA";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(255, 192, 255);
            btnC.Location = new Point(272, 645);
            btnC.Name = "btnC";
            btnC.Size = new Size(300, 100);
            btnC.TabIndex = 11;
            btnC.Text = "btnC";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Clicked;
            // 
            // btnB
            // 
            btnB.BackColor = Color.FromArgb(255, 192, 255);
            btnB.Location = new Point(991, 510);
            btnB.Name = "btnB";
            btnB.Size = new Size(300, 100);
            btnB.TabIndex = 12;
            btnB.Text = "btnB";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(255, 192, 255);
            btnD.Location = new Point(991, 645);
            btnD.Name = "btnD";
            btnD.Size = new Size(300, 100);
            btnD.TabIndex = 13;
            btnD.Text = "btnD";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // PersonalityTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1542, 813);
            Controls.Add(btnD);
            Controls.Add(btnB);
            Controls.Add(btnC);
            Controls.Add(btnA);
            Controls.Add(label1);
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
        private Label label1;
        private Button btnA;
        private Button btnB;
        private Button btnD;
        private Button btnC;
    }
}