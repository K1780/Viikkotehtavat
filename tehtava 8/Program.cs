using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kolme lukua: ");
            int luku1 = int.Parse(Console.ReadLine());
            int luku2 = int.Parse(Console.ReadLine());
            int luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine("Suurin luku on: " + luku1);
            }
            else if ( luku2 > luku1 && luku2 > luku3)
            {
                Console.WriteLine("Suurin luku on: " + luku2);
            }
            else if (luku3 > luku1 && luku3 > luku2)
            {
                Console.WriteLine("Suurin luku on: " + luku3);
            }


            Console.ReadLine();
        }
    }
}
