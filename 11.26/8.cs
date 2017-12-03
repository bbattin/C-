using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171126HW8
{
    class Program
    {
        enum Week : ushort
    {
        NoDay = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
        LastDaysValue = 8
    }
        
        static void Main(string[] args)
        {

            Week day = 0;

            do
            {
                day = WriteEnumDay();
                Console.WriteLine("day = {0}, (int)day = {1}", day, (int)day);

            } while (day < Week.LastDaysValue);

            Console.WriteLine("Error input");

            Console.ReadKey();
        }
        public static Week WriteEnumDay()
        {
            Week d = 0;
            Console.Write("Day of the week number or name: ");
            string sDay = Console.ReadLine();
            Enum.TryParse(sDay, out d);
            return d;
        }
    }
}
