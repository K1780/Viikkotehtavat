using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_15
{
    class Program
    {
        static void Main(string[] args)
        {
            puu();

        }
        static void puu()
        {
            int input = int.Parse(Console.ReadLine());

            var tähti = "*";
            var väli = " ";

          
            for (int x = 0; x < input; x++)
            {
               

                for (int z = input - x - 1; z > 0; z--)
                {
                    Console.Write(väli);

                }

                
                for (int y = 0; y < 2 * x + 1; y++)
                {
                    Console.Write(tähti);

                }
               
                Console.WriteLine();
            }

           
            for (int x = 0; x < 2; x++)
            {
                
                for (int y = input - 1; y > 0; y--)
                {
                    Console.Write(väli);
                }
               
                for (int z = 0; z < 1; z++)
                {
                    Console.Write(tähti);
                }
                Console.WriteLine();
            }
        }
    }
}









        