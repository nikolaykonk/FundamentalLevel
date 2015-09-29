using System;
using System.Collections.Generic;
using System.Linq;

    public class ReverseNumber
    {
        static void Main()
        {
            double inputNum = double.Parse(Console.ReadLine());

            double reverced = GetReversedNumber(inputNum);
            Console.WriteLine(reverced);
        }

        private static double GetReversedNumber(double inputNum)
        {
            bool isPositive = inputNum >= 0;
            string doubleNum = inputNum.ToString().TrimStart('-');
            char[] reversedNum = doubleNum.ToCharArray();
            Array.Reverse(reversedNum);
            double output= double.Parse(new string(reversedNum));

            return isPositive ? output : -output;
        }
    }
