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

//а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». 
//При нажатии появляется сообщение, какое число должен получить игрок.
//Игрок должен получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
//Используйте обобщенный класс Stack.
//Вся логика игры должна быть реализована в классе с удвоителем.

namespace lev1les7t1
{
    public delegate void GameClick(int num);

    public partial class WF_Udvoitel : Form
    {
        udvoitel Game = new udvoitel();
        GameClick gclick;
        public WF_Udvoitel()
        {
            InitializeComponent();
            gclick = Game.NewStep;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            gclick(int.Parse(lblResult.Text) + 1);
            updScreen();
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            gclick(int.Parse(lblResult.Text) * 2);
            updScreen();
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            udvoitel.Count();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Game.ClearGame();
            updScreen();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Game.BackStep();
            updScreen();
        }

        private void NewGameSubMenuItem_Click(object sender, EventArgs e)
        {
            Game.NewGame();
            updScreen();
            enBtn();
        }

        private void disBtn()
        {
            btnPlus.Enabled = false;
            btnX2.Enabled = false;
            btnBack.Enabled = false;
            btnReset.Enabled = false;
        }
        private void enBtn()
        {
            btnPlus.Enabled = true;
            btnX2.Enabled = true;
            btnBack.Enabled = true;
            btnReset.Enabled = true;
        }
        private void updScreen()
        {
            try
            {
                int res = Game.StepList.Peek().Result;
                int target = Game.StepList.Peek().Target;
                int step = Game.StepList.Peek().Counter;
                int minstep = Game.StepList.Peek().MinStep;
                lblResult.Text = res.ToString();
                lblShagCountNum.Text = step.ToString();
                lblCeilNum.Text = target.ToString();
                lblMinStep.Text = (minstep - step).ToString();
                if (step == minstep && target != res)
                {
                    disBtn();
                    MessageBox.Show("Вы проиграли!");
                }
                if (step == minstep && target == res)
                {
                    disBtn();
                    MessageBox.Show("Вы выиграли!");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e}");
            }
        }
    }
}
