using System;
using Geek.Extensions; //tools.

//4. Реализовать метод проверки логина и пароля. 
//На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел 
//(Логин: root, Password: GeekBrains). 
//Используя метод проверки логина и пароля, написать программу: 
//  пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
//С помощью цикла do while ограничить ввод пароля тремя попытками.
//Выполнил Светлаков Е.С.

namespace lev1les2t4
{
    class Program
    {
        public static bool CorrectLogin(string in_login, string in_pwd, string Rlogin = "root", string Rpwd="GeekBrains"){
            return (in_login == Rlogin) && (in_pwd == Rpwd);
        }
        static void Main(string[] args)
        {
            string login;
            string pwd;
            bool next = false;
            int count = 0;
            do{
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                pwd = Console.ReadLine();
                next = CorrectLogin(login,pwd);
                count++;
            } while(!next && count != 3);
            if(!next) {
                Console.WriteLine("Вы не прошли авторизацию. До свидания.");
                return;
            }
            Console.WriteLine("Вы прошли авторизацию. Можем продолжить.");
        }
    }
}
