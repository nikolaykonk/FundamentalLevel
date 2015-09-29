using System;
using System.Collections.Generic;
using System.Linq;

    public class NumberCalculations
    {
        static void Main()
        {
            decimal[] input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            Console.WriteLine(sumInput(input));
            Console.WriteLine(averageInput(input));
            Console.WriteLine(productInput(input));
            Console.WriteLine(minInput(input));
            Console.WriteLine(maxInput(input));
        }
        public static decimal maxInput(decimal[] numbers)
        {
            decimal result = decimal.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (result < numbers[i])
                {
                    result = numbers[i];
                }
            }
            return result;
        }

        public static decimal minInput(decimal[] numbers)
        {
            decimal result = decimal.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(result>numbers[i])
                {
                    result=numbers[i];
                }
            }
            return result;
        }

        public static decimal productInput(decimal[] numbers)
        {
            decimal result = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            return result;
        }
        public static decimal averageInput(decimal[] numbers)
        {
            decimal result = 0;
            result = (sumInput(numbers))/numbers.Length;
            return result;
        }

        public static decimal sumInput(decimal[] numbers)
        {
            decimal result=0;
            for(int i =0;i<numbers.Length;i++)
            {
                result += numbers[i];
            }
            return result;
        }
    }
