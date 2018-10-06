using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> vat = n => n * 1.2;

            double[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(vat).ToArray();

            foreach (var num in input)
            {
                Console.WriteLine($"{num:f2}");
            }
        }
    }
}
