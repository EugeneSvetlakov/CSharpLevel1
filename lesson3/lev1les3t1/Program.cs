using System;
//1. Работа с комплексными числами (за основу взять описание класса из методички):
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.
//Выполнил: Светлаков Е.С.
struct SComplex
    {
        double _re,_im;
        
        /// <summary>
        /// Структура комплексное число с передачей действительной и мнимой части.
        /// </summary>
        /// <param name="re">действительная часть</param>
        /// <param name="im">мнимая часть</param>
        public SComplex(double re, double im)
        {
            this._re = re;
            this._im = im;
        }

        /// <summary>
        /// Сложение комплексных чисел.
        /// </summary>
        /// <param name="x">второе слагаемое</param>
        public SComplex Plus(SComplex x)
	    {
            SComplex y;
            y._re = this._re + x._re;
            y._im = this._im + x._im;
            return y;
        }
        
        /// <summary>
        /// Вычитание комплексных чисел.
        /// </summary>
        /// <param name="x">вычитаемое</param>
        public SComplex Subtract(SComplex x)
	    {
            SComplex y;
            y._re = this._re - x._re;
            y._im = this._im - x._im;
            return y;
        }
        
        /// <summary>
        /// Умножение комплексных чисел.
        /// </summary>
        /// <param name="x">второй множитель</param>
        public SComplex Multi(SComplex x)
        {
            SComplex y;
            y._re = this._re * x._re - this._im * x._im;
            y._im = this._re * x._im + this._im * x._re;
            return y;
        }
        
        /// <summary>
        /// Возвращение строкового представления комплексного числа
        /// </summary>
        public string ToStr()
        {
            if(this._im >= 0) return $"{this._re}+{this._im}i";
            else return $"{this._re}{this._im}i";
        }
    }
class CComplex
{
    double _re,_im;
    
    /// <summary>
    /// Класс комплексное число без параметров.
    /// </summary>
    public CComplex()
    {
        this._im = 0;
        this._re = 0;
    }

    /// <summary>
    /// Класс комплексное число с передачей действительной и мнимой части.
    /// </summary>
    /// <param name="re">действительная часть</param>
    /// <param name="im">мнимая часть</param>
    public CComplex(double re, double im)
    {
        this._re = re;
        this._im = im;
    }
    
    /// <summary>
    /// Сложение комплексных чисел.
    /// </summary>
    /// <param name="x">второе слагаемое</param>
    public CComplex Plus(CComplex x)
    {
        CComplex y = new CComplex();
        y._re = this._re + x._re;
        y._im = this._im + x._im;
        return y;
    }
    
    /// <summary>
    /// Вычитание комплексных чисел.
    /// </summary>
    /// <param name="x">вычитаемое</param>
    public CComplex Subtract(CComplex x)
	    {
            CComplex y = new CComplex();
            y._re = this._re - x._re;
            y._im = this._im - x._im;
            return y;
        }
    
    /// <summary>
    /// Умножение комплексных чисел.
    /// </summary>
    /// <param name="x">второй множитель</param>
    public CComplex Multi(CComplex x)
        {
            CComplex y = new CComplex();
            y._re = this._re * x._re - this._im * x._im;
            y._im = this._re * x._im + this._im * x._re;
            return y;
        }

/// <summary>
/// Действительная часть комплексного числа {get; set}
/// </summary>
public double re
    {
        get { return this._re; }
        set { this._re = value; }
    }

/// <summary>
/// Мнимая часть комплексного числа {get; set}
/// </summary>
public double im
    {
        get { return this._im; }
        set { this._im = value; }
    }
    
    /// <summary>
    /// Возвращение строкового представления комплексного числа
    /// </summary>
    public string ToSt()
    {
        if(this._im >= 0) return $"{this._re}+{this._im}i";
        else return $"{this._re}{this._im}i";
    }
}

namespace lev1les3t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Работа со структурами комплексных чисел:");
            Console.ResetColor();
            SComplex C = new SComplex(1,-2);
            Console.WriteLine("Комплексное число C = " + C.ToStr());
            SComplex D = new SComplex(4,3);
            Console.WriteLine("Комплексное число D = " + D.ToStr());
            Console.WriteLine("Сумма комплексных чисел C и D = " + C.Plus(D).ToStr());
            Console.WriteLine("Разность комплексных чисел C и D = " + C.Subtract(D).ToStr());
            Console.WriteLine("Произведение комплексных чисел C и D = " + C.Multi(D).ToStr());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Работа с классами комплексных чисел:");
            Console.ResetColor();
            SComplex Cc = new SComplex(1,-2);
            SComplex Dc = new SComplex(4,3);
            Console.WriteLine("Комплексное число Cc = " + Cc.ToStr());
            Console.WriteLine("Комплексное число Dc = " + Dc.ToStr());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Программа умеет складывать, вычитать и умножать комплексные числа.");
            Console.WriteLine("1 - сложение, 2 - вычитание, 3 - умножение.");
            Console.ResetColor();
            Console.Write("Ваш выбор: ");
            switch (Console.ReadLine()){
                case "1":
                    Console.WriteLine("Сумма комплексных чисел Cc и Dc = " + Cc.Plus(Dc).ToStr());
                    break;
                case "2":
                    Console.WriteLine("Разность комплексных чисел Cc и Dc = " + Cc.Subtract(Dc).ToStr());
                    break;
                case "3":
                    Console.WriteLine("Произведение комплексных чисел Cc и Dc = " + Cc.Multi(Dc).ToStr());
                    break;
                default:
                    Console.WriteLine("Очень жаль, что вас не привлекли операции с комплексными числами.");
                    break;
            }
        }
    }
}
