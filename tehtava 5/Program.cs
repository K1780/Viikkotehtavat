using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_5
{
    class Program
    {
        static void Main(string[] args)
        {
            aika();
        }
        static void aika()
        {
            Console.WriteLine("Anna haluamasi sekuntimäärä :");
            int aika = int.Parse(Console.ReadLine());

            Console.WriteLine("hh:mm:ss");
            Console.WriteLine(TimeSpan.FromSeconds(aika));
        }
    }
    }

