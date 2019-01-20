using System;

namespace lev1dz4b
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Выполнил Светлаков Е.С.
            № 4б: Написать программу обмена значениями двух переменных без использования третьей переменной */
            int a = 12;
            int b = 7;
            Console.WriteLine($"Значения до обмена: a = {a}, b = {b}.");
            
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
            Console.WriteLine($"Значения после обмена: a = {a}, b = {b}.");
        }
    }
}
