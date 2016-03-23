using System;
namespace Mahjong
{
    /// <summary>
    /// Абстрактный генератор значений поля.
    /// </summary>

    abstract class Generator
    {
        protected Random random = new Random();
        public abstract int[,] GenerateNumbers(int xCount, int yCount, Difficulty diff);
    }
}
