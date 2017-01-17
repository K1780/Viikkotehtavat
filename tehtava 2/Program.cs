using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero();
        }
       static void Numero()
        {
            int[] pisteet= { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 5 };

            Console.WriteLine("Oppilaan saamat pisteet :");
            int points = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Oppilaan numero on : " + pisteet[points]);
        }
    }
}
