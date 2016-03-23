namespace Mahjong
{
    /// <summary>
    /// Генерация значений по "простому алгоритму":
    /// </summary>
  
    // Каждый столбец матрицы заполняется парными случайными значениями.
    // Если количество элементов в столбце нечетное - одно из значений переходит в следующий столбец.
    // Элементы в столбце перемешиваются. Количество элементов в матрице должно быть четным.

    class SimpleAlgorithm : Generator
    {
        public override int[,] GenerateNumbers(int xCount, int yCount, Difficulty diff)
        {
            int[,] arr = new int[xCount, yCount];

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

            // Оставшееся без пары значение
            int buffer = 0;

            for (int x = 0; x < xCount; x++)
            {
                // Заполняем попарно значения в столбце массива
                for (int y = 0; y < yCount; y += 2)
                {
                    int randomValue = random.Next(maxValue);
                    arr[x, y] = randomValue;
                    if (y + 1 < yCount) arr[x, y + 1] = randomValue;
                }
                // Проверка на нечетность для столбцов
                if (yCount % 2 == 1)
                {
                    // Записываем число в последнюю ячейку и буффер если столбец - четный или
                    // записываем значение из буффера в последнюю ячейку 
                    if (x % 2 == 0)
                    {
                        int temp = random.Next(maxValue);
                        buffer = temp;
                        arr[x, yCount - 1] = temp;
                    }
                    else arr[x, yCount - 1] = buffer;
                }
            }
            // Перемешиваем матрицу
            Shuffle(arr);

            return arr;
        }

        // Сортировка
        private void Shuffle<T>(T[,] arr)
        {
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                for (int i = arr.GetLength(1); i > 1; i--)
                {
                    int j = random.Next(i);
                    T tmp = arr[k, j];
                    arr[k, j] = arr[k, i - 1];
                    arr[k, i - 1] = tmp;
                }
            }

        }
    }
}
    
   
