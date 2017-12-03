using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171126HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Enter the 5 numbers");
            double one = WriteNumber();
            double two = WriteNumber();
            double three = WriteNumber();
            double four = WriteNumber();
            double five = WriteNumber();

            double maximum;
            double minimum;
            double secondMaximum;
            double secondMinimum;

            MinMaxDouble(one, two, three, four, five, out maximum, out minimum, out secondMaximum, out secondMinimum);

            Console.WriteLine("Maximum: {0}, Minimum: {1}", maximum, minimum);
            Console.WriteLine("Second maximum: {0}, Second minimum: {1}", secondMaximum, secondMinimum);




            Console.ReadKey();
        }

        static double WriteNumber()
        {
            Console.Write("Enter the number: ");
            string number = Console.ReadLine();
            double n;
            if (double.TryParse(number, out n))
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
        static void MinMaxDouble(double one, double two, double three, double four, double five, out double max, out double min, out double max2, out double min2)
        {
            if (one >= two)
            {
                max = one;
                min = two;
                max2 = two;
                min2 = one;
            }
            else
            {
                max = two;
                min = one;
                max2 = one;
                min2 = two;
            }
            if (three > max)
            {
                max2 = max;
                max = three;
            }
            if (four > max)
            {
                max2 = max;
                max = four;
            }
            if (five > max)
            {
                max2 = max;
                max = five;
            }
            if (three < min)
            {
                min2 = min;
                min = three;
            }
            if (four < min)
            {
                min2 = min;
                min = four;
            }
            if (five < min)
            {
                min2 = min;
                min = five;
            }
           
        }
    }
}

