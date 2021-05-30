using G4HE.Views.Menus;
using G4HE.Views.Print;
using System;
using System.Collections.Generic;

namespace G4HE.Views
{
    /// <summary>
    /// Text output used to show to users.
    /// </summary>
    public static class Display
    {
        /// <summary>
        /// Displays the result 
        /// </summary>
        public static void ShowResult()
        {
            Console.Clear();
            CalculatorMenu.Menu();
        }

        /// <summary>
        ///  Displays an example of how to fill in the expense- / income form with tag.
        /// </summary>
        /// <param name="type">Income/expenditure.</param>
        /// <param name="name">Name of the income/expenditure.</param>
        /// <param name="tag">Fixed/Unexpected/Saving.</param>
        /// <param name="amount">Amount of money.</param>
        public static void GiveExampleOf(string type, string name, string tag, float amount)
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"To enter your {type} you",
                "will need to provide:",
                "Examples:",
                $"Name: \"{name}\"",
                $"Tag: \"{tag}\"",
                $"Amount: \"{amount}\"\n"
            });
        }

        /// <summary>
        ///  Displays an example of how to fill in the expense- / income form without tag.
        /// </summary>
        /// <param name="type">Income/expenditure.</param>
        /// <param name="name">Name of the income/expenditure.</param>
        /// <param name="amount">Amount of money.</param>
        public static void GiveExampleOf(string type, string name, float amount)
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"To enter your {type} you",
                "will need to provide:",
                "Examples:",
                $"Name: \"{name}\"",
                $"Amount: \"{amount}\"\n"
            });
        }
    }
}
