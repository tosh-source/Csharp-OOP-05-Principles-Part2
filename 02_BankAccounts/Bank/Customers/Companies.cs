using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankAccounts.Bank.Customers
{
    class Companies : ICustomers
    {
        string ICustomers.Name { get; set; }
        string ICustomers.Type { get; set; }
    }
}

