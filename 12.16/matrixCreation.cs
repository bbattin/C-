using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// изменение одномерного массива на двумерный

namespace _20171216HW2
{
    class Program
    {
        public static object Enviroment { get; private set; }

        static void Main(string[] args)
        {

            int arrLen = LengthArr();

            int[] vector = initVector(arrLen);

            Console.WriteLine(Environment.NewLine + "Array result: ");
            printVector(vector);

            int[,] matrix = matrixNxNfromVector(vector);

            Console.WriteLine(Environment.NewLine + "Matrix result: ");
            printMatrix(matrix);

            Console.ReadKey();
        }

        // длина массива
        private static int LengthArr()
        {
            int ArrLen = 0;

            Console.Write("Enter array lenth: ");
            var inp = Console.ReadLine();

            if (!int.TryParse(inp, out ArrLen) || ArrLen <= 0)
            {
                Console.WriteLine("Wrong number: " + inp);
                Environment.Exit(1);

            }
            return ArrLen;
        }

        
        private static int[] initVector(int len)
        {
            int[] arr = new int[len];

            for (int i = 0; i < len; i++)
            {
                arr[i] = i + 1;
            }

            return arr;
        }

        private static void printVector(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }



        private static int[,] matrixNxNfromVector(int[] arr)
        {
            // Берем корень из длины масива и округляем вверх к ближайшему целому
            // для этого приводим длину массива к double а в конце приводим к int
            int n = Convert.ToInt32(Math.Ceiling(Math.Sqrt(Convert.ToDouble(arr.Length))));

            // квадратная матрица с количеством эллементов n*n, не меньше чем в исходном массиве
            int[,] matrix = new int[n, n];

            // индексы элементов в новом массиве (матрице)
            int k = 0, j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                matrix[k, j] = arr[i];

                // если дошли до конца строки, то надо вернуться в начало и начать новую строку
                if (j == n - 1)
                {
                    k++;
                    j = 0;
                }
                else
                {
                    j++;
                }
            }

            return matrix;
        }

        private static void printMatrix(int[,] matrix)
        {
            // длина одного измерения matrix.GetLength(0)

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write(matrix[i, j]);
                    if (j < matrix.GetLength(1) - 1)
                    {
                        Console.Write(", \t");
                    }
                }
                Console.WriteLine();
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
        }

    }
}
