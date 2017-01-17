using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jesse Luotio
namespace tehtava_6
{
    class Program
    {
        static void Main(string[] args)
        {
            kulutus();
            Console.ReadLine();
        }
        static void kulutus()
        {
            Console.WriteLine("Anna matkasi pituus :");
            int matka = int.Parse(Console.ReadLine());

            double kulutus = ((matka / 100) * 7.02);
            double hinta = (kulutus * 1.595);

            Console.WriteLine("Bensaa kuluu " + kulutus + " litraa ja bensa maksoi " + hinta + " euroa");
        }
      
        
    }
    
}
