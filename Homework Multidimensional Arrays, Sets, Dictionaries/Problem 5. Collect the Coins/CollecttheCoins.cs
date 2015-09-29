using System;

    class CollectTheCoins
    {
        static void Main()
        {
            int coinCounter = 0;
            int wallCounter = 0; 
            char[][] jagged = new char[4][];
            jagged[0] = Console.ReadLine().ToCharArray();
            jagged[1] = Console.ReadLine().ToCharArray();
            jagged[2] = Console.ReadLine().ToCharArray();
            jagged[3] = Console.ReadLine().ToCharArray();
            char[] command = Console.ReadLine().ToCharArray();

            int i = 0;
            int j = 0;
            for(int a=0;a<command.Length;a++)
            {
                
                switch(command[a])
                {
                    case 'V': i++; break;
                    case '^': i--; break;
                    case '<': j--; break;
                    case '>': j++; break;
                }
                if ((i == 0 && j>=0 && j<= jagged[0].Length - 1) || (i == 1 && j>=0 && j <= jagged[1].Length - 1) || (i == 2 && j>=0 && j <= jagged[2].Length - 1) || (i == 3 && j>=0 && j <= jagged[3].Length - 1))
                {
                    if (jagged[i][j] == '$')
                    {
                        coinCounter++;
                    }
                }
                else
                {
                    wallCounter++;
                    switch (command[a])
                    {
                        case 'V': i--; break;
                        case '^': i++; break;
                        case '<': j++; break;
                        case '>': j--; break;
                    }
                }
                
            }
            Console.WriteLine("Coins collected:{0}",coinCounter);
            Console.WriteLine("Walls hit:{0}", wallCounter);
        }
    }
