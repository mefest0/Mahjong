namespace Mahjong
{
    /// <summary>
    /// Ключ игровой кости.
    /// </summary>

    public struct TileKey
    {
        // Параметры местонахождения кости на поле
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        // Нулевой ключ
        public static TileKey NullKey = new TileKey(-1, -1, -1);

        public TileKey(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static bool operator ==(TileKey first, TileKey second)
        {
            if ((first.X == second.X) && (first.Y == second.Y) && (first.Z == second.Z))
                return true;
            else return false;
        }

        public static bool operator !=(TileKey first, TileKey second)
        {
            if ((first.X == second.X) && (first.Y == second.Y) && (first.Z == second.Z))
                return false;
            else return true;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", X, Y, Z);
        }
    }
}
