using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_18
{
    class Program
    {
        static void Main(string[] args)
        {
            palidromi();
        }
        static void palidromi()
        {
           
           
            Console.WriteLine("Kirjoita sana. Ohjelma tarkistaa onko sana palidromi. ");
            string word = Console.ReadLine();
            
            char[] characters = word.ToCharArray();
            
            var lastChar = characters.Length - 1;
           
            for (int x = 0; x <= lastChar;)
            {
                
                if (characters[x] == characters[lastChar])
                {
                    
                    lastChar--;
                    x++;

                }
               
                else
                {
                    break;
                }
                
                if (x == lastChar || x == lastChar + 1)
                {
                    Console.Write("Sana on palidromi !!");
                }
            }
            Console.WriteLine();
        }

    }
}
