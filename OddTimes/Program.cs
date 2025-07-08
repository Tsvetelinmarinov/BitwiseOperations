/*
 * OddTimes
 */

using System.Net.Http.Headers;

namespace OddOccurence;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()!
            .Split()
            .Select(int.Parse)
            .ToList();

        Console.WriteLine(GetOddOccurence(numbers));
    }
    
    static int GetOddOccurence(List<int> collection)
    {
        for (int i = 0; i < collection.Count; i++)
        {
            int counter = default;
            for (int j = 0; j < collection.Count; j++)
            {
                if (collection[i] == collection[j])
                {
                    counter++;
                }
            }

            if (counter % 2 != 0)
            {
                return collection[i];
            }

            counter = 0;
        }

        return 0;
    }
};