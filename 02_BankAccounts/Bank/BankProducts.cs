﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankAccounts.Bank.Accounts;
using _02_BankAccounts.Bank.Customers;

namespace _02_BankAccounts.Bank
{
    class BankProducts
    {
        private Deposit deposit;
        private Loan loan;
        private Mortgage mortgage;

        public Deposit Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }

        public Loan Loan
        {
            get { return loan; }
            set { loan = value; }
        }

        public Mortgage Mortgage
        {
            get { return mortgage; }
            set { mortgage = value; }
        }

        public BankProducts()  //Default customer is set to Individuals. 
        {
            this.Deposit = new Deposit();
            this.Loan = new Loan();
            this.Mortgage = new Mortgage();
        }
        public BankProducts(ICustomers customerType)  //Customers can be: Companies/Individuals
        {
            this.Deposit = new Deposit(customerType);
            this.Loan = new Loan(customerType);
            this.Mortgage = new Mortgage(customerType);
        }
    }
}
