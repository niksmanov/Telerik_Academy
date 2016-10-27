using System.Text;

namespace Decorator.Models
{
    public class Mocha : DecoratorCoffee
    {
        public Mocha(Coffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 1.0;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + ", chocholate";
        }

        public override string Print()
        {
            var result = new StringBuilder();
            result.AppendLine("Mocha cost: " + GetCost());
            result.AppendLine("Mocha ingredients: " + GetIngredients());
            return result.ToString();
        }
    }
}
