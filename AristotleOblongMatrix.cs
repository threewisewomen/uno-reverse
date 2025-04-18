using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public class AristotleOblongMatrix
    {
        private IMatrixOperations _operations;
        public AristotleOblongMatrix(IMatrixOperations operations)
        {
            _operations = operations;
        }
        public void AritoteOblongMatrixMain()
        {
            Console.WriteLine("Enter your favourite even number");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            // Ensure the number is even
            if (n % 2 != 0)
            {
                Console.WriteLine("That's not an even number! I'll add 1 to make it even.");
                n += 1;
            }
            int rows = n / 2;
            int cols = rows + 1;
            double[,] matrix2 = new double[rows, cols];

            matrix2[0, 0] = 1;
            matrix2[0, 1] = 2;

            for (int j = 2; j < cols; j++)
            {
                matrix2[0, j] = 1;
            }
            Console.WriteLine("------------------1st in---------------------");

            _operations.PrintMatrix(matrix2);
            for (int k = 2; k <= rows; k++)
            {
                int rowidx = k - 1;//zero based index
                int colidx = k;//zero based index

                for (int i = 0; i < rowidx; i++)
                {
                    matrix2[i, colidx] = i + 1;
                    Console.WriteLine($"------matrix2[i, colidx][{i},{colidx}]----------for inside for i-----k={k}--rowidx={rowidx}------------");


                    _operations.PrintMatrix(matrix2);

                }

                int evennumber = 2 * k;
                for (int l = 0; l <= colidx; l++)
                {
                    matrix2[rowidx, l] = evennumber - l;
                    Console.WriteLine($"-------matrix2[rowidx, l][{rowidx},{l}]------------for inside for l-------k={k}--------colidx={colidx}---------------");

                    _operations.PrintMatrix(matrix2);

                }
                //for (int m = k+1; m < cols; m++)
                //{
                //    matrix2[idx, m] = k;
                //}
                Console.WriteLine($"----------------for k---------rows={rows}--------------");


                _operations.PrintMatrix(matrix2);





            }
            Console.WriteLine("----------------FINAL-----------------------");

            _operations.PrintMatrix(matrix2);
        }
    }
}
