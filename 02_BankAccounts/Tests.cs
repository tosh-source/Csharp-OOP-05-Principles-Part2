using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankAccounts.Bank;
using _02_BankAccounts.Bank.Customers;

namespace _02_BankAccounts
{
    class Tests
    {
        static void Main(string[] args)
        {
            BankProducts johnsAccounts = new BankProducts();

            //Deposit some money
            johnsAccounts.Deposit.WithdrawMoney(246);
            //You can not get money from an empty account! So for that reason you need to use correct method "Deposit.DepositMoney()".
            johnsAccounts.Deposit.DepositMoney(246);
            Console.WriteLine("Deposit balance: " + johnsAccounts.Deposit.Balance);

            johnsAccounts.Deposit.Customer.Type = CustomerType.Individuals.ToString();
            johnsAccounts.Deposit.Customer.Name = "John Johns";


        }
    }
}
