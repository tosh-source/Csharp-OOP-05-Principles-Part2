using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankAccounts.Bank.Customers
{
    class Companies : ICustomers
    {
        private string name;
        private string type;

        string ICustomers.Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        string ICustomers.Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public Companies()
        {
            this.type = CustomerType.Companies.ToString();
        }
    }
}

