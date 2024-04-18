using MySql.Data.MySqlClient;
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
        public Transaction(int accountNum,  string transactionType, double amount)
        {
            this.accountNum = accountNum;
            this.transactionType = transactionType;
            this.amount = amount;
        }

        //method to save the transaction to the DB
        public void saveTransaction(int accountNum, string type, string amount, int fromAccount, int toAccount)
        {
            MySqlConnection conn = new MySqlConnection("server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;");

            conn.Open();
            string sql = "INSERT INTO 834_morgan_transaction (accountNum, transactionType, amount, fromAccount, toAccount, date) VALUES " +
                "(@accNumber, @transType, @amount, @fromAccount, @toAccount, @date)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@accNumber", accountNum);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@transType", type);
            cmd.Parameters.AddWithValue("@fromAccount", fromAccount);
            cmd.Parameters.AddWithValue("@toAccount", toAccount);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
