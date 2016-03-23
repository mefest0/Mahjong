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
using Mahjong;
using System.Collections;

namespace Mahjong
{
    public partial class MainForm : Form
    {
        // Количество костей по ширине, длине и высоте
        public int XCount { get; set; }
        public int YCount { get; set; }
        public int ZCount { get; set; }
        // Сложность и тип поля
        public Difficulty Diff { get; set; }
        public FieldType FType { get; set; }

        private Mahjong mahjongGame;
        private NewGameForm form;

        public MainForm()
        {
            InitializeComponent();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mahjongGame != null)
            {
                saveFileDialog1.Filter = "Текстовый файл|*.txt";
                saveFileDialog1.Title = "Сохранение игры";
                if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName != null)
                        mahjongGame.SaveGame(saveFileDialog1.FileName);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Загрузить";
            openFileDialog1.Filter = "Тектовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if (mahjongGame == null)
                        mahjongGame = new Mahjong(this);

                    if (openFileDialog1.FileName != null)
                        mahjongGame.LoadGame(openFileDialog1.FileName);
                    сохранитьToolStripMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Файл поврежден. Ошибка: " + ex.Message);
                }
            }

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void новаяиграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form == null)
                form = new NewGameForm();

            form.Owner = this;
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (mahjongGame == null)
                    mahjongGame = new Mahjong(this);

                mahjongGame.StartGame(XCount, YCount, ZCount, Diff, FType);
                сохранитьToolStripMenuItem.Enabled = true;
                
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mahjongGame != null)
            {
                string message = "Сохранить прогресс?";
                string caption = "Маджонг";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    сохранитьToolStripMenuItem_Click(sender, e);
                }
            }
        }
    }
}
