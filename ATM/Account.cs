using System;
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
        public Account(int accountNum, double dailyDepositAmount, double balance, double dailyTransactionLimit, double dailyTransactionTotal, string dailyTransactionDate)
        {
            this.accountNum = accountNum;
            this.dailyDepositAmount = dailyDepositAmount;
            this.balance = balance;
            this.dailyTransactionLimit = dailyTransactionLimit;
            this.dailyTransactionTotal = dailyTransactionTotal;
            this.dailyTransactionDate = dailyTransactionDate;
        }

        //method to update the DB
        public void updateDb(double newBalance, double transTotal, int accountNumber)
        {
            MySqlConnection conn = new MySqlConnection("server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;");

            conn.Open();
            string sql = "UPDATE 834_morgan_account SET balance=@balance, dailyTransactionTotal=@transTotal, dailyTransactionDate=@transDate WHERE accountNum=@accNumber";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@balance", newBalance);
            cmd.Parameters.AddWithValue("@transTotal", transTotal);
            cmd.Parameters.AddWithValue("@transDate", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@accNumber", accountNumber);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
