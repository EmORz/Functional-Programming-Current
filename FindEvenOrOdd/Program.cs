using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;

            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string evenOrOdd = Console.ReadLine();

            var result = Enumerable.Range(input[0], input[1] - input[0] + 1)
                .Where(x => evenOrOdd == "even" ? isEven(x) : !isEven(x))
                .ToList();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
