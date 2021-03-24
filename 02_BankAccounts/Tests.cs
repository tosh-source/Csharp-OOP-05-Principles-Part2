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
            //I.Add individual bank client.
            BankProducts johnsAccounts = new BankProducts();

            //Try to withdraw money from empty deposit account.
            johnsAccounts.Deposit.WithdrawMoney(246);
            //You can not get money from an empty account! So for that reason you need to use correct method "Deposit.DepositMoney()".
            
            //Deposit some money
            johnsAccounts.Deposit.DepositMoney(246);
            Console.WriteLine("Deposit balance: " + johnsAccounts.Deposit.Balance);

            johnsAccounts.Deposit.Customer.Type = CustomerType.Individuals.ToString();
            johnsAccounts.Deposit.Customer.Name = "John Johns";

            //II.Add company bank client
            var company = new Companies();
            BankProducts companyAccount = new BankProducts(company);

            //Deposit some money
            companyAccount.Deposit.DepositMoney(2500);
            companyAccount.Mortgage.DepositMoney(6000);
            companyAccount.Loan.DepositMoney(300);

            //Calculate interest rate for company's mortgage account.
            companyAccount.Mortgage.CalculateInterestRate(12, 6);
            Console.WriteLine("Company mortgage interest: " + companyAccount.Mortgage.Interest);

            //Calculate interest rate for company's loan account.
            companyAccount.Loan.CalculateInterestRate(3, 8);
            Console.WriteLine("Company loan account interest: " + companyAccount.Loan.Interest);
        }
    }
}
