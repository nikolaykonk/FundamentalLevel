using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main(string[] args)
    {
        try
        {
            // input
            StreamReader reader = new StreamReader(@"..\..\Test.txt", Encoding.GetEncoding("windows-1251"));

            string tempStrings="";
            int lineNumber = 0;

            // algorithm: line number increases twice, the reader reads twice, console prints once
            using (reader)
            {
                while (tempStrings != null)
                {
                    tempStrings = reader.ReadLine();
                    tempStrings = reader.ReadLine();
                    lineNumber+=2;
                    Console.WriteLine("Line {0, 2}: {1}", lineNumber, tempStrings);
                } 
            }
        }

            // in case no file is found
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
    }
}