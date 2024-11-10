using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public class DiagonalTraverse
    {
        public static void DiagonalTraversev1(int n)
        {
            int num = 0;
            int z = 0;
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    num++;
                    matrix[i, j] = num;

                }
            }
            MagicSquare.PrintMatrix(matrix);
            int slice = 2 * n - 1;
            Console.WriteLine($" initial slice value: {slice}");

            for (int k = 0; k < slice; k++)
            {
                Console.WriteLine($"Slice {k}: ");
                if (k<n)
                {
                    z = 0;
                    Console.WriteLine($"{k} . z value: {z}");
                    Console.WriteLine($"slice value: {slice}");

                }
                else
                {
                    z = k - n + 1;
                    Console.WriteLine($"{k} . z value: {z}");
                    Console.WriteLine($"slice value: {slice}");

                }
                for (int j = z; j <= k - z; j++)
                {
                    Console.WriteLine($"{matrix[j,k-j]}");
                }
                Console.WriteLine("----------------");
            }
        }
        public static void DiagonalTraversalv2(int n)
        {
            int[,] matrix = new int[n,n];
            int slice = 2*n - 1;
            int xs = slice - n;
            int[,] selfmatri = new int[n,slice];
            int temp;
            int num = 0;
            int z = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    num++;
                    matrix[i, j] = num;

                }
            }


            for (int i = 0;i<n;i++)
            {
                for(int j = 0;j<slice;j++)
                {
                    if (j < n)
                    {
                        selfmatri[i, j] = matrix[i, j];
                    }
                    else
                    {
                        selfmatri[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < slice; j++)
                {

                }
            }
            MagicSquare.PrintMatrix(selfmatri);
        }

        public static void DiagonalTraversalv3(int n)
        {
            int[,] matrix = new int[n,n];
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    num++;
                    matrix[i, j] = num;

                }
            }
            MagicSquare.PrintMatrix(matrix);

            for (int k = 0; k <= 2 * (n - 1); k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        //Console.WriteLine(matrix[i, j]);
                        if (i + j == k)
                        {
                            Console.Write($"{i},{j}   ,  ");
                            //Console.WriteLine(matrix[i, j]);
                        }
                    }

                }
                Console.WriteLine();

            }




        }
    }
}

