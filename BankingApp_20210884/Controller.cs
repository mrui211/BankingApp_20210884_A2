using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_20210884
{
    class Controller
    {
        string filenameCustomerData = "customer.dat";
        public Controller()
        {
        }

        public bool CustomerExists(string name, string contactDetails, bool bankStaff) {
            if (LstCustomers.Clientes == null)
                return false;
            if(LstCustomers.Clientes.Where(x => x.Name == name && x.ContactDetails == contactDetails && x.BankStaff == bankStaff).Count() > 0 )
                return true;
            else return false;
        }

        public void AddCustomer(string name, string contactDetails, bool bankStaff)
        {
            LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
            int nexID = 1;
            if (LstCustomers.Clientes != null)
            {
                Customer LastClient = LstCustomers.Clientes.Last();
                nexID = LastClient.UniqueID + 1;
            }
            else {
                LstCustomers.Clientes = new List<Customer>();
            }           

            LstCustomers.Clientes.Add(new Customer(nexID, name, contactDetails, bankStaff));
            Customer c = LstCustomers.Clientes.First( x => x.Name == name && x.ContactDetails == contactDetails && x.BankStaff == bankStaff);
            PersistenceData.SerializeToXmlFile(LstCustomers.Clientes, filenameCustomerData);
            LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
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
            PersistenceData.SerializeToXmlFile(LstCustomers.Clientes, filenameCustomerData);
            LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
        }

        public void DeleteCustomer(int customerID)
        {
            var customer = LstCustomers.Clientes.Find(c => c.UniqueID == customerID);
            if (customer != null)
            {
                LstCustomers.Clientes.Remove(customer);
            }
            PersistenceData.SerializeToXmlFile(LstCustomers.Clientes, filenameCustomerData);
            LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
        }

        public void AddCustomerAccount(int customerID, string accountType, double deposit)
        {
            var customer = LstCustomers.Clientes.Find(c => c.UniqueID == customerID);
            if (customer != null)
            {
                if (customer.ListAccounts == null)
                {
                    customer.ListAccounts = new List<Account>();
                }
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

                PersistenceData.SerializeToXmlFile(LstCustomers.Clientes, filenameCustomerData);
                LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);
            }
        }


    }
}

