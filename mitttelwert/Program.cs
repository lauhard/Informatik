// See https://aka.ms/new-console-template for more information
using System.Globalization;

double summe = 0, mittelwert, zahl;
uint durchlaeufe = 0;
Console.WriteLine("Berechnen des Mittelwertes:");

// in der Schleife wird in jeder Iteration:
// - die eingegeben Zahl zur summe addiert
// - die Variable durchlaeufe um eins erhöht
// Abbruchbedingung:
// Schleife wird solange durchlaufen bis die Zahl 0 eingegeben wird.

// prüfen wie oft die Schleife durchlaufen wurde
// hat durchlaeufe den Wert > 1, ist wurde mindestens eine Zahl eingegeben

// Summe ausgeben

// Mittelwert berechnen
// - wird berechnet aus der Summe / durchlaeufe
// - durchlaeufe muss um 1 verringert werden da der letzte Durchlauf die Abbruchbedinung war.


// try catch - zum abfangen unerwarteter Fehler
// im try block steht der code
// im catch block wird auf den Fehler reagiert der im try block abgefangen wurde.
try
{
    do //Schleifenkörper
    {
        Console.WriteLine("Zahl (0...Ende):");
        //gibt die Zahl mit richtigen Komma aus
        //read() ist eine methode für Console.ReadLine; nur als kurzschreibweise...
        //convertCultureInfo habe ich eingebaut... kann man weglassen

        zahl = double.Parse(convertCultureInfo(read()));
        //addiert die zahl zur summe
        summe += zahl;
        //erhöht durchläufe um 1
        durchlaeufe++;
    } while (zahl != 0); //Abbruchbedinung

    // Ändert die Konsolenfarbe auf orange
    changeColor(ConsoleColor.DarkYellow);
    // Gibt summe aus
    Console.WriteLine($"Summe: {summe}");

    // Prüft ob min 2 mal durchlaufen wurde
    if (durchlaeufe > 1)
    {
        //berechnet den mittelwert
        mittelwert = summe / (durchlaeufe - 1);
        //Ändert die Farbe der Konsole auf grün
        changeColor(ConsoleColor.Green);
        //Gibt den Mittelwert aus
        Console.WriteLine($"Mittelwert: {mittelwert}");
    }
}
catch (Exception ex)  // fängt die Fehlermeldung
{   // catch block wird nur im Fehlerfall betreten

    //ändert Hintergrundfarbe auf rot
    changeColor(ConsoleColor.Red);
    //gibt fehler aus
    Console.WriteLine(ex.Message);
}

//Kurze Version von Console.Readline
static string? read() => Console.ReadLine();

///<summary>
/// Returns the current culture name 
///</summary>
///<returns>
/// Name of the current culture
/// </returns>
static string getCultureInfo() => CultureInfo.CurrentCulture.Name;
///<summary>
/// Stellt Gleitkommazahl richtig dar
/// </summary>
/// <param name="str">Gleitkommazahl als string</param>
/// <returns>
/// Konvertierte Gleitkommazahl als string
/// </returns>
static string convertCultureInfo(string str) => getCultureInfo().Split("-")[0].ToLower() == "de" ? str.Replace(".", ",") : str.Replace(",", ".");
///<summary>
/// Ändert die Schriftfarbe in der Konsole
/// </summary>
/// <param name="c" description="ConsoleColor">
/// es wird ein Enum ConsoleColor erwartet
/// </param>
static void changeColor(ConsoleColor c) => Console.ForegroundColor = c;

