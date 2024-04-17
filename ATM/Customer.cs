using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int pin { get; set; }
        public int accountNum { get; set; }

        //constructor
        public Customer(int customerId, string firstName, string lastName)
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
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
        public void verifyPin()
        {

        }
    }
        
}
