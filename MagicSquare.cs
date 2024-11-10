using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public class MagicSquare
    {
        public static int MagicSum(int m)
        {
            return ((m) * ((m * m) + 1) / 2);
        }

        public static int[,] DurerMagicSquare()
        {
            int[,] magicSquare = new int[4,4];
            int p,q = 0;
            //int j,k = 0;
            int count = 0;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        count++;
            //        if ((i == 0 && j == 0))
            //        {
            //            magicSquare[i, j] =  count;
            //            Console.WriteLine($"Placing count {count} for {i} x {j}");
            //        }
            //        else if((i == 3 && j == 0))
            //        {

            //        }
            //        else if((i == 0 && j == 3))
            //        {

            //        }
            //        else if((i == 3) && (j == 3))
            //        {

            //        }

            //        else
            //        {
            //            magicSquare[i,j] = 0;
            //        }
            //    }
            //}
            return magicSquare;

        }


        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
