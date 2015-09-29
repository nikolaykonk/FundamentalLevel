using System;
using System.Collections.Generic;
using System.Linq;

    class ActivityTracker
    {
        static void Main()
        {
            SortedDictionary<int, SortedDictionary<string, List<double>>> database = new SortedDictionary<int, SortedDictionary<string, List<double>>>();
            SortedDictionary<int, SortedSet<string>> finals = new SortedDictionary<int, SortedSet<string>>();
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int month = DateTime.Parse(input[0]).Month;
                string name = input[1];
                double distance = double.Parse(input[2]);

                //new month
               if(!database.ContainsKey(month))
               {
                   SortedDictionary<string, List<double>> users = new SortedDictionary<string, List<double>>();
                   List<double> distances = new List<double>();
                   distances.Add(distance);
                   users.Add(name,distances);
                   database.Add(month, users);
               }
                //existing month
               else if (database.ContainsKey(month))
               {
                   //new name
                   if(!database[month].ContainsKey(name))
                   {
                       List<double> distances = new List<double>();
                       distances.Add(distance);
                       database[month].Add(name,distances);
                   }
                   //existing name
                   else if(database[month].ContainsKey(name))
                   {
                       database[month][name].Add(distance);
                   }
               }
            }
            foreach(var pair1 in database)
            {
                SortedSet<string> usersInfo = new SortedSet<string>();
                foreach(var pair2 in pair1.Value)
                {
                    string userInfo = pair2.Key + "(" + pair2.Value.Aggregate((a, b) => b + a) + ")";
                    usersInfo.Add(userInfo);
                }
                finals.Add(pair1.Key, usersInfo);
            }
            foreach(var pair1 in finals)
            {
                Console.WriteLine("{0}: {1}",pair1.Key,string.Join(", ",pair1.Value));
            }
        }
    }
