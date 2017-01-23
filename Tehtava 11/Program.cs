using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_11
{
    class Program
    {
        static void Main(string[] args)
        {
            tähdet();
        }
        static void tähdet()
        {
            Console.Write("Anna tähtien määrä: ");
            int input = int.Parse(Console.ReadLine());
            List<string> stars = new List<string>();
            for (int x = 0; x <= input; x++)
            {
                stars.Add("*");
                Console.WriteLine();
                for (int y = x; y > 0; y--)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
