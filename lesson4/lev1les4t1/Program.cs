using System;
//№1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
//Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, 
//в которых только одно число делится на 3.
//Выполнил: Светлаков Е.С.

namespace lev1les4t1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string a_string ="";
            string str = "";
            int[] a = new int[20];
            Random r = new Random();
            for (int i=0;i < 20;i++){
                a[i] = r.Next(-10001,10001);
            }
            for(int i = 0; i < a.Length-2;i++){
                if((a[i]%3 == 0 && a[i+1]%3 != 0) || (a[i]%3 != 0 && a[i+1]%3 == 0)){
                    str += $"| {a[i]}, {a[i+1]} |";
                    count++;
                }
            }
            foreach (int item in a){
                a_string += item + ", ";
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Исходный массив:");
            Console.ResetColor();
            Console.WriteLine(a_string);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Найденно");
            Console.ResetColor();
            Console.WriteLine($"{count} пар(ы)");
            Console.WriteLine($"лементов массива, в которых только одно число делится на 3:");
            Console.WriteLine(str);
        }
    }
}
