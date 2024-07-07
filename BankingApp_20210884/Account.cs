using System.Runtime.Serialization;

namespace BankingApp_20210884
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/BankingApp_20210884")]
    [KnownType(typeof(EverydayAccount))]
    [KnownType(typeof(InvestmentAccount))]
    [KnownType(typeof(OmniAccount))]

    /// <summary>
    /// Base abstract class that represents an account.
    /// </summary>
    public abstract class Account
    {
        private static int nextID = 1;

        /// <summary>
        /// Unique identifier for the account.
        /// </summary>
        [DataMember]
        private int uniqueID = 1;

        /// <summary>
        /// Current balance of the account.
        /// </summary>
        [DataMember]
        protected double balance;

        /// <summary>
        /// Gets or sets the unique identifier for the account.
        /// </summary>
        public int UniqueID { get => uniqueID; set => uniqueID = value; }

        /// <summary>
        /// Gets or sets the current balance of the account.
        /// </summary>
        public double Balance { get => balance; set => balance = value; }


        /// <summary>
        /// Enum representing different types of accounts.
        /// </summary>
        public enum accountTypes
        {
            EverydayAccount,
            InvestmentAccount,
            OmniAccount
        }

        /// <summary>
        /// Default constructor that initializes an account with a unique ID and increments the static ID counter.
        /// </summary>
        public Account() {
            uniqueID = nextID;
            nextID++;
        }


        /// <summary>
        /// Constructor that initializes an account with a specified initial balance.
        /// </summary>
        /// <param name="_balance">Initial balance of the account.</param>
        public Account(double _balance) : this() 
        {
            this.Balance = _balance;
        }

        /// <summary>
        /// Virtual method to deposit money into the account.
        /// </summary>
        /// <param name="_amount">Amount to deposit.</param>
        public virtual void Deposit(double _amount)
        {
            Balance += _amount;
        }

        /// <summary>
        /// Virtual method to withdraw money from the account.
        /// </summary>
        /// <param name="_amount">Amount to withdraw.</param>
        /// <returns>True if withdrawal is successful; false otherwise.</returns>
        public virtual bool Withdraw(double _amount)
        {
            if (balance >= _amount)
            {
                balance -= _amount;
                return true;
            }
            else
                return false;
                
        }

        /// <summary>
        /// Abstract method to calculate interest for the account. Each subclass implements its own logic.
        /// </summary>
        /// <returns>The calculated interest.</returns>
        public abstract double CalculateInterest();

    }
}
