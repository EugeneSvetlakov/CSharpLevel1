using System;
using System.IO;
using System.Collections.Generic;

namespace Lib.Array2d
{
    public struct DataEl
    {
        public int row;
        public int column;
        public int num;
    }
    public class Array2d
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
        /// <summary>
        /// Метод: Сумма всех элементов массива
        /// </summary>
        public double Summ()
        {
            double sum = 0;
            foreach(int item in a)
            {
                sum += item;
            }
            return sum;
        }
        /// <summary>
        /// Метод: Сумма всех элементов массива, больших заданного значения
        /// </summary>
        /// <param name="from">минимальное значение</param>
        public double Summ(int from)
        {
            double sum = 0;
            foreach(int item in a)
            {
                if(item >= from) sum += item;
            }
            return sum;
        }
        /// <summary>
        /// Свойство: минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = a[0,0];
                foreach (int item in a)
                {
                    if(item < min) min = item;
                }
                return min;
            }
            
        }
        /// <summary>
        /// Свойство: максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = a[0,0];
                foreach (int item in a)
                {
                    if(item > max) max = item;
                }
                return max;
            }
            
        }
        /// <summary>
        /// Метод: Возвращает строку и колонку максимального элемента массива
        /// </summary>
        /// <param name="row">строка</param>
        /// <param name="column">столбец</param>
        public void MaxItem(out int row, out int column)
        {
            int rows = a.GetUpperBound(0) + 1;
            int columns = a.Length / rows;
            int max = a[0,0];
            row = 0;
            column = 0;
            for(int j = 0; j < rows; j++)
            {
                for(int i = 1; i < columns; i++)
                {
                    if(a[j,i] > max)
                    {
                        max = a[j,i];
                        row = j;
                        column = i;
                    }
                }
            }
        }
        /// <summary>
        /// Конструктор: загружает целочисленные данные из файла в массив недостающие/некорректные элементы заполняются '0'
        /// </summary>
        /// <param name="filename">файл</param>
        /// <param name="separator">символ-делитель строки на элементы</param>
        public Array2d(string filename, string separator)
        {
            try {
                List<int> numbers = new List<int>();
                List<DataEl> ls = new List<DataEl>();
                int row = 0;
                DataEl sl;
                StreamReader sr = new StreamReader(filename);
                while(!sr.EndOfStream)
                {
                    int column = 0;
                    string[] strseparator = new string[] {separator};
                    string[] str1 = sr.ReadLine().Split(strseparator,StringSplitOptions.RemoveEmptyEntries);
                    //string[] str = sr.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);
                    foreach(string s in str1){
                        sl.row = row;
                        sl.column = column;
                        int.TryParse(s, out int num);
                        sl.num = num;
                        ls.Add(sl);
                        System.Console.Write(s + ", ");
                        column++;
                    } 
                    row++;
                }
                sr.Close();
                int maxrow = 0;
                int maxcolumn = 0;
                foreach(DataEl item in ls)
                {
                    if(maxrow < item.row) maxrow = item.row;
                    if(maxcolumn < item.column) maxcolumn = item.column;
                }
                a = new int[maxrow + 1,maxcolumn + 1];
                foreach(DataEl item in ls)
                {
                    a[item.row,item.column] = item.num;
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                int[,] a = {};
            }
        }
    }
}
