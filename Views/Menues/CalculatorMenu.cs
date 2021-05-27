using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4HE.Views.Menues
{
    class CalculatorMenu
    {
        public void Menu()
        {
            string spacing = "                                                ";

            Console.WindowHeight = 30;
            Console.WindowWidth = 120;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine(@"
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            ____  ____  __ __ __  ___  ______  ____     ____   ___   ___   __  __   ___   ___  ___ _  _
            || \\ || \\ || || || // \\ | || | ||       ||     //    // \\  ||\ ||  // \\  ||\\//|| \\//
            ||_// ||_// || \\ // ||=||   ||   ||==     ||==  ((    ((   )) ||\\|| ((   )) || \/ ||  )/ 
            ||    || \\ ||  \V/  || ||   ||   ||___    ||___  \\__  \\_//  || \||  \\_//  ||    || //  
                                                                                            
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


                                  ");
                Console.WriteLine(spacing + "test");
            }
        }

    }
}
