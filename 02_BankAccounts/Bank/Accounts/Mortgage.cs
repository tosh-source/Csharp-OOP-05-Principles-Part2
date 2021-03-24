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
        //Properties
        public decimal Balance { get; set; }
        public int NumberOfMonths { get; private set; }
        public decimal Interest { get; private set; }
        public decimal InterestRate { get; private set; }

        //Customer properties
        public ICustomers Customer { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Mortgage()
        {
            this.Customer = new Individuals();  //Default customer is set to Individuals.
        }
        public Mortgage(ICustomers customerType)
        {
            this.Customer = customerType;
        }

        public void DepositMoney(decimal addAmount)
        {
            Balance += addAmount;
        }

        public decimal CalculateInterestRate(int numberOfMonths, decimal interestRate)
        {
            this.NumberOfMonths = numberOfMonths;
            this.InterestRate = interestRate;
            int discount = 0; //for first 'N' months

            if (this.Customer.Type == CustomerType.Companies.ToString())
            {
                discount = 12; //Mortgage accounts have ½ interest for the first `12` months for companies

                if (this.NumberOfMonths <= discount)
                {
                    this.Interest = (this.NumberOfMonths * this.InterestRate) / 2;
                }
                else if (this.NumberOfMonths > discount)
                {
                    this.Interest = (discount * this.InterestRate) / 2;
                    this.Interest += (this.NumberOfMonths - discount) * this.InterestRate;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            else if (this.Customer.Type == CustomerType.Individuals.ToString())
            {
                discount = 6;  //Mortgage accounts have NO interest for the first `6` months for individuals.

                if (this.NumberOfMonths <= discount)
                {
                    this.Interest = 0;
                }
                else if (this.NumberOfMonths > discount)
                {
                    this.Interest += (this.NumberOfMonths - discount) * this.InterestRate;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                throw new ArgumentException();
            }

            return this.Interest;
        }
    }
}
