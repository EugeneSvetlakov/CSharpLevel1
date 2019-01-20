using System;

namespace lev1dz4a
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Выполнил Светлаков Е.С.
            № 4а: Написать программу обмена значениями двух переменных с использованием третьей переменной */
            int a = 12;
            int b = 7;
            Console.WriteLine($"Значения до обмена: a = {a}, b = {b}.");
            
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"Значения после обмена: a = {a}, b = {b}.");
            Console.ReadKey();
        }
    }
}
