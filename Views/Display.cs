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
            //TotalIncome();
            //TotalExpenditure();
            //Savings();
            //MoneyLeft();
        }

        /// <summary>
        /// Displays the total entered income.
        /// </summary>
        /// <param name="totalIncome">Total income entered into the program.</param>
        public static void TotalIncome()
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"The total of your income is: {BudgetCalculation._Income}"
            });
        }

        /// <summary>
        /// Displays the total entered expenses.
        /// </summary>
        /// <param name="totalExpenses">Total expenses entered into the program.</param>
        public static void TotalExpenditure()
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"The total of your expenses is: {BudgetCalculation._Expenditures}"
            });
        }

        /// <summary>
        /// Displays the amount that was put into savings after expenses were paid.
        /// </summary>
        /// <param name="savings">Total saving.</param>
        public static void Savings()
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"The total of your savings is: {BudgetCalculation._Saving}"
            });
        }

        /// <summary>
        /// Displays the money left in the account balance.
        /// </summary>
        /// <param name="moneyLeft">Total money left.</param>
        public static void MoneyLeft()
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"The amount of money you have left: {BudgetCalculation._MoneyLeft}"
            });
        }

        /// <summary>
        /// Refactored.
        ///  Displays an example of how to fill in the expense- / income form.
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
        /// Displays all the expenses that the user could
        /// not afford to pay.
        /// </summary>
        /// <param name="failExpenses">List of expenses not paid.</param>
        public static void ShowFailedExpense(IEnumerable<IExpenditure> failExpenses)
        {
            foreach (var income in BudgetCalculation._Income)
            {
                Console.WriteLine($"Income: {income.Name} {income.Amount}");
            }

            foreach (var expense in failExpenses )
            {
                Console.WriteLine($"Failed to pay: {expense.Name} {expense.Amount}");
            }

            Console.WriteLine($"Money left: {BudgetCalculation._MoneyLeft}");
        }
    }
}
