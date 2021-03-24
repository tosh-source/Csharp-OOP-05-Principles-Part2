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
        //Properties
        public decimal Balance { get; set; }
        public int NumberOfMonths { get; private set; }
        public decimal Interest { get; private set; }
        public decimal InterestRate { get; private set; }

        //Customer properties
        public ICustomers Customer { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Loan()
        {
            this.Customer = new Individuals();  //Default customer is set to Individuals.
        }
        public Loan(ICustomers customerType)
        {
            this.Customer = customerType;
        }

        public void DepositMoney(decimal addAmount)
        {
            this.Balance += addAmount;
        }

        public decimal CalculateInterestRate(int numberOfMonths, decimal interestRate)
        {
            this.NumberOfMonths = numberOfMonths;
            this.InterestRate = interestRate;

            if (this.Customer.Type == CustomerType.Companies.ToString())
            {
                this.NumberOfMonths -= 2;

                if (this.NumberOfMonths <= 0)
                {
                    this.NumberOfMonths = 1;
                }

                this.Interest = this.NumberOfMonths * this.InterestRate;
            }
            else if (this.Customer.Type == CustomerType.Individuals.ToString())
            {
                this.NumberOfMonths -= 3;

                if (this.NumberOfMonths <= 0)
                {
                    this.NumberOfMonths = 1;
                }

                this.Interest = this.NumberOfMonths * this.InterestRate;
            }
            else
            {
                throw new AggregateException();
            }

            return this.Interest;
        }
    }
}
