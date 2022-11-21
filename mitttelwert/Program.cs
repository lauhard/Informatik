// See https://aka.ms/new-console-template for more information
using System.Globalization;

double summe = 0, mittelwert, zahl;
uint anzahl = 0;
Console.WriteLine("Berechnen des Mittelwertes:");
try
{
    do
    {
        Console.WriteLine("Zahl (0...Ende):");
        zahl = double.Parse(convertCultureInfo(read()));
        summe += zahl;
        anzahl++;
    } while (zahl != 0);

    changeColor(ConsoleColor.DarkYellow);
    Console.WriteLine($"Summe: {summe}");
    if (anzahl > 1)
    {
        mittelwert = summe / (anzahl - 1);
        changeColor(ConsoleColor.Green);
        Console.WriteLine($"Mittelwert: {mittelwert}");
    }
}
catch (Exception ex)
{
    changeColor(ConsoleColor.Red);
    Console.WriteLine(ex.Message);
}
static string? read() => Console.ReadLine();
static string getCultureInfo() => CultureInfo.CurrentCulture.Name;
static string convertCultureInfo(string str) => getCultureInfo().Split("-")[0].ToLower() == "de" ? str.Replace(".", ",") : str.Replace(",", ".");
static void changeColor(ConsoleColor c) => Console.ForegroundColor = c;

