using CSVtoXML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).

namespace lev1les8t5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = args.Length;
            string help = $"Преобразование из CSV в XML.\n\nlev1les8t5 [csv файл] [xml файл]";
            string err = $"Ошибка в синтаксисе. Запустите программу без параметров чтобы увидеть справку.";
            string waitk = "\nДля продолжения нажмите любую клавишу...";
            switch (count)
            {
                case 0:
                    Console.WriteLine(help);
                    Console.WriteLine(waitk);
                    Console.ReadKey();
                    break;
                case 2:
                    ConvCSVtoXML fil = new ConvCSVtoXML(args[0], args[1]);
                    fil.Conv();
                    Console.WriteLine($"{fil.Status}");
                    break;
                default:
                    Console.WriteLine(err);
                    Console.WriteLine(waitk);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
