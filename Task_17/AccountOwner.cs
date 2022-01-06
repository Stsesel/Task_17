using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class AccountOwner<T>
    {
        public T AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public string Name { get; set; }

        public AccountOwner (T accountNumber, double accountBalance, string name)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            Name = name;
        }

        public string GetInfo()
        {
            return $"{ AccountNumber } { AccountBalance } { Name }";

        }
    }
}
