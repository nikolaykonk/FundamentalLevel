using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CategorizeNumbers
    {
        static void Main()
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            List<double> roundedNums = new List<double>();
            List<double> doubleNums = new List<double>();

            for(int i=0;i<input.Length;i++)
            {
                if(input[i]%1==0)
                {
                    roundedNums.Add(input[i]);
                }
                else
                {
                    doubleNums.Add(input[i]);
                }
            }
            Console.WriteLine("["+string.Join(", ", roundedNums)+"] -> min: {0}, max: {1}, sum: {2}, avg: {3}",roundedNums.Min(), roundedNums.Max(), roundedNums.Sum(), roundedNums.Average());
            Console.WriteLine("[" + string.Join(", ", doubleNums) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3}", roundedNums.Min(), roundedNums.Max(), roundedNums.Sum(), roundedNums.Average());
        }
    }
