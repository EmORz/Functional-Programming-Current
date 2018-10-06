using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var endOfRange = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToList();
            List<Predicate<int>> predicates = new List<Predicate<int>>();

            dividers.ForEach(x => predicates.Add(z => z % x == 0));
            List<int> result = new List<int>();

            for (int i = 1; i <= endOfRange; i++)
            {
                bool ch = true;
                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        ch = false;
                        break;
                    }
                }
                if (ch)
                {
                    result.Add(i);

                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
