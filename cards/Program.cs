using System.Runtime.ExceptionServices;

List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

int maxLenght = playerOne.Count;

while (true)
{
    if (playerOne.Count <= 0 || playerTwo.Count <= 0)
    {
        break;
    }

    for (int i = 0; i < maxLenght; i++)
    {
        if (playerOne.Count == 0 || playerTwo.Count == 0) {  break; }
        if (playerOne[0] == playerTwo[0])
        {
            playerOne.RemoveAt(0);
            playerTwo.RemoveAt(0);
        }
        else if (playerOne[0] > playerTwo[0]) 
        {
            playerOne.Add(playerOne[0]);
            playerOne.Add(playerTwo[0]);
            playerOne.RemoveAt(0);
            playerTwo.RemoveAt(0);
        } 
        else if (playerTwo[0] > playerOne[0])
        {
            playerTwo.Add(playerTwo[0]);
            playerTwo.Add(playerOne[0]);
            playerOne.RemoveAt(0);
            playerTwo.RemoveAt(0);
        }
    }   
}
int sum = 0;
if (playerOne.Count > 0)
{
    sum = playerOne.Sum();
    Console.WriteLine($"First player wins! Sum: {sum}");
}
else
{
    sum = playerTwo.Sum();
    Console.WriteLine($"Second player wins! Sum: {sum}");
}
