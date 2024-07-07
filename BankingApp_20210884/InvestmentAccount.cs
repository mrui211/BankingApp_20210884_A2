using System.Runtime.Serialization;

namespace BankingApp_20210884
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/BankingApp_20210884")]

    /// <summary>
    /// Represents an investment account in the banking application.
    /// </summary>
    public class InvestmentAccount : Account
    {
        [DataMember]
        private double interestRate = 4;
        [DataMember]
        private double feeForFailed = 10;

        /// <summary>
        /// Gets or sets the interest rate for the investment account.
        /// </summary>
        public double InterestRate { get => interestRate; set => interestRate = value; }

        /// <summary>
        /// Gets or sets the fee charged for failed transactions in the investment account.
        /// </summary>
        public double FeeForFailed { get => feeForFailed; set => feeForFailed = value; }

        /// <summary>
        /// Constructor that initializes an investment account with a specified initial balance.
        /// </summary>
        /// <param name="_balance">Initial balance of the account.</param>
        public InvestmentAccount(double _balance) : base(_balance)
        {

        }

        /// <summary>
        /// Constructor that initializes an investment account with a specified initial balance, interest rate, and fee for failed transactions.
        /// </summary>
        /// <param name="_balance">Initial balance of the account.</param>
        /// <param name="_interestRate">Interest rate for the account.</param>
        /// <param name="_feeForFailed">Fee charged for failed transactions.</param>
        public InvestmentAccount(double _balance, double _interestRate, double _feeForFailed) : base(_balance)
        {
            interestRate = _interestRate;
            feeForFailed = _feeForFailed;
        }

        /// <summary>
        /// Calculates the interest earned for the investment account.
        /// </summary>
        /// <returns>The calculated interest based on the current balance and interest rate.</returns>
        public override double CalculateInterest()
        {
            var interest = interestRate / 100;
            return balance * interest ;
        }

        /// <summary>
        /// Returns a string representation of the investment account object.
        /// </summary>
        /// <returns>A string containing the account's unique ID, type, current balance, interest rate, and fee for failed transactions.</returns>

        public override string ToString()
        {
            return $"Account ID: {base.UniqueID}, Account Type: InvestmentAccount, deposit: {base.Balance}, Interest: {interestRate}%, Fee for failed transaction: ${feeForFailed}";
        }
    }
}
