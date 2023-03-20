﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        private double _balance = 0;

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Current Account Balance:");
            Console.WriteLine($"${_balance}");
        }
    }
}
