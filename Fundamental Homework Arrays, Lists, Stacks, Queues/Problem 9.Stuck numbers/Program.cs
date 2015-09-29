using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string firstResult;
            string secondResult;
            bool printNo = true;

            for (int i = 0; i < n; i++)
            { 
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        for (int l = 0; l < n; l++)
                        {
                            if(i!=j&&i!=k&&i!=l&&j!=k&&j!=l&&k!=l)
                            {
                                firstResult = numbers[i] + numbers[j];
                                secondResult = numbers[k] + numbers[l];
                                {
                                    if(firstResult==secondResult)
                                    {
                                        Console.WriteLine("{0}|{1}=={2}|{3}",numbers[i], numbers[j], numbers[k], numbers[l]);
                                        printNo = false;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            if(printNo)
            {
                Console.WriteLine("No");
            }
        }
    }
