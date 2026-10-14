using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7AppMedAI
{
    internal class HangMan
    {

        //Class that AI helped with that draws out the man in steps, also added in method to write out whole man in red color if you lose the game.
        public void DrawMan(int wrongGuess)
        {

            Console.WriteLine("+----+");

            

            if (wrongGuess >= 1)
            {
                Console.WriteLine(" |   O");
            }
            else
            {
                Console.WriteLine(" |");
            }

            if(wrongGuess >= 3)
            {
                Console.WriteLine(" |  /|\\");
            }
            else if(wrongGuess >= 2)
            {
                Console.WriteLine(" |   | ");
            }
            else
            {
                Console.WriteLine(" | ");
            }

            //Legs
            if (wrongGuess >= 5)
            {
                Console.WriteLine(" |  / \\");
            }
            else if (wrongGuess >= 4)
            {
                Console.WriteLine(" |  / ");
            }
            else
            {
                Console.WriteLine(" | ");
            }

            Console.WriteLine("_|_");


        }

        public static void DrawWholeMan()
        {
            Console.WriteLine(" |   O");
            Console.WriteLine(" |  /|\\");
            Console.WriteLine(" |   | ");
            Console.WriteLine(" |  / \\");
        }



    }
}
