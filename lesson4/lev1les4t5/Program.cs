using System;
using System.IO;
using System.Collections.Generic;
using Lib.Array2d; //Библиотека для работы с двумерным массивом

//*а) Реализовать библиотеку с классом для работы с двумерным массивом. 
//Реализовать конструктор, заполняющий массив случайными числами. 
//Создать методы, которые возвращают сумму всех элементов массива, 
//сумму всех элементов массива больше заданного, 
//свойство, возвращающее минимальный элемент массива, 
//свойство, возвращающее максимальный элемент массива, 
//метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
//**б) Добавить конструктор и методы, которые 
// - загружают данные из файла 
// - записывают данные в файл.
// **в) Обработать возможные исключительные ситуации при работе с файлами.
//Выполнил: Светлаков Е.С.

namespace lev1les4t5
{
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
            
            //Читаем массив из файла
            string filename = @"./load/load.txt";
            string separator = " ";
            Console.WriteLine($"Читаем массив из файла {filename}, символ-делитель элементов = '{separator}':");
            System.Console.WriteLine(File.ReadAllText(filename));
            Array2d ara = new Array2d(filename, separator);
            Console.WriteLine($"Элементы массива одной строкой: {ara.ToString()}");

            //Пишем массив в файл
            string path = $@"./export/ex_{DateTime.Now.ToString("yyyy-MM-dd_HH_mm")}.txt";
            System.Console.WriteLine($"Сохраним массив 'arr' в файл '{path}'");
            arr.ToFile(path);

        }
    }
}
