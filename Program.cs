using G4HE.Controllers;
using G4HE.Mock;
using G4privateEconomyClassLibrary.EconomyPlanner;
using System;

namespace G4HE
{
    class Program
    {
        //static void Main(string[] args) => MainMenuController.Menu();
        static void Main(string[] args) => Nicklas();

        private static void Julia()
        {
            var mock = new NewMock();
            mock.MockIncomeSuccess();
            mock.MockExpenditures();
            Console.WriteLine($"Income this month: {Math.Round(BudgetCalculation.TotalIncome(),2)} ");
            Console.WriteLine($"Total expenses this month: {Math.Round(BudgetCalculation.TotalExpenses(),2)} ");
            Console.WriteLine($" - of which fixed expenses this month: {Math.Round(BudgetCalculation.FixedExpenses(),2)} ");
            Console.WriteLine($" - of which savings this month: {Math.Round(BudgetCalculation.Savings(), 2)} ");
            Console.WriteLine($" - of which unexpected expenses this month: {Math.Round(BudgetCalculation.UnexpectedExpenses(), 2)} ");
            Console.WriteLine($"Calculated expenses (savings + unexpected expenses) : {Math.Round(BudgetCalculation.CalculatedExpenses(), 2)} ");
            Console.WriteLine($"Money left this month: {Math.Round(BudgetCalculation.MoneyLeft(), 2)} ");

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
