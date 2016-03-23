using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahjong
{
    /// <summary>
    /// Пасьянс Маджонг.
    /// </summary>

    class Mahjong
    {
        private Form gameForm;
        private Field field;
        private Label pointsLabel;

        // Получаем форму для последующих манипуляций с ее размерами. Создаем label для записи количества очков.
        public Mahjong(Form gameForm)
        {
            this.gameForm = gameForm;
            this.pointsLabel = new Label();
            this.pointsLabel.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (204));
            this.pointsLabel.Location = new Point(22, 33);
            this.pointsLabel.Size = new System.Drawing.Size(200, 19);
            gameForm.Controls.Add(pointsLabel);
        }

        // Начало новой игры
        public void StartGame(int xCount, int yCount, int zCount, Difficulty diff, FieldType fType)
        {
            ResetGame();

            // Создание игрового поля заданных размеров, сложностью игры и label для записи очков. 
            field = new Field(xCount, yCount, pointsLabel, diff);
            Dictionary<TileKey, Tile> tilesDictionary;
            TilesFactory factory;

            // Создание фабрики в зависимости от выбора пользователя
            if (fType == FieldType.Rectangle) factory = new FillBoardFactory();
            else factory = new PyramidFactory();

            // Заполение словаря фабрикой
            tilesDictionary = factory.CreateTiles(xCount, yCount, zCount, diff);

            // Заполнение поля игровыми костями
            foreach (KeyValuePair<TileKey, Tile> pair in tilesDictionary)
            {
                field.Add(pair.Key, pair.Value);
            }

            // Корректировка размеров формы, начальной позиции поля и добавление поля в форму.
            field.Location = new Point(20, 58);
            gameForm.Size = new Size(new Point(field.Width + 55, field.Height + 118));
            this.gameForm.Controls.Add(field);
        }

        // Сброс игрового поля
        public void ResetGame()
        {
            if (field != null)
            {
                gameForm.Controls.Remove(field);
                field.Dispose();
            }
        }

        // Сохранение игры
        public void SaveGame(string fileName)
        {
            if (fileName != "" && field != null)
            {
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@fileName))
                    {
                        // Формирование первой строки: ширина, высота поля, текущее значение очков и сложность.
                        file.WriteLine(string.Format("{0}/{1}/{2}/{3}", field.Width, field.Height, field.PointsCount, field.Difficulty));
                        // Последующие строки записываются по типу "X/Y/Z/Номер группы" для каждой игровой кости
                        // X,Y,Z - относительные координаты, Номер группы - число на кости.
                        foreach (KeyValuePair<TileKey, Tile> pair in field.tilesDictionary)
                        {
                            file.WriteLine(string.Format("{0}/{1}", pair.Key.ToString(), pair.Value.GroupNumber));
                        }
                        file.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не могу сохранить файл на диск. Ошибка: " + ex.Message);
                }
            }
        }

        // Загрузка игрового поля
        public void LoadGame(string fileName)
        {
            if (fileName != "")
            {
                ResetGame();

                try
                {
                    string[] lines = System.IO.File.ReadAllLines(@fileName);
                    string[] firstLine = lines[0].Split('/');
                    field = new Field(0, 0, pointsLabel, (Difficulty)Enum.Parse(typeof(Difficulty), firstLine[3]), int.Parse(firstLine[2]));
                    field.Size = new Size(new Point(int.Parse(firstLine[0]), int.Parse(firstLine[1])));
                    pointsLabel.Text = string.Format("Ваш счет: {0} очков.", firstLine[2]);

                    for (int i = 1; i < lines.GetLength(0); i++)
                    {
                        int[] split = lines[i].Split('/').Select(x => int.Parse(x)).ToArray();
                        TileKey key = new TileKey(split[0], split[1], split[2]);
                        Tile tile = new Tile(split[3], key);
                        tile.Location = new Point(key.X * (tile.Width + 5) + 5 + key.Z, key.Y * (tile.Height + 5) + 6 - key.Z);
                        field.Add(key,tile);
                    }

                    field.Location = new Point(20, 58);
                    gameForm.Size = new Size(new Point(field.Width + 55, field.Height + 118));
                    this.gameForm.Controls.Add(field);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Файл поврежден. Ошибка: " + ex.Message);
                }
            }
        }
    }
}
