using System;
using System.Collections.Generic;
using Lib.FindMin;

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
        public static void MyMenu()
        {
            Fx f;
            double x1;
            double x2;
            double dx;
            Console.WriteLine("Программа поиска минимума функции.");
            while (true)
            {
                System.Console.WriteLine("Выберите одну из предложенных функций:");
                System.Console.WriteLine("1. f(x) = x; 2. f(x)=x*x; 3. f(x)=sin(x); 4. f(x)=cosh(x): ");
                if (int.TryParse(Console.ReadLine(), out int ans) && ans >= 1 && ans <= 4)
                {
                    switch (ans)
                    {
                        case 1:
                            f = new Fx(FindMin.X);
                            break;
                        case 2:
                            f = new Fx(FindMin.Fxx);
                            break;
                        case 3:
                            f = new Fx(Math.Sin);
                            break;
                        case 4:
                        default:
                            f = new Fx(Math.Cosh);
                            break;
                    }
                    break;
                }
            }
            while (true)
            {
                System.Console.WriteLine("х_min: ");
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    x1 = result;
                    break;
                }
            }
            while (true)
            {
                System.Console.WriteLine("х_max: ");
                if (double.TryParse(Console.ReadLine(), out double result) && result > x1)
                {
                    x2 = result;
                    break;
                }
            }
            while (true)
            {
                System.Console.WriteLine("шаг: ");
                if (double.TryParse(Console.ReadLine(), out double result) && result <= (x2 - x1) / 2)
                {
                    dx = result;
                    break;
                }
            }
            System.Console.WriteLine($"x_min={x1}, x_max={x2}, dx={dx}, Минимум = {FindMin.MinF(f, x1, x2, dx)}");
        }
        static void Main(string[] args)
        {
            // Fx f1 = new Fx(FindMin.X);
            // Fx f2 = new Fx(FindMin.Fxx);
            // Fx f3 = new Fx(Math.Sin);
            // Fx f4 = new Fx(Math.Cosh);
            // System.Console.WriteLine($"Min(f1) = {FindMin.MinF(f1, -2,2,0.1)}");
            // System.Console.WriteLine($"Min(f2) = {FindMin.MinF(f2, -2,2,0.1)}");
            // System.Console.WriteLine($"Min(f3) = {FindMin.MinF(f3, -2,2,0.1)}");
            // System.Console.WriteLine($"Min(f4) = {FindMin.MinF(f4, -2,2,0.1)}");
            MyMenu();

        }
    }
}
