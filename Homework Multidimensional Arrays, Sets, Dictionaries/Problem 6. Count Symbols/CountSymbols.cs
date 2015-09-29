using System;
using System.Linq;
    class CountSymbols
    {
        static void Main()
        {
            string text = Console.ReadLine();
            char[] array = text.ToCharArray();
            char[] distArray = array.Distinct().ToArray();
            Array.Sort(distArray);
            int counter = 0;

            for(int i=0; i<distArray.Length; i++)
            {
                for(int j=0; j<distArray.Length; j++)
                {
                    if(distArray[i]==array[j])
                    {
                        counter++;
                    }
                }
                Console.WriteLine("{0}: {1} times",distArray[i],counter);
                counter = 0;
            }
        }
    }
