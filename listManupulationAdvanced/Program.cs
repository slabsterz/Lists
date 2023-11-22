List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        Console.WriteLine(string.Join(" ", numbers));
        break;
    }

    string[] commandParts = command.Split();
    string actionCommand = commandParts[0];

    if (actionCommand == "Contains")
    {
        int actionNumber = int.Parse(commandParts[1]);

        if (numbers.Contains(actionNumber))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (actionCommand == "PrintEven")
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (actionCommand == "PrintOdd")
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (actionCommand == "GetSum")
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;                     
        }
        Console.WriteLine(sum);
    }
    else if (actionCommand == "Filter")
    {
        string condition = commandParts[1];
        int filterNumber = int.Parse(commandParts[2]);

        foreach (int number in numbers)
        {
            if ((condition == "<" && number < filterNumber) ||
                (condition == ">" && number > filterNumber) ||
                (condition == ">=" && number >= filterNumber) ||
                (condition == "<=" && number <= filterNumber))
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
        break;
    }
}
