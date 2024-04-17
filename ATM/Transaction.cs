using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Transaction
    {
        public int accountNum { get; set; }
        public int transactionNum { get; set; }
        public string transactionType { get; set; }
        public double amount { get; set; }
        public int fromAccount { get; set; }
        public int toAccount { get; set; }
        public DateTime date { get; set; }

        //constructor
        public Transaction(int accountNum, int transactionNum, string transactionType, double amount, DateTime date)
        {
            this.accountNum = accountNum;
            this.transactionNum = transactionNum;
            this.transactionType = transactionType;
            this.amount = amount;
            this.date = date;
        }
    }
}
