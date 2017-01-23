using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_13
{
    class Program
    {
        static void Main(string[] args)
        {
            makihyppy();
        }
        static void makihyppy()
        {
           
                Console.WriteLine("Anna mäkihyppääjälle pisteet : ");

                int annetutPisteet = new int();

                List<int> allScores = new List<int>(new int[5]);
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("Tuomari " + (x + 1) + "/5 anna pisteesi: ");
                    annetutPisteet = int.Parse(Console.ReadLine());
                    allScores[x] = annetutPisteet;

                }
                
                allScores.Remove(allScores.Max());
                allScores.Remove(allScores.Min());

                Console.WriteLine("Hyppäjä sai: " + allScores.Sum() + " pistettä!");
            }
    }
}
