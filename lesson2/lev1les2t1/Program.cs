using System;
using Geek.Extensions; //tools.

//1. Написать метод, возвращающий минимальное из трех чисел.
//Выполнил Светлаков Е.С.

namespace lev1les2t1
{
    class Program
    {
        public static int MinInt(int a1, int a2, int a3){
            
            int min = a1;
            if (min >= a2){min = a2;}
            if (min >= a3){min = a3;}
            return min;
        }
        static void Main(string[] args)
        {
//            int a1 = 3;
//            int a2 = 5;
//            int a3 = -3;
            int a1 = tools.GetInt();
            int a2 = tools.GetInt();
            int a3 = tools.GetInt();
            Console.WriteLine($"Среди представленных чисел ({a1}, {a2}, {a3}) минимальным является: {MinInt(a1, a2, a3)}");
        }
    }
}
