using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .Where(num => num % 2 ==0).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", inputNumbers));
        }
    }
}
