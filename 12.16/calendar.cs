using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// погода на год

namespace _20171216HW
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            WeatherCondition[][] year = GetYearWeather();

            Print(year);

            Console.ReadKey();
        }


        public static WeatherCondition[][] GetYearWeather()
        {
            // массивы с разными состояниями погоды
            WeatherCondition[] Sun = new WeatherCondition[2] { WeatherCondition.Sunny, WeatherCondition.PartlyCloudy };
            WeatherCondition[] Precipitation = new WeatherCondition[4] { WeatherCondition.Rain, WeatherCondition.Snow, WeatherCondition.Grad, WeatherCondition.NoPrecipitation };
            WeatherCondition[] Wind = new WeatherCondition[3] { WeatherCondition.WithoutWind, WeatherCondition.LightWind, WeatherCondition.StrongWind };
            WeatherCondition[] Temperature = new WeatherCondition[6] { WeatherCondition.Hot, WeatherCondition.Cold, WeatherCondition.Heat, WeatherCondition.BitCold, WeatherCondition.ExtremelyCold, WeatherCondition.ExtremelyHot };
            // индексы элементов массивов с енамами
            int iSun = 0;
            int iPrec = 0;
            int iWind = 0;
            int iTemp = 0;

            // количество дней в месяцах
            int[] numDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            

            WeatherCondition[][] year = new WeatherCondition[numDays.Length][];

            // выделяем память для подмассивов и заполняем енамами рандомно
            for (int i = 0; i < numDays.Length; i++)
            {
                year[i] = new WeatherCondition[numDays[i]];
                for (int j = 0; j < year[i].Length; j++)
                {
                    iSun = rand.Next(0, 1);
                    iPrec = rand.Next(0, 3);
                    iWind = rand.Next(0, 2);
                    iTemp = rand.Next(0, 5);

                    year[i][j] = Precipitation[iPrec] & Sun[iSun] & Wind[iWind] & Temperature[iTemp];
                }
            }

            return year;
        }


        private static void Print(WeatherCondition[][] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.Write("{0,6}", data[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
