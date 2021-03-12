using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankAccounts.Bank.Accounts
{
    interface IAccounts
    {
        decimal Balance { get; set; }
        string Customer { get; set; }
        decimal InterestRate { get; set; }  //monthly based interest rate
        decimal CalculateInterestRate(int numberOfMonths, decimal interestRate);  //monthly based interest rate
    }
}
