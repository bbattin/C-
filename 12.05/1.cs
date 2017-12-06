using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171204HW1
{
    
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int[] arr = new int[10];

            RandomInitArray(ref arr);
                        
            List<Int32> Ch = new List<Int32>();
            for (int i = 0; i < arr.Count(); i++)
            {
                if (i % 2 == 0 && arr[i] > 0)
                {
                    Ch.Add(arr[i]);
                }
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine('\n');
            Console.WriteLine(string.Join(" ", Ch));
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
    }
}
