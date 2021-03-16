using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankAccounts.Bank.Customers;

namespace _02_BankAccounts.Bank.Accounts
{
    class Loan : IAccounts
    {
        public decimal Balance { get; set; }
        public string Customer { get; set; }
        public int NumberOfMonths { get; private set; }
        public decimal Interest { get; private set; }
        public decimal InterestRate { get; private set; }

        public void DepositMoney(decimal addAmount)
        {
           this.Balance += addAmount;
        }

        public decimal CalculateInterestRate(int numberOfMonths, decimal interestRate)
        {
            this.NumberOfMonths = numberOfMonths;
            this.InterestRate = interestRate;

            if (this.Customer == CustomerType.Companies.ToString())
            {
                if (numberOfMonths > 2)
                {
                    this.Interest = 0;
                }
                else
                {
                    this.Interest = this.NumberOfMonths * this.InterestRate;
                }
            }
            else //this.Customer == CustomerType.Individuals.ToString()
            {
                if (numberOfMonths > 3)
                {
                    this.Interest = 0;
                }
                else
                {
                    this.Interest = this.NumberOfMonths * this.InterestRate;
                }
            }

            return this.Interest;
        }
    }
}
