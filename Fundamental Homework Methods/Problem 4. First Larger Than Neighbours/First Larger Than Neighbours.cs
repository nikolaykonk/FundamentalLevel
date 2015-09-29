using System;
using System.Collections.Generic;
using System.Linq;

    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            int[] sequenceOne = new int[]{1,3,4,5,1,0,5};
            int[] sequenceTwo = new int[] {1,2,3,4,5,6,6};
            int[] sequenceThree = new int[] {1,1,1};

            Console.WriteLine(GetIndexOfFirstElementLargerThenNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThenNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThenNeighbours(sequenceThree));
        }

        public static int GetIndexOfFirstElementLargerThenNeighbours(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (LargerThanNeighbours.IsLargerThenNeighbours(numbers, i))
                {
                    return i;
                }
            }
            return -1;
        }

        
    }
