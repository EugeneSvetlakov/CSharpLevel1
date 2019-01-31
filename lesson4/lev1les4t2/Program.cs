using System;
using System.IO;
using System.Collections.Generic;

//№2. Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
//в)**Добавьте обработку ситуации отсутствия файла на диске.
//Выполнил: Светлаков Е.С.

namespace lev1les4t2
{
    class StaticClass
    {
        /// <summary>
        /// Возвращает количество пар элементов массива, в которых только одно число делится на 3
        /// </summary>
        /// <param name="a">входной массив целых чисел</param>
        public static int PairMod3(int[] a)
        {
            int count = 0;
            for(int i = 0; i < a.Length-2;i++){
                if((a[i]%3 == 0 && a[i+1]%3 != 0) || (a[i]%3 != 0 && a[i+1]%3 == 0))
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// Возвращает массив целых чисел считанный из файла
        /// </summary>
        /// <param name="filename">файл</param>
        /// <param name="separator">Символ-разделитель элементов в файле</param>
        public static int[] ArrFromFile(string filename, string separator)
        {
            try {
                List<int> numbers = new List<int>();
                StreamReader sr = new StreamReader(filename);
                while(!sr.EndOfStream)
                {
                    string[] str = sr.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);
                    foreach(string s in str){
                        if(int.TryParse(s, out int num)){
                            numbers.Add(num);
                        }
                    }
                }
                sr.Close();
                int[] a = new int[numbers.Count];
                int i = 0;
                foreach(int item in numbers){
                    a[i] = item;
                    i++;
                }
                return a;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                int[] a = {};
                return a;
            }
        }
        /// <summary>
        /// Метод генерирующий массив заполненный случайными числами
        /// </summary>
        /// <param name="n">количество элементов в массиве</param>
        /// <param name="min">нижняя граница значений элементов массива</param>
        /// <param name="max">верхняя граница значений элементов массива</param>
        public static int[] RandArray(int n, int min,int max)
        {
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                {
                    a[i] = r.Next(min,max);
                }
                return a;
        }
        public static string PrintArr(int [] array)
        {
            string ArrToStr = "";
            foreach(int item in array)
            {
                ArrToStr += $"{item}  ";
            }
            return ArrToStr;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = StaticClass.RandArray(20,-10001,10001);
            Console.WriteLine($"Элементы входного массива: {StaticClass.PrintArr(arr)}");
            Console.WriteLine($"Количество найденных пар: {StaticClass.PairMod3(arr)}");
            
            //Массив из файла
            string filename = "./txt/1.txt";
            string separator = " ";
            Console.WriteLine($"Считаем файл из: {filename}");
            Console.WriteLine($"Символ разделитель элементов: '{separator}'");
            int[] arr2 = StaticClass.ArrFromFile(filename, separator);
            Console.WriteLine($"В файле найдено {arr2.Length} элементов, являющихся целыми числами. Результат помещен в массив 'arr2'.");
        }
    }
}
