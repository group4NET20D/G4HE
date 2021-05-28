using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace G4HE.Views.Menues
{
    class CalculatorMenu
    {
        public void Menu(float income, float expenses, float savings, float moneyleft)
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
                Console.Write("                              " + $"Income: {income}");
                Thread.Sleep(1500);
                Console.Write($"   Expenses: {expenses}");
                Thread.Sleep(1500);
                Console.Write($"   Savings: {savings}");
                Thread.Sleep(1500);
                Console.WriteLine();
                Console.WriteLine("\n                                       " + $"Your total money left: {moneyleft}!");
                Thread.Sleep(1500);
                Console.WriteLine("\n                                    Enter a key to exit the application...");
                Console.ReadLine();
            }
        }
    }
}
