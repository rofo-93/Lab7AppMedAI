namespace Lab7AppMedAI
{
    internal class Program : HangMan
    {
        static void Main(string[] args)
        {
            //random words generated from the words array for the  game
            string[] words = { "Robin", "Kevin", "Daniel", "Alice", "Gry", "Tobias", "Alexander" };
            Random random = new Random();
            string word = words[random.Next(words.Length)].ToUpper();

            string guessedLetters = "";
            string guess = "";
            int wrongGuess = 0;
            HangMan drawHangman = new HangMan();

            Console.WriteLine("Welcome to a game of Hangman. Try and guess the word letter by letter. You have 6 guesses.");
            Console.WriteLine($"The word is {word.Length} letters long.");

            //while loop that contains the whole logic for the game
            while(wrongGuess < 6 && guess != word)
            {
                drawHangman.DrawMan(wrongGuess);
                foreach (char letters in word)
                {
                    if (guessedLetters.Contains(letters))
                    {
                        Console.Write(letters);
                    }
                    else
                    {
                        Console.Write("_");
                    }
                  
                }
                
                Console.Write("\nGuess a letter: ");

                //with the help of AI removed the need to have the letter be case sensitive
                //also added logic to check if you already have guessed the same letter, or if you are not typing in a letter
                string input = Console.ReadLine()?.Trim().ToUpper() ?? "";
                if (input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Please enter a letter.");
                    continue;
                }
                
                char letter = input[0];
                

                if (guessedLetters.Contains(letter))
                {
                    Console.WriteLine("You have already guessed that letter.");
                    continue;
                }

                guessedLetters += letter;


                if (word.Contains(letter))
                {
                    guess += letter;
                    Console.WriteLine("Correct guess!");
                }
                else
                {
                    wrongGuess++;
                    Console.WriteLine($"Wrong guess. total guesses: {wrongGuess}");
                }

                if(guessedLetters == word)
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
