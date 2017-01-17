using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna vuosi ja ohjelma tarkistaa onko vuosi karkausvuosi: ");
            int vuosi = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(vuosi))
            {
                Console.WriteLine("Vuosi " + vuosi + " on karkausvuosi");
            } else
            {
                Console.WriteLine("Vuosi " + vuosi + " ei ole karkausvuosi");
            }

            Console.ReadLine();
        }
    }
}
