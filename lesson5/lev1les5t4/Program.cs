using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lev1les5t4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Входные данные: 1) база ФИО + оценки; 2) количество разных минимальных средних баллов
            string path = @"./txt/exam.txt";
            int count_avg = 3;
            //загрузка базы в словарь: ФИО + средний балл
            Dictionary<string, double> Dict = DbToAvgDict(path);
            //Формируем список учеников с {count_avg} наименьшими средними баллами
            string out_str = GetAvg(count_avg, ref Dict);
            //Вывод на экран списка
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Список учеников с {count_avg} наименьшими средними баллами:");
            Console.ResetColor();
            System.Console.WriteLine(out_str);
        }
        /// <summary>
        /// Получение списка учеников с заданным количеством наименьшими величинами среднего балла
        /// </summary>
        /// <param name="count_avg">Кол-во наименьших величин среднего балла</param>
        /// <param name="Dict">Список учеников со значением среднего балла</param>
        private static string GetAvg(int count_avg, ref Dictionary<string, double> Dict)
        {
            string out_str = string.Empty;
            Dict = Dict.OrderBy(i => i.Value).ToDictionary(i => i.Key, i => i.Value);
            double start_avg = Dict.Values.ElementAt(1);
            int count = 1;
            foreach (KeyValuePair<string, double> kvp in Dict)
            {
                if (kvp.Value != start_avg)
                {
                    start_avg = kvp.Value;
                    count++;
                }
                if (count > count_avg) break;
                out_str += $"ФИО: {kvp.Key} Средний балл: {kvp.Value}{Environment.NewLine}";
            }

            return out_str;
        }
        /// <summary>
        /// Формирование Списка учеников со значением среднего балла по 3-м экзаменам
        /// </summary>
        /// <param name="path">Файл для загрузки (формат: [Самилия] [Имя] [оценка] [оценка] [оценка]) </param>
        private static Dictionary<string, double> DbToAvgDict(string path)
        {
            string[] exam = File.ReadAllLines(path);
            int num_items = 0;
            string fio = string.Empty;
            double avg = double.NaN;
            bool b1;
            bool b2;
            bool b3;
            Dictionary<string, double> Dict = new Dictionary<string, double>();
            if (int.TryParse(exam[0], out int amt))
            {
                for (int i = 1; i < amt + 1; i++)
                {
                    string[] subs = exam[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    num_items = subs.Length;
                    if (num_items == 5)
                    {
                        fio = $"{subs[0]} {subs[1]}";
                        b1 = int.TryParse(subs[2], out int n1);
                        b2 = int.TryParse(subs[3], out int n2);
                        b3 = int.TryParse(subs[4], out int n3);
                        if (b1 && b2 && b3) { avg = Math.Round((double)(n1 + n2 + n3) / 3, 2); }
                        if (!Dict.ContainsKey(fio)) { Dict.Add(fio, avg); }
                    }
                }
            }

            return Dict;
        }
    }
}
