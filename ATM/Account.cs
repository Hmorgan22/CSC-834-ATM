﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ATM
{
    public class Account
    {
        public string dailyTransactionDate { get; set; } 
        public double dailyTransactionTotal { get; set; }
        public double dailyTransactionLimit { get; set; }
        public double balance { get; set; }
        public double dailyDepositAmount { get; set; }
        public int accountNum { get; set; }
        public int customerId { get; set; }

        //constructor
        public Account(int accountNum, double dailyDepositAmount,  double balance, double dailyTransactionLimit, double dailyTransactionTotal, string dailyTransactionDate)
        {
            this.accountNum = accountNum;
            this.dailyDepositAmount = dailyDepositAmount;
            this.balance = balance;
            this.dailyTransactionLimit = dailyTransactionLimit;
            this.dailyTransactionTotal = dailyTransactionTotal;
            this.dailyTransactionDate = dailyTransactionDate;
        }

        //method to get the balance
        public void getBalance()
        {

        }
    }
}
