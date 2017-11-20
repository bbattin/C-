using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20171118HW2
    
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

{
    class Program
    {
        

        static void Main(string[] args)
       {
            string numberDay;
            MultyDaysWeek day1 = 0;
            MultyDaysWeek day2 = 0;
            ushort day = 0;
            do
            {
                day2 = day1 | day2;
                Console.Write("Day of the week number (mon-1, tue-2, wed-3, thu-4, fri-5, sat-6, sun-7, end-other char): ");
                numberDay = Console.ReadLine();
                switch (numberDay)
                {
                    case "1":
                        day1 = MultyDaysWeek.Monday;
                        break;
                    case "2":
                        day1 = MultyDaysWeek.Tuesday;
                        break;
                    case "3":
                        day1 = MultyDaysWeek.Wednesday;
                        break;
                    case "4":
                        day1 = MultyDaysWeek.Thursday;
                        break;
                    case "5":
                        day1 = MultyDaysWeek.Friday;
                        break;
                    case "6":
                        day1 = MultyDaysWeek.Saturday;
                        break;
                    case "7":
                        day1 = MultyDaysWeek.Sunday;
                        break;
                    default:
                        day1 = MultyDaysWeek.NoDay;
                        break;
                }

            } while (ushort.TryParse(numberDay, out day) && day > 0 && day < 8);

            Console.WriteLine("Thanks, schedule recorded.");

            do
            {
                Console.Write("Day of the week number today (end-other char): ");
                numberDay = Console.ReadLine();
                switch (numberDay)
                {
                    case "1":
                        day1 = MultyDaysWeek.Monday;
                        break;
                    case "2":
                        day1 = MultyDaysWeek.Tuesday;
                        break;
                    case "3":
                        day1 = MultyDaysWeek.Wednesday;
                        break;
                    case "4":
                        day1 = MultyDaysWeek.Thursday;
                        break;
                    case "5":
                        day1 = MultyDaysWeek.Friday;
                        break;
                    case "6":
                        day1 = MultyDaysWeek.Saturday;
                        break;
                    case "7":
                        day1 = MultyDaysWeek.Sunday;
                        break;
                    default:
                        day1 = MultyDaysWeek.NoDay;
                        break;
                }
                if ((day1 & day2) == day1)
                {
                    Console.WriteLine("Today");
                }
                else
                {
                    Console.WriteLine("Not today");
                }
            }
            while (ushort.TryParse(numberDay, out day) && day > 0 && day < 8);

            Console.ReadKey();


        }
    }
}
