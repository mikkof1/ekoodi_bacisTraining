using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class BankAccount
    {
        private string _accountNumber;
        private List<AccountActivity> _accountActivityList;
        private double _money;

        public BankAccount(string accountNumber)
        {
            _accountNumber = accountNumber;
            StartNewAccountActivity();
        }

        public List<AccountActivity> AccountActivityList
        {
            get { return _accountActivityList; }
        }

        public double Money
        {
            get { return _money; }
        }

        public string GetActivityListString()
        {
            string returnValue = "";

            int activityIndex = 0;
            foreach (AccountActivity activity in _accountActivityList)
            {
                returnValue += activity.TimeStamp + " : " + activity.MoneyTransfer;

                activityIndex++;
                bool addNextLine = activityIndex < _accountActivityList.Count;
                if (addNextLine)
                {
                    returnValue += "\r\n";
                }
            }
            return returnValue;
        }

        public string GetActivityListString(DateTime starDateTime, DateTime endDate)
        {
            string returnValue = "";

            int activityIndex = 0;
            foreach (AccountActivity activity in _accountActivityList)
            {
                bool timePeriodActivity = activity.TimeStamp >= starDateTime && activity.TimeStamp < endDate;
                if (timePeriodActivity)
                {
                    returnValue += activity.TimeStamp + " : " + activity.MoneyTransfer;
                }

                activityIndex++;
                bool addNextLine = activityIndex < _accountActivityList.Count;
                if (addNextLine)
                {
                    returnValue += "\r\n";
                }
            }
            return returnValue;
        }
        

        public void AddMoneyActivity(double money)
        {
            _money = _money + money;

            string activityString = "(+)" + money;
            AccountActivity activity = new AccountActivity(activityString);
            _accountActivityList.Add(activity);

        }


        public void TakeMoneyActivity(double money)
        {
            _money = _money - money;

            string activityString = "(-)" + money;
            AccountActivity activity = new AccountActivity(activityString);
            _accountActivityList.Add(activity);

        }


        private void StartNewAccountActivity()
        {
            _money = 0;
            _accountActivityList = new List<AccountActivity>();

            string activityString = "-- Start new account --";
            AccountActivity activity = new AccountActivity(activityString);
            _accountActivityList.Add(activity);
        }


    }
}
