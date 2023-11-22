using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (numbers.Count > 1)
        {
            List<int> condensedList = new List<int>();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int sum = numbers[i] + numbers[i + 1];
                condensedList.Add(sum);
            }

            numbers = condensedList;
        }

        Console.WriteLine(numbers[0]);
    }
}
