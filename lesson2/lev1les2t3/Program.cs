using System;
using Geek.Extensions; //tools.

//3. С клавиатуры вводятся числа, пока не будет введен 0. 
//Подсчитать сумму всех нечетных положительных чисел.
//Выполнил Светлаков Е.С.

namespace lev1les2t3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = -100;
            int end = 100;
            int num;
            int sum = 0;
            string allnum = "";
            Console.WriteLine("Программа вычисления суммы положительных нечетных целых чисел.");
            Console.WriteLine($"Принимаются числа в диаппазрне от {start} до {end}");
            Console.WriteLine($"Для завершения запроса чисел введите цифру '0'");
            do{
                //num = tools.GetInt(min: -100, max: 100);
                num = tools.GetInt(start, end);
                if (num >= 0 && num % 2 != 0){
                    allnum += num.ToString() + " ";
                    sum += num;
                }
            } while(num != 0);
            Console.WriteLine($"Введенные положительные нечетные числа: {allnum}");
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {sum}");
        }
    }
}
