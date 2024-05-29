using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp_20210884
{
    public partial class ManageAccouts : Form
    {
        Customer c;
        Account acc;
        private Controller control;
        double _interest = 0;
        double _failedFee = 0;

        public ManageAccouts()
        {
            InitializeComponent();
            control = new Controller();
            refreshListBoxClientes();
        }

        private void ManageAccouts_Load(object sender, EventArgs e)
        {

        }

        private void refreshListBoxClientes()
        {
            lsBoxCustomers.Items.Clear();

            foreach (var cliente in LstCustomers.Clientes)
            {
                lsBoxCustomers.Items.Add(cliente);
            }
        }

        private void lsBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = (Customer)lsBoxCustomers.SelectedItem;

            if (c == null)
            {
                MessageBox.Show("Please select a customer from the list of customers");
                return;
            }

            lsBoxCustomerAccounts.Items.Clear();
            if (c.ListAccounts.Count.Equals(0))
                lsBoxCustomerAccounts.Items.Add("Customer does not have any account");
            else
                refreshListBoxAccounts();
        }

        private void refreshListBoxAccounts()
        {
            lsBoxCustomerAccounts.Items.Clear();

            foreach (Account account in c.ListAccounts)
            {
                lsBoxCustomerAccounts.Items.Add(account);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (acc == null)
            {
                MessageBox.Show("Please select an account from the customer accounts list");
                return;
            }

            if (ValidateIsNumber(txtAmount.Text))
            {
                acc.Deposit(Convert.ToDouble(txtAmount.Text));
                lstBoxTransactionsHistory.Items.Add("Customer: " + c.Name.ToString() + " deposited $" + txtAmount.Text + " into " + acc.GetType().Name + " #" + acc.UniqueID.ToString() + " on " + DateTime.Now.ToString() + "; Updated Balance: $" + acc.Balance);
                txtAmount.Text = String.Empty;
                txtBalance.Text = acc.Balance.ToString();
                acc = null;
                clearInfo();
            }
        }

        public bool ValidateIsNumber(string num)
        {
            if (!string.IsNullOrEmpty(num))
            {
                if (double.TryParse(num, out double amount))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The value entered is not a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void lsBoxCustomerAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsBoxCustomerAccounts.SelectedItem != null)
            {

                if (lsBoxCustomerAccounts.SelectedItem.ToString().Contains("Customer does not have any account"))
                {
                    //MessageBox.Show("Please create fist an account from manage customers");
                    acc = null;
                    return;
                }

                acc = (Account)lsBoxCustomerAccounts.SelectedItem;

                if (acc == null)
                {
                    MessageBox.Show("Please select an account from the customers accounts list.");
                    return;
                }

                if (acc.GetType() == typeof(EverydayAccount))
                {
                    txtBalance.Text = acc.Balance.ToString();
                    txtInterest.Text = "N/A";
                    txtOverdraftPermitted.Text = "N/A";
                }
                if (acc.GetType() == typeof(InvestmentAccount))
                {
                    InvestmentAccount investmentAccount = (InvestmentAccount)acc;
                    txtBalance.Text = acc.Balance.ToString();
                    txtInterest.Text = investmentAccount.InterestRate.ToString();
                    txtOverdraftPermitted.Text = "N/A";
                    if (c.BankStaff == false)
                        _failedFee = investmentAccount.FeeForFailed;
                    else
                        _failedFee = investmentAccount.FeeForFailed / 2;
                }
                if (acc.GetType() == typeof(OmniAccount))
                {
                    OmniAccount omniAccount = (OmniAccount)acc;
                    txtBalance.Text = acc.Balance.ToString();
                    txtInterest.Text = omniAccount.InterestRate.ToString();
                    txtOverdraftPermitted.Text = omniAccount.OverdraftLimit.ToString();
                    if (c.BankStaff == false)
                        _failedFee = omniAccount.FeeForFailed;
                    else
                        _failedFee = omniAccount.FeeForFailed / 2;
                }
            }
            else
                acc = null;

        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            if (acc == null)
            {
                MessageBox.Show("Please select an account from the customer accounts list");
                return;
            }

            var accountName = acc.GetType().Name;
            if (ValidateIsNumber(txtAmount.Text))
            {
                if (acc.Withdraw(Convert.ToDouble(txtAmount.Text)))
                {
                    lstBoxTransactionsHistory.Items.Add("Customer: " + c.Name.ToString() + " withdrew $" + txtAmount.Text + " from " + accountName + " #" + acc.UniqueID.ToString() + " on " + DateTime.Now.ToString() + "; Updated Balance: $" + acc.Balance);
                    txtBalance.Text = acc.Balance.ToString();
                    txtAmount.Text = String.Empty;
                    acc = null;
                    clearInfo();
                }
                else
                {
                    //MessageBox.Show("You don't hhave enough founds, please check current balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (accountName.Equals(Account.accountTypes.EverydayAccount.ToString()))
                        //return;
                        throw new FailedWithdrawalException("Account type: " + accountName + " - You don't hhave enough founds, please check current balance.");
                    if ((accountName.Equals(Account.accountTypes.InvestmentAccount.ToString()) && (acc.Balance >= _failedFee)) || (accountName.Equals(Account.accountTypes.OmniAccount.ToString()) && ((Convert.ToDouble(acc.Balance) - _failedFee) >= (Convert.ToDouble(txtOverdraftPermitted.Text) * -1))))
                    {
                        acc.Withdraw(_failedFee);
                        lstBoxTransactionsHistory.Items.Add("Customer: " + c.Name.ToString() + "; " + accountName + " #" + acc.UniqueID.ToString() + "; Withdraw Attempt: $" + txtAmount.Text + " on " + DateTime.Now.ToString()
                        + "; Transaction status: Failed; Fee: $" + _failedFee + "; Updated Balance: $" + acc.Balance);
                        txtBalance.Text = acc.Balance.ToString();
                        txtAmount.Text = String.Empty;
                        acc = null;
                        clearInfo();
                    }
                    else
                        //MessageBox.Show("You don't have enough balance to cover the failed widreawal attempt fee transcaction of $" + _failedFee + ". Your current balance is $" + acc.Balance);
                        throw new FailedWithdrawalException("Account type: " + accountName + " - You don't have enough balance to cover the failed widreawal attempt fee transcaction of $" + _failedFee + ". Your current balance is $" + acc.Balance);
                }
            }
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            if (acc == null)
            {
                MessageBox.Show("Please select an account from the customer accounts list");
                return;
            }

            var accountName = acc.GetType().Name;
            if (accountName == Account.accountTypes.EverydayAccount.ToString())
            {
                MessageBox.Show("Not applicable for this type of account");
                acc = null;
                clearInfo();
                return;
            }
            else
            {
                _interest = acc.CalculateInterest();
                lstBoxTransactionsHistory.Items.Add("Customer: " + c.Name.ToString() + " ; interest calculated for " + acc.GetType().Name + " #" + acc.UniqueID.ToString() + " on " + DateTime.Now.ToString() + " is $" + _interest);
                acc = null;
                clearInfo();
            }
        }

        private void btnAddInterest_Click(object sender, EventArgs e)
        {
            if (acc == null)
            {
                MessageBox.Show("Please select an account from the customer accounts list");
                return;
            }

            if (acc.GetType().Name == Account.accountTypes.EverydayAccount.ToString())
            {
                MessageBox.Show("Not applicable for this type of account");
                acc = null;
                clearInfo();
                return;
            }
            acc.Deposit(_interest);
            lstBoxTransactionsHistory.Items.Add("Customer: " + c.Name.ToString() + " ; " + acc.GetType().Name + " #" + acc.UniqueID.ToString() + " interest added: $" + _interest +
                " ; " + "updated balance: $" + acc.Balance + " on " + DateTime.Now.ToString());
            txtBalance.Text = acc.Balance.ToString();
            acc = null;
            clearInfo();
        }

        public void clearInfo()
        {
            txtBalance.Text = String.Empty;
            txtInterest.Text = String.Empty;
            txtOverdraftPermitted.Text = String.Empty;
        }
    }
}
