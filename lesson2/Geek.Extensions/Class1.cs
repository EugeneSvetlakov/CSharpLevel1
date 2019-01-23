using System;

namespace Geek.Extensions
{
    public class tools
    {
        static public int GetInt(int min = 0, int max = 100, string msg = "Целое число", string measure = ""){
            string message;
            if(measure == ""){
                message = $"Введите {msg} в диаппазоне от {min} до {max}: ";
            } else {
                message = $"Введите {msg} в диаппазоне от {min} до {max}, {measure}: ";
            }
            Console.Write($"{message}");
            while(true){
                if(!int.TryParse(Console.ReadLine(), out int num) || min > num || max < num){
                    Console.WriteLine($"Ошибка преобразования.");
                    Console.Write($"{message}");
                } else
                {
                    return num;
                }
            }
        }

        static public double GetDouble(double min = 0, double max = 100, string msg = "Число", string measure = ""){
            string message;
            if(measure == ""){
                message = $"Введите {msg} в диаппазоне от {min} до {max}: ";
            } else {
                message = $"Введите {msg} в диаппазоне от {min} до {max}, {measure}: ";
            }
            Console.Write($"{message}");
            while(true){
                if(!Double.TryParse(Console.ReadLine(), out double num) || min > num || max < num){
                    Console.WriteLine($"Ошибка преобразования.");
                    Console.Write($"{message}");
                } else
                {
                    return num;
                }
            }
        }
        
        static public void Pause(){
            //Console.ResetColor();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        static public void PrintMsg(string msg, int x=0, int y=0, bool ClearConsole = false, string ColorName = "Default"){
            //str - текст сообщения
            //x, y - расположение текста на экране
            //ClearConsole = true/false - очистка экрана
            //ColorName = Green,Red,... - цвет выводимого текста
            int ww = Console.WindowWidth;
            int wh = Console.WindowHeight;
            if (x != 0 && y != 0 && x < ww && y < wh){
                Console.SetCursorPosition(x, y);
                }
            if(ClearConsole){
                Console.Clear();
            }
            
            if (ColorName != "Default"){
                Type type = typeof(ConsoleColor);
                foreach (var name in Enum.GetNames(type))
                {
                    if(name == ColorName)
                    {
                        Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                    }
                }
            } else {
                Console.ResetColor();
            }
            Console.WriteLine(msg);
        }
    }
}
