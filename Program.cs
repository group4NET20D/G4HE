using G4HE.Controllers;
using G4HE.Mock;
using G4privateEconomyClassLibrary.EconomyPlanner;
using System;

namespace G4HE
{
    class Program
    {
        //static void Main(string[] args) => MainMenuController.Menu();
        static void Main(string[] args) => Julia();

        private static void Julia()
        {
            var BC = new BudgetCalculation();
            var mock = new NewMock();
            mock.MockIncome();
            mock.MockExpenditures();
            Console.WriteLine($"Money lft this month: {BC.MoneyLeft()} ");

        }

        private static void Nicklas()
        {
            MainMenuController.Menu();
        }

        private static void Nils()
        {
            var calcMenu = new G4HE.Views.Menues.CalculatorMenu();
            //    calcMenu.Menu();
        }

        private static void Christopher()
        {

        }
    }
}
