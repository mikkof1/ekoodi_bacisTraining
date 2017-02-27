using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class Bank
    {
        private string _name;
        private string[] _accounts;

        public Bank()
        {
        }

        public string CreateNewAccount()
        {     Random rnd = new Random();
            string accountNumber = "FI";
            for (int i = 0; i < 16; i++)
            {
           
                int newNumber = rnd.Next(10);
                accountNumber += newNumber;
            }

            return accountNumber;
        }

    }
}
