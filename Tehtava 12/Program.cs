using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_12
{
    class Program
    {
      

        static void Main(string[] args)
        {
            kaanteinen();
        }
        static void kaanteinen()
        {
            int[] array = new int[5];
          
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Anna viisi kokonaislukua : ");
                array[x] = int.Parse(Console.ReadLine());
            }

            Console.Write("Takaperin : ");
            for (int x = 4; x >= 0; x--)
            {
                Console.Write(array[x] + ", ");
            }

        }
    }
}