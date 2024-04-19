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
        Account account1;
        Account account2;
        string transactionAmount = "";
        string customerPin = "";
        int accountFrom = 0;
        int accountTo = 0;
        int AMTSupply = 100000;

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
            transferErrorPanel.Visible = false;

            // Calculate the location to center the panel
            int x = (this.ClientSize.Width - mainMenuPanel.Size.Width) / 2;
            int y = (this.ClientSize.Height - mainMenuPanel.Size.Height) / 2;

            // Set the location of the panel
            mainMenuPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
             x = (this.ClientSize.Width - loginPanel.Size.Width) / 2;
             y = (this.ClientSize.Height - loginPanel.Size.Height) / 2;

            // Set the location of the panel
            loginPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - loginPinEorrorPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - loginPinEorrorPanel.Size.Height) / 2;

            // Set the location of the panel
            loginPinEorrorPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - checkBalanceAccountListPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - checkBalanceAccountListPanel.Size.Height) / 2;

            // Set the location of the panel
            checkBalanceAccountListPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - checkBalancePanel.Size.Width) / 2;
            y = (this.ClientSize.Height - checkBalancePanel.Size.Height) / 2;

            // Set the location of the panel
            checkBalancePanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - depositAmountPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - depositAmountPanel.Size.Height) / 2;

            // Set the location of the panel
            depositAmountPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - depositPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - depositPanel.Size.Height) / 2;

            // Set the location of the panel
            depositPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
             x = (this.ClientSize.Width - withdrawalAccountSelectionPanel.Size.Width) / 2;
             y = (this.ClientSize.Height - withdrawalAccountSelectionPanel.Size.Height) / 2;

            // Set the location of the panel
            withdrawalAccountSelectionPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - transferFromAccountListPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - transferFromAccountListPanel.Size.Height) / 2;

            // Set the location of the panel
            transferFromAccountListPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - mainMenuPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - mainMenuPanel.Size.Height) / 2;

            // Set the location of the panel
            mainMenuPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - transferErrorPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - transferErrorPanel.Size.Height) / 2;

            // Set the location of the panel
            transferErrorPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - atmCashAmountErrorPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - atmCashAmountErrorPanel.Size.Height) / 2;

            // Set the location of the panel
            atmCashAmountErrorPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - overWithdrawErrorPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - overWithdrawErrorPanel.Size.Height) / 2;

            // Set the location of the panel
            overWithdrawErrorPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - withdrawalPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - withdrawalPanel.Size.Height) / 2;

            // Set the location of the panel
            withdrawalPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - limitErrorPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - limitErrorPanel.Size.Height) / 2;

            // Set the location of the panel
            limitErrorPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - transferAmountPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - transferAmountPanel.Size.Height) / 2;

            // Set the location of the panel
            transferAmountPanel.Location = new System.Drawing.Point(x, y);

            // Calculate the location to center the panel
            x = (this.ClientSize.Width - transferToAccountListPanel.Size.Width) / 2;
            y = (this.ClientSize.Height - transferToAccountListPanel.Size.Height) / 2;

            // Set the location of the panel
            transferToAccountListPanel.Location = new System.Drawing.Point(x, y);
        }

        //Logout Button
        private void button1_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            loginPanel.Visible = true;
            
        }

        //withdraw button
        private void button1_Click_1(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            withdrawalAccountSelectionPanel.Visible = true;
            transactionAmount = "";
            accountList.Clear();

            //gets a list of accounts for this customer
            accountList = customer.getAccounts(customer.customerId);

            //displays accounts on screen
            withdrawalAccountList.Items.Clear();
            foreach (Account acc in accountList)
            {
                if (!withdrawalAccountList.Items.Contains(acc))
                {
                    withdrawalAccountList.Items.Add(acc.accountNum);
                }
            }
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
                //gets current time and last trans time
                DateTime date1 = Convert.ToDateTime(accountList.ElementAt(depositAccountList.SelectedIndex).dailyTransactionDate);
                DateTime date2 = DateTime.Now;

                //checks to see if its the same day or not
                if (DateTime.Compare(date1.Date, date2.Date) != 0)
                {
                    accountList.ElementAt(depositAccountList.SelectedIndex).dailyTransactionTotal = 0;
                }

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
                tempTrans.saveTransaction(accountNumber, "Deposit", transactionAmount, 0, accountNumber);

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

        //withdraw method selection
        private void withdrawalAccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //gets current time and last trans time
                DateTime date1 = Convert.ToDateTime(accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionDate);
                DateTime date2 = DateTime.Now;

                //checks to see if its the same day or not
                if (DateTime.Compare(date1.Date, date2.Date) != 0)
                {
                    accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal = 0;
                    AMTSupply = 100000;
                }

                //check if the account is below 3000 daily limit
                if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal < 3000)
                {
                    //show screens
                    withdrawalAccountSelectionPanel.Visible = false;
                    withdrawalPanel.Visible = true;
                    withdrawalAccountList.Text = transactionAmount;
                }
                else
                {
                    //show error message
                    withdrawalAccountSelectionPanel.Visible = false;
                    limitErrorPanel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                withdrawalAccountSelectionPanel.Visible = false;
                mainMenuPanel.Visible = true;
            }
        }

        private void withdrawalAccountSelectReturnBtn_Click(object sender, EventArgs e)
        {
            withdrawalAccountSelectionPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        private void overWithdrawErrorReturnBtn_Click(object sender, EventArgs e)
        {
            overWithdrawErrorPanel.Visible = false;
            withdrawalPanel.Visible = true;
        }

        private void withdrawalReturnBtn_Click(object sender, EventArgs e)
        {
            withdrawalPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        //method to withdraw $20 
        private void withdrawal20Btn_Click(object sender, EventArgs e)
        {
           
            //checks to see if the the transaction total is less than 3000
            if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal + 20 <= 3000)
            {
                //check to see if the account has the balance
                if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance >= 20)
                {
                    double newBalance = accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance -= 20;
                    int accountNumber = accountList.ElementAt(withdrawalAccountList.SelectedIndex).accountNum;
                    double transTotal = accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal += 20;

                    //create temp account 
                    Account tempAccount = new Account(accountNumber, 0, newBalance, 3000, transTotal, DateTime.Now.ToString());

                    //updated deposit into DB
                    tempAccount.updateDb(newBalance, transTotal, accountNumber);

                    //create temp transaction
                    Transaction tempTrans = new Transaction(accountNumber, "Withdrawal", transTotal);

                    //update transaction into DB
                    tempTrans.saveTransaction(accountNumber, "Withdrawal", "20", accountNumber, 0);

                    //subtract it from the ATM cash supply
                    AMTSupply -= 20;

                    //swap screens
                    withdrawalPanel.Visible = false;
                    mainMenuPanel.Visible = true;
                }
                else
                {
                    withdrawalPanel.Visible = false;
                    overWithdrawErrorPanel.Visible = true;
                }
            }
            else
            {
                withdrawalPanel.Visible = false;
                limitErrorPanel.Visible = true;
            }
        }

        //method to withdraw $40
        private void withdrawal40Btn_Click(object sender, EventArgs e)
        {
            //checks to see if the the transaction total is less than 3000
            if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal + 40 <= 3000)
            {
                //check to see if the account has the balance
                if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance >= 40)
                {
                    double newBalance = accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance -= 40;
                    int accountNumber = accountList.ElementAt(withdrawalAccountList.SelectedIndex).accountNum;
                    double transTotal = accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal += 40;

                    //create temp account 
                    Account tempAccount = new Account(accountNumber, 0, newBalance, 3000, transTotal, DateTime.Now.ToString());

                    //updated deposit into DB
                    tempAccount.updateDb(newBalance, transTotal, accountNumber);

                    //create temp transaction
                    Transaction tempTrans = new Transaction(accountNumber, "Withdrawal", transTotal);

                    //update transaction into DB
                    tempTrans.saveTransaction(accountNumber, "Withdrawal", "40", accountNumber, 0);

                    //subtract it from the ATM cash supply
                    AMTSupply -= 40;

                    //swap screens
                    withdrawalPanel.Visible = false;
                    mainMenuPanel.Visible = true;
                }
                else
                {
                    withdrawalPanel.Visible = false;
                    overWithdrawErrorPanel.Visible = true;
                }
            }
            else
            {
                withdrawalPanel.Visible = false;
                limitErrorPanel.Visible = true;
            }
        }

        //method to withdraw $60
        private void withdrawal60Btn_Click(object sender, EventArgs e)
        {
            //checks to see if the the transaction total is less than 3000
            if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal + 60 <= 3000)
            {
                //check to see if the account has the balance
                if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance >= 60)
                {
                    double newBalance = accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance -= 60;
                    int accountNumber = accountList.ElementAt(withdrawalAccountList.SelectedIndex).accountNum;
                    double transTotal = accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal += 60;

                    //create temp account 
                    Account tempAccount = new Account(accountNumber, 0, newBalance, 3000, transTotal, DateTime.Now.ToString());

                    //updated deposit into DB
                    tempAccount.updateDb(newBalance, transTotal, accountNumber);

                    //create temp transaction
                    Transaction tempTrans = new Transaction(accountNumber, "Withdrawal", transTotal);

                    //update transaction into DB
                    tempTrans.saveTransaction(accountNumber, "Withdrawal", "60", accountNumber, 0);

                    //subtract it from the ATM cash supply
                    AMTSupply -= 60;

                    //swap screens
                    withdrawalPanel.Visible = false;
                    mainMenuPanel.Visible = true;
                }
                else
                {
                    withdrawalPanel.Visible = false;
                    overWithdrawErrorPanel.Visible = true;
                }
            }
            else
            {
                withdrawalPanel.Visible = false;
                limitErrorPanel.Visible = true;
            }
        }

        //method to withdraw $80
        private void withdrawal80Btn_Click(object sender, EventArgs e)
        {
            //checks to see if the the transaction total is less than 3000
            if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal + 80 <= 3000)
            {
                //check to see if the account has the balance
                if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance >= 80)
                {
                    double newBalance = accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance -= 80;
                    int accountNumber = accountList.ElementAt(withdrawalAccountList.SelectedIndex).accountNum;
                    double transTotal = accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal += 80;

                    //create temp account 
                    Account tempAccount = new Account(accountNumber, 0, newBalance, 3000, transTotal, DateTime.Now.ToString());

                    //updated deposit into DB
                    tempAccount.updateDb(newBalance, transTotal, accountNumber);

                    //create temp transaction
                    Transaction tempTrans = new Transaction(accountNumber, "Withdrawal", transTotal);

                    //update transaction into DB
                    tempTrans.saveTransaction(accountNumber, "Withdrawal", "80", accountNumber, 0);

                    //subtract it from the ATM cash supply
                    AMTSupply -= 80;

                    //swap screens
                    withdrawalPanel.Visible = false;
                    mainMenuPanel.Visible = true;
                }
                else
                {
                    withdrawalPanel.Visible = false;
                    overWithdrawErrorPanel.Visible = true;
                }
            }
            else
            {
                withdrawalPanel.Visible = false;
                limitErrorPanel.Visible = true;
            }
        }

        //method to withdraw $100
        private void withdrawal100Btn_Click(object sender, EventArgs e)
        {
            //checks to see if the the transaction total is less than 3000
            if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal + 100 <= 3000)
            {
                //check to see if the account has the balance
                if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance >= 100)
                {
                    double newBalance = accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance -= 100;
                    int accountNumber = accountList.ElementAt(withdrawalAccountList.SelectedIndex).accountNum;
                    double transTotal = accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal += 100;

                    //create temp account 
                    Account tempAccount = new Account(accountNumber, 0, newBalance, 3000, transTotal, DateTime.Now.ToString());

                    //updated deposit into DB
                    tempAccount.updateDb(newBalance, transTotal, accountNumber);

                    //create temp transaction
                    Transaction tempTrans = new Transaction(accountNumber, "Withdrawal", transTotal);

                    //update transaction into DB
                    tempTrans.saveTransaction(accountNumber, "Withdrawal", "100", accountNumber, 0);

                    //subtract it from the ATM cash supply
                    AMTSupply -= 100;

                    //swap screens
                    withdrawalPanel.Visible = false;
                    mainMenuPanel.Visible = true;
                }
                else
                {
                    withdrawalPanel.Visible = false;
                    overWithdrawErrorPanel.Visible = true;
                }
            }
            else
            {
                withdrawalPanel.Visible = false;
                limitErrorPanel.Visible = true;
            }
        }

        //method to withdraw $200
        private void withdrawal200Btn_Click(object sender, EventArgs e)
        {
            //checks to see if the the transaction total is less than 3000
            if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal + 200 <= 3000)
            {
                //check to see if the account has the balance
                if (accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance >= 200)
                {
                    double newBalance = accountList.ElementAt(withdrawalAccountList.SelectedIndex).balance -= 200;
                    int accountNumber = accountList.ElementAt(withdrawalAccountList.SelectedIndex).accountNum;
                    double transTotal = accountList.ElementAt(withdrawalAccountList.SelectedIndex).dailyTransactionTotal += 200;

                    //create temp account 
                    Account tempAccount = new Account(accountNumber, 0, newBalance, 3000, transTotal, DateTime.Now.ToString());

                    //updated deposit into DB
                    tempAccount.updateDb(newBalance, transTotal, accountNumber);

                    //create temp transaction
                    Transaction tempTrans = new Transaction(accountNumber, "Withdrawal", transTotal);

                    //update transaction into DB
                    tempTrans.saveTransaction(accountNumber, "Withdrawal", "200", accountNumber, 0);

                    //subtract it from the ATM cash supply
                    AMTSupply -= 200;

                    //swap screens
                    withdrawalPanel.Visible = false;
                    mainMenuPanel.Visible = true;
                }
                else
                {
                    withdrawalPanel.Visible = false;
                    overWithdrawErrorPanel.Visible = true;
                }
            }
            else
            {
                withdrawalPanel.Visible = false;
                limitErrorPanel.Visible = true;
            }
        }

        //transfer Money button
        private void transferBtn_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            transferFromAccountListPanel.Visible = true;
            transactionAmount = "";
            accountList.Clear();

            //gets a list of accounts for this customer
            accountList = customer.getAccounts(customer.customerId);

            //displays accounts on screen
            transferFromAccountListBox.Items.Clear();
            foreach (Account acc in accountList)
            {
                if (!transferFromAccountListBox.Items.Contains(acc))
                {
                    transferFromAccountListBox.Items.Add(acc.accountNum);
                }
            }
        }

        //transfer from account list select
        private void transferFromAccountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                transactionAmount = "";

                //gets current time and last trans time
                DateTime date1 = Convert.ToDateTime(accountList.ElementAt(transferFromAccountListBox.SelectedIndex).dailyTransactionDate);
                DateTime date2 = DateTime.Now;

                //checks to see if its the same day or not
                if (DateTime.Compare(date1.Date, date2.Date) != 0)
                {
                    accountList.ElementAt(transferFromAccountListBox.SelectedIndex).dailyTransactionTotal = 0;
                }

                //check if the account is below 3000 daily limit
                if (accountList.ElementAt(transferFromAccountListBox.SelectedIndex).dailyTransactionTotal < 3000)
                {
                    //show screens
                    transferFromAccountListPanel.Visible = false;
                    transferAmountPanel.Visible = true;
                    transferAmountTextBox.Text = transactionAmount;
                    transferAccountBalanceText.Text = accountList.ElementAt(transferFromAccountListBox.SelectedIndex).balance.ToString();
                    transferAccountNumberText.Text = accountList.ElementAt(transferFromAccountListBox.SelectedIndex).accountNum.ToString();
                }
                else
                {
                    //show error message
                    transferFromAccountListPanel.Visible = false;
                    limitErrorPanel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                transferFromAccountListPanel.Visible = false;
                mainMenuPanel.Visible = true;
            }
        }

        private void transferFromAccountListReturnBtn_Click(object sender, EventArgs e)
        {
            transferFromAccountListPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        //transfer amount enter selected
        private void transferEnterBtn_Click(object sender, EventArgs e)
        {

            //checks to see if the amount text is empty
            if (string.IsNullOrEmpty(transferAmountTextBox.Text))
                transactionAmount = "0";

            //checks to see if the the transaction total is less than 3000
            if (accountList.ElementAt(transferFromAccountListBox.SelectedIndex).dailyTransactionTotal + Int32.Parse(transactionAmount) <= 3000)
            {
                //check to see if the account has the balance
                if (accountList.ElementAt(transferFromAccountListBox.SelectedIndex).balance >= Int32.Parse(transactionAmount))
                {
                    double newBalance = accountList.ElementAt(transferFromAccountListBox.SelectedIndex).balance -= Int32.Parse(transactionAmount);
                    int accountNumber = accountList.ElementAt(transferFromAccountListBox.SelectedIndex).accountNum;
                    double transTotal = accountList.ElementAt(transferFromAccountListBox.SelectedIndex).dailyTransactionTotal += Int32.Parse(transactionAmount);

                    //create temp account 
                    account1 = new Account(accountNumber, 0, newBalance, 3000, transTotal, DateTime.Now.ToString());
                    accountFrom = accountNumber;

                    accountList.Clear();

                    //gets a list of accounts for this customer
                    accountList = customer.getAccounts(customer.customerId);

                    //displays accounts on screen
                    transferToAccountListBox.Items.Clear();
                    foreach (Account acc in accountList)
                    {
                        if (!transferToAccountListBox.Items.Contains(acc))
                        {
                            transferToAccountListBox.Items.Add(acc.accountNum);
                        }
                    }

                    //swap screens
                    transferAmountPanel.Visible = false;
                    transferToAccountListPanel.Visible = true;
                }
                else
                {
                    transferAmountPanel.Visible = false;
                    transferErrorPanel.Visible = true;
                }
            }
            else
            {
                transferAmountPanel.Visible = false;
                limitErrorPanel.Visible = true;
            }
        }
        //-----------------------------------------------------------------------------Transfer amount buttons --------------------------------------------------------------------------
        private void transfer1Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "1";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transfer2Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "2";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transfer3Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "3";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transfer4Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "4";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transfer5Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "5";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transfer6Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "6";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transfer7Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "7";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transfer8Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "8";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transffer9Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "9";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transfer0Btn_Click(object sender, EventArgs e)
        {
            transactionAmount += "0";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transferClrbtn_Click(object sender, EventArgs e)
        {
            transactionAmount = "";
            transferAmountTextBox.Text = transactionAmount;
        }

        private void transferEraseBtn_Click(object sender, EventArgs e)
        {
            if (transactionAmount.Length >= 1)
            {
                transactionAmount = transactionAmount.Remove(transactionAmount.Length - 1);
                transferAmountTextBox.Text = transactionAmount;
            }
        }

        //---------------------------------------------------------------------------Transfer Amount button end-----------------------------------------------------------------------------------

        //transfer to selection
        private void transferToAccountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //gets current time and last trans time
                DateTime date1 = Convert.ToDateTime(accountList.ElementAt(transferToAccountListBox.SelectedIndex).dailyTransactionDate);
                DateTime date2 = DateTime.Now;

                //checks to see if its the same day or not
                if (DateTime.Compare(date1.Date, date2.Date) != 0)
                {
                    accountList.ElementAt(transferToAccountListBox.SelectedIndex).dailyTransactionTotal = 0;
                }

                if (accountList.ElementAt(transferToAccountListBox.SelectedIndex).dailyTransactionTotal < 3000)
                {
                    double newBalance = accountList.ElementAt(transferToAccountListBox.SelectedIndex).balance += Int32.Parse(transactionAmount);
                    int accountNumber = accountList.ElementAt(transferToAccountListBox.SelectedIndex).accountNum;
                    double transTotal = accountList.ElementAt(transferToAccountListBox.SelectedIndex).dailyTransactionTotal += Int32.Parse(transactionAmount);

                    //create temp account 
                    account2 = new Account(accountNumber, 0, newBalance, 3000, transTotal, DateTime.Now.ToString());
                    accountTo = accountNumber;

                    //update withdraw into DB
                    account1.updateDb(account1.balance, account1.dailyTransactionTotal, account1.accountNum);

                    //updated deposit into DB
                    account2.updateDb(newBalance, transTotal, accountNumber);

                    //create temp transaction
                    Transaction tempTrans = new Transaction(accountNumber, "Withdrawal", transTotal);

                    //update transaction into DB
                    tempTrans.saveTransaction(accountNumber, "Transfer", transactionAmount, accountFrom, accountTo);

                    transferToAccountListPanel.Visible = false;
                    mainMenuPanel.Visible = true;

                }
                else
                {
                    transferToAccountListPanel.Visible = false;
                    limitErrorPanel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                transferToAccountListPanel.Visible = false;
                mainMenuPanel.Visible = true;
            }

        }

        private void transferToAccountListReturnBtn_Click(object sender, EventArgs e)
        {
            transferToAccountListPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        private void transferErrorReturnButton_Click(object sender, EventArgs e)
        {
            transferErrorPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        private void loginPinEorrorPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void checkBalanceAccountListPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void checkBalancePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void depositPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void limitErrorPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void withdrawalPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void overWithdrawErrorPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void transferFromAccountListPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void transferAmountPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void transferErrorPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void transferToAccountListPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void atmCashAmountErrorPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void mainMenuPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
