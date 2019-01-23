using System;
using Geek.Extensions; //tools.

//7. б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
//Выполнил Светлаков Е.С.

namespace lev1les2t7b
{
    class Program
    {
        static int SummRange(int a, int b){
            if(a >= b) return b;
            else return SummRange(a+1, b) + a;
        }
        static void Main(string[] args)
        {
            int sa = SummRange(9,6);
            Console.WriteLine($"{sa}");
        }
    }
}
