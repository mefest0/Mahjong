using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Mahjong
{
    /// <summary>
    /// Игровая кость.
    /// </summary>

    public partial class Tile : UserControl
    {
        public int GroupNumber { get; private set; }
        public TileKey Key { get; private set; } 
        public Color SaveColor { get; private set; } 
        private Field parent;

        // Задание цвета кости в зависимости от высоты и отрисовка номера группы.
        private void Decorate()
        {
            this.BackColor = Color.FromArgb(80 + Key.Z * 25, 80 + Key.Z * 25, 150 + Key.Z * 15);
            this.SaveColor = BackColor;
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Font font = new Font("Arial", 20, System.Drawing.GraphicsUnit.Pixel);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            int colorCoef = (Key.Z > 2) ? 255 : 0;
            graphics.DrawString(GroupNumber.ToString(), font, new SolidBrush(Color.FromArgb(255 - colorCoef, 255 - colorCoef, 255 - colorCoef)), 0, 0);
            this.BackgroundImage = bitmap;
        }

        public Tile()
       {
            this.Key = TileKey.NullKey;
            GroupNumber = 0;
            InitializeComponent();
        }

        public Tile(int number, TileKey key)
        {
            this.Key = key;
            GroupNumber = number;
            InitializeComponent();
            Decorate();
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            if (ActivateCheck())
            {
                // Выделение нажатой кости
                this.BackColor = Color.FromArgb(SaveColor.R, SaveColor.G, SaveColor.B - 50);
                if (this.Parent is Field)
                {
                    // Если другая кнопка была нажата ранее ее цвет меняется к исходному
                    if (parent.SelectedTileKey != TileKey.NullKey && parent.SelectedTileKey != this.Key)
                    {
                        Tile SelectedTile = parent.tilesDictionary[parent.SelectedTileKey] as Tile;
                        SelectedTile.BackColor = SelectedTile.SaveColor;
                        // Если при этом групповой номер соответсовует данной кнопке - обе удаляются с поля 
                        if (SelectedTile.GroupNumber == this.GroupNumber)
                        {
                            parent.Remove(parent.SelectedTileKey);
                            parent.Select(TileKey.NullKey);
                            parent.Remove(Key);
                        }
                        else parent.Select(this.Key);
                    }
                    else parent.Select(this.Key);

                }
            }
        }

        // Проверка возможности использования кости
        // (должна быть активна только в случае отсутствия кости справа, слева и сверху)
        private bool ActivateCheck()
        {
            TileKey ElementFromLeft = new TileKey(Key.X - 1, Key.Y, Key.Z);
            TileKey ElementFromRight = new TileKey(Key.X + 1, Key.Y, Key.Z);
            TileKey ElementFromUp = new TileKey(Key.X, Key.Y, Key.Z + 1);

            if ((parent.tilesDictionary.ContainsKey(ElementFromLeft) && parent.tilesDictionary.ContainsKey(ElementFromRight)) || parent.tilesDictionary.ContainsKey(ElementFromUp))
                return false;
            else return true;
        }

        private void Tile_ParentChanged(object sender, EventArgs e)
        {
             parent = this.Parent as Field;
        }
    }
}
