using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matx = new int[5,5];

            matx[0, 0] = 1;
            matx[0, 1] = 2;
            matx[0, 2] = 3;
            matx[0, 3] = 4;
            matx[0, 4] = 100;

            matx[1, 0] = 5;
            matx[1, 1] = 6;
            matx[1, 2] = 7;
            matx[1, 3] = 8;
            matx[1, 4] = 200;

            matx[2, 0] = 9;
            matx[2, 1] = 10;
            matx[2, 2] = 11;
            matx[2, 3] = 12;
            matx[2, 4] = 300;

            matx[3, 0] = 13;
            matx[3, 1] = 14;
            matx[3, 2] = 15;
            matx[3, 3] = 16;
            matx[3, 4] = 400;

            matx[4, 0] = 17;
            matx[4, 1] = 18;
            matx[4, 2] = 19;
            matx[4, 3] = 20;
            matx[4, 4] = 500;


            for (int i = 0; i < matx.GetLength(0); i++)
            {
                for (int j = 0; j < matx.GetLength(1); j++)
                {
                    Console.Write(matx[i, j]+ " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            RotateMatrixBy90(matx);

            for (int i = 0; i < matx.GetLength(0); i++)
            {
                for (int j = 0; j < matx.GetLength(1); j++)
                {
                    Console.Write(matx[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public static int[,] RotateMatrixBy90(int[,] matrix)
        {
            if (matrix.Length == 0 || matrix.GetLength(0) != matrix.GetLength(1))
                throw new ArgumentException("");

            int n = matrix.GetLength(0) - 1;

            for (int layer = 0; layer <= n/2; layer++)
            {
                //Made mistake here initially , i should be less than end not <= as it will override
                //the values changed in first rotation
                for (int i = layer; i < n-layer; i++)
                {                   
                    int top = matrix[layer, i];                    

                    matrix[layer, i] = matrix[n-i, layer];
                    matrix[n-i, layer] = matrix[n-layer, n-i];
                    matrix[n - layer, n - i] = matrix[i,n-layer];
                    matrix[i, n-layer] = top;
                }
            }
            return matrix;
        }
    }
}
