using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   проверка массива на зеркальность относительно центра 

namespace _20171210HW2._2
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int[] arr = new int[10];

            RandomInitArray(ref arr);

            OutputArray(arr);

            Console.WriteLine();

            SpecularArr(arr);

            Console.ReadKey();
        }

        //  цикл для рандома

        public static void RandomInitArray(ref int[] array)   
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 4);
            }
        }

        //  цикл вывода массива

        private static void OutputArray(int[] array)           
        {
            foreach (int a in array)
                Console.Write("{0} ", a);
        }

        //  цикл для проверки зеркальности массива относительно центра

        public static void SpecularArr(int[] arr)   
        {
            int k = 0;
            int i = arr.Length - 1;
            
            Console.WriteLine("Specularity");
            do
            {
                if (arr[k]==arr[i])
                {
                    Console.Write("[{0}={1} yes] ", arr[k], arr[i]);
                }
                else
                {
                    Console.Write("[{0}={1} no] ", arr[k], arr[i]);
                }
                k++;
                i--;
            } while ((k<=(arr.Length - 1)/2) && (k != i));

        }

    }

}
