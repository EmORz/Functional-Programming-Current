using System;
using System.Linq;

namespace CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, int> comparator = (n1, n2) => (n1 % 2 == 0 && n2 % 2 != 0) ? -1
                                                         :(n2 % 2 == 0 && n1 % 2 !=0) ? 1
                                                         :n1.CompareTo(n2);
            Array.Sort(array, new Comparison<int>(comparator));
            Console.WriteLine(string.Join(" ", array));

        }
    }
}