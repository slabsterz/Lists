List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

for  (int i = numbers.Count-1; i >= 0; i--)
{
    if (numbers[i] < 0)
    {
        numbers.Remove(numbers[i]);
    }   
}
if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}

numbers.Reverse();

Console.WriteLine(string.Join(" ", numbers));