using System;
using Geek.Extensions; //tools.

//2. Написать метод подсчета количества цифр числа.
//Выполнил Светлаков Е.С.

namespace lev1les2t2
{
    
    class Program
    {
        public static int DigitQuantity(int num){
            return num.ToString().Length;
        }
        static void Main(string[] args)
        {
            //int num = 223123;
            int num = tools.GetInt(max: 1000000);
            Console.WriteLine($"В числе {num} содержится {DigitQuantity(num)} чисел.");
        }
    }
}
