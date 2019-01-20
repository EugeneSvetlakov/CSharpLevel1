using System;

namespace lev1dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Выполнил Светлаков Е.С.
            № 2 Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
            I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах. */
            string s_height = "Рост, м: ";
            string s_weight = "Вес, кг: ";
            
            Console.Write(s_height);
            double h = Convert.ToDouble(Console.ReadLine());

            Console.Write(s_weight);
            double m = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"№ 2: Индекс массы тела расчитанный по формуле I=m/(h*h) равен: {(m/(h*h)):F5}");
            Console.ReadKey();
        }
    }
}
