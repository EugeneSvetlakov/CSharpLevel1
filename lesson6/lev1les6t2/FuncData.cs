using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
// а) Сделать меню с различными функциями и представить пользователю выбор, 
//для какой функции и на каком отрезке находить минимум. 
//Использовать массив (или список) делегатов, в котором хранятся различные функции.
// б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
//Пусть она возвращает минимум через параметр (с использованием модификатора out).

namespace lev1les6t2
{
    public delegate double Fx(double x);
    public class FindMin
    {

        public static double Fxx(double x)
        {
            return x * x;
        }
        public static double X(double x)
        {
            return x;
        }
        /// <summary>
        /// MinF
        /// </summary>
        /// <param name="F">Функция</param>
        /// <param name="x1">начало диаппазона</param>
        /// <param name="x2">конец диаппазона</param>
        /// <param name="dx">шаг</param>
        public static double MinF(FuncData FF)
        {
            Fx F = FF.F;
            double xx = FF.x_min;
            double x_max = FF.x_max;
            double dx = FF.dx;
            double minF = F(xx);
            double y = 0;
            while (xx <= x_max)
            {
                y = F(xx);
                if (minF > y) minF = y;
                //System.Console.WriteLine($"xx= {xx}\tF(x)= {Math.Round(y,4)}");
                xx = Math.Round(xx + dx, 2);
            }
            return Math.Round(minF, 4);
        }
        public static void ExportF(FuncData FF, string path)
        {
            Fx F = FF.F;
            double xx = FF.x_min;
            double x_max = FF.x_max;
            double dx = FF.dx;
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    while (xx <= x_max)
                    {
                        bw.Write(Math.Round(F(xx), 4));
                        xx = Math.Round(xx + dx, 2);
                    }
                }
            }
        }
        public static void LoadF(string path,out double[] result)
        {
            double d;
            List<double> dataF = new List<double>();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader bw = new BinaryReader(fs))
                {
                    for (int i = 0; i < fs.Length / sizeof(double); i++)
                    {
                        d = bw.ReadDouble();
                        dataF.Add(d);
                    }
                }
            }
            result = new double[dataF.Count];
            for (int i = 0; i < dataF.Count; i++)
            {
                result[i] = dataF.ElementAt(i);
            }
        }
        public static void LoadF(string path,out double[] result, out double min)
        {
            min = double.MaxValue;
            double d;
            List<double> dataF = new List<double>();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader bw = new BinaryReader(fs))
                {
                    for (int i = 0; i < fs.Length / sizeof(double); i++)
                    {
                        d = bw.ReadDouble();
                        dataF.Add(d);
                        if (d < min) min = d;
                    }
                }
            }
            result = new double[dataF.Count];
            for (int i = 0; i < dataF.Count; i++)
            {
                result[i] = dataF.ElementAt(i);
            }
        }
    }
    public class FuncData
    {
        Fx _F;
        double _x_min;
        double _x_max;
        double _dx;
        string _strF;

        public FuncData(Fx F, double x_min, double x_max, double dx, string strF)
        {
            this._F = F;
            this._x_min = x_min;
            this._x_max = x_max;
            this._dx = dx;
            this._strF = strF;
        }
        public Fx F
        {
            get { return this._F; }
            set { this._F = value; }
        }
        public double x_min
        {
            get { return this._x_min; }
            set { this._x_min = value; }
        }
        public double x_max
        {
            get { return this._x_max; }
            set { this._x_max = value; }
        }
        public double dx
        {
            get { return this._dx; }
            set { this._dx = value; }
        }
        public string strF
        {
            get { return this._strF; }
            set { this._strF = value; }
        }
    }
    public class MDict
    {
        public static string Tostr(Dictionary<string, Fx> Dict)
        {
            string result = string.Empty;
            foreach (KeyValuePair<string, Fx> kvp in Dict)
            {
                int idx = Dict.Keys.ToList().IndexOf(kvp.Key);
                result += $"{idx}. {kvp.Key};";
            }
            result = $"{result.Substring(0, result.Length - 1)}: ";
            return result;
        }
        public static Fx GetFxById(Dictionary<string, Fx> Dict, int idx)
        {
            return Dict.Values.ElementAt(idx);
        }
        public static string GetFstrById(Dictionary<string, Fx> Dict, int idx)
        {
            return Dict.Keys.ElementAt(idx);
        }

    }
}
