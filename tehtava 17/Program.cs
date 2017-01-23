using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_17
{
    class Program
    {
        static void Main(string[] args)
        {
            yhdistaminen();
        }
        static void yhdistaminen()
        {
            Console.Clear();

            
            int[] array1 = new int[] { 10, 20, 30, 40, 50 };

            int[] array2 = new int[] { 5, 15, 25, 35, 45 };
            
            int[] arraysCombined = array1.Concat(array2).ToArray();
          
            Array.Sort(arraysCombined);
           
            Console.Write("Array 1: ");
            for (int x = 0; x < array1.Length; x++)
            {
                Console.Write(array1[x]);
                Console.Write(" ");
            }
            Console.WriteLine();
            
            Console.Write("Array 2: ");
            for (int x = 0; x < array2.Length; x++)
            {
                Console.Write(array2[x]);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.Write("Combined and sorted: ");
            foreach (int value in arraysCombined)
            {
                Console.Write(value);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
