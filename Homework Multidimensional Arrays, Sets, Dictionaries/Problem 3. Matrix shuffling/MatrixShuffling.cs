using System;

    class MatrixShuffling
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            string[,] matrix = new string[N, M];

            for(int i=0;i<N;i++)
            {
                for(int j =0;j<M;j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            string command = Console.ReadLine();

            while(command !="END")
            {
                if (command != "END")
                {
                    if (CommandValidation(command, N, M))
                    {
                        SwapAfterCommand(matrix, command);
                        PrintMatrix(matrix, N, M);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    command = Console.ReadLine();
                }
            }


        }
        static bool CommandValidation(string input,int N, int M)
        {
            bool isValid = false;
            string[] inputArr=input.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            if (inputArr.Length==5&&inputArr[0] == "swap" && int.Parse(inputArr[1]) >= 0 && int.Parse(inputArr[1]) <N && int.Parse(inputArr[2]) >= 0 && int.Parse(inputArr[2]) < M && int.Parse(inputArr[3]) >= 0 && int.Parse(inputArr[3]) < N && int.Parse(inputArr[4]) >= 0 && int.Parse(inputArr[4]) < M)
            {
                isValid = true;
            }
            return isValid;
        }
        static void SwapAfterCommand(string[,] matrixNM, string command)
        {
            string[] commandArr = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if(commandArr[0]=="swap")
            {
                string temp = matrixNM[int.Parse(commandArr[1]), int.Parse(commandArr[2])];
                matrixNM[int.Parse(commandArr[1]), int.Parse(commandArr[2])] = matrixNM[int.Parse(commandArr[3]), int.Parse(commandArr[4])];
                matrixNM[int.Parse(commandArr[3]), int.Parse(commandArr[4])] = temp;
            }
        }

        public static void PrintMatrix(string[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
