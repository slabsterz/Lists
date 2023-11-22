List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
int bombNumber = bomb[0];
int bombPower = bomb[1];

int numbersLenght = inputNumbers.Count;

for  (int i = 0; i < numbersLenght; i++)
{
    int currentNumber = inputNumbers[i];

    if (currentNumber == bombNumber) 
    {
        int removeRange = 1 + bombPower * 2; 
        int position = inputNumbers.IndexOf(currentNumber);
        int startRange = position - bombPower;

        if (removeRange > inputNumbers.Count - startRange)
        {
            inputNumbers.RemoveRange(startRange, inputNumbers.Count - startRange);
            break;
        }
        else if (startRange < 0)
        {
            if (removeRange > inputNumbers.Count)
            {
                startRange = position;
                removeRange = startRange + bombPower + 1;
                inputNumbers.RemoveRange(startRange, removeRange);
                break;
            }
            startRange = 0;
            removeRange--;
        }


        inputNumbers.RemoveRange(startRange, removeRange);
        i--;        

    }
    numbersLenght = inputNumbers.Count;
    
}

Console.WriteLine(inputNumbers.Sum());
