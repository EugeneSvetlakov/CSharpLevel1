using System;
using System.IO;
using System.Collections.Generic;
//№4. Решить задачу с логинами из урока 2, 
//только логины и пароли считать из файла в массив. 
//Создайте структуру Account, содержащую Login и Password.
//Выполнил: Светлаков Е.С.

namespace lev1les4t4
{
    public struct Account
    {
        public string Login;
        public string Password;
    }
    class Program
    {
        static bool CheckPwd(string Login, string Password, string filename, string separator = " ")
        {
            try
            {
                bool accepted = false;
                StreamReader sr = new StreamReader(filename);
                List<Account> AccList = new List<Account>();
                Account Acc;
                while(!sr.EndOfStream)
                {
                    string[] str = sr.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);
                    Acc.Login = str[0];
                    Acc.Password = str[1];
                    AccList.Add(Acc);
                }
                foreach(Account acc in AccList){
                    if(acc.Login == Login && acc.Password == Password)
                    {
                        accepted = true;
                    }
                }
                return accepted;
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine(ex);
                return false;
            }
        }
        static void Main(string[] args)
        {
            Account MyAcc;
            Console.Write("Введите логин: ");
            MyAcc.Login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            MyAcc.Password = Console.ReadLine();
            string filename = @"./txt/accounts.txt";
            bool loggedin = CheckPwd(MyAcc.Login, MyAcc.Password, filename);
            Console.WriteLine("Введенный логин " +  (loggedin ? "присутствует" : "отсутствует") +  " в считанной базе");
        }
    }
}
