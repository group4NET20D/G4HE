using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G4HE.Views.Print;

namespace G4HE.Views
{
    public class Display
    {

        public static void ShowResult(float totalIncome, float totalExpenditure, float savings, float moneyLeft)
        {
            Console.Clear();
            TotalIncome(totalIncome);
            TotalExpenditure(totalExpenditure);
            Savings(savings);
            MoneyLeft(moneyLeft);

        }

        public static void TotalIncome(float totalIncome)
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"The total of your income is: {totalIncome}"
            });
        }

        public static void TotalExpenditure(float totalExpenses)
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"The total of your expenses is: {totalExpenses}"
            });
        }

        public static void Savings(float savings)
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"The total of your savings is: {savings}"
            });
        }

        public static void MoneyLeft(float moneyLeft)
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"The amount of money you have left: {moneyLeft}"
            });
        }

        public static void GiveExampleOf(string type, string name, string tag, float amount)
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
            {
                $"To enter your {type} you",
                "will need to provide:",
                "Examples:",
                $"Name: \"{name}\"",
                $"Tag: \"{tag}\"",
                $"Amount: \"{amount}\"\n"
            });
        }

    }
}
