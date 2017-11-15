using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171111_HW
{
    class Program
    {
        const byte MASK_01 = 0x01;    // 0000 0001
        const byte MASK_02 = 0x02;    // 0000 0010
        const byte MASK_04 = 0x04;    // 0000 0100
        const byte MASK_08 = 0x08;    // 0000 1000
        const byte MASK_10 = 0x10;    // 0001 0000
        const byte MASK_20 = 0x20;    // 0010 0000
        const byte MASK_40 = 0x40;    // 0100 0000
        const byte MASK_80 = 0x80;    // 1000 0000

        static void Main(string[] args)
        {
            Console.Write("day of the week today: ");
            string day = Console.ReadLine();
            day = day.ToLower();
            Console.WriteLine(day);
            short x;
            switch (day)
            {
                case "monday":
                case "понедельник":
                    x = MASK_01;
                    break;
                case "tuesday":
                case "вторник":
                    x = MASK_02;
                    break;
                case "wednesday":
                case "среда":
                    x = MASK_04;
                    break;
                case "thursday":
                case "четверг":
                    x = MASK_08;
                    break;
                case "friday":
                case "пятница":
                    x = MASK_10;
                    break;
                case "saturday":
                case "суббота":
                    x = MASK_20;
                    break;
                case "sunday":
                case "воскресенье":
                    x = MASK_40;
                    break;
                default:
                    Console.Write("Error");
                    break;
            }
            if (x & MASK_80)
            {
                Console.Write("Today");
            }
            else
            {
                Console.Write("Not today");
            }
            
            Console.ReadKey();
        }

    }
}
