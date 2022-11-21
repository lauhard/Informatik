// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Globalization;
string antwort = "";
Console.WriteLine("Vergleiche Distanz 2er Punkte im Raun D2");
do
{
    Console.WriteLine("Geben Sie die (X,Y) Koordinaten für den 1. Punkt ein:");
    Console.Write("X1:");
    double x1 = double.Parse(Console.ReadLine());
    Console.Write("Y1:");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine($"Punkt1 (x:{x1,2}; y:{y1,2})");

    Console.WriteLine("Geben Sie die (X,Y) Koordinaten für den 2. Punkt ein:");
    Console.Write("X2:");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Y2:");
    double y2 = double.Parse(Console.ReadLine());
    Console.WriteLine($"Punkt2 (x:{x2,2}; y:{y2,2})");

    double distanz1, distanz2 = 0;
    distanz1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
    distanz2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

    if(distanz1 == distanz2)
    {
        changeColor(ConsoleColor.Green);
        Console.WriteLine("Die Distanzen sind gleich.");
    } else
    {
        changeColor(ConsoleColor.Red);
        Console.WriteLine("Die Distanzen sind unterschiedlich");
    }

    changeColor(ConsoleColor.White);
    Console.WriteLine("Wollen Sie das Programm wiederholen, gebens sie 'j' ein.");
    antwort = Console.ReadLine();
} while (antwort == "j");


static string? read() => Console.ReadLine();
static void changeColor(ConsoleColor c) => Console.ForegroundColor = c;












