using System;
using System.Collections.Generic;
using System.Linq;

    class GenericArraySort
    {
        static void Main()
        {
            int[] numbers = { 1,3,4,5,1,0,5};
            string[] strings = { "zas", "cba", "baa", "azis"};
            DateTime[] dates = {new DateTime(2002,3,1), new DateTime(2015,5,6), new DateTime(2014,1,1)};

            Console.WriteLine(SortArray(numbers));
            Console.WriteLine(SortArray(strings));
            Console.WriteLine(SortArray(dates));
        }
        public static string SortArray<T>(IEnumerable<T> inputArray)
        {
            List < T > input= inputArray.ToList();
            List<T> result = new List<T>();

            while(input.Count!=0)
            {
                var tempMin = input.Min();
                result.Add(tempMin);
                input.Remove(tempMin);
            }
            string output = string.Join(", ", result);
            return output;
        }
    }
