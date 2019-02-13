using System;
using System.Collections.Generic;
using System.IO;

namespace CSVtoXML
{
    [Serializable]
    public class Student
    {
        string _lastName;
        string _firstName;
        string _university;
        string _faculty;
        string _department;
        int _course;
        int _group;
        string _city;
        int _age;

        public Student()
        {

        }
        public Student(string lastName, string firstName, string university, string faculty, string department, int course, int group, string city, int age)
        {
            this._lastName = lastName;
            this._firstName = firstName;
            this._university = university;
            this._faculty = faculty;
            this._department = department;
            this._course = course;
            this._group = group;
            this._city = city;
            this._age = age;
        }

        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string University { get => _university; set => _university = value; }
        public string Faculty { get => _faculty; set => _faculty = value; }
        public string Department { get => _department; set => _department = value; }
        public int Course { get => _course; set => _course = value; }
        public int Group { get => _group; set => _group = value; }
        public string City { get => _city; set => _city = value; }
        public int Age { get => _age; set => _age = value; }
    }
    public class Base
    {
        List<Student> _list;

        public List<Student> List { get => _list; set => _list = value; }

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
        }
    }
    public class ConvCSVtoXML
    {
        string _inFile;
        string _outFile;
        /// <summary>
        /// Преобразование CSV в XML
        /// </summary>
        /// <param name="inFile">Полный путь к CSV файлу</param>
        /// <param name="outFile">Полный путь к XML файлу</param>
        public void Conv(string inFile, string outFile, char separator = ';')
        {

        }
        private void LoadCSV(string path, char separator)
        {

        }
        private void SaveXML(string path)
        {

        }
    }
}
