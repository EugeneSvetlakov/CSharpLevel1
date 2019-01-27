using System;
//2.  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечётных положительных чисел. 
//Сами числа и сумму вывести на экран, используя tryParse.
//Выполнил: Светлаков Е.С.

namespace lev1les3t2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while(true){
                Console.Write("Введите целое число: ");
                string str = Console.ReadLine();
                if(int.TryParse(str, out int x)){
                    if(x != 0){
                        if(x%2 != 0){
                            sum += x;
                            Console.WriteLine("x= " + x + ", сумма нечетных чисел = " + sum);
                        }
                    } else {
                        break;
                    }
                } else {
                    Console.WriteLine("Ошибка преобразования.");
                }
            }
            Console.WriteLine("Итоговая сумма введенных нечетных чисел = " + sum);
        }
    }
}
