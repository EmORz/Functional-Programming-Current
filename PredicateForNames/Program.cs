using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLenght = int.Parse(Console.ReadLine());
            string[] arrayOfNames = Console.ReadLine().Split();
            Predicate<string> checkForLenght = x => x.Length <= maxLenght;
            var perfectNames = arrayOfNames.Where(x => checkForLenght(x)).ToArray();
            Console.WriteLine(string.Join("\n", perfectNames));
        }
    }
}
