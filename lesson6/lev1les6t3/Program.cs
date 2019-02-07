using System;
using System.Collections.Generic;
using System.Linq;
//Переделать программу Пример использования коллекций для решения следующих задач:
// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
// в) отсортировать список по возрасту студента;
// г) *отсортировать список по курсу и возрасту студента;

namespace lev1les6t3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "students_6.csv";
            DateTime dt = DateTime.Now;
            Base.LoadCsv(path, out List<Student> list);
            Console.WriteLine("Всего студентов:" + list.Count);
            //количество студентов учащихся на 5 и 6 курсах
            int AmountCourse = (from p in list where p.course == 5 || p.course==6 select p).Count();
            Console.WriteLine($"Количество студентов учащихся на 5 и 6 курсах: {AmountCourse}");
            //Количество студентов в возрасте от 18 до 20 лет
            int AmountAge = (from p in list where p.age >= 18 && p.age <= 20 select p).Count();
            Console.WriteLine($"Количество студентов в возрасте от 18 до 20 лет: {AmountAge}");
            Console.WriteLine("\nСписок студентов отсортированный по Возрасту:");
            foreach (var v in list.OrderBy(a => a.age)) Console.WriteLine($"age: {v.age} lastname: {v.lastName}");
            Console.WriteLine("\nСписок студентов отсортированный по Курсу и Возрасту:");
            foreach (var v in list.OrderBy(a => a.course).ThenBy(a => a.age)) Console.WriteLine($"course: {v.course} age: {v.age} lastname: {v.lastName}");
            Console.WriteLine(DateTime.Now - dt);
            Console.Write("Для выхода из программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
