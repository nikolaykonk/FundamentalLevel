using System;
using System.Collections.Generic;

    class StringMatrixRotation
    {
        static void Main()
        {
            string command = Console.ReadLine();
            string[] getAngel = command.Split('(');
            string angleString = getAngel[1].TrimEnd(')');
            int angle = int.Parse(angleString);
            while(angle>=360)
            {
                angle -= 360;
            }
            List<string> lines = new List<string>();
            string input = Console.ReadLine();
            int maxLength = int.MinValue;

            while(input!="END")
            {
                lines.Add(input);
                if(input.Length>maxLength)
                {
                    maxLength = input.Length;
                }
                input = Console.ReadLine();
            }
            for (int i =0;i<lines.Count;i++)
            {
                lines[i] = lines[i].PadRight(maxLength,' ');
            }

            
            switch(angle)
            {
                case 0: Rotate0(lines, maxLength); break;
                case 90: Rotate90(lines, maxLength); break;
                case 180: Rotate180(lines, maxLength); break;
                case 270: Rotate270(lines, maxLength); break;
            }      
        }
        static void Rotate0(List<string> lines, int maxLength)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                for (int j = 0; j < maxLength; j++)
                {
                    Console.Write("{0}", lines[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Rotate90(List<string> lines, int maxLength)
        {
            for (int i = 0; i < maxLength; i++)
            {
                for (int j = lines.Count-1; j >=0 ; j--)
                {
                    Console.Write("{0}", lines[j][i]);
                }
                Console.WriteLine();
            }
        }
        static void Rotate180(List<string> lines, int maxLength)
        {
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                for (int j = maxLength - 1; j >= 0; j--)
                {
                    Console.Write("{0}", lines[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Rotate270(List<string> lines, int maxLength)
        {
            for (int i = maxLength-1; i >=0 ; i--)
            {
                for (int j = 0; j < lines.Count; j++)
                {
                    Console.Write("{0}", lines[j][i]);
                }
                Console.WriteLine();
            }
        }

    }
