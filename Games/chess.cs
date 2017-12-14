using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
 
 
namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            int xk, yk, xp, yp, xf, yf;            
            Console.WriteLine("Имитация трех фигур на поле: король(ч), пешка(ч), дамка(б).");
// Ввод короля на поле                
            Console.WriteLine("Введите координаты короля:");
            Console.Write("хk= ");
            xk = Convert.ToInt32(Console.ReadLine());// ввод и инициализация хk
            Console.Write("yk= ");
            yk = Convert.ToInt32(Console.ReadLine());// ввод и инициализация yk
            if(xk<=0 || xk>=9 || yk<=0 || yk>=9){
                Console.WriteLine("Ошибка! Фигура за полем!");
                return;
            }
// Ввод пешки на поле  
            Console.WriteLine("Введите координаты пешки:");
            Console.Write("хp= ");
            xp = Convert.ToInt32(Console.ReadLine());// ввод и инициализация хp
            Console.Write("yp= ");
            yp = Convert.ToInt32(Console.ReadLine());// ввод и инициализация yp
            if (xp <= 0 || xp >= 8 || yp <= 0 || yp >= 8) // пешка за полем или на неположеном месте?
            {
                Console.WriteLine("Ошибка! Фигура за полем!");
                return;
            }
            if (yp == 1)        // пешка стала дамкой дойдя до конца доски?
            {
                Console.WriteLine("Ошибка! Пешка стала дамкой!");
                return;
            }
            if (xp == xk && yp == yk)              // пешка на короле?
            {
                Console.WriteLine("Ошибка! Фигура на фигуре!");
                return;
            }
// Ввод дамки на поле            
            Console.WriteLine("Введите координаты дамки:");
            Console.Write("хf= ");
            xf = Convert.ToInt32(Console.ReadLine());// ввод и инициализация хf   
            Console.Write("yf= ");
            yf = Convert.ToInt32(Console.ReadLine());// ввод и инициализация yf
            if (xf <= 0 || xf >= 9 || yf <= 0 || yf >= 9) // ферзь за полем?
            {
                Console.WriteLine("Ошибка! Фигура за полем!");
                return;
            }
            if ((xf == xk && yf == yk) || (xf==xp && yf==yp) ) // ферзь на другой фигуре?
            {
                Console.WriteLine("Ошибка! Фигура на фигуре!");
                return;
            }
            Console.WriteLine("Фигуры раставлены.");
            Console.WriteLine("Король [{0},{1}], пешка [{2},{3}], дамка [{4},{5}]", xk, yk, xp, yp, xf, yf);
// -------------------------Проверка боя и вывод-----------------------------
            bool boy_korol = false, boy_peshka = false, peshka_Zkorol = false, korol_Zpeshka = false;
// Дамка под боем короля?
            if ((xk+1==xf || xk==xf || xk-1==xf) && (yk - 1 == yf || yk == yf || yk - 1 == yf))
            { 
                Console.WriteLine("Дамка находится под боем короля"); 
            }
           
// Дамка под боем пешки?
            if (yp - 1 == yf && (xp - 1 == xf || xp + 1 == xf))
            {
                Console.WriteLine("Дамка находится под боем пешки");
            }
// Король под боем дамки?            
            if ((xf == xk) || (yf == yk))      // По вертикали и горизонтали
            {
                if (((xk > xp && xk < xf) || (xk < xp && xk > xf)) ||
                    ((yk > yp && yk < yf) || (yk < yp && yk > yf)))
                {
                    korol_Zpeshka = true;  // Король под боем дамки и защищает пешку
                }
                else
                {
                    boy_korol = true; // Король под боем дамки без защиты пешки
                }
            }
            if (Math.Abs(xk - xf) == Math.Abs(yk - yf))       // По диагонялям
            {
                if (Math.Abs(xk - xf) < Math.Abs(xp - xf))
                {
                    korol_Zpeshka = true;// Король под боем дамки и защищает пешку
                }
                else
                {
                    boy_korol = true;                         // Король под боем дамки без защиты пешки
                }
            }
// Пешка под боем дамки?
            if ((xf == xp) || (yf == yp))  // По вертикали и горизонтали
            {
                if (((xp > xk && xp < xf) || (xp < xk && xp > xf)) || 
                    ((yp > yk && yp < yf) || (yp < yk && yp > yf)))
                {
                    peshka_Zkorol = true; // Пешка под боем дамки и защищает короля
                }
                else
                {
                    boy_peshka = true; // Пешка под боем дамки без защиты короля
                }
            }
            if (Math.Abs(xp - xf) == Math.Abs(yp - yf))       // По диагонялям
            {
                if (Math.Abs(xp - xf) < Math.Abs(xk - xf)) 
                {
                    peshka_Zkorol = true;// Пешка под боем дамки и защищает короля
                }else 
                {
                    boy_peshka = true;// Пешка под боем дамки без защиты короля
                }
            }
// Вывод кто под чьим боем
            
            if ((!korol_Zpeshka) && (boy_peshka)) { Console.WriteLine("Пешка находится под боем дамки"); }
            if (peshka_Zkorol) { Console.WriteLine("Пешка находится под боем дамки и защищает короля"); }
 
            if ((!peshka_Zkorol) && (boy_korol)) { Console.WriteLine("Король находится под боем дамки"); }
            if (korol_Zpeshka) { Console.WriteLine("Король находится под боем дамки и защищает пешку"); }
 
            if (!korol_Zpeshka && !boy_peshka && !peshka_Zkorol && !boy_korol) 
            {
                Console.WriteLine("Фигуры не пересекаются"); 
            }
            Console.Read();
        }
    }
}
