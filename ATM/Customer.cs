using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int pin { get; set; }
        public int accountNum { get; set; }

        //constructor
        public Customer(int customerId)
        {
            this.customerId = customerId;
        }

        //method to get a list of the users accounts
        public List<Account> getAccounts(int customerId)
        {
            MySqlConnection conn = new MySqlConnection("server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;");
            List<Account> tempList = new List<Account>();

            //gets the info using customer id
            conn.Open();
            string sql = "SELECT accountNum, dailyDepositAmount, balance, dailyTransactionLimit, dailyTransactionTotal, dailyTransactionDate FROM 834_morgan_account WHERE customerId=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //creates list of accounts
            cmd.Parameters.AddWithValue("@id", customerId);
            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                tempList.Add(new Account(Int32.Parse(myReader["accountNum"].ToString()),
                    Int32.Parse(myReader["dailyDepositAmount"].ToString()),
                    Int32.Parse(myReader["balance"].ToString()),
                    Int32.Parse(myReader["dailyTransactionLimit"].ToString()),
                    Int32.Parse(myReader["dailyTransactionTotal"].ToString()),
                    myReader["dailyTransactionDate"].ToString()));

            }
            myReader.Close();
            conn.Close();

            return tempList;
        }

        //method to verify the users pin
        public int verifyPin(string customerPin)
        {
            //set up connection to DB
            MySqlConnection conn = new MySqlConnection("server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;");
            int tempId = 0;

            //opens connections and reads all customers from the DB
            conn.Open();
            string sql = "SELECT * FROM 834_morgan_customer";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader myReader = cmd.ExecuteReader();
            //checks DB for a customer with the pin that was entered
            while (myReader.Read())
            {
                //if a match is found, update the customer Id
                if (myReader["pin"].ToString().Equals(customerPin))
                {
                    tempId = Int32.Parse(myReader["customerId"].ToString());
                }
            }
            myReader.Close();
            conn.Close();

            return tempId;
        }
    }
        
}
