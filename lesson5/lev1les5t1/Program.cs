using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//1. Создать программу, которая будет проверять корректность ввода логина. 
//Корректным логином будет строка от 2 до 10 символов, содержащая только буквы 
//латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) **с использованием регулярных выражений.

namespace lev1les5t1
{

    public struct Login
    {
        string _login;

        public string login
        {
            get { return this._login; }
            set { _login = value; }
        }


        /// <summary>
        /// Длина логина
        /// </summary>
        public int Length { get { return this.login.Length; } }
        /// <summary>
        /// Проверка что первый символ логина - цифра
        /// </summary>
        public bool IsFirstDigit { get { return char.IsDigit(this.login[0]); } }
        /// <summary>
        /// Проверка наличия только букв и цифр в логине
        /// </summary>
        public bool OnlyLetterOrDigit
        {
            get
            {
                bool onlyletdig = true;
                foreach (char ch in this.login)
                {
                    if (!char.IsLetterOrDigit(ch)) onlyletdig = false;
                }
                return onlyletdig;
            }
        }
        /// <summary>
        /// Проверка наличия букв в логине
        /// </summary>
        public bool HaveLetter
        {
            get
            {
                bool let = false;
                foreach (char ch in this.login)
                {
                    if (char.IsLetter(ch)) let = true;
                }
                return let;
            }
        }
        /// <summary>
        /// Проверка наличия цифр в логине
        /// </summary>
        public bool HaveDigit
        {
            get
            {
                bool dig = false;
                foreach (char ch in this.login)
                {
                    if (char.IsLetterOrDigit(ch)) dig = true;
                }
                return dig;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Входные данные - список логинов
            string[] LoginBase = new string[] { "goshaFulled", "Vasya", "vasya123", "2vasya123", "va$sya123" };
            string str1 = "Корректный логин";

            //Без использования регулярных выражений
            #region WithoutRegular
            Login MyLogin = new Login();
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Проверка логина без использования регулярного выражения:");
            Console.ResetColor();
            foreach (string ss in LoginBase)
            {
                MyLogin.login = ss;
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("New Login:");
                Console.ResetColor();
                System.Console.WriteLine($"For Login: {MyLogin.login}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"Properties of Login:");
                Console.ResetColor();
                System.Console.WriteLine($"Length = {MyLogin.Length}");
                System.Console.WriteLine($"IsFirstDigit: {MyLogin.IsFirstDigit}");
                System.Console.WriteLine($"HaveLetter: {MyLogin.HaveLetter}");
                System.Console.WriteLine($"HaveDigit: {MyLogin.HaveDigit}");
                System.Console.WriteLine($"OnlyLetterOrDigit: {MyLogin.OnlyLetterOrDigit}");
                int leng = MyLogin.Length;
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine((leng >= 2 && leng <= 10 && MyLogin.OnlyLetterOrDigit && !MyLogin.IsFirstDigit) ? $"{str1}" : $"Не {str1}");
                Console.ResetColor();
                System.Console.WriteLine();
            }
            #endregion
            
            //С использованием регулярных выражений
            #region Regular
            Regex myregex = new Regex(@"^[\D]{1,}[A-Za-z0-9]{2,9}");
            Regex znaki = new Regex(@"[\W_]");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Проверка логина с помощью регулярного выражения:");
            Console.ResetColor();
            foreach (string str in LoginBase)
            {
                bool LetterDigit = myregex.IsMatch(str);
                bool HaveNotLetterDigit = znaki.IsMatch(str);
                bool GoogLength = str.Length >= 2 && str.Length <= 10;
                if (LetterDigit && !HaveNotLetterDigit && GoogLength)
                {
                    System.Console.WriteLine($"{str} - {str1}");
                }
                else
                {
                    System.Console.WriteLine($"{str} - Не {str1}");
                }
            }
            #endregion
        }
    }
}
