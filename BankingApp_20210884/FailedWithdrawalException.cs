using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_20210884
{
    public class FailedWithdrawalException : Exception
    {
        public FailedWithdrawalException(string message) : base(message) { }
    }
}
