using System;
using System.Collections.Generic;

//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
// а) Сделать меню с различными функциями и представить пользователю выбор, 
//для какой функции и на каком отрезке находить минимум. 
//Использовать массив (или список) делегатов, в котором хранятся различные функции.
// б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
//Пусть она возвращает минимум через параметр (с использованием модификатора out).

namespace lev1les6t2
{
    public class CMenu
    {
        public static void ConsoleMenu(Dictionary<string, Fx> Dict, out FuncData FF)
        {
            Fx f;
            int n = Dict.Count;
            double x1;
            double x2;
            double dx;
            string strF;
            string StrMenu = MDict.Tostr(Dict);
            Console.WriteLine("Программа поиска минимума функции.");
            while (true)
            {
                System.Console.Write("Выберите одну из предложенных функций ");
                System.Console.Write($"{StrMenu}");
                if (int.TryParse(Console.ReadLine(), out int ans) && ans >= 0 && ans <= n - 1)
                {
                    f = MDict.GetFxById(Dict, ans);
                    strF = MDict.GetFstrById(Dict, ans);
                    break;
                }
            }
            x1 = GetXmin();
            x2 = GetXmax(x1);
            dx = Getdx(x1, x2);
            FF = new FuncData(f, x1, x2, dx, strF);
        }

        private static double Getdx(double x1, double x2)
        {
            double dx;
            while (true)
            {
                System.Console.Write("шаг: ");
                if (double.TryParse(Console.ReadLine(), out double result) && result <= (x2 - x1) / 2)
                {
                    dx = result;
                    break;
                }
            }
            return dx;
        }

        private static double GetXmax(double x1)
        {
            double x2;
            while (true)
            {
                System.Console.Write("х_max: ");
                if (double.TryParse(Console.ReadLine(), out double result) && result > x1)
                {
                    x2 = result;
                    break;
                }
            }
            return x2;
        }

        private static double GetXmin()
        {
            double x1;
            while (true)
            {
                System.Console.Write("х_min: ");
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    x1 = result;
                    break;
                }
            }
            return x1;
        }
    }
}
