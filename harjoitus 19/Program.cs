using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_19
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void teht19()
        {
            
            Console.WriteLine("Hirsipuu-peli");
            string magicWord = "apple";
            magicWord.ToCharArray();
            char[] displayLine = { '_', '_', '_', '_', '_' };
            int wrongGuesses = 0;

            for (int guessCount = 0; ; guessCount++)
            {
                
                int check = 0;

                Console.WriteLine("Arvaa numero: " + (guessCount + 1));
                Console.WriteLine("Vääriä arvauksia: " + wrongGuesses + "/6");
                Console.WriteLine("Paina jatkaaksesi.");

               
                char guess = Console.ReadKey().KeyChar;
                Console.WriteLine();

                
                for (int x = 0; x < magicWord.Length; x++)
                {
                  
                    if (magicWord[x].Equals(guess))
                    {
                        displayLine[x] = guess;
                        Console.Clear();
                        Console.WriteLine("Sinun arvauksesi \"" + guess + "\" on oikein!");
                    }
                    else
                    {
                        
                        check++;
                    }
                }

              
                if (check == magicWord.Length)
                {
                    Console.Clear();
                    Console.WriteLine("Sinun arvauksesi \"" + guess + "\" on väärin!");
                    wrongGuesses++;
                }

                
                for (int x = 0; x < displayLine.Length; x++)
                {
                    Console.Write(displayLine[x] + " ");
                }
                Console.WriteLine();
               
                if (displayLine.SequenceEqual(magicWord))
                {
                    Console.Clear();
                    Console.WriteLine("VOITIT!!");
                    Console.WriteLine("Oikea sana oli " + magicWord);
                    break;
                }

               
                if (wrongGuesses == 0)
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("*    ______     *");
                    Console.WriteLine("*    |          *");
                    Console.WriteLine("*    |          *");
                    Console.WriteLine("*    |          *");
                    Console.WriteLine("*   / \\         *");
                    Console.WriteLine("*****************");
                }
                else if (wrongGuesses == 1)
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("*    ______     *");
                    Console.WriteLine("*    |    O     *");
                    Console.WriteLine("*    |          *");
                    Console.WriteLine("*    |          *");
                    Console.WriteLine("*   / \\         *");
                    Console.WriteLine("*****************");
                }
                else if (wrongGuesses == 2)
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("*    ______     *");
                    Console.WriteLine("*    |    O     *");
                    Console.WriteLine("*    |    |     *");
                    Console.WriteLine("*    |          *");
                    Console.WriteLine("*   / \\         *");
                    Console.WriteLine("*****************");
                }
                else if (wrongGuesses == 3)
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("*    ______     *");
                    Console.WriteLine("*    |    O     *");
                    Console.WriteLine("*    |   -|     *");
                    Console.WriteLine("*    |          *");
                    Console.WriteLine("*   / \\         *");
                    Console.WriteLine("*****************");
                }
                else if (wrongGuesses == 4)
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("*    ______     *");
                    Console.WriteLine("*    |    O     *");
                    Console.WriteLine("*    |   -|-    *");
                    Console.WriteLine("*    |          *");
                    Console.WriteLine("*   / \\         *");
                    Console.WriteLine("*****************");
                }
                else if (wrongGuesses == 5)
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("*    ______     *");
                    Console.WriteLine("*    |    O     *");
                    Console.WriteLine("*    |   -|-    *");
                    Console.WriteLine("*    |   /      *");
                    Console.WriteLine("*   / \\         *");
                    Console.WriteLine("*****************");
                }
                else if (wrongGuesses == 6)
                {
                    Console.WriteLine("*****************");
                    Console.WriteLine("*    ______     *");
                    Console.WriteLine("*    |    O     *");
                    Console.WriteLine("*    |   -|-    *");
                    Console.WriteLine("*    |   / \\    *");
                    Console.WriteLine("*   / \\         *");
                    Console.WriteLine("*****************");
                    Console.WriteLine("*HÄVISIT*");
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
