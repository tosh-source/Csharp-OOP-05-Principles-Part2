using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankAccounts.Bank.Accounts
{
    interface IAccounts
    {
        decimal Balance { get; }
        string Customer { get; }
        int NumberOfMonths { get; }
        decimal Interest { get; }      //interest amount
        decimal InterestRate { get; }  //monthly based interest rate
        decimal CalculateInterestRate(int numberOfMonths, decimal interestRate);  //monthly based interest rate
    }
}
