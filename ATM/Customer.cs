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
        public void getAccounts(int customerId)
        {

        }

        //method to withdraw money
        public void withdrawlMoney()
        {

        }

        //method to depoist money
        public void depositMoney()
        {

        }

        //method to trasnfer money
        public void transferMoney()
        {

        }

        //method to check the users account balance
        public void checkBalance()
        {

        }

        //method to logout of the system
        public void logout()
        {

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
