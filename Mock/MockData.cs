using G4privateEconomyClassLibrary.EconomyPlanner;
using G4privateEconomyClassLibrary.EconomyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4HE.Mock
{
    public class NewMock
    {
        public bool MockIncome()
        {
            try
            {
                //var budget = new BudgetCalculation();
                Income income = new Income("Fixed", "Salary", 14500F);
                return true;
            }
            catch (Exception e)
            {
                Logger.Log(e);
                return false;
            }
        }

        public bool MockExpenditures()
        {
            try
            {
                List<Expenditure> expenditure = new()
                {
                    new Expenditure("Fixed", "Rent", 8900),
                    new Expenditure("Fixed", "Netflix", 89),
                    new Expenditure("Fixed", "Mobile", 99),
                    new Expenditure("Fixed", "Broadband", 199),
                    new Expenditure("Fixed", "Food", 1200),
                    new Expenditure("Fixed", "Consumables", 600),
                    new Expenditure("Fixed", "Bank cost", 45),
                    new Expenditure("Fixed", "Pensions", 1000),
                    new Expenditure("Fixed", "Gym", 350),
                    new Expenditure("Fixed", "Home insurance", 75),
                    new Expenditure("Saving", "Saving", 0.1F),
                    new Expenditure("Unexpected", "Pizza", 0.25F)
                };
                return true;
            }
            catch (Exception e)
            {
                Logger.Log(e);
                return false;
            }
        }
    }
}
