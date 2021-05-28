using G4HE.Utility;
using G4HE.Views;
using G4HE.Views.Logotypes;
using G4privateEconomyClassLibrary.EconomyPlanner;
using System;
using G4HE.Mock;
using G4privateEconomyClassLibrary.EconomyPlanner.Models;

namespace G4HE.Controllers
{
    /// <summary>
    /// Responsible for controlling the way the user interacts
    /// with the MVC application.
    /// </summary>
    public class EconomyController
    {
        private BudgetCalculation BC = new();
        private string name;
        private string tag;
        private float amount;
        private string _continue;
        private int index;

        /// <summary>
        /// Asks the user to fill in forms for
        /// income & expenditure. Than displays the totals
        /// money saved and money left.
        /// </summary>
        public void Questionnaire()
        {
            //SetIncome();
            //SetExpenditure();
            var md = new NewMock();
           // md.MockIncomeSuccess();
            md.MockIncomeFail();
            md.MockExpenditures();
            var failExpenses = BC.ExpenseChecker();
            if (failExpenses.Count > 0) { Display.ShowFailedExpense(failExpenses); }
            else
            {
                Display.ShowResult(BudgetCalculation.TotalIncome(), BudgetCalculation.TotalExpenses(), 999, BudgetCalculation.MoneyLeft());
            }
        }

        /// <summary>
        /// Prompts user to fill in a form for his/her income.
        /// </summary>
        private void SetIncome()
        {
            index = 1;
            do
            {
                FillInForm("income");
                BudgetCalculation._Income.Add(new Income(name, tag, amount));
                KeepGoing("income");
                index++;
            } while (_continue == "yes");
        }

        /// <summary>
        /// Prompts user to fill in a form for his/her expenditure.
        /// </summary>
        private void SetExpenditure()
        {
            index = 1;
            do
            {
                FillInForm("expenditure");
                BudgetCalculation._Expenditures.Add(new Expenditure(name, tag, amount));
                KeepGoing("expenditure");
                index++;
            } while (_continue == "yes");
        }

        /// <summary>
        /// Refactoring.
        /// Asks users to fill in the form.
        /// </summary>
        /// <param name="type"></param>
        private void FillInForm(string type)
        {
            Console.Clear();
            DecideFormType(type, index);
            GetName();
            GetTag(type);
            GetAmount();
        }

        /// <summary>
        /// Refactoring.
        /// Gets the name of the income/expenditure.
        /// </summary>
        private void GetName()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Name: ");
            Console.ResetColor();
            name = Console.ReadLine()?.Trim();
        }

        /// <summary>
        /// Refactoring.
        /// Sets the tag to 
        /// </summary>
        /// <param name="type"></param>
        private void GetTag(string type)
        {
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
        }

        private void GetAmount()
        {
            amount = Helper.GetUserInputNoOption(int.MaxValue, "Amount");
        }

        private static void DecideFormType(string type, int index)
        {
            switch (type)
            {
                case "income" when index is 1:
                    Logo.SetIncome();
                    Display.GiveExampleOf("income", "CSN", "Fixed", 10000);
                    break;
                case "expenditure" when index is 1:
                    Logo.SetExpenditure();
                    Display.GiveExampleOf("expenditure", "Rent", "Fixed", 6000);
                    break;
                case "income":
                    Logo.SetIncome();
                    break;
                default:
                    Logo.SetExpenditure();
                    break;
            }
        }

        private void KeepGoing(string type)
        {
            Console.WriteLine($"\nAdd more {type}?");
            Console.WriteLine("\"Yes\" / \"No\"");
            var loop = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Option: ");
                _continue = Console.ReadLine()?.ToLower().Trim();
                if (_continue == "no")
                {
                    break;
                }
                else if (_continue == "yes")
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Input not recognized. Try again.");
                }
            } while (loop);
        }
    }
}
