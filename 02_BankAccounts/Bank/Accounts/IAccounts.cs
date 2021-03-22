using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankAccounts.Bank.Customers;

namespace _02_BankAccounts.Bank.Accounts
{
    interface IAccounts : ICustomers
    {
        decimal Balance { get; }
        ICustomers Customer { get; }
        int NumberOfMonths { get; }
        decimal Interest { get; }      //interest amount
        decimal InterestRate { get; }  //monthly based interest rate
        decimal CalculateInterestRate(int numberOfMonths, decimal interestRate);  //monthly based interest rate
    }
}
