using System;

namespace Helper
{
    public static class Utils
    {
        public static bool Mod0(int number, int divider) => number % divider == 0;
        public static bool Mod0(uint number, int divider) => number % divider == 0;
        public static bool Mod0(double number, int divider) => number % divider == 0;
        public static bool Mod0(float number, int divider) => number % divider == 0;

        
    }
    public static class Terminal
    {
        public static void Runner(Action<string> callback)
        {
            string prevInput = "";

            while (true)
            {
                Console.Write("command: ");

                string input = Console.ReadLine();

                if (input == "") input = prevInput;

                else prevInput = input;

                callback(input);

            }
        }
        public static void ChangeColor(ConsoleColor c) => Console.ForegroundColor = c;

        public static T GetConvertedConsoleInput<T>(string description)
        {
            Console.Write(description);
            try
            {
                T x = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                return x;
            }
            catch (Exception)
            {
                Console.WriteLine("Not possible...");
                return GetConvertedConsoleInput<T>(description);
            }

        }
    }
}

