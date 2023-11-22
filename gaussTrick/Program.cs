

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> sum = new List<int>();

        while (numbers.Count > 1)
        {
            int firstNum = numbers[0];
            int lastNum = numbers[numbers.Count - 1];
            sum.Add(firstNum + lastNum);

            numbers.RemoveAt(0);
            numbers.RemoveAt(numbers.Count - 1);
        }

        if (numbers.Count == 1)
        {
            sum.Add(numbers[0]);
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}
