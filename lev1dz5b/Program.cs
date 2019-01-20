using System;

namespace lev1dz5b
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Выполнил Светлаков Е.С.
            Написать программу, которая выводит на экран ваше имя, фамилию и город проживания */
            string name = "Евгений";
            string surname = "Светлаков";
            string city = "Йошкар-Ола";
            int ww = Console.WindowWidth;
            int wh = Console.WindowHeight;
            string msg = $"Имя: {name}, Фамилия: {surname}, Город: {city}";
            Console.WriteLine($"Высота: {wh}, Ширина: {ww}");
            Console.SetCursorPosition(ww/2 - msg.Length/2, wh/2);
            Console.Write(msg);
        }
    }
}
