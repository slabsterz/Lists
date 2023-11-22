List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }

    string[] commandParts = command.Split();
    string action = commandParts[0];
    int actionNumber = int.Parse(commandParts[1]);

    if (action == "Add")
    {
        numbers.Add(actionNumber);
    }
    else if (action == "Remove")
    {
        numbers.Remove(actionNumber);
    }
    else if (action == "RemoveAt")
    {
        numbers.RemoveAt(actionNumber);
    }
    else if (action == "Insert")
    {
        int actionIndex = int.Parse(commandParts[2]);
        numbers.Insert(actionIndex, actionNumber);
    }
}
Console.WriteLine(string.Join(" ", numbers));