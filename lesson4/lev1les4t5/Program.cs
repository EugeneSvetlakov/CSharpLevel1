using System;
using System.IO;
using System.Collections.Generic;
using Lib.Array2d;

//*а) Реализовать библиотеку с классом для работы с двумерным массивом. 
//Реализовать конструктор, заполняющий массив случайными числами. 
//Создать методы, которые возвращают сумму всех элементов массива, 
//сумму всех элементов массива больше заданного, 
//свойство, возвращающее минимальный элемент массива, 
//свойство, возвращающее максимальный элемент массива, 
//метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
//**б) Добавить конструктор и методы, которые 
// - загружают данные из файла 
// [TODO]- записывают данные в файл.
// [TODO] **в) Обработать возможные исключительные ситуации при работе с файлами.
//Выполнил: Светлаков Е.С.

namespace lev1les4t5
{
    /* struct DataEl
    {
        public int row;
        public int column;
        public int num;
    }
    class Array2d
    {
        int[,] a;
        /// <summary>
        /// Конструктор двумерного массива заполненного случайными числами
        /// </summary>
        /// <param name="rows">количество строк</param>
        /// <param name="columns">количество столбцов</param>
        /// <param name="min">минимальное значение</param>
        /// <param name="max">максимальное значение</param>
        public Array2d(int rows, int columns, int min = 0, int max = 101)
        {
            Random r = new Random();
            a = new int[rows,columns];
            for(int j = 0; j < rows; j++)
            {
                for(int i = 0; i < columns; i++)
                {
                    a[j,i] = r.Next(min,max);
                }
            }
        }
        /// <summary>
        /// Конструктор двумерного массива загружаемого из файла
        /// </summary>
        /// <param name="filename">файл</param>
        /// <param name="separator">разделитель элементов</param>
        public Array2d(string filename, string separator)
        {
            try {
                List<int> numbers = new List<int>();
                StreamReader sr = new StreamReader(filename);
                while(!sr.EndOfStream)
                {
                    string[] str = sr.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);
                    foreach(string s in str){
                        int.TryParse(s, out int num);
                        numbers.Add(num);
                    }
                }
                a = new int[1,numbers.Count];
                int i = 0;
                foreach(int num in numbers)
                {
                    a[0,i] = num;
                    i++;
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                int[,] a = {};
            }
        }
        /// <summary>
        /// Метод: Массив в строку
        /// </summary>
        public override string ToString()
        {
            int rows = a.GetUpperBound(0) + 1;
            int columns = a.Length / rows;
            string str = "";
            for(int j = 0; j < rows; j++)
            {
                if(j == 0) str += "{{";
                else str += "{";
                for(int i = 0; i < columns; i++)
                {
                    if(i != columns - 1) str += $"{a[j,i]},";
                    else str += $"{a[j,i]}";
                }
                if (j != rows - 1) str += "}";
                else str += "}}";
            }
            return str;
        }
    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Работа с библиотекой Lib.Array2d
            
            Array2d arr = new Array2d(2,4);
            Console.WriteLine($"Элементы массива одной строкой: {arr.ToString()}");
            Console.WriteLine($"Сумма всех элементов массива равна: {arr.Summ()}");
            int start = 30;
            Console.WriteLine($"Сумма всех элементов массива >= {start} равна: {arr.Summ(start)}");
            System.Console.WriteLine($"Минимальный элемент массива= {arr.Min}");
            System.Console.WriteLine($"Максимальный элемент массива= {arr.Max}");
            int row;
            int column;
            arr.MaxItem(out row, out column);
            System.Console.WriteLine($"Номер максимального элемент массива = a[{row},{column}]");
            

            //
            string filename = @"./load/load.txt";
            string separator = " ";
            Array2d ara = new Array2d(filename, separator);
            Console.WriteLine($"Элементы массива одной строкой: {ara.ToString()}");
        }
    }
}
