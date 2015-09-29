﻿using System;
using System.IO;
using System.Text.RegularExpressions;

    class ExtractEmails
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine("Name: {0}", match.Groups[1]);
            }
        }
    }
