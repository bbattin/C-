using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  подсчет количества нулей и единиц в двоичной версии десятичного числа, введенного пользователем

namespace _20171126HW6
{
    class Program
    {
        

        static void Main(string[] args)

        {
            int N = WriteN();

            string s = Convert.ToString(N, 2);

            
            int one = 0;
            int zero = 0;

            ZeroAndUnits(N, ref one, ref zero);

            Console.WriteLine("Number: {0}, amount of units: {1}, amount of zeros: {2}", s, one, zero);

            Console.ReadKey();
        }

        public static int WriteN()
        {
            Console.Write("Enter the number: ");
            string number = Console.ReadLine();
            int n;
            if (int.TryParse(number, out n))
            {
                Console.WriteLine("Ok");
                return n;
            }
            else
            {
                Console.WriteLine("Error. Not a number. Recorded 0");
                return 0;

            }

        }
        
        public static void ZeroAndUnits(int number, ref int odin, ref int nolik)
        {
            do
            {
                if ((number & 0x01) > 0)
                    odin++;
                else
                    nolik++;
                //после этого делаем сдвиг вправо 
                number >>= 1;
            } while (number > 0);
        }
    }
}

