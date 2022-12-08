using Utils = Helper.Utils;
using Terminal = Helper.Terminal;
namespace BitsErmitteln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal.ChangeColor(ConsoleColor.Green);

            Console.WriteLine(
                "Bit einer Ganzzahl ermitteln:\n\n" +

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
                    {
                        Console.WriteLine("Programm is starting...\n");

                        uint zahl = Terminal.GetConvertedConsoleInput<uint>("Geben Sie eine ganze positive Zahl ein: ");

                        Decimal2Binary(zahl);

                        break;
                    }
                case "info":
                    {
                        Console.WriteLine($"no infos available...");

                        break;
                    }
                default:
                    Console.WriteLine($"unknown command...");

                    break;
            }

            Terminal.ChangeColor(ConsoleColor.White);
        }

        private static void Decimal2Binary(uint zahl)
        {
            string binary = "";

            while (zahl > 0)
            {
                string bit = (zahl % 2).ToString();
                zahl /= 2;
                binary += bit;
            }
            Console.WriteLine("Binary:  {0}", binary);
        }
    }
}