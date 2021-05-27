using System;
using System.Threading;
using static System.Int32;

namespace G4HE.Utility
{
    internal static class Helper
    {
        private static bool Success;
        private static string Input;
        private static int Number;

        internal static int GetUserInputWithOption(int maxOptions)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Option: ");
            Console.ResetColor();
            Input = Console.ReadLine()?.Trim().ToLower();
            Success = TryParse(Input, out Number);
            if (!Success || Number > maxOptions || Number <= 0)
            {
                Error();
                GetUserInputWithOption(maxOptions);
            }
            Console.ResetColor();
            return Number;
        }

        internal static int GetUserInputNoOption( int maxOptions)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.ResetColor();
            Input = Console.ReadLine()?.Trim().ToLower();
            Success = TryParse(Input, out Number);
            if (!Success || Number > maxOptions || Number <= 0)
            {
                Error();
                GetUserInputNoOption(maxOptions);
            }
            Console.ResetColor();
            return Number;
        }

        private static void Error()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error, something went wrong. Try again.");
            Thread.Sleep(1300);
            Console.ResetColor();
        }
    }
}
