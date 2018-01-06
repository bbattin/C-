using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Board
    {

        Cell[,] Cells;

        Figure[] WhiteFigs = new Figure[12];
        Figure[] BlackFigs = new Figure[12];

        // конструктор
        public Board()
        {
            Init();
        }

        public void Init()
        {
            int iWhite = 0;
            int iBlack = 0;

            // создание массива
            Cells = new Cell[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Cell OneCell = new Cell();
                    OneCell.x = i;
                    OneCell.y = j;

                    // белые
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                    {
                        OneCell.Color = CellColor.White;
                    }
                    else
                    {
                        OneCell.Color = CellColor.Black;
                        // расставляем фигуры - белые вверху
                        if (j < 3)
                        {
                            Figure NewFig = new Figure();
                            NewFig.x = i;
                            NewFig.y = j;
                            NewFig.State = FigureState.White;

                            // устанавливаем связь фигуры с клекой
                            OneCell.Fig = NewFig;

                            WhiteFigs[iWhite] = NewFig;
                            iWhite++;
                        }

                        // тут черные
                        if (j > 4)
                        {
                            Figure NewFig = new Figure();
                            NewFig.x = i;
                            NewFig.y = j;
                            NewFig.State = FigureState.Black;

                            // устанавливаем связь фигуры с клеткой
                            OneCell.Fig = NewFig;

                            BlackFigs[iBlack] = NewFig;
                            iBlack++;

                        }

                    }
                    Cells[i, j] = OneCell;

                }
            }
        }

       

        public void PrintWhite(Cell OneCell)
        {
            PrintOneCell(OneCell, ConsoleColor.Gray);
        }

        public void PrintBlack(Cell OneCell)
        {
            PrintOneCell(OneCell, ConsoleColor.DarkGray);
        }

        const int sizeCell = 3;
        const int xConst = 5;
        const int yConst = 3;

        public void PrintOneCell(Cell OneCell, ConsoleColor Col)
        {
            for (int i = 0; i < sizeCell; i++)
            {
                for (int j = 0; j < sizeCell; j++)
                {
                    int xout = xConst + OneCell.x * sizeCell;
                    int yout = yConst + OneCell.y * sizeCell;
                    Console.BackgroundColor = Col;
                    Console.SetCursorPosition(xout + j, yout + i);
                    Console.Write(" ");
                }
            }
        }

        public void PrintCells()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // белые
                    if (Cells[i, j].Color == CellColor.White)
                    {
                        PrintWhite(Cells[i, j]); 
                    }
                    else
                    {
                        PrintBlack(Cells[i, j]); 
                    }
                }
            }
        }

        public void PrintOneFigure(Figure OneFig, ConsoleColor ColFig)
        {
            
                    int xout = xConst + OneFig.x * sizeCell;
                    int yout = yConst + OneFig.y * sizeCell;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ColFig;
                    Console.SetCursorPosition(xout + 1, yout + 1);
                    Console.Write("O");
             
        }

        public void PrintWhiteFig(Figure OneFig)
        {
            PrintOneFigure(OneFig, ConsoleColor.White);
        }

        public void PrintBlackFig(Figure OneFig)
        {
            PrintOneFigure(OneFig, ConsoleColor.Black);
        }

        public void PrintFigs()
        {
            for (int i = 0; i < 12; i++)
            {
                PrintWhiteFig(WhiteFigs[i]);
                PrintBlackFig(BlackFigs[i]);
                        
            }
        }


    }
}
