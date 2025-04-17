using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public class AritoteSquareMatrix
    {
        private IMatrixOperations _operations;
        public AritoteSquareMatrix(IMatrixOperations operations)
        {
            _operations = operations;
        }
        public void AritoteSquareMatrixMain()
        {
            Console.WriteLine("Enter the size of the matrix (n x n): ");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            Console.WriteLine($"You entered: {n}");
            double[,] matrix2 = new double[n, n];

            for (int i = 1; i <= n; i++)
            {
                int idx = i - 1;//zero based index
                int oddnumber = (2 * i) -1;

                for(int j = 0;j<=idx;j++)
                {
                    matrix2[j,idx] = j+1;
                }
                for(int k = 0;k<n;k++)
                {
                    matrix2[idx, k] = oddnumber - k;
                }


            }
            _operations.PrintMatrix(matrix2);
        }
    }
}
