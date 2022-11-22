// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

string antwort = "";
do
{
    Console.ResetColor();
    Console.Clear();

    int rest = 0;
    Console.WriteLine("Geben sie einen Ganzzahligen Centbetrag ein");
    int cents = int.Parse(Console.ReadLine());

    /// cent in euro umrechnen
    int euro = (cents / 100);
    rest = (cents % 100);
    /// cent in euro umrechnen
    Console.WriteLine($"Euro: {euro} Rest: {rest} Cent");


    int anzahlCoins = 0;
    int coin_in_cents = 200;
    if (cents >= coin_in_cents)
    {
        anzahlCoins = cents / coin_in_cents;
        rest = cents % coin_in_cents;
        int coin =  coin_in_cents / 100;
        changeColor(ConsoleColor.DarkGray);
        Console.WriteLine($" {anzahlCoins} X {coin} Euro,  rest {rest} Cent ");
        if (rest > 0) cents = rest;
    }

    coin_in_cents = 100;
    if (cents >= coin_in_cents)
    {
        anzahlCoins = cents / coin_in_cents;
        rest = cents % coin_in_cents;
        int coin =  coin_in_cents / 100;
        changeColor(ConsoleColor.DarkGray);
        Console.WriteLine($" {anzahlCoins} X {coin} Euro,  rest {rest} Cent ");
    }
    coin_in_cents = 50;
    if (rest >= coin_in_cents)
    {
        anzahlCoins = rest / coin_in_cents;
        rest = rest % coin_in_cents;
        int coin = coin_in_cents;
        changeColor(ConsoleColor.DarkYellow);
        Console.WriteLine($" {anzahlCoins} X {coin} Cent,  rest {rest} Cent ");
    }

    coin_in_cents = 20;
    if (rest >= coin_in_cents)
    {
        anzahlCoins = rest / coin_in_cents;
        rest = rest % coin_in_cents;
        int coin = coin_in_cents;
        changeColor(ConsoleColor.DarkYellow);
        Console.WriteLine($" {anzahlCoins} X {coin} Cent,  rest {rest} Cent ");
    }

    coin_in_cents = 10;
    if (rest >= coin_in_cents)
    {
        anzahlCoins = rest / coin_in_cents;
        rest = rest % coin_in_cents;
        int coin = coin_in_cents;
        changeColor(ConsoleColor.DarkYellow);
        Console.WriteLine($" {anzahlCoins} X {coin} Cent,  rest {rest} Cent ");
    }

    coin_in_cents = 5;
    if (rest >= coin_in_cents)
    {
        anzahlCoins = rest / coin_in_cents;
        rest = rest % coin_in_cents;
        int coin = coin_in_cents;
        changeColor(ConsoleColor.DarkRed);
        Console.WriteLine($" {anzahlCoins} X {coin} Cent,  rest {rest} Cent ");
    }

    coin_in_cents = 2;
    if (rest >= coin_in_cents)
    {
        anzahlCoins = rest / coin_in_cents;
        rest = rest % coin_in_cents;
        int coin = coin_in_cents;
        changeColor(ConsoleColor.DarkRed);
        Console.WriteLine($" {anzahlCoins} X {coin} Cent,  rest {rest} Cent ");
    }

    coin_in_cents = 1;
    if (rest >= coin_in_cents)
    {
        anzahlCoins = rest / coin_in_cents;
        rest = rest % coin_in_cents;
        int coin = coin_in_cents;
        changeColor(ConsoleColor.DarkRed);
        Console.WriteLine($" {anzahlCoins} X {coin} Cent,  rest {rest} Cent ");
    }


    changeColor(ConsoleColor.White);
    Console.WriteLine("Wollen Sie das Programm wiederholen, gebens sie 'j' ein.");
    antwort = Console.ReadLine();

} while (antwort == "j");









static void changeColor(ConsoleColor c) => Console.ForegroundColor = c;


