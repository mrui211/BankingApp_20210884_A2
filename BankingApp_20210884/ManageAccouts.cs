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
        string filenameCustomerData = "customer.dat";

        public ManageAccouts()
        {
            InitializeComponent();
            control = new Controller();
            refreshListBoxClientes();
        }

        private void ManageAccouts_Load(object sender, EventArgs e)
        {
            UpdateTransaction();

        }

        public void UpdateTransaction() {
            lstBoxTransactionsHistory.Items.Clear();

            LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
            foreach (Customer customerInfo in LstCustomers.Clientes)
            {
                if (customerInfo.UniqueID == c.UniqueID)
                {

                    foreach (TransactionsHistory transactions in c.ListTransactions)
                    {
                        string accTypeNameInfoFrom = String.Empty;
                        int accIDTypeFrom = 0;
                        double balanceAccFrom = 0;
                        string accTypeNameInfoTo = String.Empty;
                        int accIDTypeTo = 0;
                        double balanceAccTo = 0;
                        foreach (Account accInfo in c.ListAccounts)
                        {
                            // Deposit - Withdraw - Transference
                            if (accInfo.UniqueID == transactions.AccFrom)
                            {
                                accTypeNameInfoFrom = accInfo.GetType().Name;
                                accIDTypeFrom = accInfo.UniqueID;
                                balanceAccFrom = accInfo.Balance;// only for Deposit - Withdraw
                            }
                            if (accInfo.UniqueID == transactions.AccTo)
                            {
                                accTypeNameInfoTo = accInfo.GetType().Name;
                                accIDTypeTo = accInfo.UniqueID;
                                balanceAccTo = accInfo.Balance;
                            }

                        }
                        if (transactions.IsDeposit == true)
                        {
                            lstBoxTransactionsHistory.Items.Add("Customer: " + c.Name.ToString() + " deposited $" + transactions.Amount + " into " + accTypeNameInfoFrom + " #" + accIDTypeFrom.ToString() + " on " + transactions.TransactionTime.ToString() + "; Updated Balance: $" + transactions.CurrentBalance.ToString());
                        }
                        if (transactions.IsWithdraw == true && transactions.IsWithdrawOK == true)
                        {
                            lstBoxTransactionsHistory.Items.Add("Customer: " + c.Name.ToString() + " withdrew $" + transactions.Amount + " into " + accTypeNameInfoFrom + " #" + accIDTypeFrom.ToString() + " on " + transactions.TransactionTime.ToString() + "; Updated Balance: $" + transactions.CurrentBalance.ToString());
                        }
                        if (transactions.IsWithdraw == true && transactions.IsWithdrawOK == false)
                        {                          
                            lstBoxTransactionsHistory.Items.Add("Customer: " + c.Name.ToString() + " Withdraw Attempt $" + transactions.Amount + " into " + accTypeNameInfoFrom + " #" + accIDTypeFrom.ToString() + " on " + transactions.TransactionTime.ToString() + "; Transaction status: Failed ; Fee: $" + transactions.Fee.ToString() + "+ Updated Balance: $" + transactions.CurrentBalance.ToString());
                        }
                        if (transactions.IsTransfer == true)
                        {
                            lstBoxTransactionsHistory.Items.Add("Customer: " + c.Name.ToString() + " transfersed $" + transactions.Amount + " from " + accTypeNameInfoFrom + " #" + accIDTypeFrom.ToString() + " to " + accTypeNameInfoTo + " #" + accIDTypeTo.ToString() + " on " + transactions.TransactionTime.ToString() + "; Updated Balance: $" + transactions.CurrentBalance.ToString());
                        }

                    }


                }
            }
        }

        public void setCustomer(Customer customer)
        {
            c = customer;

            lsBoxCustomerAccounts.Items.Clear();
            if (c.ListAccounts == null)
                lsBoxCustomerAccounts.Items.Add("Customer does not have any account");
            else if (c.ListAccounts != null && c.ListAccounts.Count() == 0)
                lsBoxCustomerAccounts.Items.Add("Customer does not have any account");
            else
                refreshListBoxAccounts();
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
            //c = (Customer)lsBoxCustomers.SelectedItem;

            //if (c == null)
            //{
            //    MessageBox.Show("Please select a customer from the list of customers");
            //    return;
            //}

            //lsBoxCustomerAccounts.Items.Clear();
            //if (c.ListAccounts.Count.Equals(0))
            //    lsBoxCustomerAccounts.Items.Add("Customer does not have any account");
            //else
            //    refreshListBoxAccounts();
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

                double currentBalance = acc.Balance;
                if (c.ListTransactions == null)
                    c.ListTransactions = new List<TransactionsHistory>();
                TransactionsHistory deposit = new TransactionsHistory(DateTime.Now, Convert.ToDouble(txtAmount.Text), currentBalance, true, false, acc.UniqueID, false);

                c.ListTransactions.Add(deposit);

                foreach (Customer customerInfo in LstCustomers.Clientes)
                {
                    if (customerInfo.UniqueID == c.UniqueID)
                    {
                        customerInfo.ListAccounts = c.ListAccounts;
                        customerInfo.ListTransactions = c.ListTransactions;
                    }
                }

                PersistenceData.SerializeToXmlFile(LstCustomers.Clientes, filenameCustomerData);
                LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
                UpdateTransaction();

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
                try
                {
                    if (acc.Withdraw(Convert.ToDouble(txtAmount.Text)))
                    {
                        double currentBalance = acc.Balance;
                        if (c.ListTransactions == null)
                            c.ListTransactions = new List<TransactionsHistory>();
                        TransactionsHistory withdraw = new TransactionsHistory(DateTime.Now, Convert.ToDouble(txtAmount.Text), currentBalance, false, true, acc.UniqueID, true);
                        c.ListTransactions.Add(withdraw);

                        foreach (Customer customerInfo in LstCustomers.Clientes)
                        {
                            if (customerInfo.UniqueID == c.UniqueID)
                            {
                                customerInfo.ListAccounts = c.ListAccounts;
                                customerInfo.ListTransactions = c.ListTransactions;
                            }
                        }

                        PersistenceData.SerializeToXmlFile(LstCustomers.Clientes, filenameCustomerData);
                        LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
                        UpdateTransaction();
                        clearInfo();

                    }
                    else
                    {
                        
                        if (accountName.Equals(Account.accountTypes.EverydayAccount.ToString()))
                            throw new FailedWithdrawalException("Account type: " + accountName + " - You don't have enough founds, please check current balance.");
                        if ((accountName.Equals(Account.accountTypes.InvestmentAccount.ToString()) && (acc.Balance >= _failedFee)) || (accountName.Equals(Account.accountTypes.OmniAccount.ToString()) && ((Convert.ToDouble(acc.Balance) - _failedFee) >= (Convert.ToDouble(txtOverdraftPermitted.Text) * -1))))
                        {
                            
                            acc.Withdraw(_failedFee);
                            double currentBalance = acc.Balance;
                            txtBalance.Text = acc.Balance.ToString();
                            double currentAttempt = Convert.ToDouble(txtAmount.Text);
                            TransactionsHistory withdraw = new TransactionsHistory(DateTime.Now, currentAttempt, currentBalance, false, true, acc.UniqueID, false, _failedFee);
                            c.ListTransactions.Add(withdraw);

                            foreach (Customer customerInfo in LstCustomers.Clientes)
                            {
                                if (customerInfo.UniqueID == c.UniqueID)
                                {
                                    customerInfo.ListAccounts = c.ListAccounts;
                                    customerInfo.ListTransactions = c.ListTransactions;
                                }
                            }

                            PersistenceData.SerializeToXmlFile(LstCustomers.Clientes, filenameCustomerData);
                            LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
                            UpdateTransaction();
                            clearInfo();
                        }
                        else
                            throw new FailedWithdrawalException("Account type: " + accountName + " - You don't have enough balance to cover the failed widreawal attempt fee transcaction of $" + _failedFee + ". Your current balance is $" + acc.Balance);
                    }
                }
                catch (FailedWithdrawalException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("The interest result is " + _interest.ToString());
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
            _interest = acc.CalculateInterest();
            acc.Deposit(_interest);

            double currentBalance = acc.Balance;
            if (c.ListTransactions == null)
                c.ListTransactions = new List<TransactionsHistory>();
            TransactionsHistory deposit = new TransactionsHistory(DateTime.Now, _interest, currentBalance, true, false, acc.UniqueID, false);

            c.ListTransactions.Add(deposit);

            foreach (Customer customerInfo in LstCustomers.Clientes)
            {
                if (customerInfo.UniqueID == c.UniqueID)
                {
                    customerInfo.ListAccounts = c.ListAccounts;
                    customerInfo.ListTransactions = c.ListTransactions;
                }
            }

            PersistenceData.SerializeToXmlFile(LstCustomers.Clientes, filenameCustomerData);
            LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
            UpdateTransaction();
            txtBalance.Text = acc.Balance.ToString();
            acc = null;
            clearInfo();
        }

        public void clearInfo()
        {
            refreshListBoxAccounts();
            txtBalance.Text = String.Empty;
            txtInterest.Text = String.Empty;
            txtOverdraftPermitted.Text = String.Empty;
            txtTotalTransfer.Text = string.Empty;
            cmBoxTransferTo.Text = string.Empty;
            txtAmount.Text = string.Empty;
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            grpBoxTransfer.Visible = true;

            if (c.ListAccounts.Count <= 1)
                MessageBox.Show("Customer needs to have a minimun of 2 accounts");
            else
                fillTransderFromDropBox();
        }

        private void fillTransderFromDropBox()
        {
            cmBoxTransferFrom.Items.Clear();

            foreach (Account account in c.ListAccounts)
            {
                cmBoxTransferFrom.Items.Add(account);
            }
        }

        private void cmBoxTransferFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBoxTransferFrom.SelectedItem == null)
            {
                MessageBox.Show("Please select account origin.");
                return;
            }
            else
            {
                Account a;
                a = (Account)cmBoxTransferFrom.SelectedItem;

                cmBoxTransferTo.Items.Clear();
                cmBoxTransferTo.Text = "";
                foreach (Account account in c.ListAccounts)
                {
                    if (account.UniqueID != a.UniqueID)
                    {
                        cmBoxTransferTo.Items.Add(account);
                    }
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            Account accFrom, accTo;
            accFrom = (Account)cmBoxTransferFrom.SelectedItem;
            accTo = (Account)cmBoxTransferTo.SelectedItem;
            double tranferAmount = 0;
            //validate the transfer information before done it
            if (double.TryParse(txtTotalTransfer.Text, out tranferAmount))
            {
                if (tranferAmount > 0 && accFrom.Balance > tranferAmount)
                {
                    accTo.Balance += Convert.ToDouble(txtTotalTransfer.Text);
                    accFrom.Balance -= Convert.ToDouble(txtTotalTransfer.Text);
                    TransactionsHistory transference = new TransactionsHistory(accFrom.UniqueID, accTo.UniqueID, DateTime.Now, tranferAmount, accTo.Balance);

                    c.ListTransactions.Add(transference);

                    foreach (Customer customerInfo in LstCustomers.Clientes)
                    {
                        if (customerInfo.UniqueID == c.UniqueID)
                        {
                            customerInfo.ListAccounts = c.ListAccounts;
                            customerInfo.ListTransactions = c.ListTransactions;
                        }
                    }

                    PersistenceData.SerializeToXmlFile(LstCustomers.Clientes, filenameCustomerData);
                    LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
                    UpdateTransaction();
                    clearInfo();
                }
                else
                    MessageBox.Show("Please make sure the transfer amout is correct.");

            }
            else
            {
                MessageBox.Show("Please make sure to enter a number.");
            }
        }

    }
}
