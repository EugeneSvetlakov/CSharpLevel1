using System;
//*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
//Написать программу, демонстрирующую все разработанные элементы класса.
//* Добавить свойства типа int для доступа к числителю и знаменателю;
//* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//*** Добавить упрощение дробей.
//Выполнил: Светлаков Е.С.

namespace lev1les3t3
{
    class Fraction
    {
        int _numerator;
        int _denominator;
        
        /// <summary>
        /// Класс "дробь"
        /// </summary>
        
        /// <summary>
        /// Класс дробь без параметров.
        /// </summary>
        public Fraction(){
            this._numerator = 0;
            this._denominator = 1;
        }
        
        /// <summary>
        /// Класс дробь с передачей числителя и знаменателя.
        /// </summary>
        /// <param name="numerator">числитель</param>
        /// <param name="denominator">знаменатель</param>
        public Fraction(int numerator, int denominator){
            if(denominator > 0) {
                this._numerator = numerator;
                this._denominator = denominator;
            } else if(denominator < 0){
                this._numerator = numerator*(-1);
                this._denominator = denominator*(-1);
            } else {
                throw new ArgumentException(String.Format("Знаменатель не может быть равен {0}"
                            , denominator), "denominator");
            }
        }
        
        /// <summary>
        /// числитель {get;set}
        /// </summary>
        public int numerator
        {
            get { return this._numerator; }
            set { this._numerator = value; }
        }
        
        /// <summary>
        /// знаменатель {get;set}
        /// </summary>
        public int denominator
        {
            get { return this._denominator; }
            set { 
                if(value == 0){
                    throw new ArgumentException(String.Format("Знаменатель не может быть равен {0}"
                            , denominator), "denominator");
                } else if (value > 0) {
                    this._denominator = value;
                } else
                {
                    this._numerator *= -1;
                    this._denominator = -value;
                }
            }
        }
        
        /// <summary>
        /// Строковое представление дроби = 'числитель / знаменатель'.
        /// </summary>
        public string ToStr()
        {
            string str = $"{this._numerator}/{this._denominator}";
            return str;
        }
        
        /// <summary>
        /// Десятичное значение дроби {get;}
        /// </summary>
        public double Decimal
        {
            get { return (double) this._numerator / this._denominator; }
        }
        
        /// <summary>
        /// Сложение дробей: a.Addition(b), a и b - слагаемые дроби
        /// </summary>
        /// <param name="b">дробь - второе слагаемое</param>
        public Fraction Addition(Fraction b){
            Fraction c = new Fraction(this._numerator * b._denominator + b._numerator * this._denominator
                                    ,this._denominator * b._denominator);
            return c.Simplify();
        }
        
        /// <summary>
        /// Вычитание дробей: a.Subtraction(b), a - уменьшаемая дробь, b - вычитаемая дробь.
        /// </summary>
        /// <param name="b">вычитаемая дробь</param>
        public Fraction Subtraction(Fraction b){
            Fraction c = new Fraction(this._numerator * b._denominator - b._numerator * this._denominator
                                    ,this._denominator * b._denominator);
            return c.Simplify();
        }
        
        /// <summary>
        /// Умножение дробей: a.Multiplication(b), a, b - дроби-множители.
        /// </summary>
        /// <param name="b">дробь-множитель</param>
        public Fraction Multiplication(Fraction b){
            Fraction c = new Fraction(this._numerator * b._numerator, this._denominator * b._denominator);
            return c.Simplify();
        }
        
        /// <summary>
        /// Деление дробей: a.Division(b), a - дробь-делимое, b - дроби-делитель.
        /// </summary>
        /// <param name="b">дробь-делитель</param>
        public Fraction Division(Fraction b){
            Fraction c = new Fraction(this._numerator * b._denominator, this._denominator * b._numerator);
            return c.Simplify();
        }
        
        /// <summary>
        /// Упрощение дроби
        /// </summary>
        public Fraction Simplify()
        {
            int nod = 1;
            int a = Math.Abs(this._numerator);
            int b = Math.Abs(this._denominator);
            int cf = a;
            if (b < cf) cf = b;
            for (int i = cf; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    nod = i;
                    break;
                }
            }
            Fraction simpl = new Fraction(this._numerator / nod, this._denominator / nod);
            return simpl;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Создадим первую дробь:");
            Console.ResetColor();
            Fraction a = new Fraction(15,45);
            Console.WriteLine($"a = {a.ToStr()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("'Get' для числителя и знаменателя:");
            Console.ResetColor();
            Console.WriteLine($"Числитель a = {a.numerator}");
            Console.WriteLine($"Знаменатель a = {a.denominator}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Десятичное представления дроби:");
            Console.ResetColor();
            Console.WriteLine($"(double) a = {a.Decimal:F3}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Упрощение дробей:");
            Console.ResetColor();
            Fraction a_simp = a.Simplify();
            Console.WriteLine($"дробь a = {a.ToStr()} после упрощения = {a_simp.ToStr()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Создадим вторую дробь:");
            Console.ResetColor();
            Fraction b = new Fraction(7,12);
            Console.WriteLine($"b = {b.ToStr()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("'Set' для числителя и знаменателя");
            Console.ResetColor();
            b.numerator = 9;
            Console.WriteLine($"b.numerator = 9, b = {b.ToStr()}");
            b.denominator = 17;
            Console.WriteLine($"b.denominator = 17, b = {b.ToStr()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Демонстрация операций с дробями:");
            Console.ResetColor();
            Console.WriteLine($"a + b = {a.Addition(b).Simplify().ToStr()}");
            Console.WriteLine($"a - b = {a.Subtraction(b).Simplify().ToStr()}");
            Console.WriteLine($"a * b = {a.Multiplication(b).Simplify().ToStr()}");
            Console.WriteLine($"a / b = {a.Division(b).Simplify().ToStr()}");
            //Исключение ArgumentException("Знаменатель не может быть равен 0")
            //Для демонстрации - раскоментировать строку 128
            //Fraction c = new Fraction(4,0);
        }
    }
}
