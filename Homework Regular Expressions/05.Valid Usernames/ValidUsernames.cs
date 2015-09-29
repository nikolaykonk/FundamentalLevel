using System;
using System.Text.RegularExpressions;

    class ValidUsernames
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=[\s\\\/\,]|^)([A-Za-z]\w{2,24})(?=[\s\\\/\,]|$)";
            Regex regex = new Regex(pattern);
            MatchCollection usernames = regex.Matches(input);
            int maxLength = int.MinValue;
            int position = 0;

            for(int i =0; i<usernames.Count-1;i++)
            {
                if(usernames[i].Length+usernames[i+1].Length>maxLength)
                {
                    maxLength = usernames[i].Length + usernames[i + 1].Length;
                    position = i;
                }
            }
            Console.WriteLine(usernames[position]);
            Console.WriteLine(usernames[position+1]);
        }
    }
