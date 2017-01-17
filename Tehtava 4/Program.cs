using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ikä();
        }
        static void ikä()
        {
            Console.WriteLine("Kuinka vanha olet ?");
            int ikä = int.Parse(Console.ReadLine());

            if (ikä < 18 )
            {
                Console.WriteLine("Olet alaikäinen !!");
            }
           else if (ikä > 18 && ikä < 65)
            {
                Console.WriteLine("Olet aikuinen.");
            }
           else if (ikä > 65)
            {
                Console.WriteLine("Olet seniori .");
            }
        }
    }
}
