using System;
using System.Windows;
using LibMas;
using Lib_12;
using System.Windows.Controls;

namespace Practical3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("3 практическую работу выполнил студент группы ИСП-34 Букин Ярослав. Задание: Дана матрица размера M × N. Найти количество ее столбцов, элементы которых упорядочены по убыванию.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            int M, N;

            if (int.TryParse(textBoxM.Text, out M) && int.TryParse(textBoxN.Text, out N))
            {
                int minValue = 0; // Минимальное значение для генерации
                int maxValue = 10; // Максимальное значение для генерации

                int[,] matrix = ArrayHelper.GenerateRandomMatrix(M, N, minValue, maxValue);
                matrixText.Text = "Сгенерированная матрица:\n" + MatrixToString(matrix);

                int descendingOrderColumns = TaskSolver.CountDescendingOrderColumns(matrix);
                resultText.Text = $"Количество столбцов в убывающем порядке: {descendingOrderColumns}";
            }
            else
            {
                MessageBox.Show("Введите корректные значения для M и N.");
            }
        }

        private string MatrixToString(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            string result = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += matrix[i, j] + "\t";
                }
                result += "\n";
            }

            return result;
        }
    }
}
