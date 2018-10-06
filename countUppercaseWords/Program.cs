using System;
using System.Linq;

namespace countUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];
            var words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(checker).ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
