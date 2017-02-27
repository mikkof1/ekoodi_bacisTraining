﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    public class Client
    {
        private string _firstName;
        private string _lastName;
        private string _accountNumber;

        public Client()
        {
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        
        public override string ToString()
        {
            return "Name: " + _firstName + " " + _lastName + " AccountNumber: " + _accountNumber ;
        }
    }
}
