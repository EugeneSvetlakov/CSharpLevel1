using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
//**Считайте файл различными способами. 
//Смотрите “Пример записи файла различными способами”. 
//Создайте методы, которые возвращают 
// - массив byte (FileStream, BufferedStream), 
// - строку для StreamReader 
// - массив int для BinaryReader.
namespace lev1les6t4
{
    class Program
    {
        //static FileStream ReadFS(string path)
        //{
        //    FileStream fs = new FileStream(path, FileMode.Open);
        //    return fs;
        //}
        //static BufferedStream ReadBF(string path)
        //{

        //}
        static byte[] GetByteArr(string path)
        {

            byte[] arr = new byte[0];

            return arr;
        }
        static void Main(string[] args)
        {
        }
    }
}
