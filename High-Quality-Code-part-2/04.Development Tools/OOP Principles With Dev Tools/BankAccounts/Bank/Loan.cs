﻿namespace BankAccounts.Bank
{
    using System;

    internal class Loan : Account
    {
        public Loan(Customer customer, double balance, double interestRate) :
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

            if (this.Customer == Customer.Individuals)
            {
                interestAmount = (numberOfMonths - 3) * this.InterestRate;
            }
            else if (this.Customer == Customer.Companies)
            {
                interestAmount = (numberOfMonths - 2) * this.InterestRate;
            }

            Console.WriteLine("Interest amount for {0} months for loan is {1}", numberOfMonths, interestAmount);
        }
    }
}