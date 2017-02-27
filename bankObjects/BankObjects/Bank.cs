using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class Bank
    {
        private string _bankname;
        private List<BankAccount> _accounts;

        public Bank(string bankName)
        {
            _bankname = bankName;
        }

        public string CreateNewAccount()
        {
            Random rnd = new Random();
            string accountNumber = "FI";
            for (int i = 0; i < 16; i++)
            {
                int newNumber = rnd.Next(10);
                accountNumber += newNumber;
            }
            BankAccount = new BankAccount(accountNumber);

            return accountNumber;
        }



    }
}
