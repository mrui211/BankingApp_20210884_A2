using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_20210884
{
    public class OmniAccount : Account
    {
            
        private double interestRate = 7;
        private double feeForFailed = 100;
        private double overdraftLimit = 750;

        public double InterestRate { get => interestRate; set => interestRate = value; }
        public double FeeForFailed { get => feeForFailed; set => feeForFailed = value; }
        public double OverdraftLimit { get => overdraftLimit; set => overdraftLimit = value; }


        public OmniAccount(double _balance) : base(_balance)
        {

        }

        public OmniAccount(double _balance, double _interestRate, double _feeForFailed, double _overdraftLimit) : base(_balance)
        {
            interestRate = _interestRate;
            feeForFailed = _feeForFailed;
            overdraftLimit = _overdraftLimit;
        }


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

        public override double CalculateInterest()
        {
            var interest = interestRate / 100;
            return balance * interest;
        }

        public override string ToString()
        {
            return $"Account ID: {base.UniqueID}, Account Type: OmniAccount, deposit: {base.Balance}, Interest: {interestRate}%, Fee for failed transaction: ${feeForFailed}, Overdraft Limit: ${overdraftLimit}";
        }
    }
}
