using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lev1les7t1
{
    class GElement
    {
        int _Target;
        int _Result;
        int _Counter;
        int _minStep;

        public GElement()
        {
            _Target = 0;
            _Result = 0;
            _Counter = 0;
            _minStep = 0;
        }
        public GElement(int Target, int Result, int Counter, int MinStep)
        {
            _Target = Target;
            _Result = Result;
            _Counter = Counter;
            _minStep = MinStep;
        }

        public int Target { get => _Target; set => _Target = value; }
        public int Result { get => _Result; set => _Result = value; }
        public int Counter { get => _Counter; set => _Counter = value; }
        public int MinStep { get => _minStep; set => _minStep = value; }
    }

    class udvoitel
    {
        static int _counter;
        Stack<GElement> _StepList;
        Random random = new Random();

        public udvoitel()
        {
            this._StepList = new Stack<GElement>();
        }

        internal Stack<GElement> StepList { get => _StepList; set => _StepList = value; }

        public static int Counter { get => _counter; }

        public static void Count()
        {
            _counter++;
            //Debug.WriteLine($"Всего кликов: {udvoitel.Counter}");
        }

        public string Print()
        {
            string msg = $"Target: {this._StepList.Peek().Target}, Result: {this._StepList.Peek().Result}, Counter: {this._StepList.Peek().Counter}, ListCount= {this._StepList.Count}, ClickCounter: {udvoitel.Counter}";
            //MessageBox.Show(msg);
            //Debug.WriteLine(msg);
            return msg;
        }

        public void NewStep(int num)
        {
            try
            {
                this._StepList.Push(new GElement(this._StepList.Peek().Target, num, this._StepList.Peek().Counter + 1, this._StepList.Peek().MinStep));
                Debug.WriteLine($"input num= {num}, Count List= {this._StepList.Count}");
                Debug.WriteLine(this.Print());
            }
            catch { }
        }

        public void BackStep()
        {
            try
            {
                if (this._StepList.Count > 1)
                {
                    this._StepList.Pop();
                    Debug.WriteLine(this.Print());
                }
            }
            catch { }
        }

        public void ClearGame()
        {
            try
            {
                this._StepList.Push(new GElement(this._StepList.Peek().Target, 0, 0, this._StepList.Peek().MinStep));
                Debug.WriteLine(this.Print());
            }
            catch { }
        }

        public void NewGame()
        {
            int target = random.Next(1,101);
            int minstep = 1;
            int startNum = target;
            while (true)
            {
                if (startNum == 1)
                {
                    break;
                }
                else
                {
                    if(startNum % 2 == 0)
                    {
                        startNum /= 2;
                    }
                    else
                    {
                        startNum -= 1;
                    }
                    minstep++;
                }
                
            }
            this._StepList.Clear();
            this._StepList.Push(new GElement(target, 0, 0, minstep));
            MessageBox.Show($"Получите число: '{target}' за {minstep} ходов.");
            Debug.WriteLine(this.Print());
        }
    }
}
