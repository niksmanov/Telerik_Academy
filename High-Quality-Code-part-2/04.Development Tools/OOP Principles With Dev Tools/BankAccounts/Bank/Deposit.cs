namespace BankAccounts.Bank
{
    using System;

    internal class Deposit : Account
    {
        public Deposit(Customer customer, double balance, double interestRate) :
            base(customer, balance, interestRate)
        {
        }

        public double DepositMoney(double moneyToDeposit)
        {
            return this.Balance += moneyToDeposit;
        }

        public double WithDrawMoney(double moneyToWithDraw)
        {
            return this.Balance -= moneyToWithDraw;
        }

        public override void CalculateInterestAmount(double numberOfMonths)
        {
            double interestAmount = 0;

            if (this.Balance > 0 && this.Balance < 1000)
            {
                this.InterestRate = 0;
            }
            else
            {
                interestAmount = numberOfMonths * this.InterestRate;
            }

            Console.WriteLine("Interest amount for {0} months for deposit is {1}", numberOfMonths, interestAmount);
        }
    }
}
