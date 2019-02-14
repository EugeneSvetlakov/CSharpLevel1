using System;
using System.Collections.Generic;
using MyLibDB;
//*Используя полученные знания и класс TrueFalse в качестве шаблона, 
//разработать собственную утилиту хранения данных 
//(Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
namespace lev1les8t4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример работы утилиты хранения данных
            string path = "db1.xml"; //Исходная база
            string path2 = "db2.xml"; //Новая база
            MyDB db = new MyDB(path);
            db.Load();
            Console.WriteLine($"Count db before = {db.Count}");
            //Добавление элементов в базу
            db.AddRange(new List<DItem>() {{ new DItem("Киселева Г.В.", "20.10.1984") },
                { new DItem("Иванова Н.Г.", "15.05.1994")},
            { new DItem("Торжков И.С.", "01.11.1914") } } );
            Console.WriteLine($"Count db after add = {db.Count}");
            db.FileName = path2;
            db.Save();
            Console.ReadKey();
        }
    }
}
