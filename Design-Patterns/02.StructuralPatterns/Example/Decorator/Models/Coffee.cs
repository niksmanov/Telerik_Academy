using Decorator.Contracts;
using System;
using System.Text;

namespace Decorator.Models
{
    public class Coffee : ICoffee
    {
        public double GetCost()
        {
            return 1.20;
        }

        public string GetIngredients()
        {
            return "coffe, sugar";
        }

        public string Print()
        {
            var result = new StringBuilder();
            result.AppendLine("Coffee cost: " + GetCost());
            result.AppendLine("Coffee ingredients: " + GetIngredients());
            return result.ToString();
        }
    }
}
