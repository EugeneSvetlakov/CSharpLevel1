using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
// 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
// а) Вывести только те слова сообщения,  которые содержат не более n букв.
// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
// в) Найти самое длинное слово сообщения.
// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
// д) ***Создать метод, который производит частотный анализ текста. 
//В качестве параметра в него передается массив слов и текст, 
//в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
//Здесь требуется использовать класс Dictionary.
namespace lev1les5t2
{
    public class Message
    {
        private string _msg;

        public string msg
        {
            get { return this._msg; }
            set { this._msg = value; }
        }
        /// <summary>
        /// Вывести только те слова сообщения, которые содержат не более n букв.
        /// </summary>
        /// <param name="maxsimbols">максимальное количество символов в строке</param>
        public List<string> GetWords(int maxsimbols)
        {
            List<string> str = new List<string>();
            foreach (string substr in this._msg.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (substr.Length <= maxsimbols)
                {
                    str.Add(substr);
                }
            }
            return str;
        }
        /// <summary>
        /// Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        /// </summary>
        /// <param name="EndWordChar">символ</param>
        public void RemWords(char EndWordChar)
        {
            string resmsg = string.Empty;
            foreach (string substr in this._msg.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (!substr.EndsWith(EndWordChar))
                {
                    resmsg += $"{substr} ";
                }
            }
            this._msg = resmsg.Trim();
        }
        /// <summary>
        /// Длина самого длинного слова в сообщении.
        /// </summary>
        public int BigestWordLength
        {
            get
            {
                int maxLength = 0;
                foreach (string item in this._msg.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                {
                    if (item.Length > maxLength)
                    {
                        maxLength = item.Length;
                    }
                }
                return maxLength;
            }
        }
        /// <summary>
        /// Список самых длинных слов в сообщении
        /// </summary>
        public List<string> BigestWords()
        {
            List<string> res = new List<string>();
            int maxLength = this.BigestWordLength;
            foreach (string item in this._msg.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (item.Length == maxLength)
                {
                    res.Add(item);
                }
            }
            return res;
        }
        /// <summary>
        /// Частотный анализо текста по заданному словарю.
        /// </summary>
        /// <param name="text">входной текст</param>
        /// <param name="words">словарь слов, списком</param>
        public static Dictionary<string, int> FreqDict(string text, List<string> words)
        {
            text = text.Replace("\n", " ").Replace("\r\n", " ");
            Dictionary<string, int> Dict = new Dictionary<string, int>();
            string itm = string.Empty;
            char[] dchar = new char[] { ' ', ',', '.', '!', '?', ':', ';', '(', ')' };
            foreach (string item in words)
            {
                itm = item.Trim().ToLower();
                if (!Dict.ContainsKey(itm))
                {
                    Dict.Add(itm, 0);
                }
            }
            foreach (string item in text.Split(dchar, StringSplitOptions.RemoveEmptyEntries))
            {
                itm = item.Trim().ToLower();
                if (Dict.ContainsKey(itm))
                {
                    Dict[itm] += 1;
                }
            }
            return Dict;
        }
        /// <summary>
        /// Частотный анализо текста по заданному словарю.
        /// </summary>
        /// <param name="text">входной текст</param>
        /// <param name="words">словарь слов, строкой с делением элементов символом пробела</param>
        public static Dictionary<string, int> FreqDict(string text, string words)
        {
            text = text.Replace("\n", " ").Replace("\r\n", " ");
            words = words.Replace("\n", " ").Replace("\r\n", " ");
            Dictionary<string, int> Dict = new Dictionary<string, int>();
            string itm = string.Empty;
            char[] dchar = new char[] { ' ', ',', '.', '!', '?', ':', ';', '(', ')' };
            foreach (string item in words.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                itm = item.Trim().ToLower();
                if (!Dict.ContainsKey(itm))
                {
                    Dict.Add(itm, 0);
                }
            }
            foreach (string item in text.Split(dchar, StringSplitOptions.RemoveEmptyEntries))
            {
                itm = item.Trim().ToLower();
                if (Dict.ContainsKey(itm))
                {
                    Dict[itm] += 1;
                }
            }
            return Dict;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Инициируем класс и передаем в него сообщение
            Message m1 = new Message();
            m1.msg = "sssdassd asdsda sdssaasd sdsssdw 2dsadsadacer3cffwf2 ssda sddawdw ddsda awww aa a wd32fef sdsadsadacer3cffwfr";
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Исходное сообщение:");
            Console.ResetColor();
            System.Console.WriteLine($"{m1.msg}");
            //Выводим слова длина который не больше заданного числа символов
            int msibm = 5;
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Слова сообщения, которые содержат не более {msibm} симолов: ");
            Console.ResetColor();
            foreach (string item in m1.GetWords(msibm))
            {
                System.Console.Write($"| {item} |");
            }
            System.Console.WriteLine();
            //Удаляем из сообщения слова заканчивающмеся на заданный символ
            char ch = 'w';
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Удалв из сообщения слова, заканчивающиеся на '{ch}' получим: ");
            Console.ResetColor();
            m1.RemWords(ch);
            System.Console.WriteLine($"'{m1.msg}'");
            //Выводим самое длинное слово в сообщении
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Самые длинные слова в сообщении: ");
            Console.ResetColor();
            StringBuilder bigword_msg = new StringBuilder();
            foreach (string item in m1.BigestWords())
            {
                bigword_msg.Append($"{item}  ");
            }
            System.Console.WriteLine(bigword_msg.ToString().Trim());

            //Частотный анализ текста
            string path_text = @"./txt/chechov.txt";
            string path_dict = @"./txt/chechov_dict.txt";
            try
            {
                string txt_text = File.ReadAllText(path_text);
                string txt_dict = File.ReadAllText(path_dict);
                txt_dict = txt_dict.Replace("\n", " ").Replace("\r\n", " ");
                var res = Message.FreqDict(txt_text, txt_dict);
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Результат частотного анализа текста согласно приложенному словарю:");
                Console.ResetColor();
                foreach (KeyValuePair<string, int> kvp in res)
                {
                    System.Console.WriteLine($"Key: '{kvp.Key}'\tValue: {kvp.Value}");
                }
            }
            catch (System.Exception)
            {

                //throw;
            }

        }
    }
}
