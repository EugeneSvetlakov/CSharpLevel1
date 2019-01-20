using System;
using System.Globalization;

namespace sharpaddons
{
    class Program
    {
        static double StrToNum(string str) => Convert.ToDouble(str);

        static bool IsStringNum(string str){
            str = str.Trim();
            //string uiSep = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            bool isnum = double.TryParse(str, out double num);
            return isnum;
        }
        
        static void Pause(){
            //Console.ResetColor();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        static void PrintMsg(string msg, int x=0, int y=0, bool ClearConsole = false, string TextColorName = "Default"){
            //str - текст сообщения
            //x, y - расположение текста на экране
            //ClearConsole = true/false - очистка экрана
            //TextColorName = Green,Red,... - цвет выводимого текста
            int ww = Console.WindowWidth;
            int wh = Console.WindowHeight;
            if (x != 0 && y != 0 && x < ww && y < wh){
                Console.SetCursorPosition(x, y);
                }
            if(ClearConsole){
                Console.Clear();
            }
            
            if (TextColorName != "Default"){
                Type type = typeof(ConsoleColor);
                foreach (var name in Enum.GetNames(type))
                {
                    if(name == TextColorName)
                    {
                        Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                    }
                }
            } else {
                Console.ResetColor();
            }
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
           
        }
    }
}
