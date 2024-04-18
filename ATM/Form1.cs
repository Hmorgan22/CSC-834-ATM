using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        //declare variables
        List<Account> accountList = new List<Account>();
        Customer customer = new Customer(0);
        string transactionAmount = "";
        string customerPin = "";

        MySqlConnection conn = new MySqlConnection("server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;");

        public Form1()
        {
            InitializeComponent();
            //set all panels to hidden except the login screen
            transferFromAccountListPanel.Visible = false;
            transferToAccountListPanel.Visible = false;
            withdrawalAccountSelectionPanel.Visible = false;
            depositPanel.Visible = false;
            checkBalanceAccountListPanel.Visible = false;
            limitErrorPanel.Visible = false;
            checkBalancePanel.Visible = false;
            overWithdrawErrorPanel.Visible = false;
            loginPinEorrorPanel.Visible = false;
            withdrawalPanel.Visible = false;
            transferAmountPanel.Visible = false;
            depositAmountPanel.Visible = false;
            mainMenuPanel.Visible = false;
            atmCashAmountErrorPanel.Visible = false;
        }

        //Logout Button
        private void button1_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            loginPanel.Visible = true;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        //method to check the balance of the account
        private void button3_Click(object sender, EventArgs e)
        {
            //change the screens
            mainMenuPanel.Visible = false;
            checkBalanceAccountListPanel.Visible = true;
            accountList.Clear();

            //gets a list of accounts for this customer
            accountList = customer.getAccounts(customer.customerId);

            //displays accounts on screen
            checkBalanceAccountListBox.Items.Clear();
            foreach(Account acc in accountList)
            {
                if (!checkBalanceAccountListBox.Items.Contains(acc))
                {
                    checkBalanceAccountListBox.Items.Add(acc.accountNum);
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void withdrawalAccountSelectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBalanceAccountNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //login screen
        private void loginEnterBtn_Click(object sender, EventArgs e)
        {
            //checks the DB to see if the pin is valid and set the customer Id  to the customer that  has that pin
            customer.customerId = customer.verifyPin(loginTextBox.Text);

            //if the pin is not 0 then the pin was valid
            if (customer.customerId != 0)
            {
                loginPanel.Visible = false;
                mainMenuPanel.Visible = true;
            }
            else
            {
                loginPanel.Visible = false;
                loginPinEorrorPanel.Visible = true;
            }

            //reset pin and login text
            loginTextBox.Text = "";
            customerPin = "";
        }

        //hides the invlaid pin error message
        private void loginPinErrorMessageBtn_Click(object sender, EventArgs e)
        {
            loginPinEorrorPanel.Visible = false;
            loginPanel.Visible = true;
        }
        //-----------------------------------------------------------------This section is for Login screen buttons-------------------------------------
        private void login1Btn_Click(object sender, EventArgs e)
        {
            customerPin += "1";
            loginTextBox.Text = customerPin;
        }

        private void login2Btn_Click(object sender, EventArgs e)
        {
            customerPin += "2";
            loginTextBox.Text = customerPin;
        }

        private void login3Btn_Click(object sender, EventArgs e)
        {
            customerPin += "3";
            loginTextBox.Text = customerPin;
        }

        private void login4Btn_Click(object sender, EventArgs e)
        {
            customerPin += "4";
            loginTextBox.Text = customerPin;
        }

        private void login5Btn_Click(object sender, EventArgs e)
        {
            customerPin += "5";
            loginTextBox.Text = customerPin;
        }

        private void login6Btn_Click(object sender, EventArgs e)
        {
            customerPin += "6";
            loginTextBox.Text = customerPin;
        }

        private void login7Btn_Click(object sender, EventArgs e)
        {
            customerPin += "7";
            loginTextBox.Text = customerPin;
        }

        private void login8Btn_Click(object sender, EventArgs e)
        {
            customerPin += "8";
            loginTextBox.Text = customerPin;
        }

        private void login9Btn_Click(object sender, EventArgs e)
        {
            customerPin += "9";
            loginTextBox.Text = customerPin;
        }

        private void login0Btn_Click(object sender, EventArgs e)
        {
            customerPin += "0";
            loginTextBox.Text = customerPin;
        }

        private void loginClrBtn_Click(object sender, EventArgs e)
        {
            customerPin = "";
            loginTextBox.Text = customerPin;
        }

        private void loginEraseBtn_Click(object sender, EventArgs e)
        {
            if (customerPin.Length >= 1) {
                customerPin = customerPin.Remove(customerPin.Length - 1);
                loginTextBox.Text = customerPin;
            }
           
        }
        //---------------------------------------------------------------------Login screen buttons end-------------------------------------------------
        private void checkBalanceAccountReturnBtn_Click(object sender, EventArgs e)
        {
            checkBalanceAccountListPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        //check balance list seclection
        private void checkBalanceAccountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                checkBalanceAccountListPanel.Visible = false;
                checkBalancePanel.Visible = true;

                //displays text based on the selected account
                checkBalanceAccountBalanceTextBox.Text = $"${accountList.ElementAt(checkBalanceAccountListBox.SelectedIndex).balance}";
                checkBalanceAccountNumberTextBox.Text = $"{accountList.ElementAt(checkBalanceAccountListBox.SelectedIndex).accountNum}";
            }
            catch (Exception ex)
            {
                checkBalanceAccountListPanel.Visible = false;
                checkBalancePanel.Visible = false;
                mainMenuPanel.Visible = true;
            }
        }

        //check balance return button
        private void checkBalanceReturnBtn_Click(object sender, EventArgs e)
        {
            checkBalancePanel.Visible = false;
            checkBalanceAccountListPanel.Visible = true;
        }

        //deposit money method
        private void depositBtn_Click(object sender, EventArgs e)
        {
            //show screens
            mainMenuPanel.Visible = false;
            depositPanel.Visible = true;
            transactionAmount = "";
            accountList.Clear();

            //gets a list of accounts for this customer
            accountList = customer.getAccounts(customer.customerId);

            //displays accounts on screen
            depositAccountList.Items.Clear();
            foreach (Account acc in accountList)
            {
                if (!depositAccountList.Items.Contains(acc))
                {
                    depositAccountList.Items.Add(acc.accountNum);
                }
            }
        }

        //deposit money selection
        private void depositAccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //check if the account is below 3000 daily limit
                if (accountList.ElementAt(depositAccountList.SelectedIndex).dailyTransactionTotal < 3000)
                {
                    //show screens
                    depositPanel.Visible = false;
                    depositAmountPanel.Visible = true;
                    depositAmountTextBox.Text = transactionAmount;
                }
                else
                {
                    //show error message
                    depositPanel.Visible = false;
                    limitErrorPanel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                depositPanel.Visible = false;
                mainMenuPanel.Visible = true;
            }
            
        }

        private void depositAccountReturnBtn_Click(object sender, EventArgs e)
        {
            depositPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        private void errorReturnBtn_Click(object sender, EventArgs e)
        {
            limitErrorPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        private void depositAmountPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //deposit money enter method
        private void depositEnterBtn_Click(object sender, EventArgs e)
        {
            //gets current time and last trans time
            DateTime date1 = Convert.ToDateTime(accountList.ElementAt(depositAccountList.SelectedIndex).dailyTransactionDate);
            DateTime date2 = DateTime.Now;

            //checks to see if its the same day or not
            if (DateTime.Compare(date1.Date, date2.Date) != 0)
            {
                accountList.ElementAt(depositAccountList.SelectedIndex).dailyTransactionTotal = 0;
            }

            //checks to see if the amount text is empty
            if (string.IsNullOrEmpty(depositAmountTextBox.Text))
                transactionAmount = "0";

            //checks to see if the the transaction total is less than 3000
            if (accountList.ElementAt(depositAccountList.SelectedIndex).dailyTransactionTotal + Int32.Parse(transactionAmount) <= 3000)
            {
               
                double newBalance = accountList.ElementAt(depositAccountList.SelectedIndex).balance += Int32.Parse(transactionAmount);
                int accountNumber = accountList.ElementAt(depositAccountList.SelectedIndex).accountNum;
                double transTotal = accountList.ElementAt(depositAccountList.SelectedIndex).dailyTransactionTotal += Int32.Parse(transactionAmount);

                //ceate temp account 
                Account tempAccount = new Account(accountNumber, 0, newBalance, 3000, transTotal, DateTime.Now.ToString());

                //updated deposit into DB
                tempAccount.updateDb(newBalance, transTotal, accountNumber);

                //create temp transaction
                Transaction tempTrans = new Transaction(accountNumber, "Deposit", transTotal);

                //update transaction into DB
                tempTrans.saveTransaction(accountNumber, "Deposit", transactionAmount, accountNumber, 0);

                //swap screens
                depositAmountPanel.Visible = false;
                mainMenuPanel.Visible = true;
            }
            else
            {
                depositAmountPanel.Visible = false;
                limitErrorPanel.Visible = true;
            }

        }
        //---------------------------------------------------------------------------Deposit Money Panel buttons start------------------------------------
        private void deposit1Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "1";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void deposit2Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "2";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void deposit3Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "3";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void deposit4Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "4";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void deposit5Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "5";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void deposit6Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "6";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void deposit7Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "7";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void deposit8Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "8";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void deposit9Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "9";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void deposit0Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "0";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void depositClrBtn_Click(object sender, EventArgs e)
        {
            transactionAmount = "";
            depositAmountTextBox.Text = transactionAmount;
        }

        private void depositEraseBtn_Click(object sender, EventArgs e)
        {
            if (transactionAmount.Length >= 1)
            {
                transactionAmount = transactionAmount.Remove(transactionAmount.Length - 1);
                depositAmountTextBox.Text = transactionAmount;
            }
        }
        //-------------------------------------------------------------------------Deposit button end --------------------------------------------------
    }
}
