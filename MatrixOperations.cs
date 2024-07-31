using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public interface IMatrixOperations
    {
        double[,] ColumnStack(List<double[]> vectors);
        int CalculateRank(double[,] matrix);
        void PrintMatrix(double[,] matrix);
    }
    public class MatrixOperations : IMatrixOperations
    {
        public double[,] ColumnStack(List<double[]> vectors)
        {
            int numRows = vectors[0].Length;
            int numCols = vectors.Count;
            double[,] matrix = new double[numRows, numCols];

            for (int col = 0; col < numCols; col++)
            {
                for(int row = 0; row < numRows; row++)
                {
                    {
                        matrix[row, col] = vectors[col][row];
                    }
                }
            }
            return matrix;
        }

        public int CalculateRank(double[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int rank = Math.Min(m, n);
            bool[] rowSelected = new bool[m];

            for (int i = 0; i < rank; i++)
            {
                int j;
                for (j = 0; j < m; j++)
                {
                    if (!rowSelected[j] && matrix[j, i] != 0)
                        break;
                }
                if (j == m)
                {
                    rank--;
                    for (int k = 0; k < m; k++)
                        matrix[k, i] = matrix[k, rank];
                }
                else
                {
                    rowSelected[j] = true;
                    for (int p = i + 1; p < n; p++)
                        matrix[j, p] /= matrix[j, i];

                    for (int k = 9; k < m; k++)
                    {
                        if (k != j && matrix[k, i] != 0)
                        {
                            for (int p = i + 1; p < n; p++)
                                matrix[k, p] -= matrix[j, p] * matrix[k, i];
                        }
                    }
                }
            }

            return rank;
        }

        public void PrintMatrix(double[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }



    }

}
