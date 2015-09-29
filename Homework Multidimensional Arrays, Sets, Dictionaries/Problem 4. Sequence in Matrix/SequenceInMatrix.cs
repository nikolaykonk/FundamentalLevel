using System;
using System.Collections.Generic;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        string[,] matrix = new string[N, M];
        int maxCounter = 1;
        string maxValue = "";
        int[] maxCount = new int[4];
        string[] value = new string[4];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                matrix[i, j] = Console.ReadLine();
            
            }
        }

        CheckRows(matrix, N, M, out maxValue, out maxCounter);
        maxCount[0]=maxCounter;
        value[0]=maxValue;

        CheckCol(matrix, N, M, out maxValue, out maxCounter);
        maxCount[1]=maxCounter;
        value[1]=maxValue;

        CheckLRdiagonal(matrix, N, M, out maxValue, out maxCounter);
        maxCount[2] = maxCounter;
        value[2] = maxValue;

        CheckRLdiagonal(matrix, N, M, out maxValue, out maxCounter);
        maxCount[3] = maxCounter;
        value[3] = maxValue;

        maxCounter=maxCount[Array.IndexOf(maxCount, maxCount.Max())];
        maxValue = value[Array.IndexOf(maxCount, maxCount.Max())];
        PrintSeq(N, M, maxCounter, maxValue);
        
        


    }
    public static void CheckRLdiagonal(string[,] matrix, int N, int M, out string maxValue, out int maxCounter)
    {
        int counter = 1;
        maxCounter = 1;
        maxValue = "";

        for (int j = 0,i = M-1; j < N - 1 && i >= 0; j++,i--)
        {
            if (matrix[j, i] == matrix[j + 1, i - 1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                maxValue = matrix[j, i];
            }
        }
    }
    public static void CheckLRdiagonal(string[,] matrix, int N, int M, out string maxValue, out int maxCounter)
    {
        int counter = 1;
        maxCounter = 1;
        maxValue = "";

            for (int j = 0; j < N - 1; j++)
            {
                if (matrix[j, j] == matrix[j + 1, j + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxValue = matrix[j, j];
                }
            }
    }
    public static void CheckCol(string[,] matrix, int N, int M, out string maxValue, out int maxCounter)
    {
        int counter = 1;
        maxCounter = 1;
        maxValue = "";

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j <N - 1; j++)
            {
                if (matrix[j, i] == matrix[j+1, i])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxValue = matrix[j, i];
                }
            }
            counter = 1;
        }

    }
    public static void CheckRows(string[,] matrix, int N, int M,out string maxValue,out int maxCounter)
    {
        int counter = 1;
        maxCounter = 1;
        maxValue = "";
       
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M-1; j++)
            {
                if(matrix[i,j]==matrix[i,j+1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxValue=matrix[i,j];
                }
            }
            counter = 1;
        }
    }
    public static void PrintSeq(int n, int m,int maxCounter, string maxValue)
    {
        for (int i = 0; i < maxCounter-1; i++)
        {
            Console.Write("{0}, ",maxValue);
        }
        Console.Write(maxValue);
        Console.WriteLine();
    }
}
