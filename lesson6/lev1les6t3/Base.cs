using System;
using System.Collections.Generic;
using System.IO;
//Переделать программу Пример использования коллекций для решения следующих задач:
// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
// в) отсортировать список по возрасту студента;
// г) *отсортировать список по курсу и возрасту студента;

namespace lev1les6t3
{
    public class Base
    {
        List<Student> _list;

        public List<Student> List { get => _list; set => _list = value; }

        public static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }
        public static int SortByCourse(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(st1.course.ToString(), st2.course.ToString());          // Сравниваем две строки
        }
        public static void LoadCsv(string path, out List<Student> list, char separator = ';')
        {
            list = new List<Student>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string[] s = sr.ReadLine().Split(separator);
                        // Добавляем в список новый экземпляр класса Student
                        list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), s[7], int.Parse(s[8])));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                        // Выход из Main
                        if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                    }
                }
            }
            list.Sort(new Comparison<Student>(MyDelegat));
        }
        static void DCourse(string path, out Dictionary<int, int> Dc)
        {
            Dc = new Dictionary<int, int>();
            LoadCsv(path, out List<Student> list);
            int i = 0;
            foreach (Student item in list)
            {
                if (!Dc.ContainsKey(item.course))
                {
                    Dc.Add(item.course, 1);
                }
                else
                {
                    Dc[item.course] += 1;
                }
                i++;
            }
        }
        static void DAge(string path, out Dictionary<int, int> Da)
        {
            Da = new Dictionary<int, int>();
            LoadCsv(path, out List<Student> list);
            int i = 0;
            foreach (Student item in list)
            {
                if (!Da.ContainsKey(item.age))
                {
                    Da.Add(item.age, 1);
                }
                else
                {
                    Da[item.age] += 1;
                }
                i++;
            }
        }
    }
}
