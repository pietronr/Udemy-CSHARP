﻿using System;
using Exercicio.Entities.Exceptions;

namespace Exercicio.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account (int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(Balance == 0)
            {
                throw new DomainException("There is no balance in this account!");
            }
            if(Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else
            {
                Balance -= amount;
            }
            
        }
    }
}
