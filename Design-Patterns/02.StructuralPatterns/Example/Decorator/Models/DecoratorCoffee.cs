using Decorator.Contracts;

namespace Decorator.Models
{
    public abstract class DecoratorCoffee : ICoffee
    {
        private readonly Coffee coffee;

        public DecoratorCoffee(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual double GetCost()
        {
            return coffee.GetCost();
        }

        public virtual string GetIngredients()
        {
            return coffee.GetIngredients();
        }

        public virtual string Print()
        {
            return coffee.Print();
        }
    }
}
