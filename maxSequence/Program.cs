using System.ComponentModel.Design;

List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> maxNumbers = new List<int>();

int count = 1;
int maxCount = 1;

for (int i = 1; i < inputNumbers.Count; i++)
{
    int currentDigit = inputNumbers[i];
    int previousDigit = inputNumbers[i-1];

    if (currentDigit == previousDigit)
    {
        count++;
    }
    else
    {
        count = 1;
    }

    if (count > maxCount)
    {
        maxCount = count;
        maxNumbers.Clear();
        maxNumbers.Add(currentDigit);
    }
    else if (count == maxCount)
    {
        maxNumbers.Add(currentDigit);
    }
}
Console.WriteLine(string.Join(" ", maxNumbers));
