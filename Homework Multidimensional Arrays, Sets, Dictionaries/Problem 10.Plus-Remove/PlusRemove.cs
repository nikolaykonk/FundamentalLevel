using System;
using System.Collections.Generic;

class PlusRemuve
{
    static void Main()
        {
            List<string> text = new List<string>();
            string input=Console.ReadLine();
            int lowerLength = 0;

            while(input!="END")
            {
                text.Add(input);
                input = Console.ReadLine();
            }
            for (int i = 0; i < text.Count-2; i++)
            {
                string up = text[i].ToLower();
                string middle = text[i + 1].ToLower();
                string down = text[i + 2].ToLower();
                if (up.Length > middle.Length - 1)
                {
                    lowerLength = middle.Length;
                }
                else
                {
                    lowerLength = up.Length;
                }
                if (lowerLength > down.Length)
                {
                    lowerLength = down.Length;
                }
                for (int j = 1; j < lowerLength; j++)
                {                   
                    if ((up[j] == middle[j - 1] && up[j] == middle[j] && up[j]== middle[j + 1] && up[j] == down[j]))
                    {

                        text[i] = text[i].Remove(j, 1);
                        text[i] = text[i].Insert(j," ");
                        text[i+1] = text[i + 1].Remove(j - 1,3);
                        text[i + 1] = text[i + 1].Insert(j - 1, "   ");
                        text[i+2] = text[i + 2].Remove(j,1);
                        text[i + 2] = text[i + 2].Insert(j, " ");
                    }
                }
            }
            foreach (string line in text)
            {
                string output = line.Replace(" ","");
                Console.WriteLine(output);
            }
        }
}
