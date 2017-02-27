using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            for (int i = 0; i < 30; i++)
            {
                string newAccount = bank.CreateNewAccount();
            }

        }
    }
}
