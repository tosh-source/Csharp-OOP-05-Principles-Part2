using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankAccounts.Bank.Accounts
{
    class Deposit : IAccounts
    {
        public decimal Balance { get; set; }
        public string Customer { get; set; }
        public decimal InterestRate { get; set; }

        public void DepositMoney(decimal addAmount)
        {
            Balance += addAmount;
        }
        public void WithdrawMoney(decimal amountWithdraw)
        {
            if (Balance <= 0)
            {
                Console.WriteLine("No more money in deposit account! You need to add some amounts first!");
            }
            else
            {
                Balance -= amountWithdraw;
            }
        }

        public decimal CalculateInterestRate(int numberOfMonths, decimal interestRate)
        {
            throw new NotImplementedException();
        }
    }
}
