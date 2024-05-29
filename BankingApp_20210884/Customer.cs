using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_20210884
{
    public class Customer
    {
        private static int nextID = 1;
        private int uniqueID = 1;

        private string name;
        private string contactDetails;
        private bool bankStaff;
        
        public List<Account> ListAccounts { get; set; }

        public int UniqueID { get => uniqueID; set => uniqueID = value; }
        public string Name { get => name; set => name = value; }
        public string ContactDetails { get => contactDetails; set => contactDetails = value; }
        public bool BankStaff { get => bankStaff; set => bankStaff = value; }

        public Customer()
        {
            uniqueID = nextID;
            nextID++;
        }

        public Customer(string _name, string _contactDetails, bool _bankStaff) : this()
        {
            Name = _name;
            ContactDetails = _contactDetails;
            BankStaff = _bankStaff;

            ListAccounts = new List<Account>();
        }

        public override string ToString()
        {
            return $"ID: {UniqueID}, Name: {Name}, Contact Details: {ContactDetails}, Bank Staff: {BankStaff}"; 
        }

    }


    public static class LstCustomers
    {
        public static List<Customer> Clientes { get; set; } = new List<Customer>();
    }
}
