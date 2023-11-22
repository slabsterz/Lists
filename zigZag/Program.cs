List<int> firstList = new List<int>();
List<int> secondList = new List<int>();

int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
    int firstNumber = inputList[0];
    int secondNumber = inputList[1];

    if (i % 2 != 0)
    {
        firstList.Add(firstNumber);
        secondList.Add(secondNumber);
    }
    else
    {
        firstList.Add(secondNumber);
        secondList.Add(firstNumber);
    }
}

Console.WriteLine(string.Join(" ", firstList));
Console.WriteLine(string.Join(" ", secondList));

