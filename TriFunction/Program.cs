using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            //
            Func<string, int, bool> checkForName = (name, n) => name.Sum( ch => ch) >= n;
            Func<string[], int, Func<string, int, bool>, string> validator = (arr, n, func) => arr.FirstOrDefault(str => func(str, n));
            var result = validator(names, num, checkForName);
            Console.WriteLine(string.Join(" ", result) );
        }
    }
}
