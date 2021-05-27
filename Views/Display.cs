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
        public static void TotalIncome(float totalIncome)
        {
            DrawFrames.DisplayMenuNoNumbers(new List<string>
                $""
                )
        }

        public static void TotalExpenditure(float totalExpenses)
        {
            throw new NotImplementedException();
        }

        public static void Savings()
        {
            throw new NotImplementedException();
        }

        public static void MoneyLeft(float moneyLeft)
        {
            throw new NotImplementedException();
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
