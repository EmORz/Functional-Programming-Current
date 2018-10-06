using System;
using System.Linq;

namespace SumNumbers
{
    class SumNumbersStart
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, int> parser = num => int.Parse(num);
            int[] array = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(parser).ToArray();
            Console.WriteLine(array.Count());
            Console.WriteLine(array.Sum());
        }
    }
}
