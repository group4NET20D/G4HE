using System;
using System.Linq;
using System.Threading;
using G4privateEconomyClassLibrary.EconomyPlanner;

namespace G4HE.Views.Menus
{
    /// <summary>
    /// This class contains a menu method that prints out values for the user.
    /// </summary>
    public static class CalculatorMenu
    {
        /// <summary>
        /// This method prints out the income, expenses, savings and money left.
        /// </summary>
        public static void Menu()
        {
            Console.WindowHeight = 30;
            Console.WindowWidth = 120;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine(@"
$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                       __  ___                              __         __     __  _         
                      /  |/  /__  ___  ___ __ __  _______ _/ /_____ __/ /__ _/ /_(_)__  ___ 
                     / /|_/ / _ \/ _ \/ -_) // / / __/ _ `/ / __/ // / / _ `/ __/ / _ \/ _ \
                    /_/  /_/\___/_//_/\__/\_, /  \__/\_,_/_/\__/\_,_/_/\_,_/\__/_/\___/_//_/
                                          /__/
                                                                                            
$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$


                                  ");
                Console.Write($"                                    Income: {BudgetCalculation.TotalIncome()}kr");
                Thread.Sleep(1500);
                Console.WriteLine($"   Expenses: {BudgetCalculation.TotalExpenses()}kr");
                Thread.Sleep(1500);
                Console.WriteLine($"                                    Savings: {BudgetCalculation.Savings()}kr");
                Thread.Sleep(1500);
                Console.WriteLine($"                                    Money put away for unexpected expenses: {BudgetCalculation.UnexpectedExpenses()}kr");
                Thread.Sleep(1500);
                Console.WriteLine($"                                    Money left for pizza: {BudgetCalculation._MoneyLeft}kr!");
                Thread.Sleep(1500);
                Console.WriteLine("\n                                    Enter a key to exit the application...");
                Console.ReadLine();
                Console.ResetColor();
            }
        }
    }
}
