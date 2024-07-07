using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_20210884
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/BankingApp_20210884")]
    public class TransactionsHistory
    {
        private static int nextID = 1;
        [DataMember]
        private int uniqueID = 0;
        [DataMember]
        private int accFrom = 0;
        [DataMember]
        private int accTo = 0;
        [DataMember]
        private DateTime transactionTime;
        [DataMember]
        private double amount;
        [DataMember]
        private double fee;
        [DataMember]
        private double currentBalance;
        [DataMember]
        private bool isTransfer = false;
        [DataMember]
        private bool isDeposit = false;
        [DataMember]
        private bool isWithdraw = false;
        [DataMember]
        private bool isWithdrawOK = false;

        public int UniqueID { get => uniqueID; set => uniqueID = value; }
        public int AccFrom { get => accFrom; set => accFrom = value; }
        public int AccTo { get => accTo; set => accTo = value; }
        public DateTime TransactionTime { get => transactionTime; set => transactionTime = value; }
        public double Amount { get => amount; set => amount = value; }
        public double CurrentBalance { get => currentBalance; set => currentBalance = value; }
        public double Fee { get => fee; set => fee = value; }
        public bool IsTransfer { get => isTransfer; set => isTransfer = value; }
        public bool IsDeposit { get => isDeposit; set => isDeposit = value; }
        public bool IsWithdraw { get => isWithdraw; set => isWithdraw = value; }

        public bool IsWithdrawOK { get => isWithdrawOK; set => isWithdrawOK = value; }


        public TransactionsHistory(DateTime transactionTime, double amount, double currectBalance, bool isDeposit, bool isWithdraw, int accFrom, bool isWithdrawOK, double fee = 0)
        {
            uniqueID++;
            AccFrom = accFrom;
            TransactionTime = transactionTime;
            Amount = amount;
            Fee = fee;
            CurrentBalance = currectBalance;
            IsDeposit = isDeposit;
            IsWithdraw = isWithdraw;
            TransactionTime = transactionTime;
            IsWithdrawOK = isWithdrawOK;
        }

        public TransactionsHistory(int accFrom, int accTo, DateTime transactionTime, double amount, double currectBalance)
        {
            uniqueID++;
            AccFrom = accFrom;
            AccTo = accTo;
            TransactionTime = transactionTime;
            Amount = amount;
            IsTransfer = true;
            CurrentBalance = currectBalance;
        }
    }
}
