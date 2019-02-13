using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MyLibDB
{
    [Serializable]
    public class DItem
    {
        string _key;    // Ключ
        string _data;   // Данные

        // Для сериализации должен быть пустой конструктор.
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public DItem()
        {
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="data">Данные</param>
        public DItem(string key, string data)
        {
            this._key = key;
            this._data = data;
        }
        /// <summary>
        /// Ключ {get;set;}
        /// </summary>
        public string Key { get => _key; set => _key = value; }
        /// <summary>
        /// Данные {get;set;}
        /// </summary>
        public string Data { get => _data; set => _data = value; }
    }
    public class MyDB
    {
        string _fileName; //Полный путь к файлу
        List<DItem> _list; //Список данных

        /// <summary>
        /// Свойство: путь к файлу
        /// </summary>
        public string FileName
        {
            set { _fileName = value; }
        }
        /// <summary>
        /// Конструктор новой базы
        /// </summary>
        /// <param name="fileName">Полный путь к файлу</param>
        public MyDB(string fileName)
        {
            this._fileName = fileName;
            this._list = new List<DItem>();
        }
        /// <summary>
        /// Добавление новой записи в базу
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="data">Данные</param>
        public void Add(string key, string data)
        {
            this._list.Add(new DItem(key, data));
        }
        /// <summary>
        /// Удаление элемента базы по его индексу
        /// </summary>
        /// <param name="index">Индекс [0..Count-1]/param>
        public void Remove(int index)
        {
            if (this._list != null && index < this._list.Count && index >= 0) this._list.RemoveAt(index);
        }
        /// <summary>
        /// Индексатор - свойство для доступа к закрытому объекту
        /// </summary>
        /// <param name="index">Индекс элемента базы</param>
        /// <returns></returns>
        public DItem this[int index]
        {
            get { return this._list[index]; }
        }
        /// <summary>
        /// Сохранить базу в файл
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<DItem>));
            Stream fStream = new FileStream(this._fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, this._list);
            fStream.Close();
        }
        /// <summary>
        /// Загрузить базу из файла
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<DItem>));
            Stream fStream = new FileStream(this._fileName, FileMode.Open, FileAccess.Read);
            this._list = (List<DItem>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        /// <summary>
        /// Свойство: Количество записей в базе
        /// </summary>
        public int Count
        {
            get { return this._list.Count; }
        }
    }
}
