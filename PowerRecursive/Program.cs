using Utils = Helper.Utils;
using Terminal = Helper.Terminal;
namespace PowerRecursive
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Terminal.ChangeColor(ConsoleColor.Green);

            Console.WriteLine(
                "Power recursive:\n\n" +

                "Write 'info' for program infos\n" +

                "Write 'run' to start the program\n"
            );

            Terminal.ChangeColor(ConsoleColor.White);

            Terminal.Runner(new Action<string>(Execute));
        }

        public static void info()
        {
            Console.WriteLine($"\n\n" +
                $"Schritte:\n" +
                $"Abbruchbedinbung definieren:\n" +
                $"b = 0\n" +
                $"Fälle definieren:\n" +
                $" b > 0 => a * a^(b-1)\n" +
                $" b < 0 => 1 / a^b\n" +
                $"-----------------\n\n"
            );
        }
        
        public static double PowerRecursive(double a, int b)
        {
            double aPowerB = 1;

            if (b == 0) return aPowerB;

            if (b > 0) aPowerB = a * PowerRecursive(a, b - 1);

            if (b < 0) aPowerB = 1 / PowerRecursive(a, b);

            return aPowerB;
        }

        public static void Execute(string input)
        {
            switch (input)
            {
                case "run":
                    {
                        Console.WriteLine("Programm is starting...\n");

                        double basis = Terminal.GetConvertedConsoleInput<double>("Geben Sie eine Basis ein: ");

                        int potenz = Terminal.GetConvertedConsoleInput<int>("Geben Sie eine Potenz ein: ");

                        double result = PowerRecursive(basis, potenz);

                        Console.WriteLine($"{basis} ^ {potenz} = {result}");

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

    }
}