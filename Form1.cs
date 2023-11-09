namespace Assignment_5
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int numberOfGuesses;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
            numberOfGuesses = 0;
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int userGuess = int.Parse(guessTextBox.Text);
                if (userGuess < 1 || userGuess > 100)
                {
                    resultLabel.Visible = true;
                    resultLabel.Text = "Invalid input. Please enter a number between 1 and 100.";
                }
                else
                {
                    numberOfGuesses++;

                    if (userGuess > randomNumber)
                    {
                        resultLabel.Visible = true;
                        resultLabel.Text = "Too high, try again.";
                    }
                    else if (userGuess < randomNumber)
                    {
                        resultLabel.Visible = true;
                        resultLabel.Text = "Too low, try again.";
                    }
                    else
                    {
                        resultLabel.Visible = true;
                        resultLabel.Text = $"Congratulations! You guessed the number in {numberOfGuesses} guesses.";
                        InitializeGame();
                    }
                }
            }
            catch (FormatException)
            {
                resultLabel.Visible = true;
                resultLabel.Text = "Invalid input. Please enter a number.";
            }
        }
    }
}
