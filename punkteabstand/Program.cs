// See https://aka.ms/new-console-template for more information

using System.Globalization;
Console.WriteLine("Vergleiche Distanz 2er Punkte im Raun D2");
do
{
    Console.WriteLine("Geben Sie die (X,Y) Koordinaten für den 1. Punkt ein:");
    // um das erstellen der Punkte nicht so oft schreiben zu müssen, habe ich hier eien methode gemacht
    var p1 = createPoint();

    Console.WriteLine("Geben Sie die (X,Y) Koordinaten für den 2. Punkt ein:");
    var p2 = createPoint();
    if (p1 != null && p2 != null)
    {
        double d1 = calcDistance(p1);
        double d2 = calcDistance(p2);

        if (Equals(d1, d2))
        {
            changeColor(ConsoleColor.Green);
            Console.WriteLine("Die Distanz ist gleich");
        }
        else
        {
            changeColor(ConsoleColor.Red);
            Console.WriteLine("Die Distanzen sind unterschiedlich");
        }
    }
    else
    {
        changeColor(ConsoleColor.Red);
        Console.WriteLine("Punkte sind fehlerhaft... Abbruch");
    }
    
    changeColor(ConsoleColor.White);

} while (laufWiederholen());


static string? read() => Console.ReadLine();
static string getCultureInfo() => CultureInfo.CurrentCulture.Name;
static string convertCultureInfo(string str) => getCultureInfo().Split("-")[0].ToLower() == "de" ? str.Replace(".", ",") : str.Replace(",", ".");
static void changeColor(ConsoleColor c) => Console.ForegroundColor = c;
///<summary>
///
/// </summary>
/// <param name="x">X Koordinate </param>
/// <param name="y">Y Koordinate </param>
/// <returns>dynamic tuple as point </returns>
static (double x, double y)? createPoint()
{
    try
    {
        (double x, double y) point;
        Console.Write("X:");
        point.x = double.Parse(convertCultureInfo(read()));
        Console.Write("Y:");
        point.y = double.Parse(convertCultureInfo(read()));
        Console.WriteLine($"Punkt (x:{point.x,2}; y:{point.y,2})");
        return point;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
        return null;
    }
}
static double calcDistance((double x, double y)? p) => Math.Sqrt(Math.Pow((double)p?.x, 2) + Math.Pow((double)p?.y, 2));
static bool laufWiederholen()
{
    Console.WriteLine("Wollen Sie das Programm wiederholen, J/N");
    var wunsch = read().ToLower();
    if (wunsch != "j" && wunsch != "n") return laufWiederholen();
    else return wunsch == "j" ? true : false;
}








       



