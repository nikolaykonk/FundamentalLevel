using System;
using System.Linq;
    class TotheStars
    {
        static void Main()
        {
            string[] star1 = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] star2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] star3 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] position = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int turns = int.Parse(Console.ReadLine());


            for(int i=0;i<=turns;i++)
            {
                if ((position[0] >= double.Parse(star1[1]) - 1 && position[0] <= double.Parse(star1[1]) + 1) && (position[1] >= double.Parse(star1[2]) - 1 && position[1] <= double.Parse(star1[2]) + 1))
                {
                    Console.WriteLine(star1[0].ToLower());
                }
                else if ((position[0] >= double.Parse(star2[1]) - 1 && position[0] <= double.Parse(star2[1]) + 1) && (position[1] >= double.Parse(star2[2]) - 1 && position[1] <= double.Parse(star2[2]) + 1))
                {
                    Console.WriteLine(star2[0].ToLower());
                }
                else if ((position[0] >= double.Parse(star3[1]) - 1 && position[0] <= double.Parse(star3[1]) + 1) && (position[1] >= double.Parse(star3[2]) - 1 && position[1] <= double.Parse(star3[2]) + 1))
                {
                    Console.WriteLine(star3[0].ToLower());
                }
                else
                {
                    Console.WriteLine("space");
                }
                position[1] += 1; 
            }
        }
    }
