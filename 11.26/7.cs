using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  умножение с помощью битовых сдвигов

namespace _20171126HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint one = WriteNUint();
            uint two = WriteNUint();

            uint rezultFirst = SimpleMult(one, two);

            uint rezultSecond = ShiftsMult(one, two);

            Console.WriteLine("first*second = {0}, shifts: {1}", rezultFirst, rezultSecond);

                Console.ReadKey();
        }

        public static uint WriteNUint()
        {
            Console.Write("Enter the number: ");
            string number = Console.ReadLine();
            uint n;
            if (uint.TryParse(number, out n))
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

        public static uint SimpleMult(uint a, uint b)
        {
            uint c = a * b;
            
            return c;
        }

        public static uint ShiftsMult(uint a, uint b)
        {
            uint c = 0;
            do
            {
                
                if ((a & 1) > 0)
                    c += b;

                b <<= 1;
                a >>= 1;

            } while (a > 0);
            return c;
        }
    }
    
}
