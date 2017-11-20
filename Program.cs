using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20171118HW1

{
    class Program
    {
        

        static void Main(string[] args)
        {

            Week day;
            string sDay;
            
            do
            {
                Console.Write("Day of the week number or name: ");
                sDay = Console.ReadLine();
                Enum.TryParse(sDay, out day);
                Console.WriteLine("day = {0}, (int)day = {1}", day, (int)day);

            } while (Enum.TryParse(sDay, out day) && (day < Week.LastDaysValue));

            Console.WriteLine("Error input");

            Console.ReadKey();
        }
    }
}
