using System;
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
                Console.Write("                              " + $"Income: {BudgetCalculation._Income}");
                Thread.Sleep(1500);
                Console.Write($"   Expenses: {BudgetCalculation._Expenditures}");
                Thread.Sleep(1500);
                Console.Write($"   Savings: {BudgetCalculation._Saving}");
                Thread.Sleep(1500);
                Console.WriteLine();
                Console.WriteLine("\n                                       " + $"Your total money left: {BudgetCalculation._MoneyLeft}!");
                Thread.Sleep(1500);
                Console.WriteLine("\n                                    Enter a key to exit the application...");
                Console.ReadLine();
            }
        }
    }
}
