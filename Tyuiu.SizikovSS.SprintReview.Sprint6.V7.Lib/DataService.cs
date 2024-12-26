using System;
using tyuiu.cources.programming.interfaces.Sprint6;
using tyuiu.cources.programming.interfaces.Sprint88;

namespace Tyuiu.SizikovSS.SprintReview.Sprint6.V7.Lib
{
    public class DataService 
    {
        public int[,] GenMatrix(int N, int M, int n1, int n2)
        {
            Random random = new Random();
            int[,] result = new int[N, M];

            // Заполняем первую строку и первый столбец случайными значениями
            for (int i = 0; i < N; i++)
            {
                result[i, 0] = random.Next(n1, n2 + 1);
            }

            for (int j = 0; j < M; j++)
            {
                result[0, j] = random.Next(n1, n2 + 1);
            }

            // Заполняем остальные элементы, чередуя знаки
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < M; j++)
                {
                    int neighborLeft = result[i, j - 1];   // значение слева
                    int neighborUp = result[i - 1, j];     // значение сверху

                    // Генерируем новое случайное число
                    int value = random.Next(n1, n2 + 1);

                    // Определяем знак нового числа
                    if ((neighborLeft > 0 && neighborUp < 0) || (neighborLeft < 0 && neighborUp > 0))
                    {
                        result[i, j] = value;
                    }
                    else
                    {
                        result[i, j] = -value;
                    }
                }
            }

            return result;
        }

        public int GetMatrix(int[,] array, int c, int k, int l)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i < k || i > l) // Пропускаем строки в диапазоне от k до l
                {
                    if (array[i, c] < 0) // Проверяем, является ли элемент отрицательным
                    {
                        count++; // Увеличиваем счётчик
                    }
                }
            }

            return count;
        }


    }
}
