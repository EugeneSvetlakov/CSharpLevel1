using System;

//С помощью рефлексии выведите все свойства структуры DateTime

namespace lev1les8t1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in typeof(DateTime).GetProperties())
            {
                Console.WriteLine($"Свойство: {item.Name}");
            }
            Console.ReadKey();
        }
    }
}
