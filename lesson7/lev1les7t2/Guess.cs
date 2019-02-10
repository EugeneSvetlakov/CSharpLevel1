using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lev1les7t2
{
    delegate void Suppose(string str);
    public class Game
    {
        int _Num;
        int _mygues;
        int _moreThen;
        int _lessThen;
        int _counter;
        int _state;
        Random random = new Random();

        public Game()
        {
            _Num = random.Next(1, 101);
            this._mygues = 0;
            this._moreThen = 1;
            this._lessThen = 100;
            this._counter = 0;
            this._state = -2; //-2 исходное состояние, -1 - 
        }

        public int Mygues { get => _mygues; set => _mygues = value; }
        public int MoreThen { get => _moreThen; set => _moreThen = value; }
        public int LessThen { get => _lessThen; set => _lessThen = value; }
        public int Winn { get => _state; set => _state = value; }
        public int Counter { get => _counter; set => _counter = value; }

        //public void NewGame()
        //{
        //    this._Num = random.Next(1, 101);
        //    //Debug.WriteLine($"{this._Num}");
        //}

        public void Guess(string str)
        {
            this._counter++;
            if (int.TryParse(str, out int gnum) && gnum >= 1 && gnum <= 100)
            {
                this._mygues = gnum;
                if (gnum == _Num)
                {
                    this._state = 1; //Число угадано.
                    this._lessThen = gnum;
                    this._moreThen = gnum;
                }
                else if(gnum > _Num) //Число больше чем загаданное
                {
                    this._lessThen = gnum;
                    this._state = 0; //Число не угадано
                }
                else //Число мнгьше чем загаданное
                {
                    this._moreThen = gnum;
                    this._state = 0; //Число не угадано
                }
            }
            else
            {
                this._state = -1; //Ошибка преобразования в число или число за заданным диаппазоном
            }
        }
    }
}
