using System;
using Geek.Extensions; //tools.

//5. б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
//Выполнил Светлаков Е.С.

namespace lev1les2t5b
{
    class Program
    {
        static void Main(string[] args)
        {
            double Imin = 18.5;
            double Imax = 24.99;
            double m = tools.GetDouble(10, 300, "вес","кг");
            double h = tools.GetDouble(0.10, 5, "рост","м");
            double I = m/(h*h);
            double m_min = Imin*h*h;
            double m_max = Imax*h*h;

            if(I < Imin){
                Console.WriteLine($"Ваш индекск массы {I:F2}. Это меньше нормы. Нужно набрать минимум {(m_min - m + 0.01):F2} кг");
            } else if(I > Imax){
                Console.WriteLine($"Ваш индекск массы {I:F2}. Это выше нормы. Нужно сбросить минимум {(m - m_max - 0.01):F2} кг");
            } else {
                Console.WriteLine($"Ваш индекск массы {I:F2}. Вес в Норме!");
            }
        }
    }
}
