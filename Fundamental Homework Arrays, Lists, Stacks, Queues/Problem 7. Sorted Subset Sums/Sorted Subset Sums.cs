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
        List<string> sorted = new List<string>();

        int combinations = (int)Math.Pow(2, input.Length);
        for (int mask = 0; mask < combinations; mask++)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if ((mask & (1 << j)) != 0)
                {
                    subset.Add(input[j]);
                }
            }
            if (subset.Sum() == sum)
            {
                string temp=(string.Join(" + ", subset)+" = " + sum);
                isMatch = true;
                sorted.Add(temp);
            }
            subset.Clear();
        }
       
        if (isMatch == false)
        {
            Console.WriteLine("No matching subsets.");
        }
        else
        {
            foreach (string s in SortByLength(sorted))
            {
                Console.WriteLine(s);
            }   
        }
    }
    static IEnumerable<string> SortByLength(IEnumerable<string> set)
    {
        var sorted1 = set.OrderBy(s => s.Length).ThenBy(s => s); 
        return sorted1;
    }
}