using System;
using System.Collections.Generic;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                people.Add(name, age);
            }
            //
            string ageCondition = Console.ReadLine();
            int yearCondition = int.Parse(Console.ReadLine());
            string formatPrint = Console.ReadLine();
            //
            var firstCondition = OlderOrYounger(ageCondition, yearCondition);
            var secondCondition = Print(formatPrint);

            //
            foreach (var man in people)
            {
                if (firstCondition(man.Value))
                {
                    secondCondition(man);
                }
            }



        }
        static Action<KeyValuePair<string, int>> Print(string formatPrint)
        {
            if (formatPrint == "name")
            {
                return x => Console.WriteLine(x.Key);
            }
            else if (formatPrint == "age")
            {
                return x => Console.WriteLine(x.Value);
            }
            else
            {
                return x => Console.WriteLine(x.Key+" - "+x.Value);
            }
        }
        static Func<int, bool> OlderOrYounger(string condition, int age)
        {
            if (condition == "older")
            {
                return x => x >= age;
            }
            return x => x < age;
        }

    }
}
