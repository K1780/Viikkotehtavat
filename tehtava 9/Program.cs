using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_9
{
    class Program
    {
        static void Main(string[] args)
        {
            SummaLaskuri();
        }
      
        
        
        static void SummaLaskuri()
        {
            Console.WriteLine("Summa laskuri. Anna lukuja ja paina 0 kun haluat lopettaa");
            List<int> numerot = new List<int>();
            for (int x = 1; ; x++)
            {
                Console.WriteLine("Anna luku" + x + ": ");
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                else
                {
                    numerot.Add(input);
                }
            }
           
            Console.WriteLine("Kaikkien lukujen summa om: " + numerot.Sum());
        }
    }


}
    

