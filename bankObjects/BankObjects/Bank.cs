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
        private List<BankAccount> _bankAccountsList;
        private List<Client> _clientList;

        public Bank(string bankName)
        {
            _bankname = bankName;
            _bankAccountsList = new List<BankAccount>();
            _clientList = new List<Client>();
        }

        public string CreateNewAccount(string firstName, string lastName)
        {
            string accountNumber = MakeRandomAccountNumber();

            BankAccount newBankAccount = new BankAccount(accountNumber);
            _bankAccountsList.Add(newBankAccount);

            Client newClient = new Client(firstName, lastName, accountNumber);
            _clientList.Add(newClient);

            return accountNumber;
        }


        public string GetClientAccountActivitys(string accountNumber)
        {
            BankAccount clientAccount = GetClientBankAccount(accountNumber);
            if (clientAccount == null)
                return "Wrong account number";
            return clientAccount.GetActivityListString();
        }

        public string GetClientAccountActivitys(string accountNumber, DateTime startDate, DateTime endDate)
        {
            BankAccount clientAccount = GetClientBankAccount(accountNumber);
            if (clientAccount == null)
                return "Wrong account number";

            return clientAccount.GetActivityListString(startDate, endDate);
        }


        public double GetClientMoney(string accountNumber)
        {
            BankAccount clientAccount = GetClientBankAccount(accountNumber);
            if (clientAccount == null)
                return 0;

            return clientAccount.Money;
        }

        public bool AddClientMoney(string accountNumber, double money)
        {
            BankAccount clientAccount = GetClientBankAccount(accountNumber);
            if (clientAccount == null)
                return false;

            clientAccount.AddMoneyActivity(money);

            return true;
        }

        public bool TakeClientMoney(string accountNumber, double money)
        {
            BankAccount clientAccount = GetClientBankAccount(accountNumber);
            if (clientAccount == null)
                return false;

            clientAccount.TakeMoneyActivity(money);

            return true;
        }

        public string PrintAllClientDetalies()
        {
            string returnValue = "";

            int clientIndex = 0;
            foreach (Client client in _clientList)
            {
                BankAccount clientBankAccount = GetClientBankAccount(client.AccountNumber);
                returnValue += client.ToString() + " : " + clientBankAccount.Money+"€";
                clientIndex++;
                if (clientIndex < _clientList.Count)
                {
                    returnValue += "\r\n";
                }
            }

            return returnValue;
        }

        
        private string MakeRandomAccountNumber()
        {
            Random rnd = new Random();
            string accountNumber = "FI";
            for (int i = 0; i < 16; i++)
            {
                int newNumber = rnd.Next(10);
                accountNumber += newNumber;
            }
            return accountNumber;
        }

        private BankAccount GetClientBankAccount(string accountNumber)
        {

            foreach (BankAccount account in _bankAccountsList)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return account;
                }
            }
            return null;
        }



    }
}
