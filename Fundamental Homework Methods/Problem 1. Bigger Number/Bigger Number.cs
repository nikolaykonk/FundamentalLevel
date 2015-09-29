using System;
using System.Collections.Generic;
using System.Linq;

    class  BiggerNumber
    {
        static int GetMax(int firstN, int secondN)
        {
            if (firstN < secondN)
            {
                return secondN;
            }
            else
            {
                return firstN;
            }

        }
        static void Main()
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());

            int max = GetMax(firstN, secondN);
            Console.WriteLine(max);
        }
    }

