using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_20210884
{
    class Controller
    {
        public Controller()
        {
        }

        public void AddCustomer(string name, string contactDetails, bool bankStaff)

        {
            LstCustomers.Clientes.Add(new Customer(name, contactDetails, bankStaff));
        }

        public void EditCustomer(int customerID, string name, string contactDetails, bool bankStaff)
        {
            var customer = LstCustomers.Clientes.Find(c => c.UniqueID == customerID);
            if (customer != null)
            {
                customer.Name = name;
                customer.ContactDetails = contactDetails;
                customer.BankStaff = bankStaff;
            }
        }

        public void DeleteCustomer(int customerID)
        {
            var customer = LstCustomers.Clientes.Find(c => c.UniqueID == customerID);
            if (customer != null)
            {
                LstCustomers.Clientes.Remove(customer);
            }
        }

        public void AddCustomerAccount(int customerID, string accountType, double deposit)
        {
            var customer = LstCustomers.Clientes.Find(c => c.UniqueID == customerID);
            if (customer != null)
            {
                if (accountType == Account.accountTypes.EverydayAccount.ToString())
                {
                    customer.ListAccounts.Add(new EverydayAccount(deposit));
                }
                if (accountType == Account.accountTypes.InvestmentAccount.ToString())
                {
                    customer.ListAccounts.Add(new InvestmentAccount(deposit));
                }
                if (accountType == Account.accountTypes.OmniAccount.ToString())
                {
                    customer.ListAccounts.Add(new OmniAccount(deposit));
                }
            }
        }
    }
}

