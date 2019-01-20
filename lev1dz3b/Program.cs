using System;

namespace lev1dz3b
{
    class Program
    {
        static double LenAB(int x1, int y1, int x2, int y2){
                return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        }
        static void Main(string[] args)
        {
            /* Выполнил Светлаков Е.С.
            № 3б Расчет расстояния между точками A(x1,y1) и B(x2,y2)
             r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2) 
             Выполнить задание, оформив вычисления расстояния между точками в виде метода*/
            int x1 = 2;
            int y1 = 2;
            int x2 = 5;
            int y2 = 7;
            
            Console.WriteLine($"№ 3б: Расстояние между точками A({x1},{y1}) и B({x2},{y2}) = {LenAB(x1,y1,x2,y2):F2}");
            Console.ReadKey();
        }
    }
}
