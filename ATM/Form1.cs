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
            checkBalanceAccountListPanel.Visible = false;
            checkBalancePanel.Visible = true;

            //displays text based on the selected account
            checkBalanceAccountBalanceTextBox.Text = $"${accountList.ElementAt(checkBalanceAccountListBox.SelectedIndex).balance}";
            checkBalanceAccountNumberTextBox.Text = $"{accountList.ElementAt(checkBalanceAccountListBox.SelectedIndex).accountNum}";
        }

        //check balance return button
        private void checkBalanceReturnBtn_Click(object sender, EventArgs e)
        {
            checkBalancePanel.Visible = false;
            checkBalanceAccountListPanel.Visible = true;
        }
    }
}
