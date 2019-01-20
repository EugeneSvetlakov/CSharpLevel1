using System;
using System.Globalization;

namespace lev1dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Выполнил Светлаков Е.С.
            № 1 Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,рост, вес).
            В результате вся информация выводится в одну строчку:
            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $. */
            
            string uiSep = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@"Доброго времени суток. Давайте заполним анкету.");
                        
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"!Внимание!");
            Console.ResetColor();
            Console.WriteLine($" Десятичным разделителем является: {uiSep}");
            
            string s_name = "Имя: ";
            string s_surname = "Фамилия: ";
            string s_age = "Возраст, лет: ";
            string s_height = "Рост, см: ";
            string s_weight = "Вес, кг: ";
            
            Console.Write(s_name);
            string name = Console.ReadLine();
            
            Console.Write(s_surname);
            string surname = Console.ReadLine();

            Console.Write(s_age);
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write(s_height);
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write(s_weight);
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вывод склеиванием: " + s_name + name + ", " + s_surname + surname + ", " + s_age + age + ", " + s_height + height + ", " + s_weight + weight);
            Console.WriteLine("Форматирование: {0}{1}, {2}{3}, {4}{5:D}, {6}{7:F1}, {8}{9:F2}",s_name,name,s_surname,surname,s_age,age,s_height,height,s_weight,weight);
            Console.WriteLine($"Вывод посредством $(интерполяция строк): {s_name}{name}, {s_surname}{surname}, {s_age}{age:D}, {s_height}{height:F1}, {s_weight}{weight:F2}");
            
            Console.ReadKey();
        }
    }
}
