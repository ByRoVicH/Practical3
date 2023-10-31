using LibMas;

namespace Lib_12
{
    public class TaskSolver
    {
        public static int CountDescendingOrderColumns(int[,] matrix)
        {
            int columnsCount = matrix.GetLength(1);
            int descendingOrderCount = 0;

            for (int col = 0; col < columnsCount; col++)
            {
                bool isDescending = true;
                for (int row = 1; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, col] > matrix[row - 1, col])
                    {
                        isDescending = false;
                        break;
                    }
                }

                if (isDescending)
                {
                    descendingOrderCount++;
                }
            }

            return descendingOrderCount;
        }
    }
}
