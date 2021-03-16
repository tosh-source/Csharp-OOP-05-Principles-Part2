using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankAccounts.Bank.Customers
{
    class Companies : ICustomers
    {
        public string Name { get; set; }
        public string Type { get => CustomerType.Companies.ToString(); }
    }
}
