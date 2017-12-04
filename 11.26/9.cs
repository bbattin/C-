using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  расписание с использованием битовых енамов

namespace _20171126HW9
{
    class Program
    {
        [Flags]
    enum MultyDaysWeek : byte
    {
        NoDay = 0x00,
        Monday = 0x01,
        Tuesday = 0x02,
        Wednesday = 0x04,
        Thursday = 0x08,
        Friday = 0x10,
        Saturday = 0x20,
        Sunday = 0x40,
        LastDaysValue = 0x80
    }
        static void Main(string[] args)
        {
            string numDay;
            MultyDaysWeek day1 = 0;
            MultyDaysWeek day2 = 0;
            ushort day = 0;
            do
            {
                day2 = day1 | day2;
                numDay = WriteDay();
                day1 = GetDayOfWeekEnum(numDay);
                

            } while (ushort.TryParse(numDay, out day) && day > 0 && day < 8);

            Console.WriteLine("Thanks, schedule recorded.");

            do
            {
                numDay = WriteDay();
                day1 = GetDayOfWeekEnum(numDay);

                if (ushort.TryParse(numDay, out day) && day > 0 && day < 8)
                {
                    if ((day1 & day2) == day1)
                    {
                        Console.WriteLine("Today");
                    }
                    else
                    {

                        Console.WriteLine("Not today");

                    }
                }
                else
                {
                    break;
                }
            }
            while (ushort.TryParse(numDay, out day) && day > 0 && day < 8);

            Console.Write("Exit");

            Console.ReadKey();


        }
        public static MultyDaysWeek GetDayOfWeekEnum(string numberDay)
        {
            MultyDaysWeek day = 0;
            switch (numberDay)
            {
                case "1":
                    day = MultyDaysWeek.Monday;
                    break;
                case "2":
                    day = MultyDaysWeek.Tuesday;
                    break;
                case "3":
                    day = MultyDaysWeek.Wednesday;
                    break;
                case "4":
                    day = MultyDaysWeek.Thursday;
                    break;
                case "5":
                    day = MultyDaysWeek.Friday;
                    break;
                case "6":
                    day = MultyDaysWeek.Saturday;
                    break;
                case "7":
                    day = MultyDaysWeek.Sunday;
                    break;
                default:
                    break;
            }
            return day;
        }

        public static string WriteDay()
        {
            Console.Write("Day of the week number today (end-other char): ");
            string n = Console.ReadLine();
            return n;
        }
    }
}
