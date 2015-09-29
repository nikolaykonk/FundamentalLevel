using System;
using System.Collections.Generic;
using System.Linq;

    public class LargerThanNeighbours
    {
        
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThenNeighbours(numbers,i));
            }
        }

        public static bool IsLargerThenNeighbours(int[] numbers, int i)
        {

            bool isLarger = true;

            if ((i > 0 && i < numbers.Length - 2 && numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1]) || (i == 0 && numbers[i] > numbers[i + 1]) || (i == numbers.Length - 1 && numbers[i] > numbers[i - 1]))
            {
                return isLarger;
            }
            else
            {
                return (!isLarger);
            }

        }
    }
