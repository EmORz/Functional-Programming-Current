using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var controlNumber = int.Parse(Console.ReadLine());
            //
            Func<int, bool> checker1 = x => x % controlNumber != 0;
            arr = arr.Where(checker1).ToList();
            arr.Reverse();
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
