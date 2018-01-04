using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class UI
    {
        public static void PrintWhiteCell(int x, int y, int size)
        {

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write(" ");
                }

            }
        }

        public static void PrintGrayCell(int x, int y, int size)
        {

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write(" ");
                }

            }
        }

        public static void PrintField(int x, int y, int size)
        {

            for (int i = 0; i < 8; i++) // столбцы
            {
                for (int j = 0; j < 8; j++) // строки
                {
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 1)
                        {
                            PrintWhiteCell(x + i * size, y + j * size, size);
                        }
                        else
                        {
                            PrintGrayCell(x + i * size, y + j * size, size);
                        }

                    }
                    else
                    { // нечетное
                        if (j % 2 == 1)
                        {
                            PrintGrayCell(x + i * size, y + j * size, size);
                        }
                        else
                        {
                            PrintWhiteCell(x + i * size, y + j * size, size);
                        }

                    }
                }

            }

        }

        public static void PrintWhiteChec(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write("O");

        }

        public static void PrintBlackChec(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write("O");

        }

        public static void PrintWhiteKing(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write("D");

        }

        public static void PrintBlackKing(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write("D");

        }

        public static void PrintSelect(int x, int y, int size)
        {

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write(" ");
                }

            }
        }


    }
}
