using System;
using System.Linq;
using System.Collections.Generic;

class SubsetSums
{

    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool isMatch = false;
        List<int> subset = new List<int>();

        int combinations = (int)Math.Pow(2, input.Length);
        for(int mask =0; mask<combinations;mask++)
        {
            for (int j=0;j<input.Length;j++)
            {
                if ((mask & (1<<j)) != 0)
                {
                    subset.Add(input[j]);             
                }
            }
            if (subset.Sum() == sum)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", subset), sum);
                isMatch = true;
            }
            subset.Clear();
        }
        if(isMatch==false)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}