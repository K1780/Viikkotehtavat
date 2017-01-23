using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_14
{
    class Program
    {
        static void Main(string[] args)
        {
            arvostelu();
        }
        static void arvostelu()
        {
            List<int> arvostelu = new List<int>();
            int input = new int();
             
            

            Console.WriteLine("Anna arvosana 1-5. Anna 6 tai suurempi luku niin ohjelma lopettaa ");

            for (int x = 0; ; x++)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    arvostelu.Add(input);
                }
                else if (input == 1)
                {
                    arvostelu.Add(input);
                }
                else if (input == 2)
                {
                    arvostelu.Add(input);
                }
                else if (input == 3)
                {
                    arvostelu.Add(input);
                }
                else if (input == 4)
                {
                    arvostelu.Add(input);
                }
                else if (input == 5)
                {
                    arvostelu.Add(input);
                }
                else if (input > 5)
                {
                    break;
                }
            }
                int nollat = arvostelu.Count(x => x == 0);

                int ykköset = arvostelu.Count(x => x == 1);

                int kakkoset = arvostelu.Count(x => x == 2);

                int kolmoset = arvostelu.Count(x => x == 3);

                int neloset = arvostelu.Count(x => x == 4);

                int vitoset = arvostelu.Count(x => x == 5);

                
                Console.WriteLine("Oppilas pistemäärällä  0: " + String.Concat(Enumerable.Repeat("*", nollat)));

                Console.WriteLine("Oppilas pistemäärällä 1: " + String.Concat(Enumerable.Repeat("*", ykköset)));

                Console.WriteLine("Oppilas pistemäärällä 2: " + String.Concat(Enumerable.Repeat("*", kakkoset)));

                Console.WriteLine("Oppilas pistemäärällä 3: " + String.Concat(Enumerable.Repeat("*", kolmoset)));

                Console.WriteLine("Oppilas pistemäärällä 4: " + String.Concat(Enumerable.Repeat("*", neloset)));

                Console.WriteLine("Oppilas pistemäärällä 5: " + String.Concat(Enumerable.Repeat("*", vitoset)));
            }
        }
        }
    
