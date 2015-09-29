using System;
using System.Text.RegularExpressions;
using System.Text;

    class ExtractHyperlinks
    {
        static void Main()
        {
            string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>";
            Regex regex = new Regex(pattern);
            StringBuilder lines = new StringBuilder();
           
            string input = Console.ReadLine();
            while(input!="END")
            {
                lines.Append(input);
                input = Console.ReadLine();
            }
            string text = lines.ToString();
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (match.Groups[j].Length>0)
                    {
                        Console.WriteLine(match.Groups[j]);
                    }
                }
            }
           
        }
    }
