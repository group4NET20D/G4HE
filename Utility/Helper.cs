using System;
using System.Threading;
using static System.Int32;

namespace G4HE.Utility
{
    /// <summary>
    /// Helper class that assists in creating the program.
    /// </summary>
    internal static class Helper
    {
        private static bool Success;
        private static string Input;
        private static int Number;

        /// <summary>
        /// Get user input as an integer.
        /// Method also prompts user for their input.
        /// Option: _______
        /// </summary>
        /// <param name="maxOptions">Maximum amount of input available for user to choose.</param>
        /// <returns>integer if user input was correct.</returns>
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

        /// <summary>
        /// Get user input as an integer.
        /// Method prompts user for input:
        /// {optionTag}: _____
        /// </summary>
        /// <param name="maxOptions">Maximum amount of input available for user to choose.</param>
        /// <param name="optionTag">ex: Option: // Amount: )</param>
        /// <returns>integer if user input was correct.</returns>
        internal static int GetUserInputNoOption(int maxOptions, string optionTag)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{optionTag}: ");
            Console.ResetColor();
            Input = Console.ReadLine()?.Trim().ToLower();
            Success = TryParse(Input, out Number);
            if (!Success || Number > maxOptions || Number <= 0)
            {
                Error();
                GetUserInputNoOption(maxOptions, optionTag);
            }
            Console.ResetColor();
            return Number;
        }

        /// <summary>
        /// If user entered unwanted input an error message will be displayed.
        /// </summary>
        private static void Error()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error, wrong input. Try again.");
            Thread.Sleep(1300);
            Console.ResetColor();
        }
    }
}
