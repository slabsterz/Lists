List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int lenght = inputNumbers.Count;

for  (int i = 0; i < lenght; i++)
{
       
    int firstNumber = inputNumbers[i];

    if (i + 1 < inputNumbers.Count)
    {
        int secondNumber = inputNumbers[i + 1];
        int sum = 0;

        if (firstNumber == secondNumber)
        {
            sum = firstNumber + secondNumber;
            inputNumbers.RemoveAt(i);
            inputNumbers.RemoveAt(i);
            inputNumbers.Insert(i, sum);
            i = -1;

        }
    }
    
    lenght = inputNumbers.Count;
    
}
Console.WriteLine(string.Join(" ", inputNumbers));