using System;

    class FilltheMatrixA
    {
        static void Main()
        {
            int N=int.Parse(Console.ReadLine());
            int[,] matrixA = new int[N, N];
            int counter=0;

            for(int i=0;i<N;i++)
            {
                for(int j=0;j<N;j++)
                {
                    counter++;
                    matrixA[j, i] = counter;
                }
            }
            printMatrix(matrixA);
        }

       public static void printMatrix(int[,] matrix)
        {
           int length=(int)Math.Sqrt(matrix.Length);
           for(int i =0;i<length;i++)
           {
               for(int j=0;j<length;j++)
               {
                   Console.Write(matrix[i,j]+" ");
               }
               Console.WriteLine();
           }
        }
    }
