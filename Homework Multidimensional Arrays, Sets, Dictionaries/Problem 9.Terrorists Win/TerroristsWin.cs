using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

    class TerroristsWin
    {
        static void Main()
        {
            int sum=0;
            string input = Console.ReadLine();

            int dotsLength=0;
            int bombIndex=0;
            string result="";
            string dots="";

            string[] inputs = input.Split('|');

            for (int i=1; i<inputs.Length;i+=2)
            {
                if (i % 2 != 0)
                {
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(inputs[i]);
                    for (int j = 0; j < asciiBytes.Length; j++)
                    {
                        sum += asciiBytes[j];
                    }
                    int lastDigit = sum % 10;
                    if (input.IndexOf('|')+1<lastDigit)
                    {
                        dotsLength = inputs[i].Length + 2 + lastDigit + (input.IndexOf('|'));
                        bombIndex = input.IndexOf('|');
                        result = input.Remove(0, dotsLength);
                        dots = new String('.', dotsLength);
                        input = result.Insert(0, dots);
                    }
                    else if ((input.Length - (input.IndexOf('|') + 2+inputs[i].Length ))< lastDigit)
                    {
                        dotsLength = inputs[i].Length + 2 + lastDigit + (input.Length - input.IndexOf('|') - 2 - inputs[i].Length);
                        bombIndex = input.IndexOf('|');
                        result = input.Remove(bombIndex-lastDigit, dotsLength);
                        dots = new String('.', dotsLength);
                        input = result.Insert(bombIndex - lastDigit, dots);
                    }
                    else
                    {
                        dotsLength = inputs[i].Length + 2 + 2 * lastDigit;
                        bombIndex = input.IndexOf('|');
                        result = input.Remove(bombIndex - lastDigit, dotsLength);
                        dots = new String('.', dotsLength);
                        input = result.Insert(bombIndex - lastDigit, dots);
                    }
                    
                    
                    sum = 0;
                }
                
            }
            Console.WriteLine(input);
        }
    }
