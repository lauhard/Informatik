using Utils = Helper.Utils;
using Terminal = Helper.Terminal;
namespace Ziffernsumme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Terminal.ChangeColor(ConsoleColor.Green);

            Console.WriteLine(
                "Ziffernsumme berechnen:\n\n" +

                "Write 'info' for program infos\n" +

                "Write 'run' to start the program\n"
            );

            Terminal.ChangeColor(ConsoleColor.White);

            Terminal.Runner(new Action<string>(Execute));

        }
        public static void Execute(string input)
        {
            switch (input)
            {
                case "run":

                    uint zahl = Terminal.GetConvertedConsoleInput<uint>("positive ganze Zahl eingeben:\n");

                    uint quersumme = Ziffernsumme(zahl);

                    Terminal.ChangeColor(ConsoleColor.DarkYellow);

                    Console.WriteLine($"Quersumme ist: {quersumme} \n");


                    break;

                case "info":

                    Terminal.ChangeColor(ConsoleColor.DarkGray);

                    Console.WriteLine("no info available...");

                    break;

                default:

                    Terminal.ChangeColor(ConsoleColor.DarkGray);

                    Console.WriteLine("unknown command...");

                    break;
            }

            Terminal.ChangeColor(ConsoleColor.White);
        }

        public static uint Ziffernsumme(uint zahl)
        {
            uint quersumme = 0;
            while (zahl > 0)
            {
                quersumme += zahl % 10;

                zahl /= 10;
            }
            return quersumme;
        }
    }
}