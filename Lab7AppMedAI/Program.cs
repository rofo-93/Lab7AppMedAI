namespace Lab7AppMedAI
{
    internal class Program : HangMan
    {
        static void Main(string[] args)
        {
            //random words generated from the words array for the  game
            string[] words = { "Robin", "Kevin", "Daniel", "Alice", "Gry", "Tobias", "Alexander" };
            Random random = new Random();
            string word = words[random.Next(words.Length)];

            string guess = "";
            int wrongGuess = 0;
            HangMan drawHangman = new HangMan();

            Console.WriteLine("Welcome to a game of Hangman. Try and guess the word letter by letter. You have 6 guesses.");
            Console.WriteLine($"The word is {word.Length} letters long.");

            //while loop that contains the whole logic for the game
            while(wrongGuess < 6 && guess != word)
            {
                drawHangman.DrawMan(wrongGuess);
                foreach (char letter in word)
                {
                    if (guess.Contains(letter))
                    {
                        Console.Write(letter);
                    }
                    else
                    {
                        Console.Write("_");
                    }
                  
                }
                
                Console.Write("\nGuess a letter: ");
                char guessedLetter = Console.ReadLine()[0];

                if (word.Contains(guessedLetter))
                {
                    guess += guessedLetter;
                    Console.WriteLine("Correct guess!");
                }
                else
                {
                    wrongGuess++;
                    Console.WriteLine($"Wrong guess. total guesses: {wrongGuess}");
                }

                if(guess == word)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations, you won! The word was {word}");
                    Console.ResetColor();
                }
                
                if (wrongGuess == 6)
                {
                    Console.WriteLine($"You lost, the word was {word}");
                    DrawWholeMan();
                }
                
            }
            


        }
    }
}
