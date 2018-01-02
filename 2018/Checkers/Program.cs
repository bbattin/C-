using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldX = Console.CursorLeft;
            int oldY = Console.CursorTop;

            int xA = 5;
            int xB = 8;
            int xC = 11;
            int xD = 14;
            int xE = 17;
            int xF = 20;
            int xG = 23;
            int xH = 26;

            int y8 = 2;
            int y7 = 3;
            int y6 = 4;
            int y5 = 5;
            int y4 = 6;
            int y3 = 7;
            int y2 = 8;
            int y1 = 9;

            // первая строка
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xA, y8);
            Console.BackgroundColor = ConsoleColor.Black;
            string black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xB, y8);
            Console.BackgroundColor = ConsoleColor.White;
            string white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xC, y8);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xD, y8);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xE, y8);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xF, y8);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xG, y8);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xH, y8);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            
            // вторая строка

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xA, y7);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xB, y7);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xC, y7);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xD, y7);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xE, y7);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xF, y7);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xG, y7);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xH, y7);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            // третья строка
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xA, y6);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xB, y6);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xC, y6);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xD, y6);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xE, y6);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xF, y6);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xG, y6);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xH, y6);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            // четвертая строка
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xA, y5);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xB, y5);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xC, y5);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xD, y5);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xE, y5);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xF, y5);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xG, y5);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xH, y5);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            // пятая строка
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xA, y4);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xB, y4);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xC, y4);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xD, y4);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xE, y4);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xF, y4);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xG, y4);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xH, y4);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            // шестая строка
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xA, y3);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xB, y3);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xC, y3);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xD, y3);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xE, y3);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xF, y3);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xG, y3);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xH, y3);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            // седьмая строка
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xA, y2);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xB, y2);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xC, y2);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xD, y2);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xE, y2);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xF, y2);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xG, y2);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xH, y2);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            // восьмая строка
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xA, y1);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xB, y1);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xC, y1);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xD, y1);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xE, y1);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xF, y1);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xG, y1);
            Console.BackgroundColor = ConsoleColor.White;
            white = "-";
            Console.Write("{0,3}", white);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(xH, y1);
            Console.BackgroundColor = ConsoleColor.Black;
            black = "+";
            Console.Write("{0,3}", black);


            Console.ReadKey();
        }
    }
}
