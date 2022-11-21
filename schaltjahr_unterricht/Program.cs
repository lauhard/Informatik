// See https://aka.ms/new-console-template for more information
Console.WriteLine("Prüfe auf Schaltjahr");
string antwort = "";
do
{
    Console.WriteLine("Geben sie ein Jahr zwischen 1500 und 3000");
    int year = int.Parse(Console.ReadLine());

    if (1500 < year && 3000 > year)
    {
        if (
            year % 400 == 0 ||
            (year % 4 == 0 && year % 100 != 0)
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

    changeColor(ConsoleColor.White); 
    Console.WriteLine("Wollen Sie das Programm wiederholen, gebens sie 'j' ein.");
    antwort = Console.ReadLine();

} while (antwort == "j");

static void changeColor(ConsoleColor c) => Console.ForegroundColor = c;
