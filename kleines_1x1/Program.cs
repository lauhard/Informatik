// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ausgabe des kleinen 1x1");
for (int i = 1; i <= 10; i++)
{
    changeColor(i);
    for (int j = 1; j <= 10; j++)
	{
		Console.WriteLine($"{j,2} mal {i,2} = {i * j}");
	}
}
static void changeColor(int i) => Console.ForegroundColor = (ConsoleColor)i;





