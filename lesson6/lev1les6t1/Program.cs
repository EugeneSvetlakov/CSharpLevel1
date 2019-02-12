using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Изменить программу вывода таблицы функции так, 
//чтобы можно было передавать функции типа double (double, double). 
//Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

namespace lev1les6t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Fx> DictFunc = new Dictionary<string, Fx>()
            {
                {"f(x) = a*x^2", new Fx(ExportT.Fxa)},
                {"f(x) = a*sin(x)", new Fx(ExportT.SinXA)}
            };
            CMenu.ConsoleMenu(DictFunc, out FuncData FF);
            System.Console.WriteLine($"{FF.strF}, x_min={FF.x_min}, x_max={FF.x_max}, dx={FF.dx}, a={FF.a}, Минимум функции = {ExportT.MinF(FF)}");
            string path = "data.bin";
            ExportT.ExportF(FF, path);
            ExportT.LoadF(path, out double[] data1, out double minF);
            string arrstr = string.Empty;
            foreach (double item in data1)
            {
                arrstr += $"{item}\t";
            }
            System.Console.WriteLine($"Масив: {arrstr}");
            System.Console.WriteLine($"Минимум = {minF}");
            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
