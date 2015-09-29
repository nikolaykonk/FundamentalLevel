using System;
using System.Linq;

    class SortArrayofNumbers
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(input);
            Console.WriteLine(string.Join(" ",input));
        }
    }
