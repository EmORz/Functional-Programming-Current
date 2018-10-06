using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var initial = Console.ReadLine().Split().ToList();
            Func<string, string, bool> stratsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endsWith = (a, b) => a.EndsWith(b);
            Func<string, string, bool> contains = (a, b) => a.Contains(b);
            Func<string, int, bool> lenght = (a, b) => a.Length == b;


            var command = Console.ReadLine();
            var filtered = new List<string>();
            var result = new List<string>(initial);

            while (command != "Print")
            {

                string[] commandAtgs = command.Split(';');

                switch (commandAtgs[1])
                {
                    case "Starts with":
                        filtered = initial.Where(p => stratsWith(p, commandAtgs[2])).ToList();
                        break;
                    case "Ends with":
                        filtered = initial.Where(p => endsWith(p, commandAtgs[2])).ToList();
                        break;
                    case "Length":
                        filtered = initial.Where(p => lenght(p, int.Parse(commandAtgs[2]))).ToList();
                        break;
                    case "Contains":
                        filtered = initial.Where(p => contains(p, commandAtgs[2])).ToList();
                        break;
                    default:
                        break;
                }

                switch (commandAtgs[0])
                {
                    case "Add filter":
                        result.RemoveAll(r => filtered.Contains(r));

                        break;
                    case "Remove filter":
                        result.AddRange(filtered);
                        result = result.Distinct().ToList();
                        break;
                }
                command = Console.ReadLine();
            }
            initial.RemoveAll(r => !result.Contains(r));
            Console.WriteLine(string.Join(" ", initial));
        }
    }
}
