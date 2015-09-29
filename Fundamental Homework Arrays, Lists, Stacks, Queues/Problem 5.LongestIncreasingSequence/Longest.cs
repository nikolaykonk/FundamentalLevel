using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Longest
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> ls = new List<int>();

            int counter=1;
            ls.Add(input[0]);

            Console.Write(input[0] + " ");
            for(int i =1;i<input.Length;i++)
            {
                if(input[i]>input[i-1])
                {
                    counter++;
                    Console.Write(input[i]+" ");
                   
                }
                else
                {
                    if (counter > ls.Count)
                    {
                        ls.Clear();
                        for (int j = i - counter; j < i; j++)
                        {
                            ls.Add(input[j]);
                        }
                    }
                    counter = 1;
                    Console.WriteLine();
                    Console.Write(input[i] + " ");
                }            
            }
            Console.WriteLine();
            Console.WriteLine("Longest: "+string.Join(" ", ls));
        }
    }
