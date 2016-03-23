using System.Collections.Generic;
using System.Drawing;

namespace Mahjong
{
    class PyramidFactory : TilesFactory
    {
        /// <summary>
        /// Конкретная фабрика игровых костей, формирующая пирамиду.
        /// </summary>

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
                int[,] grNumbers;
                // Проверка на отрицательность входных параметров для метода генерации 
                if (z < xCount / 2 && z < yCount / 2)
                    grNumbers = gen.GenerateNumbers(xCount - z * 2, yCount - z * 2, diff);
                else break;

                for (int y = 0; y < yCount - z * 2; y++)
                {
                    for (int x = 0; x < xCount - z * 2; x++)
                    {
                        // Создаем ключ для кости
                        TileKey key = new TileKey(x + z, y + z, z);
                        // Создаем кость с заданным ключом и определяем начальную позицию
                        tempTile = new Tile(grNumbers[x, y], key) { Location = new Point(key.X * (tempTile.Width + 5) + 5 + z, key.Y * (tempTile.Height + 5) + 5 - z) };

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
