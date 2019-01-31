using System;
using System.Collections.Generic;
using Geek.Extensions;

//а) Дописать класс для работы с одномерным массивом. 
//- Реализовать конструктор, создающий массив определенного размера 
//и заполняющий массив числами от начального значения с заданным шагом. 
//- Создать свойство Sum, которое возвращает сумму элементов массива, 
//- метод Inverse, возвращающий новый массив с измененными знаками 
//у всех элементов массива (старый массив, остается без изменений), 
//- метод Multi, умножающий каждый элемент массива на определённое число, 
//- свойство MaxCount, возвращающее количество максимальных элементов. 
//б)** Создать библиотеку содержащую класс для работы с массивом. 
//Продемонстрировать работу библиотеки
//е) *** Подсчитать частоту вхождения каждого элемента в массив 
//(коллекция Dictionary<int,int>)
//Выполнил: Светлаков Е.С.

namespace ArrayClass
{
    /* 
    //Класс перенесен в библотеку Geek.Extensions
    class MyArray
    {
        int[] a;
        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n,int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        public MyArray(int[] b)
        {
            a = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
                a[i] = b[i];
        }
        /// <summary>
        /// Конструктор массива размерностью n
        /// </summary>
        /// <param name="n">размер массива</param>
        /// <param name="start">минимальное/начальое значение элемент</param>
        /// <param name="param">максимальное значение элемента(rand=true)/шаг(rand=false)</param>
        /// <param name="rand">true - заполненение случайными значениями, false - заполнение значениями с заданным шагом</param>
        public MyArray(int n, int start,int param, bool rand = true)
        {
            a = new int[n];
            if(rand)
            {
                Random rnd = new Random();
                int min = start;
                int max = param;
                for (int i = 0; i < n; i++)
                    a[i] = rnd.Next(min,max);
            }
            else
            {
                int num = start;
                for(int i = 0; i < n; i++)
                {
                    a[i] = num;
                    num += param;
                }
            }
        }
        
        public int Max
        {
            get 
            { 
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                    sum += a[i];
                return sum;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public int MaxCount
        {
            get
            {
                int max = this.Max;
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == max) count++;
                return count;
            }
        }
        public int[] Inverse()
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                b[i] = -a[i];
            return b;
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s += $"{v}  ";
            return s;
        }
        public void Multi(int multiplier)
        {
            for(int i = 0; i < a.Length; i++){
                a[i] = a[i] * multiplier;
            }
        }
    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Класс MyArray перенесен в библиотеку Geek.Extensions (задание 'б)**')

            //Массив размерности n, заполненный случайными целыми числами 
            //в диаппазоне от 0 до 99
            MyArray a = new MyArray(10, 0, 100);
            Console.WriteLine($"Массив состоит из: {a.ToString()}");
            Console.WriteLine($"Максимальный элемент: {a.Max}");
            Console.WriteLine($"Минимальный элемент: {a.Min}");
            Console.WriteLine($"Количество положительных элементов масива: {a.CountPositiv}");
            Console.WriteLine($"Сумма элементов массива: {a.Sum}");
            
            //Массив размерности 10, начальным значением 0, шагом 100
            MyArray b = new MyArray(10, 0, 100, false);
            Console.WriteLine($"Массив состоит из: {b.ToString()}");
            Console.WriteLine($"Максимальный элемент: {b.Max}");
            Console.WriteLine($"Минимальный элемент: {b.Min}");
            Console.WriteLine($"Количество положительных элементов масива: {b.CountPositiv}");
            Console.WriteLine($"Сумма элементов массива: {b.Sum}");
            
            //Инверсия
            Console.WriteLine("Инверсия:");
            MyArray c = new MyArray(b.Inverse());
            Console.WriteLine($"Массив после: {c.ToString()}");
            Console.WriteLine($"Исходный массив: {b.ToString()}");
            //Умножение всех элементов на заданный множитель
            int multiplier = 3;
            b.Multi(multiplier);
            Console.WriteLine($"Массив после умножения на {multiplier}: {b.ToString()}");
            
            //Количество максимальных элементов
            Console.WriteLine($"Количество максимальных ({b.Max}) элементов: {b.MaxCount}");

            //Метод подсчета чакстоты вхождения каждого элемента в массив
            //для класса MyArray хранится в библиотеке Geek.Extensions 
            ////результат формируется в виде коллекции Dictionary<int,int>
            Console.WriteLine("Подсчитаем чачстоту вхождения каждого элемента массива: ");
            MyArray elArr = new MyArray(20,5);
            Console.WriteLine(elArr.ToString());
            Dictionary<int,int> Dic = elArr.GetDictionary();
            Console.WriteLine("Получена следующая коллекция (метод для класса MyArray):");
            foreach(KeyValuePair<int, int> kvp in Dic)
            {
                Console.WriteLine($"Key = {kvp.Key}, Value = {kvp.Value}");
            }
        }
    }
}