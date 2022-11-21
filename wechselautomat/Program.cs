// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

do
{
    Console.ResetColor();
    Console.Clear();

    int rest = 0;
    Console.WriteLine("Geben sie einen Ganzzahligen Centbetrag ein");
    int cent = int.Parse(read());
    int euro = centInEuro(cent, ref rest);
    Console.WriteLine($"Euro: {euro} Rest: {rest} Cent");

    int anzahlCoins = getCoins(200, ref cent, "EURO");
    renderZweiEuro(anzahlCoins);

    anzahlCoins = getCoins(100, ref cent, "EURO");
    renderEinEuro(anzahlCoins);

    anzahlCoins = getCoins(50, ref rest);
    renderFuenfzigCent(anzahlCoins);

    anzahlCoins = getCoins(20, ref rest);
    renderZwanzigCent(anzahlCoins);

    anzahlCoins = getCoins(10, ref rest);
    renderZehnCent(anzahlCoins);

    anzahlCoins = getCoins(5, ref rest);
    renderFuenfCent(anzahlCoins);

    anzahlCoins = getCoins(2, ref rest);
    renderZweiCent(anzahlCoins);

    anzahlCoins = getCoins(1, ref rest);
    renderEinCent(anzahlCoins);

} while (laufWiederholen());
static int centInEuro(int cent, ref int rest)
{
    int euro = (cent / 100);
    rest = (cent % 100);
    return euro;
}
static int getCoins(int coin_in_cents, ref int rest, string c = "CENT")
{
    int anzahlCoins = 0;
    if (rest >= coin_in_cents)
    {
        anzahlCoins = rest / coin_in_cents;
        rest = rest % coin_in_cents;
        int coin = coin_in_cents >= 100 ? coin_in_cents / 100 : coin_in_cents;
        Console.WriteLine($" {anzahlCoins} X {coin} {c},  rest {rest} Cent: ");
    }
    return anzahlCoins;
}








#region Helper
static void renderZweiEuro(int anzahl) {
    if(anzahl >0)
    {
        string zweiE =
      $"\n            2 EURO  x  {anzahl}" + "              \n" +
      "\n               _ _ _" + "              " +
      "\n           -          -" + "           " +
      "\n         -             -" + "          " +
      "\n        -     * * *     -" + "         " +
      "\n       -     *     *     -" + "        " +
      "\n       -         *       -" + "       " +
      "\n       -       *         -" + "        " +
      "\n        -    * * * *    -" + "         " +
      "\n         -             -" + "          " +
      "\n           -  _ _ _  -" + "          ";

        changeColor(ConsoleColor.Gray);
        Console.Write(zweiE + "\n\n");
        changeColor(ConsoleColor.White);
    }
}
static void renderEinEuro(int anzahl)
{
    if (anzahl > 0)
    {
        string einE =
    $"\n            1 EURO  x  {anzahl}" + "              \n" +
    "\n            _ - - - _" + "              " +
    "\n         -             -" + "           " +
    "\n        -       *       -" + "          " +
    "\n       -        *        -" + "         " +
    "\n       -        *        -" + "         " +
    "\n       -        *        -" + "         " +
    "\n        -       *       -" + "          " +
    "\n         -             -" + "           " +
    "\n           -  _ _ _  -" + "             ";

        changeColor(ConsoleColor.Gray);
        Console.Write(einE + "\n\n");
        changeColor(ConsoleColor.White);
    }
}
static void renderFuenfzigCent(int anzahl)
{
    if (anzahl > 0)
    {
        string fuenfzigC =
    $"\n            50 CENT  x  {anzahl}" + "              \n" +
    "\n           _ - - - - _" + "              " +
    "\n         -             -" + "            " +
    "\n        -  * * *  * * * -" + "           " +
    "\n       -   *      *   *  -" + "          " +
    "\n       -   * * *  *   *  -" + "          " +
    "\n       -       *  *   *  -" + "          " +
    "\n        -  * * *  * * * -" + "           " +
    "\n         - _         _ -" + "            " +
    "\n             - - - -" + "                ";

        changeColor(ConsoleColor.DarkYellow);
        Console.Write(fuenfzigC + "\n\n");
        changeColor(ConsoleColor.White);
    }
}
static void renderZwanzigCent(int anzahl)
{
    if (anzahl > 0)
    {
        string zwanzigC =
        $"\n            20 CENT  x  {anzahl}" +   "\n" +
        "\n           _  - - -  _" + "            " +
        "\n         -             -" + "          " +
        "\n        -   * *   * * * -" + "         " +
        "\n       -   *   *  *   *  -" + "        " +
        "\n       -     *    *   *  -" + "        " +
        "\n       -    *     *   *  -" + "        " +
        "\n        -  * * *  * * * -" + "         " +
        "\n         -             -" + "          " +
        "\n           -  _ _ _  -" + "            ";

        changeColor(ConsoleColor.DarkYellow);
        Console.Write(zwanzigC + "\n\n");
        changeColor(ConsoleColor.White);
    }
}
static void renderZehnCent(int anzahl)
{
    if (anzahl > 0)
    {
        string zehnC =
        $"\n           10 CENT  x  {anzahl}" +  "\n" +
        "\n            _ - - _" + "             " +
        "\n         -           -" + "          " +
        "\n        -   *  * * *  -" + "         " +
        "\n       -    *  *   *   -" + "        " +
        "\n       -    *  *   *   -" + "        " +
        "\n       -    *  *   *   -" + "        " +
        "\n        -   *  * * *  -" + "         " +
        "\n         -           -" + "          " +
        "\n            - _ _ -" + "             ";

        changeColor(ConsoleColor.DarkYellow);
        Console.Write(zehnC + "\n\n");
        changeColor(ConsoleColor.White);
    }
}
static void renderFuenfCent(int anzahl)
{
    if (anzahl > 0)
    {
        string fuenfC =
        $"\n            5 CENT  x  {anzahl}" +  "\n" +
        "\n            _ - - _" + "             " +
        "\n         -           -" + "          " +
        "\n        -    * * *    -" + "         " +
        "\n       -     *         -" + "        " +
        "\n       -     * * *     -" + "        " +
        "\n       -         *     -" + "        " +
        "\n        -    * * *    -" + "         " +
        "\n         -           -" + "          " +
        "\n            - _ _ -" + "             ";

        changeColor(ConsoleColor.DarkRed);
        Console.Write(fuenfC + "\n\n");
        changeColor(ConsoleColor.White);
    }

}
static void renderZweiCent(int anzahl)
{
    if (anzahl > 0)
    {
        string zweiC =
       $"\n             2 CENT  x  {anzahl}" +   "\n" +
        "\n             _ - - _" + "             " +
        "\n          -           -" + "          " +
        "\n         -     * *     -" + "         " +
        "\n        -     *   *     -" + "        " +
        "\n        -       *       -" + "        " +
        "\n        -      *        -" + "        " +
        "\n         -    * * *    -" + "         " +
        "\n          -           -" + "          " +
        "\n             - _ _ -" + "             ";

        changeColor(ConsoleColor.DarkRed);
        Console.Write(zweiC + "\n\n");
        changeColor(ConsoleColor.White);
    }
}
static void renderEinCent(int anzahl)
{
    if (anzahl > 0)
    {
        string einC =
      $"\n              1 CENT  x  {anzahl}" + "\n" +
        "\n               _" + "               " +
        "\n           -       -" + "           " +
        "\n         -     *     -" + "         " +
        "\n        -      *      -" + "        " +
        "\n        -      *      -" + "        " +
        "\n        -      *      -" + "        " +
        "\n         -     *     -" + "         " +
        "\n           -   _   -" + "           ";
        changeColor(ConsoleColor.DarkRed);
        Console.Write(einC + "\n\n");
        changeColor(ConsoleColor.White);
    }
}
static void changeColor(ConsoleColor c) => Console.ForegroundColor = c;
static bool mod0(int num, int b) => num % b == 0;
static string? read() => Console.ReadLine();
static bool laufWiederholen()
{
    changeColor(ConsoleColor.White);
    Console.WriteLine("Wollen Sie das Programm wiederholen, J/N");
    var wunsch = read().ToLower();
    if (wunsch != "j" && wunsch != "n") return laufWiederholen();
    else return wunsch == "j" ? true : false;
}
#endregion


