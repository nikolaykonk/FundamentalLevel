using System;
using System.Collections.Generic;
using System.Linq;

class PythagoreanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers= new int[n];
        for(int i =0;i<n;i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
  
        bool printNo = true;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (numbers[i]<=numbers[j]&& (numbers[i]*numbers[i] + numbers[j]*numbers[j])==numbers[k]*numbers[k])
                    {
                          Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[i], numbers[j], numbers[k]);
                          printNo = false;     
                    }
                }
            }
        }
        if (printNo)
        {
            Console.WriteLine("No");
        }
    }
}
