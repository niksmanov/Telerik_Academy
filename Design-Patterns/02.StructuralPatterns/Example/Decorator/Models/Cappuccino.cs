using System.Text;

namespace Decorator.Models
{
    public class Cappuccino : DecoratorCoffee
    {
        public Cappuccino(Coffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + ", milk";
        }

        public override string Print()
        {
            var result = new StringBuilder();
            result.AppendLine("Cappuccino cost: " + GetCost());
            result.AppendLine("Cappuccino ingredients: " + GetIngredients());
            return result.ToString();
        }

    }
}
