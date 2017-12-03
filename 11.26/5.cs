using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171126HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = WriteDays();
            ushort numberDay = GetNumberDay(d);

            Console.Write("Number: {0}", numberDay);
            Console.ReadKey();
        }

        public static string WriteDays()
        {
            Console.Write("Write the day of the week: ");
            string day = Console.ReadLine();
            day = day.ToLower();
            return day;
        }
        public static ushort GetNumberDay(string day)
        {
            ushort x;
            switch (day)
            {
                case "monday":
                case "понедельник":
                    x = 1;
                    break;
                case "tuesday":
                case "вторник":
                    x = 2;
                    break;
                case "wednesday":
                case "среда":
                    x = 3;
                    break;
                case "thursday":
                case "четверг":
                    x = 4;
                    break;
                case "friday":
                case "пятница":
                    x = 5;
                    break;
                case "saturday":
                case "суббота":
                    x = 6;
                    break;
                case "sunday":
                case "воскресенье":
                    x = 7;
                    break;
                default:
                    x = 0;
                    break;
            }
            return x;
        }
    }

}

