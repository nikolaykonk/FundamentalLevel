using System;
using System.Collections.Generic;
    class NightLife
    {
        static void Main()
        {
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> program = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
            string[] entrance = new string[3];
            string input = Console.ReadLine();

            while (input != "End")
            {
                entrance = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                string city = entrance[0];
                string venue = entrance[1];
                string performer = entrance[2];

                if(!program.ContainsKey(city))
                {     
                    SortedSet<string> performers = new SortedSet<string>();       
                    performers.Add(performer);

                    SortedDictionary<string, SortedSet<string>> venues = new SortedDictionary<string, SortedSet<string>>();
                    venues.Add(venue, performers);

                    program.Add(city,venues);
                }
                else if (program.ContainsKey(city))
                {
                    if (!program[city].ContainsKey(venue))
                    {
                        SortedSet<string> performers = new SortedSet<string>();
                        performers.Add(performer);

                        program[city].Add(venue, performers);
                    }
                    else if (program[city].ContainsKey(venue))
                    {
                        program[city][venue].Add(performer);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var pair1 in program)
            {
                Console.WriteLine(pair1.Key);
                foreach (var pair2 in pair1.Value)
                {
                    Console.WriteLine("->{0}: {1}",pair2.Key,string.Join(", ",pair2.Value));
                }
            }
        }
    }
