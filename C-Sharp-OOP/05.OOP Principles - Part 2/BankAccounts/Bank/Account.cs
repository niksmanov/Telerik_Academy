using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Bank
{
    internal class Account
    {
        private Customer customer;
        private double balance;
        private double interestRate;

        public Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
                this.customer = value;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }


        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                this.interestRate = value;
            }
        }

        public virtual void CalculateInterestAmount(double numberOfMonths)
        {
            double interestAmount = numberOfMonths * this.InterestRate;
            Console.WriteLine("Interest amount for {0} months is {1}", numberOfMonths, interestAmount);
        }

    }
}
