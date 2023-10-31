using System;

namespace LibMas
{
    public class ArrayHelper
    {
        public static int[,] GenerateRandomMatrix(int M, int N, int minValue, int maxValue)
        {
            Random random = new Random();
            int[,] matrix = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }

            return matrix;
        }
    }
}
