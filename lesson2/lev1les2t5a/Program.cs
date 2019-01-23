using System;
using Geek.Extensions; //tools.

//5. а) Написать программу, которая запрашивает массу и рост человека, 
//вычисляет его индекс массы и сообщает, 
//нужно ли человеку похудеть (>24.99), набрать вес(<18.5) или все в норме;
//Выполнил Светлаков Е.С.

namespace lev1les2t5a
{
    class Program
    {
        static void Main(string[] args)
        {
            double Imin = 18.5;
            double Imax = 24.99;
            double weight = tools.GetDouble(10.0, 300.0, "вес","кг");
            double height = tools.GetDouble(0.10, 5.0, "рост","м");
            double I = weight/(height*height);

            if(I < Imin){
                Console.WriteLine($"Ваш индекск массы {I}, меньше нормы. Нужно набрать вес!");
            } else if(I > Imax){
                Console.WriteLine($"Ваш индекск массы {I}, выше нормы. Нужно похудеть!");
            } else {
                Console.WriteLine($"Ваш индекск массы {I}. Вес в Норме!");
            }
        }
    }
}
