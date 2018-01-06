using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Program
    {
        const int sizeCell = 3;
        const int xConst = 5;
        const int yConst = 2;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            int oldX = Console.CursorLeft;
            int oldY = Console.CursorTop;

            //UI.PrintField(xConst, yConst, sizeCell);

            //UI.PrintWhiteChec(xConst, yConst + 3);

            //UI.PrintBlackChec(xConst + 9, yConst);

            //UI.PrintBlackKing(xConst + 15, yConst + 12);

            //UI.PrintWhiteKing(xConst + 9, yConst + 12);

            //UI.PrintSelect(xConst + 6, yConst + 3, sizeCell);

            Board Pole = new Board();
            Pole.PrintCells();

            Board Figs = new Board();
            Figs.PrintFigs();


            Console.ReadKey();
        }
    }
}
