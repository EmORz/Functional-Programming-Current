using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> add = x => x.Select(a => a + 1).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(a => a * 2).ToList();
            Func<List<int>, List<int>> subtract = x => x.Select(a => a - 1).ToList();
            Func<List<int>, string> print = x => string.Join(" ", x);

            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command;

            while ((command = Console.ReadLine())!="end")
            {
                switch (command)
                {
                    case "add":
                        arr = add(arr);
                        break;
                    case "multiply":
                        arr = multiply(arr);
                        break;
                    case "subtract":
                        arr = subtract(arr);
                        break;
                    case "print":
                        Console.WriteLine(print(arr));
                        break;

                }
            }

        }
    }
}
