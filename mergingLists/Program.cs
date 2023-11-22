List<int> firstLine = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondLine = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> resultList = new List<int>();

if (firstLine.Count == secondLine.Count)
{
    for (int i  = 0; i < firstLine.Count; i++)
    {
        resultList.Add(firstLine[i]);
        resultList.Add(secondLine[i]);
    }
}

if (firstLine.Count > secondLine.Count)
{
    for (int i = 0; i < firstLine.Count; i++)
    {
        if (secondLine.Count == 0)
        {
            resultList.Add(firstLine[i]);
            continue;
        }
        resultList.Add(firstLine[i]);
        resultList.Add(secondLine[i]);
        firstLine.RemoveAt(i);
        secondLine.RemoveAt(i);
        i--;       
        
    }
}
else
{
    for (int i = 0; i < secondLine.Count; i++)
    {
        if (firstLine.Count == 0)
        {
            resultList.Add(secondLine[i]);
            continue;
        }
        resultList.Add(firstLine[i]);
        resultList.Add(secondLine[i]);
        firstLine.RemoveAt(i);
        secondLine.RemoveAt(i);
        i--;

    }
}

Console.WriteLine(string.Join(" ", resultList));