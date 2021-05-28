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
        private string _continue;
        private int index;

        public void Questionnaire()
        {
            SetIncome();
            SetExpenditure();
            Display.ShowResult(BC.TotalIncome(), BC.TotalExpenses(), 999, BC.MoneyLeft());
        }

        private void SetIncome()
        {
            index = 1;
            do
            {
                FillInForm("income", index);
                BC._Income.Add(new Income(name, tag, amount));
                KeepGoing("income");
                index++;
            } while (_continue == "yes");
        }

        private void SetExpenditure()
        {
            index = 1;
            do
            {
                FillInForm("expenditure", index);
                BC._Expenditures.Add(new Expenditure(name, tag, amount));
                KeepGoing("expenditure");
                index++;
            } while (_continue == "yes");
        }

        private void FillInForm(string type, int index)
        {
            Console.Clear();
            DecideFormType(type, index);
            GetName();
            GetFixedOrUnexpected(type);
            GetAmount();
        }

        private void GetName()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Name: ");
            Console.ResetColor();
            name = Console.ReadLine()?.Trim();
        }

        private void GetFixedOrUnexpected(string type)
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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Amount: ");
            Console.ResetColor();
            amount = Helper.GetUserInputNoOption(int.MaxValue);
        }

        private static void DecideFormType(string type, int index)
        {
            if (type is "income" && index is 1)
            {
                Logo.SetIncome();
                Display.GiveExampleOf("income", "CSN", "Fixed", 10000);
            }
            else if (type is "expenditure" && index is 1)
            {
                Logo.SetExpenditure();
                Display.GiveExampleOf("expenditure", "Rent", "Fixed", 6000);
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
                    loop = false;
                    break;
                }
                else if (_continue == "yes")
                {
                    loop = false;
                    continue;
                }
                else
                {
                    Console.WriteLine("Input not recognized. Try again.");
                }
            } while (loop);
        }
    }
}
