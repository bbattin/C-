using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171111_HW2
{
    class Program
    {
        static void Main(string[] args)
        
            {
                Console.Write("Number: ");
                string number = Console.ReadLine();
                int N;
                if (int.TryParse(number, out N))
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Not a number!");
                    Console.Write("Number: ");

                    number = Console.ReadLine();
                    if (int.TryParse(number, out N))
                    {
                        Console.WriteLine("Ok");
                    }
                    else
                    {

                        return;
                    }
                }

            string s = Convert.ToString(N, 2);

            // первый вариант
            int odin = 0;
            int nolik = 0;
            
            do
            {
                if ((N & 0x01) == 0x01)
                    odin++;
                else
                    nolik++;
                //после этого делаем сдвиг вправо 
                N >>= N;
            } while (N > 0);

            

            // второй вариант

            //int c = N - 1;
            //int count = 0; //количество бит равных 1
            //for (int i = 0; i < c; i++)
            //{
            //  if ((N >> i) % 2 == 1)
            //    count++;
            //}


            Console.WriteLine("number: {0}, amount of units: {1}", s, N);
            Console.ReadKey();
            }
        }
    }

