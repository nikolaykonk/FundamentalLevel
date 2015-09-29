using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class EqualStrings
    {
        static void Main()
        {
            
            string[] inputString = Console.ReadLine().Split(' ');
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] == inputString[i + 1])
                {
                    Console.Write("{0} ", inputString[i]);
                }
                else
                {
                    Console.WriteLine("{0}", inputString[i]);
                }
            }
            Console.WriteLine("{0}", inputString[inputString.Length-1]); 
        }
    }
