using System;
using System.IO;
using System.Text.RegularExpressions;

    class Replaceatag
    {
        static void Main()
        {
            string html = File.ReadAllText(@"..\..\HTML-AHref.txt");
            string pattern = @"<a( href=.*\w{2,4})>(\w+)<\/a>";
           

            using (StreamWriter URL = new StreamWriter(@"..\..\HTML-URL.txt"))
            {
                URL.WriteLine(Regex.Replace(html, pattern, @"[URL$1]$2[/URL]"));
            }

            string fileContents = File.ReadAllText(@"..\..\HTML-URL.txt");
            Console.WriteLine(fileContents);   
        }
    }
