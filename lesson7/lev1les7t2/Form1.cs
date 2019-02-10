using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Используя Windows Forms, разработать игру «Угадай число». 
//Компьютер загадывает число от 1 до 100, 
//а человек пытается его угадать за минимальное число попыток. 
//Компьютер говорит, больше или меньше загаданное число введенного.  
//a) Для ввода данных от человека используется элемент TextBox;
//б) ** Реализовать отдельную форму c TextBox для ввода числа.

namespace lev1les7t2
{
    public partial class Form1 : Form
    {
        Game MyGame = new Game();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdScreen()
        {
            LBguess.Text = MyGame.Mygues.ToString();
            LBless.Text = MyGame.LessThen.ToString();
            LBmore.Text = MyGame.MoreThen.ToString();
            LBcounter.Text = MyGame.Counter.ToString();
        }

        private void NewGameMenuItem_Click(object sender, EventArgs e)
        {
            //Старт новой игры
            MyGame = new Game();
            UpdScreen();
            LBguess.Text = "_";
            btnMyGuess.Enabled = true;
        }

        private void btnMyGuess_Click(object sender, EventArgs e)
        {
            Form2 FormGetN = new Form2();
            FormGetN.StartPosition = FormStartPosition.Manual;
            FormGetN.Location = new Point(this.Location.X + 300, this.Location.Y + 20);
            DialogResult dr = FormGetN.ShowDialog();
            
            if (dr == DialogResult.OK)
            {
                MyGame.Guess(FormGetN.Game.Mygues.ToString());
                UpdScreen();
                if (MyGame.Winn == 1)
                {
                    btnMyGuess.Enabled = false;
                    MessageBox.Show($"Число угадано! Использовано {MyGame.Counter} ходов.");
                }
            }
            FormGetN.Dispose();
        }
    }
}
