using System;

class FilltheMatrixB
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] matrixA = new int[N, N];
        int counter = 0;
        int down = 0;

        for (int i = 0; i < N; i++)
        {
            if (down%2==0)
            {
                for (int j = 0; j < N; j++)
                {
                    counter++;
                    matrixA[j, i] = counter;
                }
            }
            if (down % 2 == 1)
            {
                for (int j = N-1; j >= 0; j--)
                {
                    counter++;
                    matrixA[j, i] = counter;
                }
            }
            down++;     
        }
        printMatrix(matrixA);
    }

    public static void printMatrix(int[,] matrix)
    {
        int length = (int)Math.Sqrt(matrix.Length);
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
