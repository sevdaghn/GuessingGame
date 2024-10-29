namespace GuessingGame
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            ResetButton = new Button();
            ResultBox = new TextBox();
            guessTextBox = new TextBox();
            guessButton = new Button();
            guessResultLabel = new Label();
            label2 = new Label();
            guessTimer = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(255, 235, 59);
            progressBar1.ForeColor = Color.FromArgb(255, 235, 59);
            progressBar1.Location = new Point(385, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 71, 79);
            label1.Location = new Point(112, 59);
            label1.Name = "label1";
            label1.Size = new Size(271, 21);
            label1.TabIndex = 1;
            label1.Text = "Guess a number between 1 and 100";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetButton.ForeColor = Color.FromArgb(55, 71, 79);
            ResetButton.Location = new Point(212, 257);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(69, 21);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // ResultBox
            // 
            ResultBox.Anchor = AnchorStyles.None;
            ResultBox.BackColor = Color.FromArgb(0, 121, 107);
            ResultBox.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResultBox.ForeColor = Color.White;
            ResultBox.Location = new Point(216, 100);
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.Size = new Size(56, 28);
            ResultBox.TabIndex = 3;
            ResultBox.Text = "?";
            ResultBox.TextAlign = HorizontalAlignment.Center;
            // 
            // guessTextBox
            // 
            guessTextBox.Location = new Point(178, 145);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(68, 23);
            guessTextBox.TabIndex = 4;
            // 
            // guessButton
            // 
            guessButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guessButton.ForeColor = Color.FromArgb(55, 71, 79);
            guessButton.Location = new Point(255, 145);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(52, 23);
            guessButton.TabIndex = 5;
            guessButton.Text = "Enter";
            guessButton.UseVisualStyleBackColor = true;
            guessButton.Click += guessButton_Click;
            // 
            // guessResultLabel
            // 
            guessResultLabel.AutoSize = true;
            guessResultLabel.Location = new Point(225, 172);
            guessResultLabel.Name = "guessResultLabel";
            guessResultLabel.Size = new Size(0, 15);
            guessResultLabel.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(55, 71, 79);
            label2.Location = new Point(172, 181);
            label2.Name = "label2";
            label2.Size = new Size(146, 17);
            label2.TabIndex = 7;
            label2.Text = "You have not guessed yet";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guessTimer
            // 
            guessTimer.Interval = 1000;
            guessTimer.Tick += guessTimer_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.ForeColor = Color.FromArgb(55, 71, 79);
            timerLabel.Location = new Point(12, 10);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(159, 17);
            timerLabel.TabIndex = 8;
            timerLabel.Text = "Time Remaining: 10 Seconds";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 247, 233);
            ClientSize = new Size(497, 321);
            Controls.Add(timerLabel);
            Controls.Add(label2);
            Controls.Add(guessResultLabel);
            Controls.Add(guessButton);
            Controls.Add(guessTextBox);
            Controls.Add(ResultBox);
            Controls.Add(ResetButton);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Button ResetButton;
        private TextBox ResultBox;
        private TextBox guessTextBox;
        private Button guessButton;
        private Label guessResultLabel;
        private Label label2;
        private System.Windows.Forms.Timer guessTimer;
        private Label timerLabel;
    }
}
