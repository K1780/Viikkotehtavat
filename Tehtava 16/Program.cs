using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_16
{
    class Program
    {
        

        static void Main(string[] args)
        {
            arvonta();
        }
        static void arvonta()
        {
            Random random = new Random();
            int randomNumero = random.Next(100);
            int input = new int();
            for (int x = 1; ; x++) 
            {
                Console.Write("Arvaa numero 0-100 : ");
                input = int.Parse(Console.ReadLine());
                if (input > randomNumero)
                {
                    Console.WriteLine("Liian korkea, arvaa uudestaan!! ");
                }
                else if (input < randomNumero)
                {
                    Console.WriteLine("Liian pieni, arvaa uudestaan!! .");
                }
                else if (input == randomNumero)
                {
                    Console.WriteLine("Oikein. Arvottu numero oli  " + randomNumero);
                    Console.WriteLine("Oikean numeron arvaaminen vaati sinulta " + x + " yritystä.");

                    break;
                }
            }
        }
    }
}
