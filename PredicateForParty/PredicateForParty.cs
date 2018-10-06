using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForParty
{
    class PredicateForParty
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().ToList();
            Func<string, string, bool> stratsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endsWith = (a, b) => a.EndsWith(b);
            Func<string, int, bool> lenght = (a, b) => a.Length == b;
            Func<List<string>, List<string>, List<string>> doubled = (a,b) =>
            {
                foreach (var doubl in b)
                {
                    for (int i = 0; i < a.Count*2; i++)
                    {
                        if (i < a.Count)
                        {
                            if (a[i] == doubl)
                            {
                                a.Insert(i, a[i]);
                                i++;
                            }
                        }
                    }
                }
                return a;
            };
            var command = Console.ReadLine();
            var filter = new List<string>();
            while (command != "Party!")
            {

                string[] commandAtgs = command.Split();

                switch (commandAtgs[1])
                {
                    case "StartsWith":
                        filter = people.Where(p => stratsWith(p, commandAtgs[2])).Distinct().ToList();
                        break;
                    case "EndsWith":
                        filter = people.Where(p => endsWith(p, commandAtgs[2])).Distinct().ToList();
                        break;
                    case "Length":
                        filter = people.Where(p => lenght(p, int.Parse(commandAtgs[2]))).Distinct().ToList();
                        break;
                    default:
                        break;
                }

                switch (commandAtgs[0])
                {
                    case "Remove":
                        people = people.Where(p => !filter.Contains(p)).ToList();
                        break;
                    case "Double":
                        people = doubled(people, filter);
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            if (people.Count>0)
            {
                Console.WriteLine(string.Join(", ", people)+ " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
