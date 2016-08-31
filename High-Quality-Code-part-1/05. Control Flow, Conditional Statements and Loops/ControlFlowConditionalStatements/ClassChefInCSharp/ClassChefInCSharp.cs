namespace ControlFlowConditionalStatementsLoops
{
    using System;
    using Contracts;

    internal class Chef
    {
        public void Cook()
        {
            var potato = this.GetPotato();
            var carrot = this.GetCarrot();
            var bowl = this.GetBowl();

            var peelPotato = this.Peel(potato);
            var peelCarrot = this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private IPotato GetPotato()
        {
            throw new NotImplementedException();
        }

        private ICarrot GetCarrot()
        {
            throw new NotImplementedException();
        }

        private IVegetable Cut(IVegetable potato)
        {
            throw new NotImplementedException();
        }

        private IVegetable Peel(IVegetable vegetable)
        {
            throw new NotImplementedException();
        }

        private IBowl GetBowl()
        {
            throw new NotImplementedException();
        }
    }
}
