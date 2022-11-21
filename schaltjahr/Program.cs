// See https://aka.ms/new-console-template for more information
Console.WriteLine("Prüfe auf Schaltjahr");
do
{
    try
    {
        Console.WriteLine("Geben sie ein Jahr zwischen 1500 und 3000");
        int year = int.Parse(read());

        if (isBetweenYears(1500, 3000, year))
        {
            if (
                mod0(year, 400) ||
                (mod0(year, 4) && !mod0(year, 100))
            )
            {
                changeColor(ConsoleColor.Green);
                Console.WriteLine($"Das Jahr {year} ist ein Schaltjahr.");
            }
            else
            {
                changeColor(ConsoleColor.Red);
                Console.WriteLine($"Das Jahr {year} kein ein Schaltjahr.");
            }
        }
        else
        {
            changeColor(ConsoleColor.Red);
            Console.WriteLine($"Das Jahr {year} liegt nicht im ausgewählten Bereich...");
        }
    }
    catch (Exception ex)
    {
        changeColor(ConsoleColor.Red);
        Console.WriteLine($"{ex.Message}");
    }
    
    changeColor(ConsoleColor.White);
} while (laufWiederholen());

static string? read() => Console.ReadLine();
static void changeColor(ConsoleColor c) => Console.ForegroundColor = c;
static bool isBetweenYears(int from, int to, int year) => from < year && to > year;
static bool mod0(int num, int b) => num % b == 0;
static bool laufWiederholen()
{
    Console.WriteLine("Wollen Sie das Programm wiederholen, J/N");
    var wunsch = read().ToLower();
    if (wunsch != "j" && wunsch != "n") return laufWiederholen();
    else return wunsch == "j" ? true : false;
}