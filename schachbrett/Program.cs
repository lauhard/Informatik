// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ausgabe eines Schachbrettes");
for (char c = 'A'; c <= 'H'; c++)
{
    for (int j = 1; j <= 8; j++)
    {
        changeColor(j);
        Console.Write($"   {c}{j}");
    }
    Console.WriteLine("\n");
}
static void changeColor(int i) => Console.ForegroundColor = (ConsoleColor)i;
