List<string> products = new List<string>();

int inputNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < inputNumber; i++)
{
    string product = Console.ReadLine();
    products.Add(product);
}

products.Sort();
int counter = 1;

foreach (string product in products)
{
    Console.WriteLine($"{counter}.{product}");
    counter++;
}