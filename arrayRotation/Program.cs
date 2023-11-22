List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int rotations = int.Parse(Console.ReadLine());

for  (int i = 0; i < rotations; i++)
{
    int element = numbers[0];
    numbers.Add(element);
    numbers.RemoveAt(0);
}
Console.WriteLine(string.Join(" ", numbers));