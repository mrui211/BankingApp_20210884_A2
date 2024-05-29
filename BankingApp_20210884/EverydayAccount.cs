using System;

namespace BankingApp_20210884
{
    public class EverydayAccount : Account 
    {
        public EverydayAccount(double _balance) : base(_balance)
        {

        }

        public override double CalculateInterest()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Account ID: {base.UniqueID}, Account Type: EverydayAccount, deposit: {base.Balance}";
        }
    }
}
