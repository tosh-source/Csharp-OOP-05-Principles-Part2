using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankAccounts.Bank.Customers;

namespace _02_BankAccounts.Bank.Accounts
{
    class Mortgage : IAccounts
    {
        public decimal Balance { get; set; }
        public string Customer { get; set; }
        public int NumberOfMonths { get; private set; }
        public decimal Interest { get; private set; }
        public decimal InterestRate { get; private set; }

        public void DepositMoney(decimal addAmount)
        {
            Balance += addAmount;
        }

        public decimal CalculateInterestRate(int numberOfMonths, decimal interestRate)
        {
            this.NumberOfMonths = numberOfMonths;
            this.InterestRate = interestRate;

            if (this.Customer == CustomerType.Companies.ToString())
            {
                if (this.NumberOfMonths <= 12)
                {
                    this.Interest = (this.NumberOfMonths * this.InterestRate) / 2;
                }
                else
                {
                    this.Interest = this.NumberOfMonths * this.InterestRate;
                }
            }
            else  //this.Customer == CustomerType.Individuals.ToString()
            {
                if (this.NumberOfMonths <= 6)
                {
                    this.Interest = (this.NumberOfMonths * this.InterestRate) / 2;
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
