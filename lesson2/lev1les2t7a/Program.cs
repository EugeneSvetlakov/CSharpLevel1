using System;
using Geek.Extensions; //tools.

//7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
//Выполнил Светлаков Е.С.

namespace lev1les2t7a
{
    class Program
    {
        static void PrintRange(int a, int b)
    {
        Console.Write($"{a.ToString(" #### ")}");
        if (a < b) PrintRange(a + 1, b);
    }

        static void Main(string[] args)
        {
            Console.WriteLine($"Выведем на экран числа в диаппазоне от a до b (a < b).");
            int a = tools.GetInt(msg: "число 'a'");
            int b = tools.GetInt(msg: "число 'b'");
            Console.WriteLine("Результат: ");
            PrintRange(a, b);
            Console.WriteLine("");
        }
    }
}
