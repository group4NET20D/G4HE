using System;
using System.Collections.Generic;
using G4HE.Utility;
using G4HE.Views.Logotypes;
using G4HE.Views.Print;

namespace G4HE.Controllers
{
    public static class MainMenuController
    {
        private static EconomyController EC = new();

        public static void Menu()
        {
            Logo.MainMenu();
            DrawFrames.DisplayMenu(new List<string> {
                "Private Economy Calculator",
                "Exit Application"
            });
            var userInput = Helper.GetUserInputWithOption(2);
            MenuOptions(userInput);
        }

        private static void MenuOptions(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    EC.Questionnaire();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
