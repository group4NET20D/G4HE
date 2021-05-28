using G4HE.Utility;
using G4HE.Views;
using G4HE.Views.Logotypes;
using G4privateEconomyClassLibrary.EconomyPlanner;
using System;
using G4privateEconomyClassLibrary.EconomyPlanner.Models;

namespace G4HE.Controllers
{
    public class EconomyController
    {
        private BudgetCalculation BC = new();
        private string name;
        private string tag;
        private float amount;
        string _continue;

        public void Questionnaire()
        {
            SetIncome();
            SetExpenditure();
            Display.ShowResult(BC.TotalIncome(), BC.TotalExpenses(), 999, BC.MoneyLeft());
        }

        private void SetIncome()
        {
            Console.Clear();
            Logo.SetIncome();
            Display.GiveExampleOf("income", "CSN", "Fixed", 10000);
            do
            {
                FillInForm("income");
                BC._Income.Add(new Income(name, tag, amount));
                KeepGoing("income");
            } while (_continue == "yes");
        }

        private void SetExpenditure()
        {
            Console.Clear();
            Logo.SetExpenditure();
            Display.GiveExampleOf("expenditure", "Rent", "Fixed", 6000);
            do
            {
                FillInForm("expenditure");
                BC._Expenditures.Add(new Expenditure(name, tag, amount));
                KeepGoing("expenditure");
            } while (_continue == "yes");
        }

        private void FillInForm(string type)
        {
            Console.Write("Name: ");
            name = Console.ReadLine()?.Trim();

            Console.WriteLine($"Is the {type} \"Fixed\" = (1) / \"Unexpected\" (2) ");
            var input = Helper.GetUserInputWithOption(2);

            if (input == 1)
            {
                Console.WriteLine("Tag = \"Fixed\"");
                tag = "Fixed";
            }
            else
            {
                Console.WriteLine("Tag = \"Unexpected\"");
                tag = "Unexpected";
            }

            Console.Write("Amount:");
            amount = Helper.GetUserInputNoOption(int.MaxValue);
        }

        private void KeepGoing(string type)
        {
            Console.WriteLine($"\nAdd more {type}?");
            Console.WriteLine("\"Yes\" / \"No\"");
            var keepGoing = true;
            do
            {
                _continue = Console.ReadLine()?.ToLower().Trim();
                if (_continue == "no")
                {
                    keepGoing = false;
                    break;
                }
                else if(_continue == "yes")
                {
                    continue;
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Input not recognized. Try again.");
                }
            } while (keepGoing);
        }
    }
}
