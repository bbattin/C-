using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOutputTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Field Pole = new Field();
            Pole.Print();

            Console.ReadKey();
        }
    }

    public enum CellColor
    {
        White,
        Black,
    }

    public enum FigureState
    {
        White, WhiteQueen,
        Black, BlackQueen,
    }


    public struct Figure
    {
        public int x, y;
        public FigureState State;
    }

    public class Cell
    {
        public CellColor Color;
        public Figure Fig;
    }

    public class Field
    {

        Cell[,] Cells;

        Figure[] WhiteFigs = new Figure[12];
        Figure[] BlackFigs = new Figure[12];
        
        // конструктор
        public Field()
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

                            // устанавливаем связь фигуры с клекой
                            OneCell.Fig = NewFig;

                            BlackFigs[iBlack] = NewFig;
                            iBlack++;

                        }

                    }
                    Cells[i, j] = OneCell;
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // белые
                    if (Cells[i, j].Color == CellColor.White)
                    {
                        // PrintWhite(Field[i, j]);
                    }
                    else
                    {
                        // PrintBlack(Field[i, j]);
                    }
                }
            }
        }

    }
}
