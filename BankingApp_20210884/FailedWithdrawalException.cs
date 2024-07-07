using System;

namespace BankingApp_20210884
{
    public class FailedWithdrawalException : Exception
    {
        public FailedWithdrawalException(string message) : base(message) { }
    }
}
