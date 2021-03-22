using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankAccounts.Bank.Customers;

namespace _02_BankAccounts.Bank.Accounts
{
    class Deposit : IAccounts
    {
        //Properties
        public decimal Balance { get; set; }
        public int NumberOfMonths { get; private set; }
        public decimal Interest { get; private set; }
        public decimal InterestRate { get; private set; }

        //Customer properties
        public ICustomers Customer { get; set; }
        public string Name { get ; set ; }
        public string Type { get ; set ; }

        public Deposit()
        {
            this.Customer = new Individuals(); //Default customer is set to Individuals. 
        }
        public Deposit(ICustomers customerType)
        {
            this.Customer = customerType;
        }

        public void DepositMoney(decimal addAmount)
        {
            this.Balance += addAmount;
        }

        public void WithdrawMoney(decimal amountWithdraw)
        {
            if ((this.Balance - amountWithdraw) <= 0)
            {
                Console.WriteLine("No more money in deposit account! You need to add some amounts first!");
            }
            else
            {
                this.Balance -= amountWithdraw;
            }
        }

        public decimal CalculateInterestRate(int numberOfMonths, decimal interestRate)
        {
            this.NumberOfMonths = numberOfMonths;
            this.InterestRate = interestRate;

            if (this.Balance > 0 && this.Balance < 1000)
            {
                this.Interest = 0;
            }
            else
            {
                this.Interest = this.NumberOfMonths * this.InterestRate;
            }

            return this.Interest;
        }
    }
}
