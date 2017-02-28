﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankObjects
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Bank bank = new Bank("Pankki");

            List<Client> clientList = new List<Client>
            {
                new Client("Nakke", "Nakuttaja"),
                new Client("Jaska", "Jokunen"),
                new Client("Aku", "Ankka")
            };

            MakeTestAccountNumbers(clientList,bank);

            MakeTestActivities(clientList, bank);

            foreach (Client client in clientList)
            {
                double money = bank.GetClientMoney(client.AccountNumber);
                PrintActivitys(client, bank.GetClientActivitys(client.AccountNumber), money);
            }
            
            Console.ReadKey();

        }


        static void MakeTestAccountNumbers(List<Client> clientList, Bank bank)
        {
            foreach (Client client in clientList)
            {
                client.AccountNumber = bank.CreateNewAccount(client.FirstName, client.LastName);
            }
        }

        static void MakeTestActivities(List<Client> clientList, Bank bank)
        {
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                int year = rnd.Next(1900, 2018);
                int month = rnd.Next(1, 12);
                int day = rnd.Next(1, 28);
                double money = rnd.Next(-1000, 1000);
                int clientIndex = rnd.Next(clientList.Count);

                bank.ClientMoneyTransfer(clientList[clientIndex].AccountNumber, money, new DateTime(year, month, day));
            }

        }

        static void PrintActivitys(Client client, List<AccountActivity> activityList, double money)
        {
            Console.WriteLine(client+ "\r\n");
            foreach (AccountActivity activity in activityList)
            {
                Console.WriteLine(activity);
            }
            Console.WriteLine("\r\nMoney: " + money);
            Console.WriteLine("------------------------------------\r\n\r\n");
        }

    }
}
