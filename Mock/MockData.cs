﻿using G4privateEconomyClassLibrary.EconomyPlanner;
using G4privateEconomyClassLibrary.EconomyPlanner.Models;
using System;
using System.Collections.Generic;
using G4privateEconomyClassLibrary.Interfaces;

namespace G4HE.Mock
{
    public class NewMock
    {
        public bool MockIncome()
        {
            try
            {
                //var budget = new BudgetCalculation();
                List<IIncome> income = new()
                {
                    new Income("Salary", "Fixed", 14500F)
                };

                BudgetCalculation._Income.AddRange(income);
                //BudgetCalculation.Income.AddRange(income);

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
                List<IExpenditure> expenditure = new()
                {
                    new Expenditure("Rent", "Fixed", 8900),
                    new Expenditure("Netflix", "Fixed", 89),
                    new Expenditure("Mobile", "Fixed", 99),
                    new Expenditure("Broadband", "Fixed", 199),
                    new Expenditure("Food", "Fixed", 1200),
                    new Expenditure("Consumables", "Fixed", 600),
                    new Expenditure("Bank cost", "Fixed", 45),
                    new Expenditure("Pensions", "Fixed", 1000),
                    new Expenditure("Gym", "Fixed", 350),
                    new Expenditure("Home insurance", "Fixed", 75),
                    new Expenditure("Saving", "Saving", 0.1F),
                    new Expenditure("Pizza", "Unexpected", 0.25F)
                };
                BudgetCalculation._Expenditures.AddRange(expenditure);
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
