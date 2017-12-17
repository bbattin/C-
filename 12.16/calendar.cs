using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171216HW
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherCondition[][] year = GetYearWeather();

            
        }


        public static WeatherCondition[][] GetYearWeather()
        {
            // количество дней в месяцах
            int[] numDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            WeatherCondition[][] year = new WeatherCondition[numDays.Length][];

            // выделяем память для подмассивов
            for (int i = 0; i < numDays.Length; i++)
            {
                year[i] = new WeatherCondition[numDays[i]];
            }

            return year;
        }
    }
}
