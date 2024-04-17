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
        public List<Account> accountList = new List<Account>();
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

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
