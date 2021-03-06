using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171118HW3
{
    class Program
    {
        const byte Monday = 0x01;    // 0000 0001
        const byte Tuesday = 0x02;    // 0000 0010
        const byte Wednesday = 0x04;    // 0000 0100
        const byte Thursday = 0x08;    // 0000 1000
        const byte Friday = 0x10;    // 0001 0000
        const byte Saturday = 0x20;    // 0010 0000
        const byte Sunday = 0x40;    // 0100 0000
        
        
        static void Main(string[] args)
        {
            string numberDay;
            byte day1 = 0;
            byte day2 = 0;
            ushort day = 0;
            do
            {
                day2 = (byte)(day1 | day2);
                Console.Write("Day of the week number (mon-1, tue-2, wed-3, thu-4, fri-5, sat-6, sun-7, end-other char): ");
                numberDay = Console.ReadLine();
                switch (numberDay)
                {
                    case "1":
                        day1 = Monday;
                        break;
                    case "2":
                        day1 = Tuesday;
                        break;
                    case "3":
                        day1 = Wednesday;
                        break;
                    case "4":
                        day1 = Thursday;
                        break;
                    case "5":
                        day1 = Friday;
                        break;
                    case "6":
                        day1 = Saturday;
                        break;
                    case "7":
                        day1 = Sunday;
                        break;
                    default:
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
                        day1 = Monday;
                        break;
                    case "2":
                        day1 = Tuesday;
                        break;
                    case "3":
                        day1 = Wednesday;
                        break;
                    case "4":
                        day1 = Thursday;
                        break;
                    case "5":
                        day1 = Friday;
                        break;
                    case "6":
                        day1 = Saturday;
                        break;
                    case "7":
                        day1 = Sunday;
                        break;
                    default:
                        break;
                }
                if (ushort.TryParse(numberDay, out day) && day > 0 && day < 8)
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
            while (ushort.TryParse(numberDay, out day) && day > 0 && day < 8);

            Console.Write("Exit");

            Console.ReadKey();
        }
    }
}
