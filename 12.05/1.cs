using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171206HW1
{

    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int[] arr = new int[10];

            RandomInitArray(ref arr);

            OutputArray(arr);

            WritePozNumbers(arr);

            //int i = 0;

            //WritePozNumb(arr, i);

            Console.ReadKey();

        }

        public static void RandomInitArray(ref int[] array)   //  цикл для рандома
        {
            array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-8, 8);
            }
        }
        public static void WritePozNumbers(int[] array)   //   функция на вывод сначала положительных элементов массива, после остальных
        {
            for (int i = 0; i < array.Length && array[i] > 0; i++)
            {
                Console.Write("{0} ", array[i]);
            }

                     
            Console.WriteLine();

            
        }

        public static void WritePozNumb(int[] array, int ind) //   рекурсивная функция на вывод сначала положительных элементов массива, после остальных
        {
            if (array[ind] > 0 && ind < array.Length)
            {
                Console.Write("{0} ", array[ind]);
                ind++;
                WritePozNumb(array, ind);

            }
            else
            {
                ind++;
                WritePozNumb(array, ind);

            }
            return;
        }

        private static void OutputArray(int[] array)           //  цикл вывода массива
        {
            foreach (int a in array)
                Console.Write("{0} ", a);
        }
    }
}
