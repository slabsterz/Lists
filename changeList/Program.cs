List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while (true)
{
    string inputCommand = Console.ReadLine();

    if (inputCommand == "end")
    {
        break;
    }

    string[] commandParts = inputCommand.Split(" ");
    string command = commandParts[0];
    int element = int.Parse(commandParts[1]);

    if (command == "Delete")
    {
        numbers.RemoveAll(number => number == element);
    }
    else if (command == "Insert")
    {
        int position = int.Parse(commandParts[2]);
        numbers.Insert(position, element);
    }     
}
Console.Write(string.Join(" ", numbers));