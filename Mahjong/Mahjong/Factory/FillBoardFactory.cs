using System.Collections.Generic;
using System.Drawing;

namespace Mahjong
{

    /// <summary>
    /// Конкретная фабрика игровых костей, полностью заполняющая поле.
    /// </summary>

    class FillBoardFactory : TilesFactory
    {
        public override Dictionary<TileKey, Tile> CreateTiles(int xCount, int yCount, int zCount, Difficulty diff)
        {
            // Определение типа генератора значений для костей
            Generator gen;
            if (diff == Difficulty.Easy) gen = new SimpleAlgorithm();
            else gen = new StandartAlgorithm();

            Tile tempTile = new Tile();
            Dictionary<TileKey, Tile> tilesDictionary = new Dictionary<TileKey, Tile>();

            for (int z = 0; z < zCount; z++)
            {
                int[,] grNumbers = gen.GenerateNumbers(xCount, yCount, diff);
                for (int y = 0; y < yCount; y++)
                {
                    for (int x = 0; x < xCount; x++)
                    {
                        // Создаем ключ для кости
                        TileKey key = new TileKey(x, y, z);
                        // Создаем кость с заданным ключом и определяем начальную позицию
                        tempTile = new Tile(grNumbers[x,y], key) { Location = new Point(key.X * (tempTile.Width + 5) + 5 + z, key.Y * (tempTile.Height + 5) + 6 - z) };

                        tilesDictionary.Add(key, tempTile);
                    }
                }
            }
            return tilesDictionary;
        }

        // Создание одного экземпляра игровой кости
        public override Tile CreateTile(int xCount, int yCount, int zCount, int groupNumber)
        {
            TileKey key = new TileKey(xCount, yCount, zCount);
            Tile tile = new Tile(groupNumber, key);
            return tile;
        }
    }
}
