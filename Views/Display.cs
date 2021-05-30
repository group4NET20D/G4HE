using G4HE.Views.Print;
using G4privateEconomyClassLibrary.EconomyPlanner;
using G4privateEconomyClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using G4HE.Views.Menus;

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

        /// <summary>
        /// Displays all the expenses that the user could
        /// not afford to pay.
        /// </summary>
        /// <param name="failExpenses">List of expenses not paid.</param>
        public static void ShowFailedExpense(IEnumerable<IExpenditure> failExpenses)
        {
            if (failExpenses != null)
            {
                Console.WriteLine("Income:\n");
                var index = 1;
                foreach (var income in BudgetCalculation._Income)
                {
                    Console.WriteLine($"{index}: {income.Name} {income.Amount}");
                    index++;
                }

                Console.WriteLine("Failed to pay:\n");
                index = 1;
                foreach (var expense in failExpenses)
                {
                    Console.WriteLine($"{index}: {expense.Name} {expense.Amount}");
                    index++;
                }

                Console.WriteLine($"Money left: {BudgetCalculation._MoneyLeft}");
            }
        }
    }
}
