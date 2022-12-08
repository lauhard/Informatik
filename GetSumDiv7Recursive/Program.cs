using Utils = Helper.Utils;
using Terminal = Helper.Terminal;
namespace GetSumDiv7Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal.ChangeColor(ConsoleColor.Green);

            Console.WriteLine(
                "GetSumDiv7Recursive:\n\n" +

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

                        Console.WriteLine("Geben Sie den Zahlenbereich ein:");

                        uint from = Terminal.GetConvertedConsoleInput<uint>("Zahlen von: ");

                        uint to = Terminal.GetConvertedConsoleInput<uint>("Zahlen bis: ");

                        uint summe = GetSumDiv7Recursive(from, to);

                        Terminal.ChangeColor(ConsoleColor.Red);

                        Console.WriteLine($"\nSumme der ZahlenDiv7: {summe}\n");

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

        public static uint GetSumDiv7Recursive(uint from, uint to)
        {
            uint summe = 0;

            if (from > to) return summe;

            if (Utils.Mod0(from,7)) { summe += from; }

            if (from <= to) summe += GetSumDiv7Recursive(from + 1, to);

            return summe;
        }

        
    }
}