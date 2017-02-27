using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    public class AccountActivity
    {
        private DateTime _timeStamp;
        private string _moneyTransfer;

        public AccountActivity( string moneyTransfer)
        {
            _timeStamp = DateTime.Now; 
            _moneyTransfer = moneyTransfer;
        }

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
        }

        public string MoneyTransfer
        {
            get { return _moneyTransfer; }
        }

    }
}
