using BankAccounts.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal class BankStartUp
    {
        internal static void Main()
        {
            var firstLoan = new Loan(Customer.Companies, 1200, 6);
            firstLoan.CalculateInterestAmount(12);
            firstLoan.DepositMoney(200);
            Console.WriteLine("Current balance is " + firstLoan.Balance);


            var secondLoan = new Loan(Customer.Individuals, 1200, 6);
            secondLoan.CalculateInterestAmount(12);

            var firstDeposit = new Deposit(Customer.Companies, 800, 6);
            firstDeposit.CalculateInterestAmount(12);
            firstDeposit.WithDrawMoney(150);
            Console.WriteLine("Current balance is " + firstDeposit.Balance);

            var secondDeposit = new Deposit(Customer.Individuals, 1200, 6);
            secondDeposit.CalculateInterestAmount(12);
            secondDeposit.DepositMoney(800);
            Console.WriteLine("Current balance is " + secondDeposit.Balance);


            var firstMortgage = new Mortgage(Customer.Companies, 1200, 6);
            firstMortgage.CalculateInterestAmount(12);

            var secondMortgage = new Mortgage(Customer.Individuals, 1200, 6);
            secondMortgage.CalculateInterestAmount(12);
            secondMortgage.DepositMoney(350);
            Console.WriteLine("Current balance is " + secondMortgage.Balance);

        }
    }
}
