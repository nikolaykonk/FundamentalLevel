using System;
using System.Collections.Generic;

class Phonebook
    {
        static void Main()
        {
            Dictionary<string,List<string>> phoneBook = new Dictionary<string,List<string>>();
            
            
            string input = Console.ReadLine();
            while (input != "search")
            {
                string[] pair = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = pair[0];
                string phone = pair[1];
                if (!phoneBook.ContainsKey(name))
                {
                    List<string> phNumbers = new List<string>();
                    phNumbers.Add(phone);
                    phoneBook.Add(name, phNumbers);
                }
                else
                {
                    phoneBook[name].Add(phone);
                }
               
                input = Console.ReadLine();
            }
            
            string search = Console.ReadLine();
            while (search != "End")
            {
                if (phoneBook.ContainsKey(search))
                {
                    Console.WriteLine("{0} -> {1}",search,String.Join(", ",phoneBook[search]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", search);
                }
                search = Console.ReadLine();
            }
        }
    }
