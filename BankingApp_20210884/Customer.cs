using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BankingApp_20210884
{
    /// <summary>
    /// Represents a customer of the banking application.
    /// </summary>
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/BankingApp_20210884")]
    public class Customer
    {
        private static int nextID = 1;

        /// <summary>
        /// Unique identifier for the customer.
        /// </summary>
        [DataMember]
        private int uniqueID = 1;

        /// <summary>
        /// Name of the customer.
        /// </summary>
        [DataMember]
        private string name;

        /// <summary>
        /// Contact details of the customer.
        /// </summary>
        [DataMember]
        private string contactDetails;

        /// <summary>
        /// Indicates if the customer is a bank staff member.
        /// </summary>
        [DataMember]
        private bool bankStaff;


        /// <summary>
        /// List of accounts associated with the customer.
        /// </summary>
        [DataMember]
        public List<Account> ListAccounts { get; set; }

        /// <summary>
        /// List of transaction histories associated with the customer.
        /// </summary>
        [DataMember]
        public List<TransactionsHistory> ListTransactions { get; set; }


        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        public int UniqueID { get => uniqueID; set => uniqueID = value; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// Gets or sets the contact details of the customer.
        /// </summary>
        public string ContactDetails { get => contactDetails; set => contactDetails = value; }

        /// <summary>
        /// Gets or sets a value indicating whether the customer is a bank staff member.
        /// </summary>
        public bool BankStaff { get => bankStaff; set => bankStaff = value; }

        /// <summary>
        /// Default constructor that initializes a customer with a unique ID and increments the static ID counter.
        /// </summary>
        public Customer()
        {
            uniqueID = nextID;
            nextID++;
        }


        /// <summary>
        /// Constructor that initializes a customer with specified name, contact details, and bank staff status,
        /// and initializes empty lists for accounts and transactions.
        /// </summary>
        /// <param name="_name">Name of the customer.</param>
        /// <param name="_contactDetails">Contact details of the customer.</param>
        /// <param name="_bankStaff">True if the customer is a bank staff member; otherwise, false.</param>
        public Customer(string _name, string _contactDetails, bool _bankStaff) : this()
        {
            Name = _name;
            ContactDetails = _contactDetails;
            BankStaff = _bankStaff;
            ListAccounts = new List<Account>();
            ListTransactions = new List<TransactionsHistory>();
        }

        /// <summary>
        /// Constructor that initializes a customer with specified ID, name, contact details, and bank staff status,
        /// and initializes empty lists for accounts and transactions.
        /// </summary>
        /// <param name="id">Unique ID of the customer.</param>
        /// <param name="_name">Name of the customer.</param>
        /// <param name="_contactDetails">Contact details of the customer.</param>
        /// <param name="_bankStaff">True if the customer is a bank staff member; otherwise, false.</param>
        public Customer(int id, string _name, string _contactDetails, bool _bankStaff)
        {
            uniqueID = id;
            Name = _name;
            ContactDetails = _contactDetails;
            BankStaff = _bankStaff;
            ListAccounts = new List<Account>();
            ListTransactions = new List<TransactionsHistory>();
        }

        /// <summary>
        /// Returns a string representation of the customer object.
        /// </summary>
        /// <returns>A string containing the customer's ID, name, contact details, and bank staff status.</returns>
        public override string ToString()
        {
            return $"ID: {UniqueID}, Name: {Name}, Contact Details: {ContactDetails}, Bank Staff: {BankStaff}"; 
        }
    }

    /// <summary>
    /// Static class to hold a list of customers.
    /// </summary
    public static class LstCustomers
    {
        /// <summary>
        /// Gets or sets the list of customers.
        /// </summary>
        public static List<Customer> Clientes { get; set; } = new List<Customer>();
    }
}
