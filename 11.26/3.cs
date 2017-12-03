using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171126HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 10;
            int b1 = 20;
            int c1 = 30;
            WriteValue(a1, b1, c1);
            ReplaceValues(ref a1, ref b1, ref c1);
            WriteValue(a1, b1, c1);

            Console.ReadKey();

        }
        public static void ReplaceValues(ref int a, ref int b, ref int c)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            c = c + a;
            a = c - a;
            c = c - a;
        }
        public static void WriteValue(int a, int b, int c)
        {
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
        }
    }
}
