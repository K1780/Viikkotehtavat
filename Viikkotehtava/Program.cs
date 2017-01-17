using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jesse Luotio
namespace Viikkotehtava
{
    class Program
    {
        static void Main(string[] args)
        {
            luvutsanoiksi();
        }
        //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".

       

            static void luvutsanoiksi()
        {

                Console.WriteLine("Anna luku 1,2 tai 3 :");
                int number = Int32.Parse(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("Yksi");
                }
                else if (number == 2)
                {
                    Console.WriteLine("Kaksi");
                }
                else if (number == 3)
                {
                    Console.WriteLine("Kolme");
                }
                else
                {
                    Console.WriteLine("Joku muu luku");
                }

            }

        }
        }
    


