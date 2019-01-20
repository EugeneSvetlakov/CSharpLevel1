using System;

namespace lev1dz3a
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* Выполнил Светлаков Е.С.
            № 3а Расчет расстояния между точками A(x1,y1) и B(x2,y2)
             r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2) */
            int x1 = 2;
            int y1 = 2;
            int x2 = 5;
            int y2 = 7;
            double r = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            
            Console.WriteLine($"№ 3а: Расстояние между точками A({x1},{y1}) и B({x2},{y2}) = {r:F2}");
            Console.ReadKey();
        }
    }
}
