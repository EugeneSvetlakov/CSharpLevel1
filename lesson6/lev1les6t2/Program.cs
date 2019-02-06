using System;
using System.Collections.Generic;
using System.Linq;

//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
// а) Сделать меню с различными функциями и представить пользователю выбор, 
//для какой функции и на каком отрезке находить минимум. 
//Использовать массив (или список) делегатов, в котором хранятся различные функции.
// б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
//Пусть она возвращает минимум через параметр (с использованием модификатора out).

namespace lev1les6t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Fx> DictFunc = new Dictionary<string, Fx>()
            {
                {"f(x) = x", new Fx(FindMin.X)},
                {"f(x) = x*x", new Fx(FindMin.Fxx)},
                {"f(x) = sin(x)", new Fx(Math.Sin)},
                {"f(x) = cosh(x)", new Fx(Math.Cosh)}
            };
            CMenu.ConsoleMenu(DictFunc, out FuncData FF);
            System.Console.WriteLine($"{FF.strF}, x_min={FF.x_min}, x_max={FF.x_max}, dx={FF.dx}, Минимум функции = {FindMin.MinF(FF)}");
            string path = "data.bin";
            FindMin.ExportF(FF,path);
            FindMin.LoadF(path, out double[] data1, out double minF);
            string arrstr = string.Empty;
            foreach (double item in data1)
            {
                arrstr += $"{item}\t";
            }
            System.Console.WriteLine($"Масив: {arrstr}");
            System.Console.WriteLine($"Минииуи = {minF}");
            Console.ReadLine();
        }
    }
}
