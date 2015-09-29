using System;
using System.Linq;
using System.Collections.Generic;

    class MaximalSum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, M];
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                int[] temp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = temp[j];
                    if(i>=1&&j>=1&&i<=3&&j<=3)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Sum = {0}",sum);

            for (int i = 1; i <= 3;i++ )
            {
                for(int j=1; j<=3;j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }


                //printMatrix(matrix, N, M);
        }


        public static void printMatrix(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
