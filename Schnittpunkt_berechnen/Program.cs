using Utils = Helper.Utils;
using Terminal = Helper.Terminal;
namespace Schnittpunkt_berechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal.ChangeColor(ConsoleColor.Green);

            Console.WriteLine(
                "Schnittpunkt von 2 Geraden berechnen:\n\n" +

                $"write 'info' for programm info\n" +

                $"write 'run' to start the program.\n"
             );

            Terminal.ChangeColor(ConsoleColor.White);

            Terminal.Runner(new Action<string>(Execute));
        }
        
        public static bool HasIntersection(out double x, out double y)
        {
            double k1 = Terminal.GetConvertedConsoleInput<double>("Geben Sie die erste Steigung ein: ");

            double d1 = Terminal.GetConvertedConsoleInput<double>("Geben Sie die erste Determinante ein: ");

            double k2 = Terminal.GetConvertedConsoleInput<double>("Geben Sie die zweite Steigung ein: ");

            double d2 = Terminal.GetConvertedConsoleInput<double>("Geben Sie die zweite Determinante ein: ");

            if (k1 == k2)
            {
                x = 0;

                y = 0;

                return false;
            }
            else
            {
                x = (d1 - d2) / (k2 - k1);

                y = (k1 * x) + d1;

                return true;
            }
        }

        public static void ShowInfo()
        {
            Terminal.ChangeColor(ConsoleColor.DarkGray);

            Console.WriteLine($"\n" +

                $"Fälle:\n" +

                $"identisch => k sind gleich, d sind gleich\n" +

                $"echt parallel => k sind gleich, d sind unterschiedlich\n" +

                $"geraden schneiden sich\n" +

                $"\n"
            );
        }

        public static void Execute(string input)
        {
            switch (input)
            {
                case "run":
                    bool result = HasIntersection(out double x, out double y);

                    if (result)
                    {

                        Terminal.ChangeColor(ConsoleColor.Yellow);

                        Console.WriteLine($"Schnittpunkt ({x}/{y})\n\n");
                    }
                    else
                    {
                        Terminal.ChangeColor(ConsoleColor.Red);

                        Console.WriteLine("Geraden schneiden sich nicht");

                    }


                    break;

                case "info":

                    ShowInfo();

                    break;

                default:

                    Terminal.ChangeColor(ConsoleColor.DarkGray);

                    Console.WriteLine("unknown command...");

                    break;
            }

            Terminal.ChangeColor(ConsoleColor.White);

        }
    }
}