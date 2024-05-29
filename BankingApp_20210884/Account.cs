using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_20210884
{
    public abstract class Account
    {
        private static int nextID = 1;
        private int uniqueID = 1;
        protected double balance;

        public int UniqueID { get => uniqueID; set => uniqueID = value; }
        public double Balance { get => balance; set => balance = value; }


        public enum accountTypes
        {
            EverydayAccount,
            InvestmentAccount,
            OmniAccount
        }

        public Account() {
            uniqueID = nextID;
            nextID++;
        }

        public Account(double _balance) : this() 
        {
            this.Balance = _balance;
        }

        public virtual void Deposit(double _amount)
        {
            Balance += _amount;
        }

        //public abstract void Withdraw(double _amount);
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

        public abstract double CalculateInterest();

    }
}
