using System.Collections.Generic;
using System.Linq;

namespace Mahjong
{
    /// <summary>
    /// Генерация значений по "стандартному алгоритму":
    /// </summary>

    // Матрица делится на 2 коллекции - правую и левую. Количество элементов в каждой коллекции равно
    // высоте столбца матрицы. Элемент коллекции содержит индексы элементов матрицы, где ключ - номер столбца,
    // значение - номер строки. Матрица заполняется с середины. Поместив случайной число в ячейку, значение
    // в коллекции либо увеличивается (правая), либо уменьшается (левая) при том же ключе. Когда значение 
    // достигает границ массива, элемент с данным ключом удаляется и выборка происходит без него. Этот алгоритм
    // продолжается до тех пор, пока обе коллекции не будут пустыми (матрица заполнится полностью). 
    // Количество элементов в матрице должно быть четным.

    class StandartAlgorithm : Generator
    {
        public override int[,] GenerateNumbers(int xCount, int yCount, Difficulty diff)
        {
            int[,] arr = new int[xCount, yCount];

            //Словари, хранящие индексы для заполняемых ячеек
            Dictionary<int, int> leftCollection = new Dictionary<int, int>();
            Dictionary<int, int> rightCollection = new Dictionary<int, int>();

            //Заполнение словарей начальными данными (индексы ячеек из середины поля)
            for (int i = 0; i < yCount; i++)
            {
                leftCollection.Add(i, xCount / 2 - 1);
                rightCollection.Add(i, xCount / 2);
            }

            //Количесво ячеек на половине поля
            int cellsCount = (xCount * yCount) / 2;

            // Максимальное значение из разброса номеров для костей
            int maxValue;

            switch (diff)
            {
                case Difficulty.Hard:
                    maxValue = 36;
                    break;
                case Difficulty.Standart:
                    maxValue = 26;
                    break;
                default:
                    maxValue = 16;
                    break;
            }

            // Алгоритм заполнения массива
            for (int i = 0; i < cellsCount; i++)
            {
                int randomValue = random.Next(maxValue);
                int left = leftCollection.Keys.ElementAt(random.Next(0, leftCollection.Count));
                int right = rightCollection.Keys.ElementAt(random.Next(0, rightCollection.Count));

                arr[leftCollection[left], left] = randomValue;
                arr[rightCollection[right], right] = randomValue;

                leftCollection[left]--;
                rightCollection[right]++;
                if (leftCollection[left] < 0) leftCollection.Remove(left);
                if (rightCollection[right] > xCount - 1) rightCollection.Remove(right);
            }
            return arr;
        }
    }
}
