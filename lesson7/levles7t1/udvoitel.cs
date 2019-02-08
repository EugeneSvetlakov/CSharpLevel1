using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace levles7t1
{
    class GElement
    {
        int _Target;
        int _Result;
        int _Counter;

        public GElement()
        {
            _Target = 0;
            _Result = 0;
            _Counter = 0;
        }
        public GElement(int Target, int Result, int Counter)
        {
            _Target = Target;
            _Result = Result;
            _Counter = Counter;
        }

        public int Target { get => _Target; set => _Target = value; }
        public int Result { get => _Result; set => _Result = value; }
        public int Counter { get => _Counter; set => _Counter = value; }
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
            string msg = $"Target: {this._StepList.Peek().Target}, Result: {this._StepList.Peek().Result}, ShagCounter: {udvoitel.Counter}, ListCount= {this._StepList.Count}";
            //MessageBox.Show(msg);
            //Debug.WriteLine(msg);
            return msg;
        }

        public void NewStep(int num)
        {
            this._StepList.Push(new GElement(this._StepList.Peek().Target, num, this._StepList.Peek().Counter++));
            Debug.WriteLine($"input num= {num}, Count List= {this._StepList.Count}");
            Debug.WriteLine(this.Print());
        }

        public void BackStep()
        {
            if (this._StepList.Count > 1)
            {
                this._StepList.Pop();
                Debug.WriteLine(this.Print());
            }
        }

        public void ClearGame()
        {
            this._StepList.Push(new GElement(this._StepList.Peek().Target,0,0));
            Debug.WriteLine(this.Print());
        }

        public void NewGame()
        {
            int target = random.Next(100);
            this._StepList.Clear();
            this._StepList.Push(new GElement(target,0,0));
            MessageBox.Show($"Получите число: '{target}' за минимальное количество ходов.");
            Debug.WriteLine(this.Print());
        }
    }
}
