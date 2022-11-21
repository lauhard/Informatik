// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ausgabe des kleinen 1x1");

//1. For schleifen für die 10 Zahlen des kleinen 1 x 1
//2. For schleife für die Multiplikation der Zahl von 1 bis 10

// i startet bei 1
// wird ausgeführt solagne i <= 10 ist
// i wird bei jedem durchlauf erhöht
for (int i = 1; i <= 10; i++)
{
	// ändert die Farbe der konsole
    changeColor(i);
	// jede Zahl i aus der oberen Schleife wird mit den Zahlen von 1 - 10 multipliziert
    for (int j = 1; j <= 10; j++)
	{
		Console.WriteLine($"{j,2} mal {i,2} = {i * j}");
	}
}
static void changeColor(int i) => Console.ForegroundColor = (ConsoleColor)i;





