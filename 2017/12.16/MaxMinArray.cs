using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// поменять местами максимум и минимум в двумерном массиве
// поменять местами строки с максимум и минимумом
// поменять столбцы местами

namespace _20171216HW3
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            {

                int[,] arr = new int[4, 4];

                RandInitMatr(arr);

                Console.WriteLine("Source array");

                PrintMatr(arr);
                
                SearchMaxFor(arr, out int max, out int iMax, out int jMax);

                SearchMinFor(arr, out int min, out int iMin, out int jMin);

                WriteMaxMinArray(max, iMax, jMax, min, iMin, jMax);

                ReplaceInd(arr, ref iMax, ref iMin, ref jMax, ref jMin);

                Console.WriteLine("Change items in places");
                PrintMatr(arr);

                arr = ReplaceStrI(arr, iMax, iMin);

                Console.WriteLine("Change strings in places");
                PrintMatr(arr);

                arr = ReplaceColI(arr, iMax, iMin);

                Console.WriteLine("Change columns in places");
                PrintMatr(arr);

                Console.ReadKey();
            }

        }
        private static void RandInitMatr(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = rand.Next(0, 100);
                }
            }
        }

        private static void PrintMatr(int[,] matr)
        {
            
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write("{0,5}", matr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // поиск максимума и его индексов в матрице
        private static void SearchMaxFor(int[,] arr, out int max, out int indMax1, out int indMax2)       
        {
            max = arr[0, 0];
            indMax1 = 0;
            indMax2 = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        indMax1 = i;
                        indMax2 = j;
                    }
            }
        }

        // поиск минимума и его индексов в матрице
        private static void SearchMinFor(int[,] arr, out int min, out int indMin1, out int indMin2)
        {
            min = arr[0, 0];
            indMin1 = 0;
            indMin2 = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        indMin1 = i;
                        indMin2 = j;
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

        // смена элементов местами
        private static void ReplaceInd(int[,] array, ref int iMax, ref int iMin, ref int jMax, ref int jMin)       
        {
            int tmp = array[iMax, jMax];
            array[iMax, jMax] = array[iMin, jMin];
            array[iMin, jMin] = tmp;

        }
        // смена строк с элементами местами
        private static int[,] ReplaceStrI(int[,] arr, int iMax, int iMin)
        {
            
            int[] tempmas = new int[4];

            // заносим минимальную строку во временный массив
            for (int i = iMin, j = 0, k = 0; j < 4; j++, k++)
            {
                tempmas[k] = arr[i, j];
            }

            // заменяем минимальную строку максимальной
            for (int j = 0; j < 4; j++)
            {
                arr[iMin, j] = arr[iMax, j];
            }
            
            // заменяем максимальную строку минимальной
            for (int j = 0; j < 4; j++)
            {
                arr[iMax, j] = tempmas[j];
            }
            return arr;
        }

        // смена столбцов с элементами местами
        private static int[,] ReplaceColI(int[,] arr, int jMax, int jMin)
        {

            int[] tempmas = new int[4];

            // заносим минимальный столбец во временный массив
            for (int i = 0, j = jMin, k = 0; i < 4; i++, k++)
            {
                tempmas[k] = arr[i, j];
            }

            // заменяем минимальный столбец максимальным
            for (int i = 0; i < 4; i++)
            {
                arr[i, jMin] = arr[i, jMax];
            }

            // заменяем максимальный столбец минимальным
            for (int i = 0; i < 4; i++)
            {
                arr[i, jMax] = tempmas[i];
            }
            return arr;
        }

    }
}

