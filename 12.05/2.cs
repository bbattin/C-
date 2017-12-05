using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  //   поиск минимума и максимума массива, смена их местами
  //   проверка массива на зеркальность относительно центра

namespace _20171204HW2
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            {   
                
                int[] arr = new int[15];

                RandomInitArray(ref arr);

                OutputArray(arr);
                             
                int max = arr[0];
                int min = arr[0];
                int iMax = 0;
                int iMin = 0;

                SearchMaxFor(arr, ref max, ref iMax);
                SearchMinFor(arr, ref min, ref iMin);

                WriteMaxMinArray(max, iMax, min, iMin);

                ReplaceInd(arr, ref iMax, ref iMin);

                OutputArray(arr);
                
                Console.ReadKey();
            }

        }
        private static void RandomInitArray(ref int[] array)   //  цикл для рандома
        {
            array = new int[15];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 100);
            }
        }

        private static void OutputArray(int[] array)           //  цикл вывода массива
        {
            foreach (int a in array)
            Console.Write("{0} ", a);
        }

        private static int SearchMaxForeach(int[] array)       // цикл foreach для поиска максимума
        {
            int max = array[0];
            foreach (int a in array)          
                if (a > max)
                    max = a;
            return max;
        }

        private static int SearchMinForeach(int[] array)       // цикл foreach для поиска минимума
        {
            int min = array[0];
            foreach (int b in array)         
                if (b < min)
                    min = b;
            return min;
        }

        private static void SearchMaxFor(int[] array, ref int maximum, ref int indMax)       // цикл for для поиска максимума и его индекса
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] > maximum)
                {
                    maximum = array[i];
                    indMax = i;
                }
        }

        private static void SearchMinFor(int[] array, ref int minimum, ref int indMin)       // цикл for для поиска минимума и его индекса
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] < minimum)
                {
                    minimum = array[i];
                    indMin = i;
                }
        }

        private static void WriteMaxMinArray(int maximum, int indMax, int minimum, int indMin)   //  вывод на экран минимума, максимума и индексов
        {
            Console.WriteLine();
            Console.WriteLine("Maximum: {0}, index: {1}", maximum, indMax);
            Console.WriteLine("Minimum: {0}, index: {1}", minimum, indMin);
        }

        private static void ReplaceInd(int[] array, ref int indMax, ref int indMin)       // смена элементов местами
        {
            int tmp = array[indMax];
            array[indMax] = array[indMin];
            array[indMin] = tmp;
        }

    }
}
