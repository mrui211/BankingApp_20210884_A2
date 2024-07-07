using System.Runtime.Serialization;

namespace BankingApp_20210884
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/BankingApp_20210884")]

    /// <summary>
    /// Represents an omni account in the banking application.
    /// </summary>
    public class OmniAccount : Account
    {
        [DataMember]
        private double interestRate = 7;
        [DataMember]
        private double feeForFailed = 100;
        [DataMember]
        private double overdraftLimit = 750;

        /// <summary>
        /// Gets or sets the interest rate for the omni account.
        /// </summary>
        public double InterestRate { get => interestRate; set => interestRate = value; }

        /// <summary>
        /// Gets or sets the fee charged for failed transactions in the omni account.
        /// </summary>
        public double FeeForFailed { get => feeForFailed; set => feeForFailed = value; }

        /// <summary>
        /// Gets or sets the overdraft limit for the omni account.
        /// </summary>
        public double OverdraftLimit { get => overdraftLimit; set => overdraftLimit = value; }

        /// <summary>
        /// Constructor that initializes an omni account with a specified initial balance.
        /// </summary>
        /// <param name="_balance">Initial balance of the account.</param>
        public OmniAccount(double _balance) : base(_balance)
        {

        }

        /// <summary>
        /// Constructor that initializes an omni account with specified initial balance, interest rate, fee for failed transactions, and overdraft limit.
        /// </summary>
        /// <param name="_balance">Initial balance of the account.</param>
        /// <param name="_interestRate">Interest rate for the account.</param>
        /// <param name="_feeForFailed">Fee charged for failed transactions.</param>
        /// <param name="_overdraftLimit">Overdraft limit for the account.</param>
        public OmniAccount(double _balance, double _interestRate, double _feeForFailed, double _overdraftLimit) : base(_balance)
        {
            interestRate = _interestRate;
            feeForFailed = _feeForFailed;
            overdraftLimit = _overdraftLimit;
        }


        /// <summary>
        /// Overrides the withdrawal method to allow for overdraft within the specified limit.
        /// </summary>
        /// <param name="_amount">Amount to withdraw.</param>
        /// <returns>True if the withdrawal is successful; false otherwise.</returns>
        public override bool Withdraw(double _amount)
        {
            if (balance >= _amount)
            {
                balance -= _amount;
                return true;
            }
            else
            {
                if ((balance - _amount) >= (OverdraftLimit * -1))
                {
                    balance -= _amount;
                    return true;
                }
                else
                    return false;

            }
        }

        /// <summary>
        /// Calculates the interest earned for the omni account.
        /// </summary>
        /// <returns>The calculated interest based on the current balance and interest rate.</returns>
        public override double CalculateInterest()
        {
            var interest = interestRate / 100;
            return balance * interest;
        }

        /// <summary>
        /// Returns a string representation of the omni account object.
        /// </summary>
        /// <returns>A string containing the account's unique ID, type, current balance, interest rate, fee for failed transactions, and overdraft limit.</returns>
        public override string ToString()
        {
            return $"Account ID: {base.UniqueID}, Account Type: OmniAccount, deposit: {base.Balance}, Interest: {interestRate}%, Fee for failed transaction: ${feeForFailed}, Overdraft Limit: ${overdraftLimit}";
        }
    }
}
