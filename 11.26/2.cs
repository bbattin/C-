using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171126HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldX = Console.CursorLeft;
            int oldY = Console.CursorTop;

            int z = 5;
            int k = 2;
            Square(z, k);
            
            z = 20;
            k = 2;
            TriangleBroken(z, k);

            z = 55;
            k = 2;
            Triangle(z, k);

            z = 70;
            k = 2;
            Trapeze(z, k);


            Console.SetCursorPosition(oldX, oldY);
            Console.ResetColor();
            Console.ReadKey();
        }

        //   functions

        public static void Square(int x, int y)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write('+');
                }
            }

        }
        public static void TriangleBroken(int x,int y)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i * 2 + 1; j > 0; j--)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(x + j * 3, y + i);
                    Console.Write('*');
                }
            }

        }
        public static void Triangle(int x, int y)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i * 2 + 1; j > 0; j--)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write('*');
                }
            }
        }
        public static void Trapeze(int x, int y)
        {
            for (int i = 4; i >= 0; --i)
            {
                for (int j = 11 - i; j > 0; --j)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write('*');
                }
            }
        }
    }
}

