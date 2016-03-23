using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mahjong
{
    /// <summary>
    /// Игровое поле.
    /// </summary>

    public partial class Field : UserControl
    {
        public Dictionary<TileKey, Tile> tilesDictionary { get; private set; }
        public TileKey SelectedTileKey { get; private set; } 
        public int PointsCount { get; private set; }
        public Difficulty Difficulty { get; private set; }

        private int diffCoeff; // Коэффициент умножения для очков
        private Label pointsLabel;

        public Field()
        {
            tilesDictionary = new Dictionary<TileKey, Tile>();
            SelectedTileKey = TileKey.NullKey;
            InitializeComponent();
        }

        public Field(int xCount, int yCount) : this() // xCount, yCount - Количество элементов по ширине и длине поля
        {
            Tile tempTile = new Tile();
            this.Size = new Size(new Point(xCount * (tempTile.Width + 5) + 7, yCount * (tempTile.Height + 5) + 7));
        }

        public Field(int xCount, int yCount, Label pointsLabel, Difficulty diff) : this(xCount, yCount)
        {
            this.pointsLabel = pointsLabel;
            PointsCount = 0;
            pointsLabel.Text = "Ваш счет: 0 очков.";
            Difficulty = diff;
            switch (diff)
            {
                case Difficulty.Easy: diffCoeff = 1; break;
                case Difficulty.Hard: diffCoeff = 3; break;
                case Difficulty.Standart: diffCoeff = 2; break;
            }
        }

        public Field(int xCount, int yCount, Label pointsLabel, Difficulty diff, int result) : this(xCount, yCount, pointsLabel, diff)
        {
            PointsCount = result;
        }

        // Добавление игровой кости на поле
        public void Add(TileKey key, Tile tile)
        {
            tilesDictionary.Add(key, tile);
            Controls.Add(tile);
            if (key.Z > 0) tile.BringToFront();
        }

        // Удаление игровой кости с поля
        public void Remove(TileKey key)
        {
            PointsChange();
            Controls.Remove(tilesDictionary[key] as Tile);
            (tilesDictionary[key] as Tile).Dispose();
            tilesDictionary.Remove(key);
        }

        // Запоминание нажатой кости
        public void Select(TileKey key)
        {
            SelectedTileKey = key;
        }

        // Изменение очков
        private void PointsChange()
        {
            if (pointsLabel != null)
            {
                PointsCount += 10 * diffCoeff;
                pointsLabel.Text = string.Format("Ваш счет: {0} очков.", PointsCount);
            }
        }
    }
}
