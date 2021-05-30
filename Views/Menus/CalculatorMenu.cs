using G4privateEconomyClassLibrary.EconomyPlanner;
using System;
using System.Threading;

namespace G4HE.Views.Menus
{
    /// <summary>
    /// This class contains a menu method that prints out values for the user.
    /// </summary>
    public static class CalculatorMenu
    {
        private static int index;
        /// <summary>
        /// This method prints out the income, expenses, savings and money left.
        /// </summary>
        public static void Menu()
        {
            Console.WindowHeight = 30;
            Console.WindowWidth = 120;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;

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

                if (BudgetCalculation._PaidExpenses.Count > 0)
                {
                    Console.WriteLine($"\n                                    Paid expenses:");
                    index = 1;
                    foreach (var bill in BudgetCalculation._PaidExpenses)
                    {
                        Console.WriteLine($"                                    {index}: {bill.Name} {bill.Amount}kr");
                        index++;
                    }

                }

                Thread.Sleep(1500);
                if (BudgetCalculation._FailedExpenses.Count > 0)
                {
                    Console.WriteLine($"\n                                    Failed to pay:");
                    index = 1;
                    foreach (var bill in BudgetCalculation._FailedExpenses)
                    {
                        Console.WriteLine($"                                    {index}: {bill.Name} {bill.Amount}kr");
                    }
                }
                Thread.Sleep(1500);
                Console.WriteLine($"\n                                    {BudgetCalculation._Saving.Name}: {BudgetCalculation.GetSavings()}kr");
                Thread.Sleep(1500);
                Console.WriteLine($"                                    {BudgetCalculation._UnexpectedExpense.Name}: {BudgetCalculation.GetUnexpectedExpenses()}kr");
                Thread.Sleep(1500);
                Console.WriteLine($"                                    Money left for pizza: {BudgetCalculation._MoneyLeft}kr!");
                Thread.Sleep(1500);



                Console.WriteLine("\n                                    Enter a key to exit the application...");
                Console.ResetColor();
                Console.ReadKey();
                break;
            }

            Environment.Exit(0);
        }
    }
}
