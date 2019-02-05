using System;

namespace Lib.FindMin
{
    public delegate double Fx(double x);
    public class FindMin
    {

        public static double Fxx(double x)
        {
            return x * x;
        }
        public static double X(double x)
        {
            return x;
        }
        /// <summary>
        /// FindM
        /// </summary>
        /// <param name="F">Функция</param>
        /// <param name="x1">начало диаппазона</param>
        /// <param name="x2">конец диаппазона</param>
        /// <param name="dx">шаг</param>
        public static double MinF(Fx F, double x1, double x2, double dx)
        {
            double xx = x1;
            double minF = F(xx);
            double y = 0;
            while (xx <= x2)
            {
                y = F(xx);
                if (minF > y) minF = y;
                //System.Console.WriteLine($"xx= {xx}\tF(x)= {Math.Round(y,4)}");
                xx = Math.Round(xx+dx,2);
            }
            return Math.Round(minF,4);
        }
        
    }
}
