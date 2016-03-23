using System.Collections.Generic;

namespace Mahjong
{
    /// <summary>
    /// Абстрактная фабрика игровых костей.
    /// </summary>

    abstract class TilesFactory
    {
        public abstract Dictionary<TileKey, Tile> CreateTiles(int xCount, int yCount, int zCount, Difficulty difficulty);
        public abstract Tile CreateTile(int xCount, int yCount, int zCount, int groupNumber);
    }
}
