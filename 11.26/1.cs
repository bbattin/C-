using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171126HW10
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

            byte schedR = ScheduleRec();
            byte schedEd = ScheduleEdit(schedR);
            Today(schedEd);
            Console.ReadKey();

        }
        
        //  функции
        
        public static byte SwitchWeek(string numberDay)
        {  
            byte day = 0;
            switch (numberDay)
                {
                    case "1":
                        day = Monday;
                        break;
                    case "2":
                        day = Tuesday;
                        break;
                    case "3":
                        day = Wednesday;
                        break;
                    case "4":
                        day = Thursday;
                        break;
                    case "5":
                        day = Friday;
                        break;
                    case "6":
                        day = Saturday;
                        break;
                    case "7":
                        day = Sunday;
                        break;
                    default:
                        break;
                }
        return day;
        }
        
        public static byte ScheduleRec()
        {
            string number;
            byte day1 = 0;
            byte day2 = 0;
            ushort day = 0;
            do
            {
                day2 = (byte)(day1 | day2);
                Console.Write("Day of the week number (mon-1, tue-2, wed-3, thu-4, fri-5, sat-6, sun-7, end-other char): ");
                number = Console.ReadLine();
                day1 = SwitchWeek(number);


            } while (ushort.TryParse(numberDay, out day) && day > 0 && day < 8);
            Console.WriteLine("Thanks, schedule recorded.");
            return day2; 
        }
        
        
        public static byte ScheduleEdit(byte day2)
        {
            string number;
            byte day1 = 0;
            ushort day = 0;
            do
            {
                day2 = (byte)(~day1 | day2);
                Console.Write("Day of the week number exclude or add (end-other char): ");
                number = Console.ReadLine();
                day1 = SwitchWeek(number);
                
            }
            while (ushort.TryParse(numberDay, out day) && day > 0 && day < 8);
            Console.Write("Exit");
            return day2;
        }

        
        public static void Today(byte day2)
        {
            string number;
            byte day1 = 0;
            ushort day = 0;
            do
            {
                Console.Write("Day of the week number today (end-other char): ");
                numberDay = Console.ReadLine();
                switch (number)
                day1 = SwitchWeek(number);
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
        }
    }

}

