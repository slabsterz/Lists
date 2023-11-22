List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int lenght  = inputNumbers.Count;

for  (int i = 0; i < lenght; i++)
{
    int startDigit = inputNumbers[i];

    if (i + 1 < lenght)
    {
        int nextDigit = inputNumbers[i + 1];

        if (startDigit < nextDigit)
        {
            inputNumbers.RemoveAt(i);
            i = -1;
        }
        lenght = inputNumbers.Count;
    }
    
}
Console.WriteLine(string.Join(" ", inputNumbers));