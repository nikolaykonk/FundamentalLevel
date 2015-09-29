using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void getInput(out int n, out int[][] jagget1, out int[][] jagget2, out int counter)
    {
        n = int.Parse(Console.ReadLine());
        jagget1 = new int[n][];
        jagget2 = new int[n][];
        counter = 0;

        char[] separators = new char[] { ' ' };
        for (int i = 0; i < n; i++)
        {
            jagget1[i] = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            counter += jagget1[i].Length;
        }
        for (int i = 0; i < n; i++)
        {
            jagget2[i] = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Array.Reverse(jagget2[i]);
            counter += jagget2[i].Length;
        }
    }

    static bool checkIfFit(int[][] jagget1, int[][] jagget2, int n)
    {
        bool fitted = true;
        int length = jagget1[0].Length + jagget2[0].Length;

        for (int i = 1; i < n; i++)
        {
            if (jagget1[i].Length + jagget2[i].Length != length)
            {
                fitted = false;
            }
        }
        return fitted;
    }

    static void printArray(int[][] jagget1, int[][] jagget2, int n)
    {
        for (int i = 0; i < n; i++)
        {

            Console.WriteLine("[{0}, {1}]", string.Join(", ", jagget1[i]), string.Join(", ", jagget2[i]));
        }
    }

    static void Main()
    {
        int[][] jagget1;
        int[][] jagget2;
        int counter;
        int n;

        getInput(out n, out jagget1, out jagget2, out counter);
        bool fitted = checkIfFit(jagget1, jagget2, n);



        if (fitted)
        {
            printArray(jagget1, jagget2, n);
        }
        else
        {
            Console.WriteLine("The total number of cells is: {0}", counter);
        }

    }
}
