
bool isInputAmountValid = false;

string[] names;

do
{
    Console.WriteLine("==== Namen in array stockeren en afdrukken ====");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Hoeveel namen wens je te stockeren?");

    string inputAmount = Console.ReadLine();
    int amount;
    isInputAmountValid = int.TryParse(inputAmount, out amount);

    if (!isInputAmountValid || amount <= 0)
    {
        Console.Clear();
        Console.WriteLine("U moet een geheel getal ingeven dat groter is dan 0");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        names = new string[amount];

        for (int i = 0; i <= amount - 1; i++)
        {
            Console.Write($"Geef naam {i + 1}: ");
            names[i] = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("=== Namen afdrukken ===");
        Console.WriteLine();

        for (int i = 0; i <= amount - 1; i++)
        {
            Console.WriteLine($"Naam {i + 1} is {names[i].ToUpper()}");
        }

        isInputAmountValid = true;
    }
}
while (isInputAmountValid == false);