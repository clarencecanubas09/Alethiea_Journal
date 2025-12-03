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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Location = new Point(272, 645);
            button1.Name = "button1";
            button1.Size = new Size(300, 100);
            button1.TabIndex = 11;
            button1.Text = "btnC";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 255);
            button2.Location = new Point(991, 510);
            button2.Name = "button2";
            button2.Size = new Size(300, 100);
            button2.TabIndex = 12;
            button2.Text = "btnB";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 255);
            button3.Location = new Point(991, 645);
            button3.Name = "button3";
            button3.Size = new Size(300, 100);
            button3.TabIndex = 13;
            button3.Text = "btnD";
            button3.UseVisualStyleBackColor = false;
            // 
            // PersonalityTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1542, 813);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
    }
}