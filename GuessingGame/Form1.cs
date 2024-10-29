using Accessibility;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        private int secretNumber;
        private int remainingAttempts = 8;
        private int remainingTime = 10;

        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            secretNumber = random.Next(0, 101);

            progressBar1.Maximum = remainingAttempts;
            progressBar1.Value = remainingAttempts;

            guessTimer.Interval = 2000; // 1 second intervals
            guessTimer.Tick += guessTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Initialize any components or start settings if needed
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(guessTextBox.Text, out int userGuess))
            {
                if (userGuess == secretNumber)
                {
                    label2.Text = "Congratulations! You guessed the correct number!";
                    label2.ForeColor = Color.DarkOliveGreen;
                    guessTextBox.Text = string.Empty;
                    ResultBox.Text = $"{secretNumber}";
                    guessTimer.Stop();
                }
                else
                {
                    if (userGuess > secretNumber)
                    {
                        label2.Text = "Too high! Try again.";
                        label2.ForeColor = Color.OrangeRed;
                    }
                    else
                    {
                        label2.Text = "Too low! Try again.";
                        label2.ForeColor = Color.OrangeRed;

                    }

                    remainingAttempts--;
                    progressBar1.Value = remainingAttempts;
                    guessTextBox.Text = string.Empty;

                    if (remainingAttempts == 0)
                    {
                        label2.Text = $"Game over! The correct number was {secretNumber}.";
                        ResultBox.Text = $"{secretNumber}";
                        guessTimer.Stop();
                    }
                    else
                    {
                        remainingTime = 10; // Reset time for the next guess
                        guessTimer.Stop(); // Stop the timer before starting it again
                        guessTimer.Start(); // Start the timer
                    }
                }
            }
            else
            {
                label2.Text = "Please enter a valid number between 0 and 100.";
            }
        }

        private void guessTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            timerLabel.Text = $"Time remaining: {remainingTime} seconds";

            if (remainingTime <= 0)
            {
                // If time runs out, reduce an attempt and reset time
                label2.Text = "Time's up! You've lost an attempt.";
                remainingAttempts--;
                progressBar1.Value = remainingAttempts;

                // Reset the timer
                remainingTime = 10;

                if (remainingAttempts == 0)
                {
                    label2.Text = $"Game over! The correct number was {secretNumber}.";
                    guessTimer.Stop(); // Stop timer if game is over
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            secretNumber = random.Next(0, 101);
            ResultBox.Text = " ? ";

            remainingAttempts = 8;
            progressBar1.Value = remainingAttempts;
            remainingTime = 10; // Reset the timer
            timerLabel.Text = $"Time remaining: {remainingTime} seconds"; // Update label

            guessTextBox.Text = string.Empty;
            label2.Text = "New game started! Make a guess.";
            guessTimer.Stop(); // Ensure the timer is stopped before starting a new game
            guessTimer.Start(); // Start the timer for the new game
        }
    }
}
