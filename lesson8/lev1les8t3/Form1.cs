using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок 
//(не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
//б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов 
//и добавив другие «косметические» улучшения на свое усмотрение.
//в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
//г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).

namespace lev1les8t3
{
    public partial class Form1 : Form
    {
        // База данных с вопросами
        TrueFalse database;
        string msgex1 = "Откройте существующую или создайте новую базу вопросов.";
        string msgex2 = "Текстовое поле не содержит вопроса. Напишите вопрос на который можно ответить Да/Нет.";
        string msgex3 = "Размер файла больше";

        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value-1);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi1 = new FileInfo(ofd.FileName);
                long filesizekb = (long)(fi1.Length / 1024);
                long filsezeMax = 5000;
                if(filesizekb <= filsezeMax)
                {
                    database = new TrueFalse(ofd.FileName);
                    database.Load();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                }
                else
                {
                    MessageBox.Show($"{msgex3} {filsezeMax}Кбайт. Выберите файл меньшего размера.");
                }
                
            }
        }

        private void btnSaveQues_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                if(!string.IsNullOrWhiteSpace(tboxQuestion.Text) && tboxQuestion.Text.Length > 2)
                {
                    database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
                    database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
                }
                else
                {
                    MessageBox.Show(msgex2);
                }
            }
            else
            {
                MessageBox.Show(msgex1);
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database != null)
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
            else
            {
                MessageBox.Show(msgex1);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                database.FileName = path;
                database.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}