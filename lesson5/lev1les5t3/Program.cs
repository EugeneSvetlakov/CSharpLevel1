using System;
using System.Collections.Generic;
using System.Linq;
//3. Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
// Например: badc являются перестановкой abcd

namespace lev1les5t3
{
    class Program
    {
        /// <summary>
        /// Проверка является ли строка 1 перестановкой символов строки 2
        /// </summary>
        /// <param name="str1">строка 1</param>
        /// <param name="str2">строка 2</param>
        public static bool IsReversion(string str1, string str2)
        {
            Dictionary<char, int> Dict1 = StrToDict(str1);
            Dictionary<char, int> Dict2 = StrToDict(str2);
            Dict1 = Dict1.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            Dict2 = Dict2.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            bool reversion = true;
            if (Dict1.Count == Dict2.Count)
            {
                int length = Dict1.Count;
                for (int i = 0; i < length; i++)
                {
                    if (!(Dict1.Keys.ElementAt(i) == Dict2.Keys.ElementAt(i) && Dict1.Values.ElementAt(i) == Dict2.Values.ElementAt(i)))
                    {
                        reversion = false;
                        break;
                    }
                }
            }
            else
            {
                reversion = false;
            }
            return reversion;
        }
        /// <summary>
        /// Формируется частотный словарь символов содержащихся в строке
        /// </summary>
        /// <param name="str">строка</param>
        public static Dictionary<char, int> StrToDict(string str)
        {
            Dictionary<char, int> Dict = new Dictionary<char, int>();
            foreach (char item in str)
            {
                if (!Dict.ContainsKey(item))
                {
                    Dict.Add(item, 1);
                }
                else
                {
                    Dict[item] += 1;
                }
            }
            return Dict;
        }

        static void Main(string[] args)
        {
            string str1 = "assdf";
            string str2 = "fadss";
            bool revers = IsReversion(str1, str2);
            System.Console.WriteLine($"Строка 1{(revers ? " " : " НЕ ")}является перестановкой символов строки 2");
        }
    }
}