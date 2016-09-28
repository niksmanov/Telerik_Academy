namespace BankAccounts.Bank
{
    using System;

    internal class Mortgage : Account
    {
        public Mortgage(Customer customer, double balance, double interestRate) :
            base(customer, balance, interestRate)
        {
        }

        public double DepositMoney(double moneyToDeposit)
        {
            return this.Balance += moneyToDeposit;
        }

        public override void CalculateInterestAmount(double numberOfMonths)
        {
            double interestAmount = 0;

            if (this.Customer == Customer.Companies && numberOfMonths <= 12)
            {
                interestAmount = numberOfMonths * (this.InterestRate / 2);
            }
            else if (this.Customer == Customer.Individuals && numberOfMonths <= 6)
            {
                interestAmount = 0;
            }
            else
            {
                interestAmount = numberOfMonths * this.InterestRate;
            }

            Console.WriteLine("Interest amount for {0} months for mortgage is {1}", numberOfMonths, interestAmount);
        }
    }
}
