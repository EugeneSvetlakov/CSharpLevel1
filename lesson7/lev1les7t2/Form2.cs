using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lev1les7t2
{
    
    public partial class Form2 : Form
    {
        Game retNum = new Game();
        public Game Game
        {
            get
            {
                return (retNum);
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClickOrEnter();
        }

        private void ClickOrEnter()
        {
            string str = textBox1.Text.Trim();
            bool b1 = int.TryParse(str, out int gnum);
            if (b1 && (gnum < 1 || gnum > 100))
            {
                MessageBox.Show("Ошибка! Введенное число за диапазоном 1..100.");
                return;
            }
            if (!b1)
            {
                MessageBox.Show("Ошибка преобразования в целое число.");
                return;
            }
            if (b1 && gnum >= 1 && gnum <= 100)
            {
                retNum.Mygues = gnum;
            }
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
