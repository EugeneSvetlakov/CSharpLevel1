using System;

namespace lev1dz5c
{
    class Program
    {
        static void PrintMsg(string msg, int x, int y){
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
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
            PrintMsg(msg, ww/2 - msg.Length/2, wh/2);
        }
    }
}
