using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   использование рекурсивной функции на вывод сначала положительных элементов массива, после остальных

namespace _20171206HW1
{

    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int[] arr = new int[15];

            RandomInitArray(ref arr);

            Console.Write("Entire array: ");
            OutputArray(arr);
            Console.WriteLine();
            
            Console.Write("First positive, after other:: ");
            int i = 0;
            WritePozNumb(arr, i);

            Console.ReadKey();

        }

        //  цикл для рандома
        public static void RandomInitArray(ref int[] array)   
        {
            array = new int[15];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }
        }
        
        //   рекурсивная функция на вывод сначала положительных элементов массива, после остальных
        private static void WritePozNumb(int[] arr, int i) 
        {

            if (i < arr.Length)
            {
                int numb = arr[i];
                if (numb > 0)
                {
                    Console.Write("{0} ", numb);

                }

                i++;
                WritePozNumb(arr, i);
                

                if (numb <= 0)
                {
                    Console.Write("{0} ", numb);
                }
            }
            return;

        }

        //  цикл вывода массива
        private static void OutputArray(int[] array)           
        {
            foreach (int a in array)
                Console.Write("{0} ", a);
        }
    }
}
