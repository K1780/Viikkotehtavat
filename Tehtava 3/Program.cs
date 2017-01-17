using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_3
{
    class Program
    {
        static void Main(string[] args)
        {
            summajakeskiarvo();
        }
        static void summajakeskiarvo()
        {
            Console.WriteLine("Anna kolme lukua :");

            int luku1= int.Parse(Console.ReadLine());
            int luku2 = int.Parse(Console.ReadLine());
            int luku3 = int.Parse(Console.ReadLine());


            int summa = luku1 + luku2 + luku3;
            int keskiarvo = (luku1 + luku2 + luku3) / 3;

            Console.WriteLine("Summa : " + summa);
            Console.WriteLine("Keskiarvo: " + keskiarvo);
        }
    }
}
