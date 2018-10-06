using System;
using System.Collections.Generic;
using System.Linq;

namespace Inferno
{
    class Program
    {
        static void Main(string[] args)
        {
            var initial = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> active = Enumerable.Range(0, initial.Count).ToList();
            List<int> allIndx = new List<int>(active);

            Func<int, int, bool> sumLeft = (b, c) => b == 0 ? initial[b] == c : initial[b] + initial[b - 1] == c;
            Func<int, int, bool> sumRight = (a, b) => a == initial[initial.Count - 1] ? initial[a] == b : initial[a] + initial[a + 1] == b;
            Func<int, int, bool> sumBouth = (a, b) =>
            initial.Count - 1 == 0 ? b == initial[0] : a == 0 ? initial[a + 1] + initial[a] == b : a == initial.Count - 1 ?
            initial[a] + initial[a - 1] == b : initial[a - 1] + initial[a] + initial[a + 1] == b;

            string command = Console.ReadLine();

            while (command != "Forge")
            {

                string[] commandArgs = command.Split(";");
                List<int> temporal = new List<int>();
                int sum = int.Parse(commandArgs[2]);
                switch (commandArgs[1])
                {
                    case "Sum Left":
                        temporal = allIndx.Where(x => sumLeft(x, sum)).ToList();
                        break;
                    case "Sum Right":
                        temporal = allIndx.Where(x => sumRight(x, sum)).ToList();
                        break;
                    case "Sum Left Right":
                        temporal = allIndx.Where(x => sumBouth(x, sum)).ToList();
                        break;
                    default:
                        break;
                }

                switch (commandArgs[0])
                {
                    case "Exclude":
                        active.RemoveAll(x => temporal.Contains(x));
                        break;
                    case "Reverse":
                        active.AddRange(temporal);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", initial.Where((item, index) => active.Contains(index))));
        }
    }
}
