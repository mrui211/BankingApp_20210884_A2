using System;
using System.Windows.Forms;

namespace BankingApp_20210884
{
    public partial class ManageCustomers : Form
    {
        private Controller control;
        Customer c;
        string filenameCustomerData = "customer.dat";

        public ManageCustomers()
        {
            InitializeComponent();
            control = new Controller();
            refreshListBoxClientes();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            foreach (var account in Enum.GetValues(typeof(Account.accountTypes)))
                cmboxAccountType.Items.Add(account);
            refreshListBoxClientes();

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(!control.CustomerExists(txtCustomerName.Text, txtCustomerContactDetails.Text, chkBoxCustomerBankStaff.Checked))
                control.AddCustomer(txtCustomerName.Text, txtCustomerContactDetails.Text, chkBoxCustomerBankStaff.Checked);
            else
                MessageBox.Show("Customer Exist please validate information.");
            //MessageBox.Show("Customer added successfully.");
            refreshListBoxClientes();
            cleanInfo();
            c = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (c == null)
            {
                MessageBox.Show("Please select a customer from the customers list");
                return;
            }
            control.EditCustomer(
            c.UniqueID,
            txtCustomerName.Text,
            txtCustomerContactDetails.Text,
            chkBoxCustomerBankStaff.Checked);

            MessageBox.Show("Customer edited successfully.");
            refreshListBoxClientes();
            cleanInfo();
            c = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (c == null)
            {
                MessageBox.Show("Please select a customer from the customers list");
                return;
            }
            control.DeleteCustomer(c.UniqueID);
            //MessageBox.Show("Customer deleted successfully.");
            refreshListBoxClientes();
            cleanInfo();
            c = null;
        }


        private void refreshListBoxClientes()
        {
            lsBoxCustomers.Items.Clear();

            LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
            if (LstCustomers.Clientes != null) {
                //foreach (var cliente in control.ListCustomers)
                foreach (var cliente in LstCustomers.Clientes)
                {
                    lsBoxCustomers.Items.Add(cliente);
                }
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

            txtCustomerName.Text = c.Name;
            txtCustomerContactDetails.Text = c.ContactDetails;
            chkBoxCustomerBankStaff.Checked = c.BankStaff;

            lsBoxCustomerAccounts.Items.Clear();
            if (c.ListAccounts == null)
                lsBoxCustomerAccounts.Items.Add("Customer does not have any account");
            else if (c.ListAccounts != null && c.ListAccounts.Count.Equals(0))
                lsBoxCustomerAccounts.Items.Add("Customer does not have any account");
            else
                refreshListBoxAccounts();
        }

        private void cleanInfo()
        {
            txtCustomerName.Text = String.Empty;
            txtCustomerContactDetails.Text = String.Empty;
            chkBoxCustomerBankStaff.Checked = false;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (c == null)
            {
                MessageBox.Show("Please select a customer from the list of customers");
                return;
            }

            if (ValidateIsNumber(txtDeposit.Text))
            {

                control.AddCustomerAccount(c.UniqueID, cmboxAccountType.Text, Convert.ToDouble(txtDeposit.Text));

                MessageBox.Show("Account created successfully.");
                refreshListBoxAccounts();
            }

        }

        private void refreshListBoxAccounts()
        {
            lsBoxCustomerAccounts.Items.Clear();

            foreach (Customer customerInfo in LstCustomers.Clientes)
            {
                if (customerInfo.UniqueID == c.UniqueID)
                {
                    c.ListAccounts = customerInfo.ListAccounts;
                    c.ListTransactions = customerInfo.ListTransactions;
                }
            }

            foreach (var account in c.ListAccounts)
            {
                lsBoxCustomerAccounts.Items.Add(account);
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
    }
}
