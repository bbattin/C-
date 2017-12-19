using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// обмен строк с мин и макс значением в зубчатом массиве

namespace _20171216HW4
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            // создание массива ссылок
            int[][] data = new int[8][];

            RandInitData(data);

            Console.WriteLine("Source array");
            Print(data);

            SearchMaxFor(data, out int max, out int iMax, out int jMax);

            SearchMinFor(data, out int min, out int iMin, out int jMin);

            WriteMaxMinArray(max, iMax, jMax, min, iMin, jMax);

            Console.WriteLine("Change strings in places");

            data = ReplaceStr(data, iMax, iMin);
            
            Print(data);

            Console.ReadKey();
        }

        private static void RandInitData(int[][] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = new int[i + 1];

                for (int j = 0; j < data[i].Length; j++)
                {
                    data[i][j] = rnd.Next(0, 100);
                }
            }
        }

        private static void Print(int[][] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.Write("{0,6}", data[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // поиск максимума и его индексов в ступенчатом массиве
        private static void SearchMaxFor(int[][] arr, out int max, out int iMax1, out int iMax2)
        {
            max = arr[0][0];
            iMax1 = 0;
            iMax2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                        iMax1 = i;
                        iMax2 = j;
                    }
            }
        }

        // поиск минимума и его индексов в ступенчатом массиве
        private static void SearchMinFor(int[][] arr, out int min, out int iMin1, out int iMin2)
        {
            min = arr[0][0];
            iMin1 = 0;
            iMin2 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    if (arr[i][j] < min)
                    {
                        min = arr[i][j];
                        iMin1 = i;
                        iMin2 = j;
                    }
            }
        }

        //  вывод на экран минимума, максимума и индексов
        private static void WriteMaxMinArray(int maximum, int indMax1, int indMax2, int minimum, int indMin1, int indMin2)
        {
            Console.WriteLine("Maximum: {0}, indexs: [{1},{2}]", maximum, indMax1, indMax2);
            Console.WriteLine("Minimum: {0}, indexs: [{1},{2}]", minimum, indMin1, indMin2);
            Console.WriteLine();
        }


        private static int[][] ReplaceStr(int[][] arr, int iMax, int iMin)
        {

            int[] tmp = arr[iMax];
            arr[iMax] = arr[iMin];
            arr[iMin] = tmp;
            return arr;
        }

    }
}
