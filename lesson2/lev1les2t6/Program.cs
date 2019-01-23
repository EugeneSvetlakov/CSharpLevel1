using System;
using Geek.Extensions; //tools.

//6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
//Хорошим называется число, которое делится на сумму своих цифр. 
//Реализовать подсчет времени выполнения программы, используя структуру DateTime.
//Выполнил Светлаков Е.С.

namespace lev1les2t6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start;
            DateTime end;
            int sum = 0;
            int count = 0;
            //1 000 000 000
            int end_number = 1000000000;
            Console.WriteLine($"Ищем 'Хорошие числа' среди {end_number}");
            start = DateTime.Now;
            for (int number=1;number <= end_number; number++){
                sum = 0;
                foreach (char c in Math.Abs(number).ToString()){
                sum += c - '0';
                }
                if(number%sum == 0) count++;
            }
            end = DateTime.Now;
            Console.WriteLine(count);
            Console.WriteLine($"{end - start}");
        }
    }
}
