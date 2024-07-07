using System;
using System.Runtime.Serialization;

namespace BankingApp_20210884
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/BankingApp_20210884")]

    /// <summary>
    /// Represents an everyday account in the banking application.
    /// </summary>
    public class EverydayAccount : Account 
    {
        /// <summary>
        /// Constructor that initializes an everyday account with a specified initial balance.
        /// </summary>
        /// <param name="_balance">Initial balance of the account.</param>
        public EverydayAccount(double _balance) : base(_balance)
        {
        }

        /// <summary>
        /// Calculates the interest for the everyday account .
        /// </summary>
        /// <returns>Interest calculated for the account.</returns>
        /// <exception cref="NotImplementedException">Thrown because interest calculation is not implemented for this account type.</exception>
        public override double CalculateInterest()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a string representation of the everyday account object.
        /// </summary>
        /// <returns>A string containing the account's unique ID, type, and current balance.</returns>
        public override string ToString()
        {
            return $"Account ID: {base.UniqueID}, Account Type: EverydayAccount, deposit: {base.Balance}";
        }
    }
}
