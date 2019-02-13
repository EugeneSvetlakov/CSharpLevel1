using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

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
        string _inFile;
        string _outFile;
        List<Student> _list;

        public Base()
        {
        }

        public string InFile { get => _inFile; set => _inFile = value; }
        public string OutFile { get => _outFile; set => _outFile = value; }
        public List<Student> List { get => _list; set => _list = value; }
    }
    public class ConvCSVtoXML
    {
        string _inFile;
        string _outFile;
        List<Student> _list;
        string _status;

        public ConvCSVtoXML()
        {
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="inFile">Входной CSV файл</param>
        /// <param name="outFile">Выходной XML файл</param>
        public ConvCSVtoXML(string inFile, string outFile)
        {
            _inFile = inFile;
            _outFile = outFile;
            _list = new List<Student>();
            _status = string.Empty;
        }
        /// <summary>
        /// Файл CSV {get;set;}
        /// </summary>
        public string InFile { get => _inFile; set => _inFile = value; }
        /// <summary>
        /// Выходной XML файл
        /// </summary>
        public string OutFile { get => _outFile; set => _outFile = value; }
        /// <summary>
        /// Список с данными
        /// </summary>
        public List<Student> List { get => _list; set => _list = value; }
        /// <summary>
        /// Статус последнего выполненного метода
        /// </summary>
        public string Status { get => _status; }
        /// <summary>
        /// Свойство размер списка с данными
        /// </summary>
        public int Count
        {
            get { return this._list.Count; }
        }
        /// <summary>
        /// Загрузка CSV файла
        /// </summary>
        /// <param name="separator">Делитель данных в строке</param>
        private void LoadCSV(char separator = ';')
        {
            FileInfo fi = new FileInfo(this.InFile);
            if(fi.Exists)
            {
                using (StreamReader sr = new StreamReader(this.InFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] s = sr.ReadLine().Split(separator);
                        // Добавляем в список новый экземпляр класса Student
                        if (s.Length == 9)
                        {
                            this._list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), s[7], int.Parse(s[8])));
                        }
                    }
                }
                if(this._list.Count > 1)
                {
                    this._status = "Load Ok";
                }
                else
                {
                    this._status = "Load Bad";
                }
            }
            else
            {
                this._status = "Load Bad";
            }
        }
        /// <summary>
        /// Сохранение данных в XML формат
        /// </summary>
        private void SaveXML()
        {
            FileInfo fi = new FileInfo(this.OutFile);
            if((!fi.Exists || !fi.IsReadOnly) && this._list.Count > 0)
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
                Stream fStream = new FileStream(this.OutFile, FileMode.Create, FileAccess.Write);
                xmlFormat.Serialize(fStream, this.List);
                fStream.Close();
                this._status = "Export Ok";
            }
            else
            {
                this._status = "Export Bad";
            }
        }
        /// <summary>
        /// Конвертер CSV -> XML
        /// </summary>
        /// <param name="separator"></param>
        public void Conv(char separator = ';')
        {
            this.LoadCSV(separator);
            if(this._status == "Load Ok")
            {
            this.SaveXML();
            }
        }
    }
}
