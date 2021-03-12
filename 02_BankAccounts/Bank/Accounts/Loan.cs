using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankAccounts.Bank.Accounts
{
    class Loan : IAccounts
    {
        public decimal Balance { get; set; }
        public string Customer { get; set; }
        public decimal InterestRate { get; set; }

        public void DepositMoney(decimal addAmount)
        {
            Balance += addAmount;
        }

        public decimal CalculateInterestRate(int numberOfMonths, decimal interestRate)
        {
            throw new NotImplementedException();
        }
    }
}
