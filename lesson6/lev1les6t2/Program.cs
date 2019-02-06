using System;
using System.Collections.Generic;
using System.Linq;
using Lib.FindMin;

//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
// а) Сделать меню с различными функциями и представить пользователю выбор, 
//для какой функции и на каком отрезке находить минимум. 
//Использовать массив (или список) делегатов, в котором хранятся различные функции.
// б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
//Пусть она возвращает минимум через параметр (с использованием модификатора out).

namespace lev1les6t2
{
    class FuncData
    {
        Fx _F;
        double _x_min;
        double _x_max;
        double _dx;

        public FuncData(Fx F, double x_min, double x_max, double dx)
        {
            this._F = F;
            this._x_min = x_min;
            this._x_max = x_max;
            this._dx = dx;
        }
        public Fx F
        {
            get { return this._F; }
            set { this._F = value; }
        }
        public double x_min
        {
            get { return this._x_min; }
            set { this._x_min = value; }
        }
        public double x_max
        {
            get { return this._x_max; }
            set { this._x_max = value; }
        }
        public double dx
        {
            get { return this._dx; }
            set { this._dx = value; }
        }
    }

    class Program
    {
        public static string DictToStr(Dictionary<string, Fx> Dict)
        {
            string result = string.Empty;
            foreach (KeyValuePair<string, Fx> kvp in Dict)
            {
                int idx = Dict.Keys.ToList().IndexOf(kvp.Key);
                result += $"{idx}. {kvp.Key};";
            }
            result = $"{result.Substring(0, result.Length - 1)}: ";
            return result;
        }
        public static Fx GetFxById(Dictionary<string, Fx> Dict, int idx)
        {
            return Dict.Values.ElementAt(idx);
        }

        public static void ConsoleMenu(Dictionary<string, Fx> Dict, out FuncData FF)
        {

            Fx f;
            int idx;
            int n = Dict.Count;
            double x1;
            double x2;
            double dx;
            string StrMenu = DictToStr(Dict);
            Console.WriteLine("Программа поиска минимума функции.");
            while (true)
            {
                System.Console.WriteLine("Выберите одну из предложенных функций:");
                System.Console.WriteLine($"{StrMenu}");
                if (int.TryParse(Console.ReadLine(), out int ans) && ans >= 0 && ans <= n - 1)
                {
                    f = GetFxById(Dict, ans);
                    break;
                }
            }
            x1 = GetXmin();
            x2 = GetXmax(x1);
            dx = Getdx(x1, x2);
            FF = new FuncData(f,x1,x2,dx);
        }

        private static double Getdx(double x1, double x2)
        {
            double dx;
            while (true)
            {
                System.Console.WriteLine("шаг: ");
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
                System.Console.WriteLine("х_max: ");
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
                System.Console.WriteLine("х_min: ");
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    x1 = result;
                    break;
                }
            }

            return x1;
        }

        static void Main(string[] args)
        {
            Dictionary<string, Fx> DictFunc = new Dictionary<string, Fx>()
            {
                {"f(x) = x", new Fx(FindMin.X)},
                {"f(x) = x*x", new Fx(FindMin.Fxx)},
                {"f(x) = sin(x)", new Fx(Math.Sin)},
                {"f(x) = cosh(x)", new Fx(Math.Cosh)}
            };
            ConsoleMenu(DictFunc, out FuncData FF);
            Fx f = FF.F;
            double x1 = FF.x_min;
            double x2 = FF.x_max;
            double dx = FF.dx;
            double minF = FindMin.MinF(f, x1, x2, dx);
            System.Console.WriteLine($"x_min={x1}, x_max={x2}, dx={dx}, Минимум = {minF}");
            Console.ReadLine();

        }
    }
}
