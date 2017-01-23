using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Hep();
        }

        static void Hep()
        {
            List<int> list = new List<int>(new int[] {  1, 2, 33, 44, 55, 68, 77, 96, 100 });

           
            for (int x = 0; x < list.Count; x++)
            {
                if (isEven(list[x])) 

                {
                    Console.WriteLine(list[x] + " HEP!");
                }
                else
                {
                    Console.WriteLine(list[x]);
                }
            }
        }
        static bool isEven(int value)
        {
            return value % 2 == 0;
        }



    
}
       
    }
