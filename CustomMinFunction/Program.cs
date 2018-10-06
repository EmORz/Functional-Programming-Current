using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> getMinInt = x => x.Min();

            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var minElement = getMinInt(array);
            Console.WriteLine(minElement);
        }
    }
}
